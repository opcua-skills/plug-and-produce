/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef GRIPPEROPCUA_H
#define GRIPPEROPCUA_H


#include <memory>

#include <common/opcua/skill/gripper/GraspReleaseGripperSkill.hpp>

#ifdef LOCAL_SIMULATION

#include <SimGripper.h>
#include <impl/MoveGripperSkill.hpp>

#define GRIPPER_CLASS SimGripper
#else
#include <rl/hal/RobotiqModelC.h>
#define GRIPPER_CLASS rl::hal::RobotiqModelC
#include <impl/MoveGripperSkill.hpp>
#endif


#define NAMESPACE_URI_ROBOTIQ "https://fortiss.org/UA/robotiq/"

namespace fortiss {
    class ReleaseGripperSkillImpl;

    class GraspGripperSkillImpl;
    class MoveGripperSkillImpl;
}

class GripperOPCUA {
public:
    explicit GripperOPCUA(
            std::shared_ptr<spdlog::logger>  _logger,
            std::shared_ptr<fortiss::opcua::OpcUaServer>  server
    );

    virtual ~GripperOPCUA();


    bool connect();

    void shutdown();

    void step();

private:
    const std::shared_ptr<fortiss::opcua::OpcUaServer> server;
    std::shared_ptr<spdlog::logger> logger;

    // disable copy constructor
    GripperOPCUA& operator=(const GripperOPCUA&) = delete;

    GripperOPCUA(const GripperOPCUA&) = delete;

    unsigned long lastStepped = 0;

    GRIPPER_CLASS gripper;


    const UA_UInt16 nsIdRobotiq;
    const UA_NodeId skillsNodeId;

    fortiss::ReleaseGripperSkillImpl* releaseSkillImpl;
    fortiss::GraspGripperSkillImpl* graspSkillImpl;
    fortiss::MoveGripperSkillImpl* moveSkillImpl;

    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> releaseSkill;
    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> graspSkill;
    std::unique_ptr<fortiss::opcua::skill::gripper::MoveGripperSkill> moveSkill;

    bool addGripperGraspSkill();
    bool addGripperMoveSkill();

    bool addGripperReleaseSkill();
};

#endif // GRIPPEROPCUA_H
