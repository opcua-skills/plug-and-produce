//
// Created by profanter on 22/01/2020.
// Copyright (c) 2020 fortiss GmbH. All rights reserved.
//

#include "CompositeSkills.h"


#include <namespace_di_generated.h>
#include <namespace_fortiss_device_generated.h>
#include <namespace_composite_skills_generated.h>
#include <common/opcua/helper.hpp>
#include "CompositeSkills.h"
#include "PickAndPlaceSkill.hpp"

#include <open62541/client.h>
#include <fortiss_device_nodeids.h>
#include <di_nodeids.h>
#include <open62541/client_highlevel.h>
#include <composite_skills_nodeids.h>


CompositeSkills::CompositeSkills(
        std::shared_ptr<spdlog::logger> _logger,
        UA_Server* server,
        const libconfig::Setting& compositeSettings,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const std::string& clientAppUri,
        const std::string& clientName
) :
        skillDetector(new SkillDetector(_logger, clientCertPath, clientKeyPath, clientAppUri, clientName)),
        isSimulation(compositeSettings["simulation"]),
        compositeSettings(compositeSettings),
        logger(std::move(_logger)),
        server(server),
        clientCertPath(clientCertPath),
        clientKeyPath(clientKeyPath),
        clientAppUri(clientAppUri),
        clientName(clientName) {

    if (isSimulation) {
        coachWrapper = new rlCoachWrapper();
        coachWrapper->runThreaded();
    }

    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Kelvin Toolchanger nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw fortiss::opcua::StatusCodeException(retval);


    rl::math::Transform cubePos;
    cubePos = ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitX()
    );
    cubePos.translation().x() = 0.05;
    cubePos.translation().y() = 0.10;
    cubePos.translation().z() = 0.00;

    setObjectFrame("cube-green", cubePos);

}

CompositeSkills::~CompositeSkills() {
    delete skillDetector;
}

bool CompositeSkills::createNodesFromNodeset() {
    if (namespace_di_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_composite_skills_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Kelvin Toolchanger namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}

UA_StatusCode CompositeSkills::initSkills() {

    UA_NodeId pickAndPlaceSkillId = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_COMPOSITE_SKILLS),
            UA_COMPOSITE_SKILLSID_COMPOSITESKILLS_SKILLS_PICKANDPLACESKILL
    );

    pickAndPlaceSkillImpl = new fortiss::composite_skills::PickAndPlaceSkillImpl(logger, this);

    pickAndPlaceSkill = std::make_unique<fortiss::opcua::skill::PickAndPlaceSkill>
            (server, logger, pickAndPlaceSkillId,
             "PickAndPlaceSkill");
    pickAndPlaceSkill->setImpl(pickAndPlaceSkillImpl, [this]() {
        delete pickAndPlaceSkillImpl;
    });
    pickAndPlaceSkill->transition(fortiss::opcua::ProgramStateNumber::READY);

    return UA_STATUSCODE_GOOD;
}

void CompositeSkills::onServerAnnounce(
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


UA_StatusCode CompositeSkills::getObjectFrame(
        const std::string& objectId,
        rl::math::Transform* objectFrame,
        rl::math::Transform* pickApproach,
        rl::math::Transform* placeApproach
) {


    // TODO get object frame from knowledge base or world model.
    // For now it's hard-coded

    if (this->objectPositions.count(objectId) == 0) {
        logger->error("Position of object with ID {} not known.", objectId);
        return UA_STATUSCODE_BADNOTFOUND;
    }

    *objectFrame = this->objectPositions.at(objectId);

    *pickApproach = ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitX()
    );
    pickApproach->translation().x() = 0.00;
    pickApproach->translation().y() = 0.00;
    pickApproach->translation().z() = -0.05;

    *placeApproach = ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitZ()
    ) * ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitY()
    ) * ::rl::math::AngleAxis(
            0.0 * DEG_TO_RAD,
            ::rl::math::Vector3::UnitX()
    );
    placeApproach->translation().x() = 0.00;
    placeApproach->translation().y() = 0.00;
    placeApproach->translation().z() = -0.05;

    return UA_STATUSCODE_GOOD;
}

void CompositeSkills::setObjectFrame(
        const std::string& objectId,
        const rl::math::Transform& objectFrame
) {
    if (this->objectPositions.count(objectId) > 0) {
        this->objectPositions.erase(objectId);
    }

    this->objectPositions.emplace(objectId, objectFrame);
}

