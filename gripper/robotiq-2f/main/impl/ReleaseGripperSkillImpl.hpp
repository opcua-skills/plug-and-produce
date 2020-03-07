//
// Created by profanter on 23/07/19.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef ROBOTICS_RELEASERELEASEGRIPPERSKILLIMPL_HPP
#define ROBOTICS_RELEASERELEASEGRIPPERSKILLIMPL_HPP


#include <GripperOPCUA.h>
#include "common/opcua/skill/gripper/GraspReleaseGripperSkill.hpp"

namespace fortiss {
    class ReleaseGripperSkillImpl
            : virtual public fortiss::opcua::skill::gripper::GraspReleaseGripperSkillImpl {

    private:

        bool isMoving = false;
        std::chrono::steady_clock::time_point skillStartTime;
        GRIPPER_CLASS *gripper;
        const std::shared_ptr<spdlog::logger> logger;

    public:
        explicit ReleaseGripperSkillImpl(const std::shared_ptr<spdlog::logger>& logger, GRIPPER_CLASS *gripperControl, bool simulation) :
                GraspReleaseGripperSkillImpl(),
                skillStartTime(), gripper(gripperControl),
                logger(logger) {

        }

        virtual ~ReleaseGripperSkillImpl() {
        }


        bool start() override {
            if (isMoving) {
                logger->error("Gripper is still moving");
                return false;
            }

            logger->info("Got open gripper");
            isMoving = true;

            gripper->setForcePercentage(static_cast<rl::math::Real>(0.1));
            gripper->setPositionPercentage(0);
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
            // Simulate get part after 2 seconds
            if (std::chrono::duration_cast<std::chrono::seconds>(std::chrono::steady_clock::now() - skillStartTime).count() > 2) {
                isMoving = false;
                this->moveFinished();
                logger->info("Released part");
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

#endif //ROBOTICS_RELEASERELEASEGRIPPERSKILLIMPL_HPP
