/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include "GripperOPCUA.h"

#include <utility>

#include "schmalz_ecbpi_nodeids.h"
#include "impl/GraspGripperSkillImpl.hpp"
#include "impl/ReleaseGripperSkillImpl.hpp"

#ifndef LOCAL_SIMULATION
static
unsigned long IRAM_ATTR millis() {
    return (unsigned long) (esp_timer_get_time() / 1000ULL);
}
#include <esp_task_wdt.h>

#else

static
unsigned long millis() {
    return std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::system_clock::now().time_since_epoch()).count();
}

#endif

#define reverse_bytes_32(num) ( ((num>>24)&0xff) | ((num<<8)&0xff0000) | ((num>>8)&0xff00) | ((num<<24)&0xff000000) )
#define reverse_bytes_16(num) ( (num>>8) | (num<<8) )

GripperOPCUA::GripperOPCUA(
        std::shared_ptr<spdlog::logger> _logger,
        std::shared_ptr<fortiss::opcua::OpcUaServer> _server,
        GRIPPER_CLASS* gripper
) :
#ifndef LOCAL_SIMULATION
        running(false),
#endif
        logger(std::move(_logger)),
        server(std::move(_server)),
        gripper(gripper),
        nsIdSchmalz(fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_SCHMALZ)),
        skillsNodeId(UA_NODEID_NUMERIC(
                nsIdSchmalz,
                UA_SCHMALZ_ECBPIID_SCHMALZECBPI_SKILLS)) {
    logger->info("Initializing Gripper");
    addGripperGraspSkill();
    addGripperReleaseSkill();
    if (const UA_StatusCode ret = initDataSources() != UA_STATUSCODE_GOOD) {
        logger->error("Could not initialized data sources: {}", UA_StatusCode_name(ret));
        throw std::runtime_error("Error in initializing data sources");
    }
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


struct GripperStepperParams {
    GripperOPCUA* gripper;
};

#ifndef LOCAL_SIMULATION
static void gripper_stepper_task(void* arg) {
    struct GripperStepperParams* params = (struct GripperStepperParams*) arg;

    ESP_ERROR_CHECK(esp_task_wdt_add(NULL));

    /*int count = 20;
    int64_t timesServerSum = 0;
    int idx = 0;*/


    params->gripper->logger->warn("Starting gripper stepper");
    while (params->gripper->running) {
        //int64_t last = esp_timer_get_time();

        if (!params->gripper->step()) {
            return;
        }
        /*timesServerSum += esp_timer_get_time() - last;
        idx++;
        if (idx == count) {
            params->gripper->logger->info("Iter time: server {} ms", (timesServerSum / (double) count) / 1000.0);
            idx = 0;
            timesServerSum = 0;
        }*/
        ESP_ERROR_CHECK(esp_task_wdt_reset());
        vTaskDelay(pdMS_TO_TICKS(50));
    }

    params->gripper->logger->warn("Exiting gripper stepper");

    ESP_ERROR_CHECK(esp_task_wdt_delete(NULL));
    vTaskDelete( NULL );
}

bool GripperOPCUA::startStepperTask() {
    if (running)
        return false;
    struct GripperStepperParams* params = (struct GripperStepperParams*) malloc(sizeof(GripperStepperParams));
    params->gripper = this;
    running = true;
    xTaskCreate(gripper_stepper_task, "gripper_task", 5000, params, ESP_TASK_TCPIP_PRIO-1, NULL);
    return true;
}

bool GripperOPCUA::stopStepperTask(bool join) {
    running = false;
    if (join) {
        //TODO

        vTaskDelay(pdMS_TO_TICKS(100));
    }
    return true;
}
#endif

bool GripperOPCUA::step() {
    releaseSkillImpl->step();
    graspSkillImpl->step();

    /*if (gripper->hasEvent()) {
        s_iolma_event_t evt = gripper->popEvent();
        logger->warn("Gripper Event:\n\tCode: {}\n\tInstance: {}\n\tMode: {}\n\tType: {}\n\tOrigin: {}", evt.code, evt.e_instance, evt.e_mode, evt.e_type,
                evt.e_origin);
    }*/

#ifndef LOCAL_SIMULATION
    const Schmalz::ECBPi::ProcessDataIn_t* processDataIn;


    {
        std::lock_guard<std::mutex> lock(dataAccessMutex);
        sourceTimestamp = UA_DateTime_now();
    }

    if (!gripper->getProcessDataIn(&processDataIn)) {
        logger->error("Could not read process data of gripper");
        return false;
    }

    // The readParameter functions are currently disabled. They take too much time! (Around 100ms per read)
    /*
    UA_UInt16 tmpVacuumValueLive = 0;
    UA_UInt16 tmpTemperatureValueLive = 0;
    UA_UInt16 tmpLeakageRate = 0;

    {
        UA_UInt16 val;
        if (!gripper->readParameter(Schmalz::ECBPi::Observation.Monitoring.ProcessData.VacuumValueLive, (uint8_t*) &val)) {
            logger->error("Could not read VacuumValueLive");
            return false;
        }
        tmpVacuumValueLive = reverse_bytes_16(val);
    }
    {
        UA_UInt16 val;
        if (!gripper->readParameter(Schmalz::ECBPi::Observation.Monitoring.ProcessData.TemperatureValueLive, (uint8_t*) &val)) {
            logger->error("Could not read TemperatureValueLive");
            return false;
        }
        tmpTemperatureValueLive = reverse_bytes_16(val);
    }
    {
        UA_UInt16 val;
        if (!gripper->readParameter(Schmalz::ECBPi::Observation.Monitoring.ProcessData.LeakageRate, (uint8_t*) &val)) {
            logger->error("Could not read LeakageRate");
            return false;
        }
        tmpLeakageRate = reverse_bytes_16(val);
    }*/

    {
        std::lock_guard<std::mutex> lock(dataAccessMutex);
        partPresent = processDataIn->partPresent;
        inControlRange = processDataIn->inControlRange;
        partDetached = processDataIn->partDetached;

        // The meaning of the EPC values depends on the selected EPC setting. See manual and IoLinkGripper Base class.
        actualPower = (UA_Byte) processDataIn->epcValue1;
        vacuumValueLive = reverse_bytes_16(processDataIn->epcValue2);
    }

#endif
    return true;
}


void GripperOPCUA::shutdown() {
    //releaseSkillImpl->start();
    //this->step();
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
                                                            gripper,
                                                            false,
                                                            graspSkill,
                                                            graspSkillImpl);

    releaseSkill = std::make_unique<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill>
            (server, logger, releaseSkillId,
             "ReleaseSkill");
    releaseSkill->setImpl(releaseSkillImpl, [this]() {
        delete releaseSkillImpl;
    });

    return true;
}

