/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef DATA_BACKBONE_SEMANTICMES_H
#define DATA_BACKBONE_SEMANTICMES_H

#include <spdlog/spdlog.h>
#include <memory>
#include <libconfig.h++>

#include <common/client/gripper/GripperSkillClient.h>
#include <common/client/robot/RobotClient.h>

#include "ExecuteProcessSkill.hpp"
#include "ExecuteProcessSkillImpl.h"

#include <common/skill_detector/SkillDetector.h>
#include <set>


class SemanticMes {

public:
    explicit SemanticMes(
            std::shared_ptr<spdlog::logger> _loggerApp,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
            const std::string& clientCertPath,
            const std::string& clientKeyPath
    );

    virtual ~SemanticMes();

    SemanticMes(const SemanticMes&) = delete;

    virtual UA_StatusCode startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
    );


    void start();

    void stop();

    void onServerRegister(const UA_RegisteredServer* registeredServer);

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

protected:
    virtual bool createNodesFromNodeset();

    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    const std::shared_ptr<fortiss::opcua::OpcUaServer> server;

    virtual UA_StatusCode initSkills();

    SkillDetector* skillDetector = nullptr;


    UA_StatusCode triggerModelChangeEvent(UA_NodeId nodeId);

private:
    bool running = false;


    fortiss::semantic_mes::ExecuteProcessSkillImpl* executeProcessSkillImpl{};
    std::unique_ptr<fortiss::opcua::skill::ExecuteProcessSkill> executeProcessSkill;

};


#endif //DATA_BACKBONE_SEMANTICMES_H
