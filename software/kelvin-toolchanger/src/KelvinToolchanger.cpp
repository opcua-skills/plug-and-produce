//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#include <namespace_di_generated.h>
#include <namespace_fortiss_device_generated.h>
#include <namespace_kelvin_toolchanger_generated.h>
#include <kelvin_toolchanger_nodeids.h>
#include <common/opcua/helper.hpp>
#include <common/skill_detector/SkillHelper.hpp>
#include "KelvinToolchanger.h"
#include "ChangeToolSkill.hpp"

#include <open62541/client.h>
#include <fortiss_device_nodeids.h>
#include <di_nodeids.h>
#include <open62541/client_highlevel.h>
#include <for_rob_nodeids.h>


KelvinToolchanger::KelvinToolchanger(
        std::shared_ptr<spdlog::logger> _logger,
        UA_Server* server,
        const libconfig::Setting& toolchangerSettings,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const std::string& clientAppUri,
        const std::string& clientName
) :
        logger(std::move(_logger)),
        server(server),
        toolchangerSettings(toolchangerSettings),
        isSimulation(toolchangerSettings["simulation"]),
        adcAdapter(new AdcAdapter(logger, toolchangerSettings["simulation"])),
        clientCertPath(clientCertPath),
        clientKeyPath(clientKeyPath),
        clientAppUri(clientAppUri),
        clientName(clientName),
        skillDetector(new SkillDetector(logger, clientCertPath, clientKeyPath, clientAppUri, clientName)) {

    if (isSimulation) {
        coachWrapper = new rlCoachWrapper();
        coachWrapper->runThreaded();
    }

    UA_ApplicationDescription_init(&currentToolDescription);

    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Kelvin Toolchanger nodeset");
    }

    currentToolReadyNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_CURRENTTOOL_READY);
    currentToolDescriptionNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_CURRENTTOOL_DESCRIPTION);
    currentToolIdNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_CURRENTTOOL_ID);

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw fortiss::opcua::StatusCodeException(retval);

    std::string endpoint = toolchangerSettings["adc_adapter_endpoint"];
    retval = adcAdapter->connect(endpoint, clientCertPath, clientKeyPath, clientAppUri);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Could not connect to ADC Adapter: {}", UA_StatusCode_name(retval));
        throw std::runtime_error("Could not connect to ADC Adapter");
    }

    adcAdapter->toolChangeCallback = std::bind(&KelvinToolchanger::onToolUpdate, this, std::placeholders::_1, std::placeholders::_2);

    toolMasterPlateOffset = ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    toolMasterPlateOffset.translation().x() = 0.0;
    toolMasterPlateOffset.translation().y() = 0.0;
    toolMasterPlateOffset.translation().z() = -0.034;

    //TODO change skill to ready after robot register
    // executeProcessSkill->transition(fortiss::opcua::ProgramStateNumber::READY);
}

KelvinToolchanger::~KelvinToolchanger() {
    delete skillDetector;
    delete adcAdapter;
    coachWrapper->stop();
    delete coachWrapper;
    UA_ApplicationDescription_clear(&currentToolDescription);
}

bool KelvinToolchanger::createNodesFromNodeset() {
    if (namespace_di_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_kelvin_toolchanger_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Kelvin Toolchanger namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}

UA_StatusCode KelvinToolchanger::initSkills() {

    hasToolNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_HASTOOL
    );
    currentToolReadyNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_CURRENTTOOL_READY
    );
    currentToolDescriptionNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_CURRENTTOOL_DESCRIPTION
    );
    currentToolIdNode = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_CURRENTTOOL_ID
    );

    UA_NodeId changeToolSkillId = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_SKILLS_CHANGETOOLSKILL
    );

    changeToolSkillImpl = new fortiss::kelvin_toolchanger::ChangeToolSkillImpl(logger,
                                                                               this);

    changeToolSkill = std::make_unique<fortiss::opcua::skill::ChangeToolSkill>
            (server, logger, changeToolSkillId,
             "ChangeToolSkill");
    changeToolSkill->setImpl(changeToolSkillImpl, [this]() {
        delete changeToolSkillImpl;
    });
    changeToolSkill->transition(fortiss::opcua::ProgramStateNumber::READY);

    UA_NodeId dropToolSkillId = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_KELVIN_TOOLCHANGER),
            UA_KELVIN_TOOLCHANGERID_KELVINTOOLCHANGER_SKILLS_DROPTOOLSKILL
    );

    dropToolSkillImpl = new fortiss::kelvin_toolchanger::DropToolSkillImpl(logger,
                                                                           this);

    dropToolSkill = std::make_unique<fortiss::opcua::skill::DropToolSkill>
            (server, logger, dropToolSkillId,
             "DropToolSkill");
    dropToolSkill->setImpl(dropToolSkillImpl, [this]() {
        delete dropToolSkillImpl;
    });
    dropToolSkill->transition(fortiss::opcua::ProgramStateNumber::READY);


    return UA_STATUSCODE_GOOD;
}

