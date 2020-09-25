/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef ROBOTICS_RELEASERELEASEGRIPPERSKILLIMPL_HPP
#define ROBOTICS_RELEASERELEASEGRIPPERSKILLIMPL_HPP


#include <GripperOPCUA.h>

#include <utility>
#include "common/opcua/skill/gripper/GraspReleaseGripperSkill.hpp"

namespace fortiss {
    class ReleaseGripperSkillImpl
            : virtual public fortiss::opcua::skill::gripper::GraspReleaseGripperSkillImpl {

    private:

        bool isMoving = false;
        std::chrono::steady_clock::time_point skillStartTime;
        GRIPPER_CLASS* gripper;
        const std::shared_ptr<spdlog::logger> logger;
        std::shared_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill> graspSkill;
        fortiss::GraspGripperSkillImpl* graspSkillImpl;

    public:
        explicit ReleaseGripperSkillImpl(
                std::shared_ptr<spdlog::logger>  logger,
                GRIPPER_CLASS* gripperControl,
                bool simulation,
                std::shared_ptr<fortiss::opcua::skill::gripper::GraspReleaseGripperSkill>  _graspSkill,
                fortiss::GraspGripperSkillImpl*  _graspSkillImpl
        ) :
                GraspReleaseGripperSkillImpl(),
                skillStartTime(), gripper(gripperControl),
                logger(std::move(logger)), graspSkill(std::move(_graspSkill)), graspSkillImpl(_graspSkillImpl) {

        }

        virtual ~ReleaseGripperSkillImpl() {
        }


        bool start() override {
            if (isMoving) {
                logger->error("Gripper is still moving");
                return false;
            }

            logger->info("Got open gripper");
            if (graspSkill->getCurrentState()->getNumber() == fortiss::opcua::ProgramStateNumber::RUNNING) {
                // abort current grasping
                logger->info("Resetting Grasp Skill as it is still running");
                if (!graspSkillImpl->haltFromRelease()) {
                    return false;
                }
            }

            if (!gripper->dropOff())
                return false;
            isMoving = true;

            skillStartTime = std::chrono::steady_clock::now();
            return true;
        };

        void step() {
            if (!isMoving)
                return;

            // Part not grasped after 5 seconds
            if (std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::steady_clock::now() - skillStartTime).count() > 500) {
                isMoving = false;
                logger->info("Release finished");
                this->moveFinished();
            }

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