UA_StatusCode GripperOPCUA::initDataSources() {

    LockedServer ls = server->getLocked();

    UA_DataSource dataSource{};
    dataSource.write = nullptr;
    dataSource.read = &GripperOPCUA::readPartPresent;
    UA_Server_setNodeContext(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_PARTPRESENT),
            this);
    UA_StatusCode retval = UA_Server_setVariableNode_dataSource(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_PARTPRESENT),
            dataSource);
    if (retval != UA_STATUSCODE_GOOD) {
        return retval;
    }

    dataSource.write = nullptr;
    dataSource.read = &GripperOPCUA::readInControlRange;
    UA_Server_setNodeContext(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_INCONTROLRANGE),
            this);
    retval = UA_Server_setVariableNode_dataSource(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_INCONTROLRANGE),
            dataSource);
    if (retval != UA_STATUSCODE_GOOD) {
        return retval;
    }

    dataSource.write = nullptr;
    dataSource.read = &GripperOPCUA::readPartDetached;
    UA_Server_setNodeContext(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_PARTDETACHED),
            this);
    retval = UA_Server_setVariableNode_dataSource(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_PARTDETACHED),
            dataSource);
    if (retval != UA_STATUSCODE_GOOD) {
        return retval;
    }


    dataSource.write = nullptr;
    dataSource.read = &GripperOPCUA::readVacuumValueLive;
    UA_Server_setNodeContext(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_VACUUMLIVE),
            this);
    retval = UA_Server_setVariableNode_dataSource(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_VACUUMLIVE),
            dataSource);
    if (retval != UA_STATUSCODE_GOOD) {
        return retval;
    }

    dataSource.write = nullptr;
    dataSource.read = &GripperOPCUA::readActualPower;
    UA_Server_setNodeContext(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_ACTUALPOWER),
            this);
    retval = UA_Server_setVariableNode_dataSource(
            ls.get(),
            UA_NODEID_NUMERIC(nsIdSchmalz, UA_SCHMALZ_ECBPIID_SCHMALZECBPI_STATUS_ACTUALPOWER),
            dataSource);
    if (retval != UA_STATUSCODE_GOOD) {
        return retval;
    }

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode GripperOPCUA::readPartPresent(
        UA_Server* server,
        const UA_NodeId* sessionId,
        void* sessionContext,
        const UA_NodeId* nodeId,
        void* nodeContext,
        UA_Boolean sourceTimestamp,
        const UA_NumericRange* range,
        UA_DataValue* dataValue
) {
    if (!nodeContext)
        return UA_STATUSCODE_BADINTERNALERROR;
    auto* self = static_cast<GripperOPCUA*>(nodeContext);

    std::lock_guard<std::mutex> lock(self->dataAccessMutex);
    UA_Variant_setScalarCopy(&dataValue->value, &self->partPresent, &UA_TYPES[UA_TYPES_BOOLEAN]);
    dataValue->hasValue = true;
    if (sourceTimestamp)
    {
        dataValue->hasSourceTimestamp = true;
        dataValue->sourceTimestamp = self->sourceTimestamp;
    }
    return UA_STATUSCODE_GOOD;
};

