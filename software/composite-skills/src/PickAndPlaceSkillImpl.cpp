//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#include <di_nodeids.h>
#include "PickAndPlaceSkillImpl.h"

#include "CompositeSkills.h"
#include <common/skill_detector/SkillHelper.hpp>

#include <open62541/client_highlevel.h>
#include <types_fortiss_device_generated.h>

using namespace fortiss::composite_skills;

PickAndPlaceSkillImpl::PickAndPlaceSkillImpl(
        std::shared_ptr<spdlog::logger> logger,
        CompositeSkills* compositeSkills
) :
        logger(std::move(logger)), compositeSkills(compositeSkills) {

}

PickAndPlaceSkillImpl::~PickAndPlaceSkillImpl() {
}


bool PickAndPlaceSkillImpl::start(
        const std::string& objectId,
        const std::string& toolControllerEndpoint,
        const std::string& moveControllerEndpoint,
        const UA_ThreeDFrame& placePosition
) {


    auto* frameCopy = (UA_ThreeDFrame*) UA_ThreeDFrame_new();
    UA_ThreeDFrame_init(frameCopy);
    UA_ThreeDFrame_copy(&placePosition, frameCopy);

    std::thread t = std::thread([this, frameCopy, toolControllerEndpoint, moveControllerEndpoint, objectId]() {

        UA_StatusCode result = this->pickAndPlaceObject(objectId, toolControllerEndpoint, moveControllerEndpoint, frameCopy);
        UA_ThreeDFrame_delete(frameCopy);

        auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::steady_clock::now() - skillStartTime);

        logger->info("PickAndPlace took {} ms. Result: {}", duration.count(), UA_StatusCode_name(result));

        if (result != UA_STATUSCODE_GOOD) {
            this->errored();
        } else
            this->finished();
    });
    t.detach();

    skillStartTime = std::chrono::steady_clock::now();
    return true;
}

static void printTransform(
        std::shared_ptr<spdlog::logger>& logger,
        const std::string name,
        const rl::math::Transform& t
) {

    rl::math::Vector3 vec = t.rotation().eulerAngles(2, 1, 0).reverse();
    UA_ThreeDFrame newPos = {
            .cartesianCoordinates = {
                    .x = t.translation().x(),
                    .y = t.translation().y(),
                    .z = t.translation().z()
            },
            .orientation = {
                    .a = vec.x(),
                    .b = vec.y(),
                    .c = vec.z(),
            }
    };

    logger->info("{}: x={}, y={}, z={}, a={}, b={}, c={}",
                 name,
                 newPos.cartesianCoordinates.x,
                 newPos.cartesianCoordinates.y,
                 newPos.cartesianCoordinates.z,
                 newPos.orientation.a * RAD_TO_DEG,
                 newPos.orientation.b * RAD_TO_DEG,
                 newPos.orientation.c * RAD_TO_DEG);
}

