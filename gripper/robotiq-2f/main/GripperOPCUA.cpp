#include "GripperOPCUA.h"

#include "robotiq_2f_nodeids.h"
#include "impl/GraspGripperSkillImpl.hpp"
#include "impl/ReleaseGripperSkillImpl.hpp"

#ifndef LOCAL_SIMULATION
static
unsigned long IRAM_ATTR millis()
{
    return (unsigned long) (esp_timer_get_time() / 1000ULL);
}
#else
static
unsigned long millis() {
    return std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::system_clock::now().time_since_epoch()).count();
}
#endif


GripperOPCUA::GripperOPCUA(const std::shared_ptr<spdlog::logger>& _logger, UA_Server *server) :
        server(server),
        logger(_logger),
        gripper(""),
        nsIdRobotiq(fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_ROBOTIQ)),
        skillsNodeId(UA_NODEID_NUMERIC(
                nsIdRobotiq,
                UA_ROBOTIQ_2FID_ROBOTIQ2F_SKILLS)) {
    logger->info("Initializing Gripper");
    addGripperGraspSkill();
    addGripperReleaseSkill();
}

GripperOPCUA::~GripperOPCUA() {

}

bool GripperOPCUA::connect() {

    gripper.open();
    gripper.start();

    logger->info("Gripper initialized and connected");

    if (!releaseSkill->transition(fortiss::opcua::ProgramStateNumber::READY)) {
        logger->error("Can not transition skill to ready");
        return false;
    }
    if (!graspSkill->transition(fortiss::opcua::ProgramStateNumber::READY)) {
        logger->error("Can not transition skill to ready");
        return false;
    }
    return true;
}

void GripperOPCUA::step() {

    unsigned long currentMillis = millis();

    if (currentMillis - lastStepped > std::chrono::duration_cast<std::chrono::milliseconds>(gripper.getUpdateRate()).count()) {
        gripper.step();
        lastStepped = currentMillis;
        releaseSkillImpl->step();
        graspSkillImpl->step();
    }
}


void GripperOPCUA::shutdown() {
    gripper.stop();
    gripper.close();
}

bool GripperOPCUA::addGripperGraspSkill() {

    UA_NodeId graspSkillId = UA_NODEID_NULL;
    bool found = fortiss::opcua::UA_Server_findChildOfType(server, logger, skillsNodeId, UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_FOR_DI),
            UA_FORTISS_DEVICEID_GRASPGRIPPERSKILLTYPE), &graspSkillId);
    if (!found) {
        logger->error("No or multiple GraspGripperSkill found on the server.");
        return false;
    }

    graspSkillImpl = new fortiss::GraspGripperSkillImpl(logger,
                                                             &gripper, false);

    graspSkill = std::make_unique<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill>
            (server, logger, graspSkillId,
             "GraspSkill");
    graspSkill->setImpl(graspSkillImpl, [this]() {
        delete graspSkillImpl;
    });

    return true;
}

bool GripperOPCUA::addGripperReleaseSkill() {

    UA_NodeId releaseSkillId = UA_NODEID_NULL;
    bool found = fortiss::opcua::UA_Server_findChildOfType(server, logger, skillsNodeId, UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(
                    server, NAMESPACE_URI_FOR_DI),
            UA_FORTISS_DEVICEID_RELEASEGRIPPERSKILLTYPE), &releaseSkillId);
    if (!found) {
        logger->error("No or multiple ReleaseGripperSkill found on the server.");
        return false;
    }

    releaseSkillImpl = new fortiss::ReleaseGripperSkillImpl(logger,
                                                                 &gripper, false);

    releaseSkill = std::make_unique<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill>
            (server, logger, releaseSkillId,
             "ReleaseSkill");
    releaseSkill->setImpl(releaseSkillImpl, [this]() {
        delete releaseSkillImpl;
    });

    return true;
}