void KelvinToolchanger::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
) {

    std::string serverName = std::string((char*) serverOnNetwork->serverName.data, serverOnNetwork->serverName.length);

    // create a copy of registered server struct since it may be deleted while the thread is still running.
    UA_ServerOnNetwork* serverOnNetworkTemp = UA_ServerOnNetwork_new();
    UA_ServerOnNetwork_copy(serverOnNetwork, serverOnNetworkTemp);
    std::shared_ptr<UA_ServerOnNetwork> serverOnNetworkSafe = std::shared_ptr<UA_ServerOnNetwork>(serverOnNetworkTemp, [=](UA_ServerOnNetwork* ptr) {
        UA_ServerOnNetwork_delete(ptr);
    });

    if (isServerAnnounce) {

        std::vector<std::string> discoveryUrls;

        std::string discoveryUrl = std::string((char*) serverOnNetwork->discoveryUrl.data, serverOnNetwork->discoveryUrl.length);

        if (serverKnown.count(discoveryUrl) > 0)
            return;

        logger->info("Got register from component: {}", serverName);

        discoveryUrls.emplace_back(discoveryUrl);
        serverKnown.emplace(discoveryUrl, true);

        std::thread([this, serverOnNetworkSafe, discoveryUrls]() {

            std::shared_ptr<spdlog::logger> loggerClient = logger->clone(logger->name() + "-client");
            if (loggerClient->level() < spdlog::level::err)
                loggerClient->set_level(spdlog::level::err);

            std::promise<std::shared_ptr<UA_EndpointDescription>> promiseEndpoint;
            fortiss::opcua::getBestEndpointFromServer(discoveryUrls, promiseEndpoint, loggerClient);
            std::future<std::shared_ptr<UA_EndpointDescription>> endpointFuture = promiseEndpoint.get_future();

            std::future_status status = endpointFuture.wait_for(std::chrono::seconds(5));

            if (status == std::future_status::ready) {
                std::shared_ptr<UA_EndpointDescription> endpoint = endpointFuture.get();
                skillDetector->componentConnected(serverOnNetworkSafe, endpoint);
            }

        }).detach();

    } else {


        std::string discoveryUrl = std::string((char*) serverOnNetwork->discoveryUrl.data, serverOnNetwork->discoveryUrl.length);
        if (serverKnown.count(discoveryUrl) == 0)
            return;

        logger->info("Got unregister from component: {}", serverName);
        serverKnown.erase(discoveryUrl);
        skillDetector->componentDisconnected(serverOnNetworkSafe);
    }


}

void KelvinToolchanger::onToolUpdate(
        const KelvinToolState toolState,
        const short toolId
) {
    std::string infoStr;
    switch (toolState) {
        case KELVIN_UNKNOWN:
            infoStr = "UNKNOWN";
            break;
        case KELVIN_READY:
            infoStr = "READY";
            break;
        case KELVIN_INTERMEDIATE:
            infoStr = "INTERMEDIATE";
            break;
        case KELVIN_NO_TOOL:
            infoStr = "NO_TOOL";
            break;
        case KELVIN_TOOL_CONNECTED:
            infoStr = "TOOL_CONNECTED";
            break;
    }
    logger->info("Got tool update: {} with tool id {}", infoStr, toolId);

    UA_Variant hasToolVar;
    UA_Boolean hasTool = toolState == KELVIN_TOOL_CONNECTED;
    UA_Variant_setScalar(&hasToolVar, &hasTool, &UA_TYPES[UA_TYPES_BOOLEAN]);
    UA_StatusCode retval = UA_Server_writeValue(server, hasToolNode, hasToolVar);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Could not set hasTool variable: {}", UA_StatusCode_name(retval));
    }


}