UA_StatusCode PickAndPlaceSkillImpl::pickAndPlaceObject(
        const std::string& objectId,
        const std::string& toolControllerEndpoint,
        const std::string& moveControllerEndpoint,
        const UA_ThreeDFrame* placePosition
) {

    logger->info("Start PickAndPlace:\n\tObject: {}\n\tToolController: {}\n\tMoveController: {}\n\tPlace at: x={}, y={}, z={}, a={}, b={}, c={}",
                 objectId,
                 toolControllerEndpoint,
                 moveControllerEndpoint,
                 placePosition->cartesianCoordinates.x,
                 placePosition->cartesianCoordinates.y,
                 placePosition->cartesianCoordinates.z,
                 placePosition->orientation.a * RAD_TO_DEG,
                 placePosition->orientation.b * RAD_TO_DEG,
                 placePosition->orientation.c * RAD_TO_DEG
    );


    std::shared_ptr<RegisteredSkill> robotCartesianLinearMoveSkill = nullptr;
    std::shared_ptr<RegisteredSkill> robotCartesianPtpMoveSkill = nullptr;
    std::shared_ptr<RegisteredSkill> graspSkill = nullptr;
    std::shared_ptr<RegisteredSkill> releaseSkill = nullptr;

    {
        std::vector<std::shared_ptr<RegisteredSkill>> skills = this->compositeSkills->skillDetector->getSkillForEndpoint(moveControllerEndpoint,
                                                                                                                         "CartesianLinearMoveSkill");
        if (skills.empty()) {
            logger->error("No skill registered for Type CartesianLinearMoveSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (skills.size() > 1) {
            logger->error("More than one skill registered for Type CartesianLinearMoveSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        robotCartesianLinearMoveSkill = skills.at(0);
    }

    {
        std::vector<std::shared_ptr<RegisteredSkill>> skills = this->compositeSkills->skillDetector->getSkillForEndpoint(moveControllerEndpoint,
                                                                                                                         "CartesianPtpMoveSkill");
        if (skills.empty()) {
            logger->error("No skill registered for Type CartesianPtpMoveSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (skills.size() > 1) {
            logger->error("More than one skill registered for Type CartesianPtpMoveSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        robotCartesianPtpMoveSkill = skills.at(0);
    }

    // wait a bit to allow tool to register itself if this skill is immediately called after toolchange
    for (int i = 0; i < 60; i++) {
        if (this->compositeSkills->skillDetector->getComponentForEndpoint(toolControllerEndpoint))
            break;
        std::this_thread::sleep_for(std::chrono::milliseconds(500));
    }
    {
        std::vector<std::shared_ptr<RegisteredSkill>> skills = this->compositeSkills->skillDetector->getSkillForEndpoint(toolControllerEndpoint,
                                                                                                                         "GraspGripperSkill");
        if (skills.empty()) {
            logger->error("No skill registered for Type GraspGripperSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (skills.size() > 1) {
            logger->error("More than one skill registered for Type GraspGripperSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        graspSkill = skills.at(0);
    }

    {
        std::vector<std::shared_ptr<RegisteredSkill>> skills = this->compositeSkills->skillDetector->getSkillForEndpoint(toolControllerEndpoint,
                                                                                                                         "ReleaseGripperSkill");
        if (skills.empty()) {
            logger->error("No skill registered for Type ReleaseGripperSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (skills.size() > 1) {
            logger->error("More than one skill registered for Type ReleaseGripperSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        releaseSkill = skills.at(0);
    }

    double fastCartSpeed[6] = {0.2, 0.2, 0.2, 20 * DEG_TO_RAD, 20 * DEG_TO_RAD, 20 * DEG_TO_RAD};
    double slowCartSpeed[6] = {0.1, 0.1, 0.1, 0.1, 0.1, 0.1};
    if (this->compositeSkills->isSimulation) {
        // full speed in simulation
        memset(&fastCartSpeed, 0, sizeof(fastCartSpeed));
        memset(&slowCartSpeed, 0, sizeof(slowCartSpeed));
    }

    rl::math::Transform worldToRobotOffset;
    if (const UA_StatusCode ret = robotCartesianLinearMoveSkill->getParentComponent()->getWorldToRobotTransform(&worldToRobotOffset) != UA_STATUSCODE_GOOD) {
        logger->error("Could not get worldToRobot Frame: {}", UA_StatusCode_name(ret));
        return ret;
    }


    rl::math::Transform pickObjectWorldFrame;
    rl::math::Transform pickApproachOffset;
    rl::math::Transform placeApproachOffset;
    if (const UA_StatusCode ret = compositeSkills->getObjectFrame(
            objectId,
            &pickObjectWorldFrame,
            &pickApproachOffset,
            &placeApproachOffset) != UA_STATUSCODE_GOOD) {
        return ret;
    }

    rl::math::Transform toolGripPointOffset;
    UA_GripTypeEnumeration gripType;
    if (const UA_StatusCode ret = getToolPickOffset(toolControllerEndpoint, &toolGripPointOffset, &gripType) != UA_STATUSCODE_GOOD) {
        return ret;
    }

    rl::math::Transform toolchangerOffset;
    toolchangerOffset = ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    toolchangerOffset.translation().x() = 0.0;
    toolchangerOffset.translation().y() = 0.0;
    toolchangerOffset.translation().z() = 0.047;

    toolGripPointOffset = toolchangerOffset * toolGripPointOffset;

    rl::math::Transform objectGripOffset;

    // TODO for now we assume the object has a height of the following in meters
    // Later on we need to get the object size and geometry from the world model (based on the object id).
    // and then automatically select a good grasping point for the corresponding grip type (vacuum, parallel, ...)
    double height = 0.04;


    switch (gripType) {
        case UA_GRIPTYPEENUMERATION_PARALLEL:
            objectGripOffset = ::rl::math::AngleAxis(
                    0.0 * DEG_TO_RAD,
                    ::rl::math::Vector3::UnitZ()
            ) * ::rl::math::AngleAxis(
                    0.0 * DEG_TO_RAD,
                    ::rl::math::Vector3::UnitY()
            ) * ::rl::math::AngleAxis(
                    180.0 * DEG_TO_RAD,
                    ::rl::math::Vector3::UnitX()
            );
            objectGripOffset.translation().x() = 0;
            objectGripOffset.translation().y() = 0;
            // grasp object in the middle
            objectGripOffset.translation().z() = height / 2.0;
            break;
        case UA_GRIPTYPEENUMERATION_VACUUM:
            // grasp object on top. So no offset.
            objectGripOffset = ::rl::math::AngleAxis(
                    0.0 * DEG_TO_RAD,
                    ::rl::math::Vector3::UnitZ()
            ) * ::rl::math::AngleAxis(
                    0.0 * DEG_TO_RAD,
                    ::rl::math::Vector3::UnitY()
            ) * ::rl::math::AngleAxis(
                    180.0 * DEG_TO_RAD,
                    ::rl::math::Vector3::UnitX()
            );
            objectGripOffset.translation().x() = 0;
            objectGripOffset.translation().y() = 0;
            // grasp object in the middle
            objectGripOffset.translation().z() = height;
            break;
        default:
            logger->error("Unsupported grip point type: {}", gripType);
            return UA_STATUSCODE_BADNOTSUPPORTED;
    }

    rl::math::Transform placeObjectWorldFrame;
    placeObjectWorldFrame = ::rl::math::AngleAxis(
            placePosition->orientation.c,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            placePosition->orientation.b,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            placePosition->orientation.a,
            ::rl::math::Vector3::UnitX()
    );
    placeObjectWorldFrame.translation().x() = placePosition->cartesianCoordinates.x;
    placeObjectWorldFrame.translation().y() = placePosition->cartesianCoordinates.y;
    placeObjectWorldFrame.translation().z() = placePosition->cartesianCoordinates.z;


    rl::math::Transform robotToPickupPosition = worldToRobotOffset.inverse() * pickObjectWorldFrame * toolGripPointOffset * objectGripOffset;
    rl::math::Transform robotToPickApproachPosition = robotToPickupPosition * pickApproachOffset;
    rl::math::Transform robotToPlacePosition = worldToRobotOffset.inverse() * placeObjectWorldFrame * toolGripPointOffset * objectGripOffset;
    rl::math::Transform robotToPlaceApproachPosition = robotToPlacePosition * placeApproachOffset;

    printTransform(logger, "worldToRobotOffset", worldToRobotOffset);
    printTransform(logger, "worldToRobotOffset.inverse()", worldToRobotOffset.inverse());
    printTransform(logger, "pickObjectWorldFrame", pickObjectWorldFrame);
    printTransform(logger, "placeObjectWorldFrame", placeObjectWorldFrame);
    printTransform(logger, "toolGripPointOffset", toolGripPointOffset);
    printTransform(logger, "objectGripOffset", objectGripOffset);
    printTransform(logger, "pickApproachOffset", pickApproachOffset);
    printTransform(logger, "placeApproachOffset", placeApproachOffset);
    printTransform(logger, "robotToPickupPosition", robotToPickupPosition);
    printTransform(logger, "robotToPickApproachPosition", robotToPickApproachPosition);
    printTransform(logger, "robotToPlacePosition", robotToPlacePosition);
    printTransform(logger, "robotToPlaceApproachPosition", robotToPlaceApproachPosition);

    if (const UA_StatusCode ret = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToPickApproachPosition,
            "",
            fastCartSpeed) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Pick Approach position. {}", UA_StatusCode_name(ret));
        return ret;
    }

    if (const UA_StatusCode ret = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToPickupPosition,
            "",
            slowCartSpeed) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Pick position. {}", UA_StatusCode_name(ret));
        return ret;
    }


    std::string coachObjectConnectionUuid;

    if (compositeSkills->isSimulation) {

        // connect the tool with the robot if simulation:
        //TODO find a better way to set robotIndex and effIndex
        //int robotIndex = compositeSkills->compositeSettings["coachWrapper"]["robotIndex"];
        //int effIndex = compositeSkills->compositeSettings["coachWrapper"]["endeffectorIndex"];
        int robotIndex = 0;
        int effIndex = 0;

        bool found = false;
        const libconfig::Setting& objects = compositeSkills->compositeSettings["coachWrapper"]["objectIdToModelIdx"];
        for (int i = 0; i < objects.getLength(); ++i) {
            const libconfig::Setting& object = objects[i];

            const std::string iri = object["iri"];
            if (iri != objectId)
                continue;

            found = true;

            int modelIdx = object["modelIdx"];
            int bodyIdx = object["bodyIdx"];

            coachObjectConnectionUuid = objectId + "_" + std::to_string(std::rand());

            compositeSkills->coachWrapper->addConnection(
                    robotIndex,
                    effIndex,
                    modelIdx,
                    bodyIdx,
                    coachObjectConnectionUuid);
        }
        if (!found) {
            logger->warn("Could not connect models in coach. Did not find any object specification for {}", objectId);
        }
    }

    if (const UA_StatusCode ret = fortiss::skill::callSkillNoParameters(
            graspSkill,
            logger) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not call grasp. {}", UA_StatusCode_name(ret));
        return ret;
    }


    if (const UA_StatusCode ret = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToPickApproachPosition,
            "",
            fastCartSpeed) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to After Pick Approach position. {}", UA_StatusCode_name(ret));
        return ret;
    }

    if (const UA_StatusCode ret = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToPlaceApproachPosition,
            "",
            fastCartSpeed) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Place Approach position. {}", UA_StatusCode_name(ret));
        return ret;
    }

    if (const UA_StatusCode ret = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToPlacePosition,
            "",
            slowCartSpeed) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Place position. {}", UA_StatusCode_name(ret));
        return ret;
    }

    if (compositeSkills->isSimulation) {
        compositeSkills->coachWrapper->removeConnection(coachObjectConnectionUuid);
    }

    if (const UA_StatusCode ret = fortiss::skill::callSkillNoParameters(
            releaseSkill,
            logger) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not call release. {}", UA_StatusCode_name(ret));
        return ret;
    }

    compositeSkills->setObjectFrame(objectId, placeObjectWorldFrame);

    if (const UA_StatusCode ret = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToPlaceApproachPosition,
            "",
            fastCartSpeed) != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to After Place Approach position. {}", UA_StatusCode_name(ret));
        return ret;
    }

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode PickAndPlaceSkillImpl::getToolPickOffset(
        const std::string& toolControllerEndpoint,
        rl::math::Transform* toolOffset,
        UA_GripTypeEnumeration* gripType
) {

    // TODO for now we just take the first grip point which is available in the gripper definition.
    // For a more intelligent system we need grasp planning or semantic reasoning here

    std::shared_ptr<RegisteredComponent> component = compositeSkills->skillDetector->getComponentForEndpoint(toolControllerEndpoint);

    if (!component) {
        logger->error("No component registered with endpoint: {}", toolControllerEndpoint);
        return UA_STATUSCODE_BADNOTFOUND;
    }

    UA_NodeId deviceSetId = UA_NODEID_NUMERIC(component->nsDiIdx, UA_DIID_DEVICESET);
    UA_NodeId skillControllerType = UA_NODEID_NUMERIC(component->nsFortissDiIdx, UA_FORTISS_DEVICEID_IGRIPPERTYPE);

    std::vector<std::shared_ptr<UA_NodeId>> foundIds;

    {
        LockedClient lc = component->getLockedClient();
        if (!fortiss::opcua::UA_Client_findChildrenImplementingInterfaceRecursively(lc.get(), logger, &deviceSetId, 1, skillControllerType, foundIds)) {
            logger->error("Did not find any gripper controller on endpoint: {}", toolControllerEndpoint);
            return UA_STATUSCODE_BADNOTFOUND;
        }
    }

    if (foundIds.empty()) {
        logger->error("Did not find any gripper controller on endpoint: {}", toolControllerEndpoint);
        return UA_STATUSCODE_BADNOTFOUND;
    }

    UA_NodeId gripPointsId;
    {
        LockedClient lc = component->getLockedClient();
        UA_String gripPoints = UA_STRING(const_cast<char*>("GripPoints"));
        if (!fortiss::opcua::UA_Client_findChildWithName(lc.get(), logger, *foundIds[0].get(), gripPoints, &gripPointsId)) {
            logger->error("Did not find any gripper controller on endpoint: {}", toolControllerEndpoint);
            return UA_STATUSCODE_BADNOTFOUND;
        }
    }

    /* Get all child nodes of the GripPoints node */
    UA_BrowseRequest bReq;
    UA_BrowseRequest_init(&bReq);
    bReq.requestedMaxReferencesPerNode = 0;
    bReq.nodesToBrowse = UA_BrowseDescription_new();
    bReq.nodesToBrowseSize = 1;
    UA_NodeId_copy(&gripPointsId, &(bReq.nodesToBrowse[0].nodeId));
    bReq.nodesToBrowse[0].resultMask = UA_BROWSERESULTMASK_ALL; /* return everything */
    UA_BrowseResponse bResp;
    {
        LockedClient lc = component->getLockedClient();
        bResp = UA_Client_Service_browse(lc.get(), bReq);
    }

    UA_NodeId choosenGripPointId = UA_NODEID_NULL;

    if (bResp.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
        logger->error("Can not browse server for children. Error {}",
                      UA_StatusCode_name(bResp.responseHeader.serviceResult));
    } else {
        UA_NodeId hasComp = UA_NODEID_NUMERIC(0, UA_NS0ID_HASCOMPONENT);
        for (size_t i = 0; i < bResp.resultsSize; ++i) {
            for (size_t j = 0; j < bResp.results[i].referencesSize; ++j) {
                UA_ReferenceDescription* ref = &(bResp.results[i].references[j]);
                if (!UA_NodeId_equal(&ref->referenceTypeId, &hasComp))
                    continue;

                // TODO for now just take the first grip point. At a later stage we may ingelligently select a good grip point
                UA_NodeId_copy(&ref->nodeId.nodeId, &choosenGripPointId);
                break;
            }
            if (!UA_NodeId_isNull(&choosenGripPointId)) {
                break;
            }
        }
    }
    UA_BrowseRequest_clear(&bReq);
    UA_BrowseResponse_clear(&bResp);

    if (UA_NodeId_isNull(&choosenGripPointId)) {
        logger->error("No suitable grip point found at gripper: {}", toolControllerEndpoint);
        return UA_STATUSCODE_BADNOTFOUND;
    }

    /* Get the grip type and offset */

    UA_NodeId gripTypeId;
    {
        LockedClient lc = component->getLockedClient();
        UA_String str = UA_STRING(const_cast<char*>("Type"));
        if (!fortiss::opcua::UA_Client_findChildWithName(lc.get(), logger, choosenGripPointId, str, &gripTypeId)) {
            logger->error("Did not find any Type node for grip point on endpoint: {}", toolControllerEndpoint);
            return UA_STATUSCODE_BADNOTFOUND;
        }
    }
    UA_NodeId gripOffsetId;
    {
        LockedClient lc = component->getLockedClient();
        UA_String str = UA_STRING(const_cast<char*>("Offset"));
        if (!fortiss::opcua::UA_Client_findChildWithName(lc.get(), logger, choosenGripPointId, str, &gripOffsetId)) {
            logger->error("Did not find any Offset node for grip point on endpoint: {}", toolControllerEndpoint);
            return UA_STATUSCODE_BADNOTFOUND;
        }
    }

    UA_Variant typeVar;
    {
        LockedClient lc = component->getLockedClient();
        UA_Client_readValueAttribute(lc.get(), gripTypeId, &typeVar);
    }
    if (typeVar.type != &UA_TYPES_FORTISS_DEVICE[UA_TYPES_FORTISS_DEVICE_GRIPTYPEENUMERATION] &&
        typeVar.type != &UA_TYPES[UA_TYPES_INT32]) {
        logger->error("Grip type does not have correct data type.");
        return UA_STATUSCODE_BADNOTFOUND;
    }
    *gripType = *(UA_GripTypeEnumeration*) typeVar.data;
    UA_Variant_clear(&typeVar);

    UA_Variant offsetVar;
    {
        LockedClient lc = component->getLockedClient();
        UA_Client_readValueAttribute(lc.get(), gripOffsetId, &offsetVar);
    }
    UA_ThreeDFrame* gripOffset;
    if (offsetVar.type != &UA_TYPES[UA_TYPES_THREEDFRAME]) {
        logger->error("Offset type does not have correct data type.");
        return UA_STATUSCODE_BADNOTFOUND;
    }
    gripOffset = (UA_ThreeDFrame*) offsetVar.data;

    *toolOffset = ::rl::math::AngleAxis(
            gripOffset->orientation.c,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            gripOffset->orientation.b,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            gripOffset->orientation.a,
            ::rl::math::Vector3::UnitX()
    );
    toolOffset->translation().x() = gripOffset->cartesianCoordinates.x;
    toolOffset->translation().y() = gripOffset->cartesianCoordinates.y;
    toolOffset->translation().z() = gripOffset->cartesianCoordinates.z;
    UA_Variant_clear(&offsetVar);

    return UA_STATUSCODE_GOOD;
};
