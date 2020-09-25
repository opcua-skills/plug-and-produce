/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

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
        std::shared_ptr<spdlog::logger> _loggerApp,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
        const std::string& clientCertPath,
        const std::string& clientKeyPath
) :
        logger(std::move(_loggerApp)),
        loggerOpcua(std::move(_loggerOpcua)),
        server(server),
        skillDetector(new SkillDetector(logger, loggerOpcua, clientCertPath, clientKeyPath, "fortiss.component.mes.client",
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
    LockedServer ls = server->getLocked();
    if (namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_semantic_mes_generated(ls.get()) != UA_STATUSCODE_GOOD) {
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

void SemanticMes::onServerRegister(const UA_RegisteredServer* registeredServer) {
    skillDetector->onServerRegister(registeredServer);
}


void SemanticMes::onServerAnnounce(
        const UA_ServerOnNetwork* serverOnNetwork,
        UA_Boolean isServerAnnounce
) {
    skillDetector->onServerAnnounce(serverOnNetwork, isServerAnnounce);
}


UA_StatusCode SemanticMes::triggerModelChangeEvent(UA_NodeId nodeId) {
    UA_NodeId eventId;

    LockedServer ls = server->getLocked();

    UA_StatusCode retval = UA_Server_createEvent(ls.get(), UA_NODEID_NUMERIC(0, UA_NS0ID_BASEMODELCHANGEEVENTTYPE), &eventId);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("createEvent failed: {}", UA_StatusCode_name(retval));
        return retval;
    }

    /* Set the Event Attributes */
    /* Setting the Time is required or else the event will not show up in UAExpert! */
    UA_DateTime eventTime = UA_DateTime_now();
    UA_Server_writeObjectProperty_scalar(ls.get(),
                                         eventId,
                                         UA_QUALIFIEDNAME(0, const_cast<char*>("Time")),
                                         &eventTime,
                                         &UA_TYPES[UA_TYPES_DATETIME]);

    UA_UInt16 eventSeverity = 100;
    UA_Server_writeObjectProperty_scalar(ls.get(),
                                         eventId,
                                         UA_QUALIFIEDNAME(0, const_cast<char*>("Severity")),
                                         &eventSeverity,
                                         &UA_TYPES[UA_TYPES_UINT16]);

    UA_LocalizedText eventMessage = UA_LOCALIZEDTEXT(const_cast<char*>("en-US"),
                                                     const_cast<char*>("The model changed"));
    UA_Server_writeObjectProperty_scalar(ls.get(),
                                         eventId,
                                         UA_QUALIFIEDNAME(0, const_cast<char*>("Message")),
                                         &eventMessage,
                                         &UA_TYPES[UA_TYPES_LOCALIZEDTEXT]);

    return UA_Server_triggerEvent(ls.get(),
                                  eventId,
                                  nodeId,
                                  NULL, UA_TRUE);

}