UA_StatusCode KelvinToolchanger::takeToolAtPosition(
        const UA_ThreeDFrame* toolPosition,
        const std::string& expectedAppUri
) {


    this->logger->info("Changing Tool\n\tPosition: {}, {}, {}, {}, {}, {}\n\tCurrent: {}",
                       toolPosition->cartesianCoordinates.x, toolPosition->cartesianCoordinates.y,
                       toolPosition->cartesianCoordinates.z, toolPosition->orientation.a * RAD_TO_DEG,
                       toolPosition->orientation.b * RAD_TO_DEG, toolPosition->orientation.c * RAD_TO_DEG, adcAdapter->getToolId());

    if (this->getToolState() == KELVIN_INTERMEDIATE) {
        this->logger->error("Can not take tool while changer is in intermediate state. Manually move the locking mechanism.");
        return UA_STATUSCODE_BADINVALIDSTATE;
    }

    if (this->getToolState() == KELVIN_TOOL_CONNECTED) {
        // check if current tool is expected one:

        std::string connectedToolAppUri = std::string((char*)currentToolDescription.applicationUri.data, currentToolDescription.applicationUri.length);

        if (connectedToolAppUri == expectedAppUri) {
            logger->info("Expected tool aready connected. Nothing to do.");
            return UA_STATUSCODE_GOOD;
        }

        UA_StatusCode retval = this->dropCurrentTool();
        if (retval != UA_STATUSCODE_GOOD)
            return retval;
    }

    rl::math::Transform worldToTool;
    worldToTool = ::rl::math::AngleAxis(
            toolPosition->orientation.c,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            toolPosition->orientation.b,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            toolPosition->orientation.a,
            ::rl::math::Vector3::UnitX()
    );
    worldToTool.translation().x() = toolPosition->cartesianCoordinates.x;
    worldToTool.translation().y() = toolPosition->cartesianCoordinates.y;
    worldToTool.translation().z() = toolPosition->cartesianCoordinates.z;

    if (const UA_StatusCode retval = initRobotSkills() != UA_STATUSCODE_GOOD) {
        logger->error("Could not get robot skills. {}", UA_StatusCode_name(retval));
        return retval;
    }

    rl::math::Transform worldToRobot;
    if (const UA_StatusCode ret = robotCartesianLinearMoveSkill->getParentComponent()->getWorldToRobotTransform(&worldToRobot) != UA_STATUSCODE_GOOD)
        return ret;

    rl::math::Transform robotToTool = worldToRobot.inverse() * worldToTool * toolMasterPlateOffset;

    const static double defaultRotate = -130.0 * DEG_TO_RAD;
    const static double lockedRotate = 63.0 * DEG_TO_RAD;

    double fastCartSpeed[6] = {0.2, 0.2, 0.2, 20 * DEG_TO_RAD, 20 * DEG_TO_RAD, 20 * DEG_TO_RAD};
    double slowCartSpeed[6] = {0.1, 0.1, 0.1, 0.1, 0.1, 0.1};
    if (isSimulation) {
        // full speed in simulation
        memset(&fastCartSpeed, 0, sizeof(fastCartSpeed));
        memset(&slowCartSpeed, 0, sizeof(slowCartSpeed));
    }


    if (const UA_StatusCode retval = initRobotSkills() != UA_STATUSCODE_GOOD)
        return retval;

    /*
     * NOTE!!!
     *
     * The following steps are also explained in the Kelvin User Manual
     */

    // Move to "Back Door" Position
    // Above the tool keeping robot rotated by 22 degree (= default master plate rotation)
    rl::math::Transform moveTransform;
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.0;
    moveTransform.translation().z() = -0.045;
    UA_StatusCode retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            fastCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Back Door position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    // Move to "Park" Position
    // Directly aligned with the tool keeping robot rotated by 22 degree (= default master plate rotation)
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Park position. {}", UA_StatusCode_name(retval));
        return retval;
    }


    if (isSimulation) {
        adcAdapter->setStateSimulated(KELVIN_INTERMEDIATE, 0);

        // connect the tool with the robot if simulation:
        int robotIndex = toolchangerSettings["coachWrapper"]["robotIndex"];
        int effIndex = toolchangerSettings["coachWrapper"]["endeffectorIndex"];

        bool found = false;
        const libconfig::Setting& tools = toolchangerSettings["coachWrapper"]["toolIriToModelIdx"];
        for (int i = 0; i < tools.getLength(); ++i) {
            const libconfig::Setting& tool = tools[i];

            const std::string iri = tool["iri"];
            if (iri != expectedAppUri)
                continue;

            found = true;

            int modelIdx = tool["modelIdx"];
            int bodyIdx = tool["bodyIdx"];

            coachModelConnectionUuid = expectedAppUri + "_" + std::to_string(std::rand());

            coachWrapper->addConnection(
                    robotIndex,
                    effIndex,
                    modelIdx,
                    bodyIdx,
                    coachModelConnectionUuid);
        }
        if (!found) {
            logger->warn("Could not connect models in coach. Did not find any tool specification for {}", expectedAppUri);
        }
    }


    // Move to "Locking" Position
    // Locking the toolchanger requires a rotation by 68 degree (default 63 degree + 3 degree overshoot)
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate - lockedRotate - 3 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.0;
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Locking position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    if (isSimulation)
        adcAdapter->setStateSimulated(KELVIN_TOOL_CONNECTED, 1);

    // Move to "Center" Position
    // Rotate back the overshot 5 degree
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate - lockedRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.0;
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Center position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    // Move to "Front Door" Position
    // Keep rotation and move out by 150mm
    moveTransform.translation().y() = 0.15;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Front Door position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    for (size_t t = 0; t < 20 && this->getToolState() != KELVIN_TOOL_CONNECTED; t++) {
        std::this_thread::sleep_for(std::chrono::milliseconds(500));
    }
    if (this->getToolState() != KELVIN_TOOL_CONNECTED) {
        logger->error("Tooolchanger did not change to expected CONNECTED state. Aborting");
        return UA_STATUSCODE_BADINVALIDSTATE;
    }

    // Move to "Approach1" Position
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate - lockedRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            20.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            -10.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.15;
    moveTransform.translation().z() = -0.05;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            fastCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Approach1 position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    // Move to "Approach" Position
    // Above docking station for safe next move
    moveTransform.translation().y() = 0.05;
    moveTransform.translation().z() = -0.25;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            fastCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Approach2 position. {}", UA_StatusCode_name(retval));
        return retval;
    }


    toolPickupPosition = worldToTool;
    toolPickupPositionSet = true;

    return detectCurrentTool(expectedAppUri);
}

