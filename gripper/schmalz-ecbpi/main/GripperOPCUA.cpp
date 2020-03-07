#include "GripperOPCUA.h"

#include "schmalz_ecbpi_nodeids.h"
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

#define reverse_bytes_32(num) ( ((num>>24)&0xff) | ((num<<8)&0xff0000) | ((num>>8)&0xff00) | ((num<<24)&0xff000000) )
#define reverse_bytes_16(num) ( (num>>8) | (num<<8) )

GripperOPCUA::GripperOPCUA(const std::shared_ptr<spdlog::logger>& _logger, UA_Server *server, GRIPPER_CLASS* gripper) :
        server(server),
        logger(_logger),
        gripper(gripper),
        nsIdSchmalz(fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_SCHMALZ)),
        skillsNodeId(UA_NODEID_NUMERIC(
                nsIdSchmalz,
                UA_SCHMALZ_ECBPIID_SCHMALZECBPI_SKILLS)) {
    logger->info("Initializing Gripper");
    addGripperGraspSkill();
    addGripperReleaseSkill();
}

GripperOPCUA::~GripperOPCUA() {

}

bool GripperOPCUA::connect() {
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

bool GripperOPCUA::step() {

    unsigned long currentMillis = millis();

    // update every 8ms
    if (currentMillis - lastStepped < 8)
        return true;

    lastStepped = currentMillis;
    releaseSkillImpl->step();
    graspSkillImpl->step();

#ifndef LOCAL_SIMULATION
    const Schmalz::ECBPi::ProcessDataIn_t *processDataIn;
    if (!gripper->getProcessDataIn(&processDataIn)) {
        logger->error("Could not read process data of gripper");
        return true;
    }
    {
        UA_Boolean val = processDataIn->partPresent;
        UA_Variant var;
        UA_Variant_setScalar(&var, &val, &UA_TYPES[UA_TYPES_BOOLEAN]);
        if (const UA_StatusCode retval = UA_Server_writeValue(
                server,
                UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_PARTPRESENT),
                var) != UA_STATUSCODE_GOOD) {
            logger->error("Could not write PartPresent Value: {} ", UA_StatusCode_name(retval));
            return true;
        }
    }
    {
        UA_Boolean val = processDataIn->inControlRange;
        UA_Variant var;
        UA_Variant_setScalar(&var, &val, &UA_TYPES[UA_TYPES_BOOLEAN]);
        if (const UA_StatusCode retval = UA_Server_writeValue(
                server,
                UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_INCONTROLRANGE),
                var) != UA_STATUSCODE_GOOD) {
            logger->error("Could not write InControlRange Value: {} ", UA_StatusCode_name(retval));
            return true;
        }
    }
    {
        UA_Boolean val = processDataIn->partDetached;
        UA_Variant var;
        UA_Variant_setScalar(&var, &val, &UA_TYPES[UA_TYPES_BOOLEAN]);
        if (const UA_StatusCode retval = UA_Server_writeValue(
                server,
                UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_PARTDETACHED),
                var) != UA_STATUSCODE_GOOD) {
            logger->error("Could not write PartDetached Value: {} ", UA_StatusCode_name(retval));
            return true;
        }
    }
    {
        UA_UInt16 val;
        if (!gripper->readParameter(Schmalz::ECBPi::Observation.Monitoring.ProcessData.VacuumValueLive, (uint8_t*)&val)) {
            logger->error("Could not read VacuumValueLive");
            return true;
        }

        UA_UInt16 val2 = reverse_bytes_16(val);
        UA_Variant var;
        UA_Variant_setScalar(&var, &val2, &UA_TYPES[UA_TYPES_UINT16]);
        if (const UA_StatusCode retval = UA_Server_writeValue(
                server,
                UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_VACUUMLIVE),
                var) != UA_STATUSCODE_GOOD) {
            logger->error("Could not write VacuumValueLive Value: {} ", UA_StatusCode_name(retval));
            return true;
        }
    }
    {
        UA_UInt16 val;
        if (!gripper->readParameter(Schmalz::ECBPi::Observation.Monitoring.ProcessData.TemperatureValueLive, (uint8_t*)&val)) {
            logger->error("Could not read TemperatureValueLive");
            return true;
        }

        UA_UInt16 val2 = reverse_bytes_16(val);
        UA_Variant var;
        UA_Variant_setScalar(&var, &val2, &UA_TYPES[UA_TYPES_UINT16]);
        if (const UA_StatusCode retval = UA_Server_writeValue(
                server,
                UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_TEMPERATURELIVE),
                var) != UA_STATUSCODE_GOOD) {
            logger->error("Could not write TemperatureValueLive Value: {} ", UA_StatusCode_name(retval));
            return true;
        }
    }
    {
        UA_UInt16 val;
        if (!gripper->readParameter(Schmalz::ECBPi::Observation.Monitoring.ProcessData.LeakageRate, (uint8_t*)&val)) {
            logger->error("Could not read LeakageRate");
            return true;
        }

        UA_UInt16 val2 = reverse_bytes_16(val);
        UA_Variant var;
        UA_Variant_setScalar(&var, &val2, &UA_TYPES[UA_TYPES_UINT16]);
        if (const UA_StatusCode retval = UA_Server_writeValue(
                server,
                UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_LEAKAGERATE),
                var) != UA_STATUSCODE_GOOD) {
            logger->error("Could not write LeakageRate Value: {} ", UA_StatusCode_name(retval));
            return true;
        }
    }
#endif

    return true;
}


void GripperOPCUA::shutdown() {

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
                                                             gripper, false);

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
                                                                 gripper, false);

    releaseSkill = std::make_unique<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill>
            (server, logger, releaseSkillId,
             "ReleaseSkill");
    releaseSkill->setImpl(releaseSkillImpl, [this]() {
        delete releaseSkillImpl;
    });

    return true;
}