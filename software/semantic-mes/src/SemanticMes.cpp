//
// Created by pangercic on 1/8/19.
//


#include "SemanticMes.h"
// next include need to be here because of forward declaration

#include "common/opcua/helper.hpp"
#include <semantic_mes_nodeids.h>


#include <namespace_di_generated.h>
#include <namespace_fortiss_device_generated.h>
#include <namespace_semantic_mes_generated.h>

#include <open62541/client_highlevel.h>
#include <open62541/client_config_default.h>
#include <common/logging_opcua.h>

#include <utility>

SemanticMes::SemanticMes(
        std::shared_ptr<spdlog::logger> _logger,
        UA_Server* server,
        const std::string& clientCertPath,
        const std::string& clientKeyPath
) :
        logger(std::move(_logger)),
        server(server),
        skillDetector(new SkillDetector(logger, clientCertPath, clientKeyPath, "fortiss.component.mes.client",
                                        "fortiss - MES - Skill Client")) {

    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Semantic MES nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw fortiss::opcua::StatusCodeException(retval);

}

SemanticMes::~SemanticMes() {
    stop();

    delete skillDetector;
}

bool SemanticMes::createNodesFromNodeset() {
    if (namespace_di_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_semantic_mes_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Semantic MES namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}


void SemanticMes::start() {
    if (running)
        return;
    running = true;

    executeProcessSkill->transition(fortiss::opcua::ProgramStateNumber::READY);
}

void SemanticMes::stop() {
    running = false;

    executeProcessSkill->transition(fortiss::opcua::ProgramStateNumber::HALTED);
}

UA_StatusCode SemanticMes::startExecution(
        const std::string& abstractProcessIri,
        const std::string& executionMode
) {
    return UA_STATUSCODE_BADNOTIMPLEMENTED;

}

UA_StatusCode SemanticMes::initSkills() {

    UA_NodeId executeProcessSkillId = UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_SEMANTIC_MES),
            UA_SEMANTIC_MESID_SEMANTICMES_SKILLS_EXECUTEPROCESSSKILL
    );

    executeProcessSkillImpl = new fortiss::semantic_mes::ExecuteProcessSkillImpl(logger,
                                                                                 this);

    executeProcessSkill = std::make_unique<fortiss::opcua::skill::ExecuteProcessSkill>
            (server, logger, executeProcessSkillId,
             "ExecuteProcessSkill");
    executeProcessSkill->setImpl(executeProcessSkillImpl, [this]() {
        delete executeProcessSkillImpl;
    });

    return UA_STATUSCODE_GOOD;
}

void SemanticMes::onRegisterServer(const UA_RegisteredServer* registeredServer) {

    std::string serverUri = std::string((char*) registeredServer->serverUri.data, registeredServer->serverUri.length);

    // create a copy of registered server struct since it may be deleted while the thread is still running.
    UA_RegisteredServer* registeredServerTmp = UA_RegisteredServer_new();
    UA_RegisteredServer_copy(registeredServer, registeredServerTmp);
    std::shared_ptr<UA_RegisteredServer> registeredServerSafe = std::shared_ptr<UA_RegisteredServer>(registeredServerTmp, [=](UA_RegisteredServer* ptr) {
        UA_RegisteredServer_delete(ptr);
    });

    if (registeredServer->isOnline) {
        logger->info("Got register from component: {}", serverUri);

        std::vector<std::string> discoveryUrls;

        for (size_t i = 0; i < registeredServer->discoveryUrlsSize; i++) {
            discoveryUrls.emplace_back(std::string((char*) registeredServer->discoveryUrls[i].data, registeredServer->discoveryUrls[i].length));
        }

        std::thread([this, registeredServerSafe, discoveryUrls]() {

            std::shared_ptr<spdlog::logger> loggerClient = logger->clone(logger->name() + "-client");
            if (loggerClient->level() < spdlog::level::err)
                loggerClient->set_level(spdlog::level::err);

            std::promise<std::shared_ptr<UA_EndpointDescription>> promiseEndpoint;
            fortiss::opcua::getBestEndpointFromServer(discoveryUrls, promiseEndpoint, loggerClient);
            std::future<std::shared_ptr<UA_EndpointDescription>> endpointFuture = promiseEndpoint.get_future();

            std::future_status status = endpointFuture.wait_for(std::chrono::seconds(5));

            if (status == std::future_status::ready) {
                std::shared_ptr<UA_EndpointDescription> endpoint = endpointFuture.get();
                skillDetector->componentConnected(registeredServerSafe, endpoint);
            }

        }).detach();

    } else {

        logger->info("Got unregister from component: {}", serverUri);

        skillDetector->componentDisconnected(registeredServerSafe);
    }


}


void SemanticMes::onServerAnnounce(
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