UA_StatusCode GripperOPCUA::readPartDetached(
        UA_Server* server,
        const UA_NodeId* sessionId,
        void* sessionContext,
        const UA_NodeId* nodeId,
        void* nodeContext,
        UA_Boolean sourceTimestamp,
        const UA_NumericRange* range,
        UA_DataValue* dataValue
) {
    if (!nodeContext)
        return UA_STATUSCODE_BADINTERNALERROR;
    auto* self = static_cast<GripperOPCUA*>(nodeContext);

    std::lock_guard<std::mutex> lock(self->dataAccessMutex);
    UA_Variant_setScalarCopy(&dataValue->value, &self->partDetached, &UA_TYPES[UA_TYPES_BOOLEAN]);
    dataValue->hasValue = true;
    if (sourceTimestamp)
    {
        dataValue->hasSourceTimestamp = true;
        dataValue->sourceTimestamp = self->sourceTimestamp;
    }
    return UA_STATUSCODE_GOOD;
};

UA_StatusCode GripperOPCUA::readInControlRange(
        UA_Server* server,
        const UA_NodeId* sessionId,
        void* sessionContext,
        const UA_NodeId* nodeId,
        void* nodeContext,
        UA_Boolean sourceTimestamp,
        const UA_NumericRange* range,
        UA_DataValue* dataValue
) {
    if (!nodeContext)
        return UA_STATUSCODE_BADINTERNALERROR;
    auto* self = static_cast<GripperOPCUA*>(nodeContext);

    std::lock_guard<std::mutex> lock(self->dataAccessMutex);
    UA_Variant_setScalarCopy(&dataValue->value, &self->inControlRange, &UA_TYPES[UA_TYPES_BOOLEAN]);
    dataValue->hasValue = true;
    if (sourceTimestamp)
    {
        dataValue->hasSourceTimestamp = true;
        dataValue->sourceTimestamp = self->sourceTimestamp;
    }
    return UA_STATUSCODE_GOOD;
};

UA_StatusCode GripperOPCUA::readVacuumValueLive(
        UA_Server* server,
        const UA_NodeId* sessionId,
        void* sessionContext,
        const UA_NodeId* nodeId,
        void* nodeContext,
        UA_Boolean sourceTimestamp,
        const UA_NumericRange* range,
        UA_DataValue* dataValue
) {
    if (!nodeContext)
        return UA_STATUSCODE_BADINTERNALERROR;
    auto* self = static_cast<GripperOPCUA*>(nodeContext);

    std::lock_guard<std::mutex> lock(self->dataAccessMutex);
    UA_Variant_setScalarCopy(&dataValue->value, &self->vacuumValueLive, &UA_TYPES[UA_TYPES_UINT16]);
    dataValue->hasValue = true;
    if (sourceTimestamp)
    {
        dataValue->hasSourceTimestamp = true;
        dataValue->sourceTimestamp = self->sourceTimestamp;
    }
    return UA_STATUSCODE_GOOD;
};


UA_StatusCode GripperOPCUA::readActualPower(
        UA_Server* server,
        const UA_NodeId* sessionId,
        void* sessionContext,
        const UA_NodeId* nodeId,
        void* nodeContext,
        UA_Boolean sourceTimestamp,
        const UA_NumericRange* range,
        UA_DataValue* dataValue
) {
    if (!nodeContext)
        return UA_STATUSCODE_BADINTERNALERROR;
    auto* self = static_cast<GripperOPCUA*>(nodeContext);

    std::lock_guard<std::mutex> lock(self->dataAccessMutex);
    UA_Variant_setScalarCopy(&dataValue->value, &self->actualPower, &UA_TYPES[UA_TYPES_BYTE]);
    dataValue->hasValue = true;
    if (sourceTimestamp)
    {
        dataValue->hasSourceTimestamp = true;
        dataValue->sourceTimestamp = self->sourceTimestamp;
    }
    return UA_STATUSCODE_GOOD;
};
