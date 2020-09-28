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
    explicit GripperOPCUA(
            std::shared_ptr<spdlog::logger> _logger,
            std::shared_ptr<fortiss::opcua::OpcUaServer> server,
            GRIPPER_CLASS* gripper
    );

    virtual ~GripperOPCUA();


    bool connect();

    void shutdown();

    bool step();

    #ifndef LOCAL_SIMULATION
    bool running;
    bool startStepperTask();
    bool stopStepperTask(bool join);
    #endif

    std::shared_ptr<spdlog::logger> logger;
private:
    const std::shared_ptr<fortiss::opcua::OpcUaServer> server;

    // disable copy constructor
    GripperOPCUA& operator=(const GripperOPCUA&) = delete;

    GripperOPCUA(const GripperOPCUA&) = delete;

    GRIPPER_CLASS* gripper;


    const UA_UInt16 nsIdSchmalz;
    const UA_NodeId skillsNodeId;

    fortiss::ReleaseGripperSkillImpl* releaseSkillImpl = nullptr;
    fortiss::GraspGripperSkillImpl* graspSkillImpl = nullptr;

    std::unique_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> releaseSkill;
    std::shared_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> graspSkill;

    bool addGripperGraspSkill();

    bool addGripperReleaseSkill();

    UA_StatusCode initDataSources();

    std::mutex dataAccessMutex;
    UA_Boolean partPresent = UA_FALSE;
    UA_Boolean inControlRange = UA_FALSE;
    UA_Boolean partDetached = UA_FALSE;
    UA_UInt16 vacuumValueLive = 0;
    UA_Byte actualPower = 0;
    UA_DateTime sourceTimestamp = 0;

    static UA_StatusCode readPartPresent(
            UA_Server* server,
            const UA_NodeId* sessionId,
            void* sessionContext,
            const UA_NodeId* nodeId,
            void* nodeContext,
            UA_Boolean sourceTimeStamp,
            const UA_NumericRange* range,
            UA_DataValue* dataValue
    );

    static UA_StatusCode readInControlRange(
            UA_Server* server,
            const UA_NodeId* sessionId,
            void* sessionContext,
            const UA_NodeId* nodeId,
            void* nodeContext,
            UA_Boolean sourceTimeStamp,
            const UA_NumericRange* range,
            UA_DataValue* dataValue
    );

    static UA_StatusCode readPartDetached(
            UA_Server* server,
            const UA_NodeId* sessionId,
            void* sessionContext,
            const UA_NodeId* nodeId,
            void* nodeContext,
            UA_Boolean sourceTimeStamp,
            const UA_NumericRange* range,
            UA_DataValue* dataValue
    );

    static UA_StatusCode readVacuumValueLive(
            UA_Server* server,
            const UA_NodeId* sessionId,
            void* sessionContext,
            const UA_NodeId* nodeId,
            void* nodeContext,
            UA_Boolean sourceTimeStamp,
            const UA_NumericRange* range,
            UA_DataValue* dataValue
    );

    static UA_StatusCode readActualPower(
            UA_Server* server,
            const UA_NodeId* sessionId,
            void* sessionContext,
            const UA_NodeId* nodeId,
            void* nodeContext,
            UA_Boolean sourceTimeStamp,
            const UA_NumericRange* range,
            UA_DataValue* dataValue
    );
};

#endif // GRIPPEROPCUA_H
