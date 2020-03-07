#ifndef GRIPPEROPCUA_H
#define GRIPPEROPCUA_H


#include <memory>

#include <common/opcua/skill/gripper/GraspReleaseGripperSkill.hpp>

#ifdef LOCAL_SIMULATION
#include <SimGripper.h>
#define GRIPPER_CLASS SimGripper
#else
#include <IoLinkGripper.h>
#define GRIPPER_CLASS IoLinkGripper
#endif


#define NAMESPACE_URI_SCHMALZ "https://fortiss.org/UA/schmalz/"

namespace fortiss {
    class ReleaseGripperSkillImpl;
    class GraspGripperSkillImpl;
}

class GripperOPCUA {
public:
    explicit GripperOPCUA(const std::shared_ptr<spdlog::logger>& _logger, UA_Server *server, GRIPPER_CLASS* gripper);

    virtual ~GripperOPCUA();


    bool connect();

    void shutdown();

    bool step();
private:
    UA_Server* server;
    std::shared_ptr<spdlog::logger> logger;

    // disable copy constructor
    GripperOPCUA & operator=(const GripperOPCUA&) = delete;
    GripperOPCUA(const GripperOPCUA&) = delete;

    unsigned long lastStepped = 0;

    GRIPPER_CLASS* gripper;


    const UA_UInt16 nsIdSchmalz;
    const UA_NodeId skillsNodeId;

    fortiss::ReleaseGripperSkillImpl* releaseSkillImpl;
    fortiss::GraspGripperSkillImpl* graspSkillImpl;

    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> releaseSkill;
    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> graspSkill;

    bool addGripperGraspSkill();
    bool addGripperReleaseSkill();
};

#endif // GRIPPEROPCUA_H
