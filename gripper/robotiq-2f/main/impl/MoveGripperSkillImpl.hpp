/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef ROBOTICS_MOVERELEASEGRIPPERSKILLIMPL_HPP
#define ROBOTICS_MOVERELEASEGRIPPERSKILLIMPL_HPP


#include <GripperOPCUA.h>
#include <rl/math/Real.h>
#ifndef LOCAL_SIMULATION
#include <rl/hal/RobotiqModelC.h>
#endif
#include "MoveGripperSkill.hpp"

namespace fortiss {
    class MoveGripperSkillImpl
            : virtual public fortiss::opcua::skill::gripper::MoveGripperSkillImpl {

    private:

        bool isMoving = false;
        std::chrono::steady_clock::time_point skillStartTime;
        GRIPPER_CLASS *gripper;
        const std::shared_ptr<spdlog::logger> logger;

    public:
        explicit MoveGripperSkillImpl(const std::shared_ptr<spdlog::logger>& logger, GRIPPER_CLASS *gripperControl, bool simulation) :
                fortiss::opcua::skill::gripper::MoveGripperSkillImpl(),
                skillStartTime(), gripper(gripperControl),
                logger(logger) {

        }

        virtual ~MoveGripperSkillImpl() {
        }


        bool start(double width, double force) override {
            if (isMoving) {
                logger->error("Gripper is still moving");
                return false;
            }

            isMoving = true;

            // width is in meters.
            double percentagePosition = std::min(std::max(width, 0.0) / 0.085, 1.0);

            // The gripper percentage position depends on the mounted gripper fingers.
            // For the default fingers, the following values apply: closed = 0.115 % opened (85mm) = 0.965%
            percentagePosition = (0.965-0.115)*percentagePosition+0.115;

            // force is in newton. Max is 235 N. Get percentage value
            double percentageForce = std::min(std::max(force, 0.0) / 235, 1.0);

            if (percentageForce == 0)
                percentageForce = 0.1;


            logger->info("Got move gripper: width: {} ({}%), force: {} ({}%)", width, percentagePosition*100.0, force, percentageForce*100.0);

            gripper->setForcePercentage(static_cast<rl::math::Real>(percentageForce));
            gripper->setPositionPercentage(1-percentagePosition);
            gripper->setSpeedPercentage(static_cast<rl::math::Real>(0.25));

            skillStartTime = std::chrono::steady_clock::now();
            return true;
        };

        void step() {
            if (!isMoving)
                return;

            #ifndef LOCAL_SIMULATION
            if (gripper->getObjectStatus() != rl::hal::RobotiqModelC::OBJECT_STATUS_MOTION) {
                isMoving = false;
                this->moveFinished();
                logger->info("Move finished");
            }
            #else
            // Simulate get part after 1 seconds
            if (std::chrono::duration_cast<std::chrono::seconds>(std::chrono::steady_clock::now() - skillStartTime).count() > 1) {
                isMoving = false;
                this->moveFinished();
                logger->info("Got part");
            }
            #endif
        }

        bool halt() override {
            return false;
        };

        bool resume() override {
            return false;

        };

        bool suspend() override {
            return false;

        };

        bool reset() override {
            return false;

        };

    };
}

#endif //ROBOTICS_MOVERELEASEGRIPPERSKILLIMPL_HPP
