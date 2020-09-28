/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef COMPOSITE_SKILLS_COMPOSITESKILLS_H
#define COMPOSITE_SKILLS_COMPOSITESKILLS_H

#include <common/skill_detector/SkillDetector.h>

#include <libconfig.h++>
#include "PickAndPlaceSkillImpl.h"
#include <common/rlCoachWrapper.hpp>
#include <rl/math/Transform.h>


class CompositeSkills {
public:
    explicit CompositeSkills(
            std::shared_ptr<spdlog::logger> _loggerApp,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
            const libconfig::Setting& compositeSettings,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const std::string& clientAppUri,
            const std::string& clientName
    );


    virtual ~CompositeSkills();

    CompositeSkills(const CompositeSkills&) = delete;

    void onServerAnnounce(
            const UA_ServerOnNetwork* serverOnNetwork,
            UA_Boolean isServerAnnounce
    );

    SkillDetector* skillDetector = nullptr;

    const bool isSimulation;

    rlCoachWrapper* coachWrapper = nullptr;
    const libconfig::Setting& compositeSettings;

    UA_StatusCode getObjectFrame(
            const std::string& objectId,
            rl::math::Transform* objectFrame,
            rl::math::Transform* pickApproach,
            rl::math::Transform* placeApproach
    );

    void setObjectFrame(
            const std::string& objectId,
            const rl::math::Transform& objectFrame
    );

private:
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerOpcua;
    const std::shared_ptr<fortiss::opcua::OpcUaServer> server;

    bool createNodesFromNodeset();

    UA_StatusCode initSkills();

    fortiss::composite_skills::PickAndPlaceSkillImpl* pickAndPlaceSkillImpl{};
    std::unique_ptr<fortiss::opcua::skill::PickAndPlaceSkill> pickAndPlaceSkill;

    const std::string clientCertPath;
    const std::string clientKeyPath;
    const std::string clientAppUri;
    const std::string clientName;

    std::map<std::string, rl::math::Transform> objectPositions;


};


#endif //COMPOSITE_SKILLS_COMPOSITESKILLS_H
