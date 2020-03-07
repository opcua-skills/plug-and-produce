#ifndef GRIPPEROPCUA_H
#define GRIPPEROPCUA_H


#include <memory>

#include <common/opcua/skill/gripper/GraspReleaseGripperSkill.hpp>

#ifdef LOCAL_SIMULATION
#include <SimGripper.h>
#define GRIPPER_CLASS SimGripper
#else
#include <rl/hal/RobotiqModelC.h>
#define GRIPPER_CLASS rl::hal::RobotiqModelC
#endif




#define NAMESPACE_URI_ROBOTIQ "https://fortiss.org/UA/robotiq/"

namespace fortiss {
    class ReleaseGripperSkillImpl;
    class GraspGripperSkillImpl;
}

class GripperOPCUA {
public:
    explicit GripperOPCUA(const std::shared_ptr<spdlog::logger>& _logger, UA_Server *server);

    virtual ~GripperOPCUA();


    bool connect();

    void shutdown();

    void step();
private:
    UA_Server* server;
    std::shared_ptr<spdlog::logger> logger;

    // disable copy constructor
    GripperOPCUA & operator=(const GripperOPCUA&) = delete;
    GripperOPCUA(const GripperOPCUA&) = delete;

    unsigned long lastStepped = 0;

    GRIPPER_CLASS gripper;


    const UA_UInt16 nsIdRobotiq;
    const UA_NodeId skillsNodeId;

    fortiss::ReleaseGripperSkillImpl* releaseSkillImpl;
    fortiss::GraspGripperSkillImpl* graspSkillImpl;

    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> releaseSkill;
    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> graspSkill;

    bool addGripperGraspSkill();
    bool addGripperReleaseSkill();
};

#endif // GRIPPEROPCUA_H
