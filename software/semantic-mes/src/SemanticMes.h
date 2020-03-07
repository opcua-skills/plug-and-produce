//
// Created by pangercic on 1/8/19.
//

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


class SemanticMes {

public:
    explicit SemanticMes(
            std::shared_ptr<spdlog::logger> _logger,
            UA_Server* server,
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

    void onRegisterServer(const UA_RegisteredServer* registeredServer);

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

protected:
    virtual bool createNodesFromNodeset();
    std::shared_ptr<spdlog::logger> logger;
    UA_Server* server;
    virtual UA_StatusCode initSkills();

    SkillDetector* skillDetector = nullptr;


private:
    bool running = false;

    bool isExecuting = false;

    fortiss::semantic_mes::ExecuteProcessSkillImpl* executeProcessSkillImpl{};
    std::unique_ptr<fortiss::opcua::skill::ExecuteProcessSkill> executeProcessSkill;

    std::map<std::string, bool> serverKnown;


};


#endif //DATA_BACKBONE_SEMANTICMES_H
