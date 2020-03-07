//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef KELVIN_TOOLCHANGER_KELVINTOOLCHANGER_H
#define KELVIN_TOOLCHANGER_KELVINTOOLCHANGER_H

#include <common/skill_detector/SkillDetector.h>

#include <libconfig.h++>
#include "ChangeToolSkillImpl.h"
#include "DropToolSkillImpl.h"
#include "AdcAdapter.h"
#include <rl/math/Transform.h>
#include <common/rlCoachWrapper.hpp>

class KelvinToolchanger {
public:
    explicit KelvinToolchanger(
            std::shared_ptr<spdlog::logger> _logger,
            UA_Server* server,
            const libconfig::Setting& toolchangerSettings,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const std::string& clientAppUri,
            const std::string& clientName
    );


    virtual ~KelvinToolchanger();

    KelvinToolchanger(const KelvinToolchanger&) = delete;

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );


    UA_StatusCode takeToolAtPosition(
            const UA_ThreeDFrame* toolPosition,
            const std::string& expectedToolAppUri
    );

    KelvinToolState getToolState() { return adcAdapter->getToolState(); };

    unsigned short getToolId() { return adcAdapter->getToolId(); };

    UA_StatusCode dropCurrentTool();

private:
    std::shared_ptr<spdlog::logger> logger;
    UA_Server* server;
    const libconfig::Setting& toolchangerSettings;

    bool createNodesFromNodeset();

    UA_StatusCode initSkills();

    bool isSimulation;
    AdcAdapter* adcAdapter = nullptr;
    const std::string clientCertPath;
    const std::string clientKeyPath;
    const std::string clientAppUri;
    const std::string clientName;

    fortiss::kelvin_toolchanger::ChangeToolSkillImpl* changeToolSkillImpl{};
    std::unique_ptr<fortiss::opcua::skill::ChangeToolSkill> changeToolSkill;
    fortiss::kelvin_toolchanger::DropToolSkillImpl* dropToolSkillImpl{};
    std::unique_ptr<fortiss::opcua::skill::DropToolSkill> dropToolSkill;

    SkillDetector* skillDetector = nullptr;
    std::map<std::string, bool> serverKnown;

    rlCoachWrapper* coachWrapper = nullptr;
    std::string coachModelConnectionUuid;

    void onToolUpdate(
            const KelvinToolState toolState,
            const short toolId
    );

    UA_NodeId hasToolNode;

    UA_NodeId currentToolReadyNode;
    UA_NodeId currentToolDescriptionNode;
    UA_NodeId currentToolIdNode;

    UA_ApplicationDescription currentToolDescription;

    UA_StatusCode setCurrentToolReady(UA_Boolean ready);

    UA_StatusCode setCurrentToolId(UA_UInt16 id);

    UA_StatusCode setCurrentToolDescription(const UA_ApplicationDescription& description);

    rl::math::Transform toolMasterPlateOffset;

    bool toolPickupPositionSet = false;
    rl::math::Transform toolPickupPosition;

    std::shared_ptr<rl::math::Transform> worldToRobotTransform = nullptr;
    std::shared_ptr<RegisteredSkill> robotCartesianLinearMoveSkill = nullptr;
    std::shared_ptr<RegisteredSkill> robotCartesianPtpMoveSkill = nullptr;

    UA_StatusCode initRobotSkills();

    UA_StatusCode powerOffTool();

    UA_StatusCode detectCurrentTool(const std::string& expectedAppUri);
};


#endif //KELVIN_TOOLCHANGER_KELVINTOOLCHANGER_H