UA_StatusCode KelvinToolchanger::dropCurrentTool() {

    if (!toolPickupPositionSet) {
        this->logger->error("Can not drop tool. Do not know where it was picked up. Manually remove it and retry.");
        return UA_STATUSCODE_BADINVALIDSTATE;
    }

    UA_StatusCode retval = this->powerOffTool();
    if (retval != UA_STATUSCODE_GOOD && retval != UA_STATUSCODE_BADNOTIMPLEMENTED) {
        logger->warn("Could not properly shut down tool. {}", UA_StatusCode_name(retval));
    }

    if ((retval = initRobotSkills()) != UA_STATUSCODE_GOOD) {
        logger->error("Could not get robot skills. {}", UA_StatusCode_name(retval));
        return retval;
    }

    rl::math::Transform worldToRobot;
    if (const UA_StatusCode ret = robotCartesianLinearMoveSkill->getParentComponent()->getWorldToRobotTransform(&worldToRobot) != UA_STATUSCODE_GOOD)
        return ret;

    rl::math::Transform robotToTool = worldToRobot.inverse() * toolPickupPosition * toolMasterPlateOffset;

    const static double defaultRotate = -130.0 * DEG_TO_RAD;
    const static double lockedRotate = 63.0 * DEG_TO_RAD;

    if (const UA_StatusCode ret = initRobotSkills() != UA_STATUSCODE_GOOD)
        return ret;

    /*
     * NOTE!!!
     *
     * The following steps are also explained in the Kelvin User Manual
     */

    double fastCartSpeed[6] = {0.2, 0.2, 0.2, 20 * DEG_TO_RAD, 20 * DEG_TO_RAD, 20 * DEG_TO_RAD};
    double slowCartSpeed[6] = {0.1, 0.1, 0.1, 0.1, 0.1, 0.1};
    if (isSimulation) {
        // full speed in simulation
        memset(&fastCartSpeed, 0, sizeof(fastCartSpeed));
        memset(&slowCartSpeed, 0, sizeof(slowCartSpeed));
    }

    // Move to Approach Position in safe place above "Front Door"
    // In front of Docking distance: 100mm
    // Above Docking distance: 250mm
    rl::math::Transform moveTransform;
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate - lockedRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            20.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            -10.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.05;
    moveTransform.translation().z() = -0.25;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            fastCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Approach position. {}", UA_StatusCode_name(retval));
        return retval;
    }


    // Move to "Approach1" Position
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.15;
    moveTransform.translation().z() = -0.05;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            fastCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Approach1 position. {}", UA_StatusCode_name(retval));
        return retval;
    }


    // Move to "Front Door" Position
    // In front of Docking distance: 150mm
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate - lockedRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().y() = 0.15;
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianPtpMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            fastCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Front Door position. {}", UA_StatusCode_name(retval));
        return retval;
    }


    // Move to "Start" Position
    // Move into dock and overshoot by 1mm
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate - lockedRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = -0.001;
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Start position. {}", UA_StatusCode_name(retval));
        return retval;
    }


    if (isSimulation)
        adcAdapter->setStateSimulated(KELVIN_INTERMEDIATE, 0);

    // Move to "Unlock" Position
    // Unlocking the toolchanger requires a rotation by 67 degree (default 63 degree + 4 degree overshoot)
    // with additional displacement of the overshot 1mm
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate + 4 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.0;
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Unlock position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    if (isSimulation)
        adcAdapter->setStateSimulated(KELVIN_READY, 0);

    // Move to "Park" Position
    // Move back the overshot 4 degree
    // Directly aligned with the tool keeping robot rotated by 22 degree (= default master plate rotation)
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.0;
    moveTransform.translation().z() = 0.0;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Park position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    if (isSimulation && !coachModelConnectionUuid.empty()) {
        // remove model connection in coach
        coachWrapper->removeConnection(coachModelConnectionUuid);
        coachModelConnectionUuid.clear();
    }

    // Move to "Back Door" Position
    // Above the tool keeping robot rotated by 22 degree (= default master plate rotation)
    moveTransform = ::rl::math::AngleAxis(
            -defaultRotate,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0,
            ::rl::math::Vector3::UnitX()
    );
    moveTransform.translation().x() = 0.0;
    moveTransform.translation().y() = 0.0;
    moveTransform.translation().z() = -0.045;
    retval = fortiss::skill::moveRobotToCartesian(
            robotCartesianLinearMoveSkill,
            logger,
            robotToTool * moveTransform,
            "",
            slowCartSpeed);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Cold not move to Back Door position. {}", UA_StatusCode_name(retval));
        return retval;
    }

    toolPickupPositionSet = false;

    return UA_STATUSCODE_GOOD;
}


