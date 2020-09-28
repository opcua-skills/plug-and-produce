/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef ROBOTICS_UNIVERSALROBOTCONTROL_H
#define ROBOTICS_UNIVERSALROBOTCONTROL_H

#include "common/logging.h"

#include "libconfig.h++"

#include <rl/hal/Exception.h>
#include <rl/math/Vector.h>
#include <rl/hal/UniversalRobotsRtde.h>
#include <rl/hal/UniversalRobotsDashboard.h>

#include "common/opcua/robot/RLRobotControl.hpp"

static constexpr unsigned int AXIS_COUNT = 6;

namespace fortiss {
    namespace robot {
        class UniversalRobotControl : public fortiss::opcua::robot::RlRobotControl<AXIS_COUNT> {

        private:
            const UA_UInt16 nsIdRobUr;
            bool isSimulation;
            bool connected;
            std::shared_ptr<rl::hal::UniversalRobotsDashboard> dashboard;


//            bool lastSafetyStatusProtective = false;
//            bool unlockProtectiveStop = false;

            //void recoverFromSafetyStop();

            rl::hal::UniversalRobotsRtde::RobotMode currentRobotMode = rl::hal::UniversalRobotsRtde::RobotMode::booting;
            rl::hal::UniversalRobotsRtde::SafetyMode currentSafetyMode = rl::hal::UniversalRobotsRtde::SafetyMode::fault;
            rl::hal::UniversalRobotsRtde::RuntimeState currentRuntimeState = rl::hal::UniversalRobotsRtde::RuntimeState::stopped;


//            void updateControlLoop();

            bool setVariableDouble(
                    const UA_NodeId& id,
                    const std::string& name,
                    const UA_Double& val
            );

            bool setVariableInt32(
                    const UA_NodeId& id,
                    const std::string& name,
                    const UA_Int32& val
            );

            bool setVariable3DFrame(
                    const UA_NodeId& id,
                    const std::string& name,
                    const rl::math::Transform& val
            );

            bool setVariable3DVector(
                    const UA_NodeId& id,
                    const std::string& name,
                    const rl::math::MotionVector& val
            );

            bool setVariable3DVector(
                    const UA_NodeId& id,
                    const std::string& name,
                    const rl::math::ForceVector& val
            );

        public:

            explicit UniversalRobotControl(
                    const libconfig::Setting& robotSettings,
                    const std::shared_ptr<fortiss::opcua::OpcUaServer>& server
            );

            bool step() override;

            virtual ~UniversalRobotControl();

//            virtual bool step() override;

            bool connect() override;

            void shutdown() override;


        };

    }
}


#endif //ROBOTICS_UNIVERSALROBOTCONTROL_H