UA_StatusCode KelvinToolchanger::initRobotSkills() {
    if (robotCartesianLinearMoveSkill == nullptr) {
        if (this->skillDetector->registeredSkills.count("CartesianLinearMoveSkill") == 0) {
            logger->error("No skill registered for Type CartesianLinearMoveSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (this->skillDetector->registeredSkills.count("CartesianLinearMoveSkill") > 1) {
            logger->error("More than one skill registered for Type CartesianLinearMoveSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        std::pair<std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator, std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator> skillIterator;
        skillIterator = this->skillDetector->registeredSkills.equal_range("CartesianLinearMoveSkill");
        robotCartesianLinearMoveSkill = skillIterator.first->second;
    }

    if (robotCartesianPtpMoveSkill == nullptr) {
        if (this->skillDetector->registeredSkills.count("CartesianPtpMoveSkill") == 0) {
            logger->error("No skill registered for Type CartesianPtpMoveSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (this->skillDetector->registeredSkills.count("CartesianPtpMoveSkill") > 1) {
            logger->error("More than one skill registered for Type CartesianPtpMoveSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        std::pair<std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator, std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator> skillIterator;
        skillIterator = this->skillDetector->registeredSkills.equal_range("CartesianPtpMoveSkill");
        robotCartesianPtpMoveSkill = skillIterator.first->second;
    }

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode KelvinToolchanger::powerOffTool() {

    std::string discoveryUrl;

    if (currentToolDescription.discoveryUrlsSize > 0)
        discoveryUrl = std::string((char*) currentToolDescription.discoveryUrls[0].data, currentToolDescription.discoveryUrls[0].length);

    setCurrentToolReady(false);
    UA_ApplicationDescription_init(&currentToolDescription);
    setCurrentToolDescription(currentToolDescription);
    setCurrentToolId(0);


    std::shared_ptr<spdlog::logger> loggerClient = logger->clone(logger->name() + "-client");
    if (loggerClient->level() < spdlog::level::err)
        loggerClient->set_level(spdlog::level::err);
    if (discoveryUrl.length() > 0) {

        UA_Client* client = fortiss::opcua::UA_Helper_getClientForEndpoint(
                fortiss::opcua::getEndpointWithHighestSecurity(discoveryUrl.c_str(), loggerClient),
                loggerClient,
                clientCertPath,
                clientKeyPath,
                clientAppUri,
                "fortiss - Component - Kelvin Toolchanger - Client"
        );
        if (!client) {
            logger->error("Could not create client for tool on toolchanger");
            return UA_STATUSCODE_BADNOTCONNECTED;
        }
        UA_ClientConfig* cnf = UA_Client_getConfig(client);
        cnf->timeout = 1000;

        UA_StatusCode retval;
        retval = UA_Client_connect(client, discoveryUrl.c_str());

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Can not connect to Tool on Toolchanger {}. Error {}", discoveryUrl.c_str(), UA_StatusCode_name(retval));
            return retval;
        }

        UA_UInt16 diNsIdx;
        {
            UA_String nsUri = UA_String_fromChars(NAMESPACE_URI_DI);
            retval = UA_Client_NamespaceGetIndex(client, &nsUri, &diNsIdx);
            UA_String_clear(&nsUri);
            if (retval != UA_STATUSCODE_GOOD) {
                logger->error("Can not get namespace index of {} from {}: {}", NAMESPACE_URI_DI, discoveryUrl.c_str(), UA_StatusCode_name(retval));
                return retval;
            }
        }
        UA_UInt16 fortissDiNsIdx;
        {
            UA_String nsUri = UA_String_fromChars(NAMESPACE_URI_FOR_DI);
            retval = UA_Client_NamespaceGetIndex(client, &nsUri, &fortissDiNsIdx);
            UA_String_clear(&nsUri);
            if (retval != UA_STATUSCODE_GOOD) {
                logger->error("Can not get namespace index of {} from {}: {}", NAMESPACE_URI_FOR_DI, discoveryUrl.c_str(), UA_StatusCode_name(retval));
                return retval;
            }
        }

        UA_NodeId deviceSetId = UA_NODEID_NUMERIC(diNsIdx, UA_DIID_DEVICESET);
        UA_NodeId powerOffDeviceType = UA_NODEID_NUMERIC(fortissDiNsIdx, UA_FORTISS_DEVICEID_IPOWEROFFDEVICETYPE);

        std::vector<std::shared_ptr<UA_NodeId>> foundIds = std::vector<std::shared_ptr<UA_NodeId>>();

        bool found = fortiss::opcua::UA_Client_findChildrenImplementingInterfaceRecursively(client, logger, &deviceSetId, 1, powerOffDeviceType, foundIds);
        if (!found) {
            UA_Client_disconnect(client);
            return UA_STATUSCODE_GOOD;
        }

        UA_NodeId* deviceNodeId = foundIds.at(0).get();

        UA_NodeId powerOffNodeId;
        std::string powerOffStr = "PowerOffDevice";
        UA_String powerOffName = {
                .length = powerOffStr.length(),
                .data = (UA_Byte*) const_cast<char*>(powerOffStr.c_str())
        };
        found = fortiss::opcua::UA_Client_findChildWithName(client, logger, *deviceNodeId,
                                                            powerOffName,
                                                            &powerOffNodeId);
        if (!found) {
            UA_Client_disconnect(client);
            return UA_STATUSCODE_GOOD;
        }


        /* Call a remote method */
        UA_Variant input;
        UA_UInt32 delayMs = 0;
        UA_Variant_init(&input);
        UA_Variant_setScalarCopy(&input, &delayMs, &UA_TYPES[UA_TYPES_UINT32]);
        size_t outputSize;
        UA_Variant* output;
        retval = UA_Client_call(client, *deviceNodeId,
                                powerOffNodeId, 1, &input, &outputSize, &output);
        if (retval == UA_STATUSCODE_GOOD) {
            UA_Array_delete(output, outputSize, &UA_TYPES[UA_TYPES_VARIANT]);
        } else if (retval != UA_STATUSCODE_BADNOTIMPLEMENTED) {
            logger->error("Can not call PowerOff Tool {}. Error {}", discoveryUrl.c_str(), UA_StatusCode_name(retval));
        }
        UA_Variant_clear(&input);

        UA_Client_disconnect(client);


    }

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode KelvinToolchanger::detectCurrentTool(const std::string& expectedAppUri) {

    const UA_String expectedUriStr = {
            .length = expectedAppUri.length(),
            .data = const_cast<UA_Byte*>((const UA_Byte*) expectedAppUri.data())
    };

    std::shared_ptr<RegisteredComponent> foundComponent;

    // wait maximum 20 seconds for the device to boot up.
    for (size_t i = 0; i < 20 && !foundComponent; i++) {
        for (const auto& component : skillDetector->registeredComponents) {

            // TODO just comparing the application URI may not be enough if we have multiple tools with the same app uri
            if (UA_String_equal(&component.second->endpoint->server.applicationUri, &expectedUriStr)) {
                foundComponent = component.second;
                break;
            }
        }
        if (!foundComponent)
            std::this_thread::sleep_for(std::chrono::milliseconds(1000));
    }

    if (!foundComponent)
        return UA_STATUSCODE_BADNOTFOUND;

    UA_ApplicationDescription_copy(&foundComponent->endpoint->server, &currentToolDescription);
    setCurrentToolDescription(currentToolDescription);
    setCurrentToolId(this->getToolId());
    setCurrentToolReady(true);

    return 0;
}

UA_StatusCode KelvinToolchanger::setCurrentToolDescription(const UA_ApplicationDescription& description) {
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, const_cast<UA_ApplicationDescription*>(&description), &UA_TYPES[UA_TYPES_APPLICATIONDESCRIPTION]);
    return UA_Server_writeValue(server, currentToolDescriptionNode, v);
}

UA_StatusCode KelvinToolchanger::setCurrentToolId(UA_UInt16 id) {
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &id, &UA_TYPES[UA_TYPES_UINT16]);
    return UA_Server_writeValue(server, currentToolIdNode, v);
}

UA_StatusCode KelvinToolchanger::setCurrentToolReady(UA_Boolean ready) {
    UA_Variant v;
    UA_Variant_init(&v);
    UA_Variant_setScalar(&v, &ready, &UA_TYPES[UA_TYPES_BOOLEAN]);
    return UA_Server_writeValue(server, currentToolReadyNode, v);
}
