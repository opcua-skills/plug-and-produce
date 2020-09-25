/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef ROBOTICS_GRASPRELEASEGRIPPERSKILLIMPL_HPP
#define ROBOTICS_GRASPRELEASEGRIPPERSKILLIMPL_HPP


#include <GripperOPCUA.h>
#include "common/opcua/skill/gripper/GraspReleaseGripperSkill.hpp"

namespace fortiss {
    class GraspGripperSkillImpl
            : virtual public fortiss::opcua::skill::gripper::GraspReleaseGripperSkillImpl {

    private:

        bool isMoving = false;
        std::chrono::steady_clock::time_point skillStartTime;
        GRIPPER_CLASS *gripper;
        const std::shared_ptr<spdlog::logger> logger;

    public:
        explicit GraspGripperSkillImpl(const std::shared_ptr<spdlog::logger>& logger, GRIPPER_CLASS *gripperControl, bool simulation) :
                GraspReleaseGripperSkillImpl(),
                skillStartTime(), gripper(gripperControl),
                logger(logger) {

        }

        virtual ~GraspGripperSkillImpl() {
        }


        bool start() override {
            if (isMoving) {
                logger->error("Gripper is still moving");
                return false;
            }

            logger->info("Got grasp gripper");
            isMoving = true;

            if (!gripper->startVaccum())
                return false;


            skillStartTime = std::chrono::steady_clock::now();
            return true;
        };

        void step() {
            if (!isMoving)
                return;

            #ifndef LOCAL_SIMULATION
            const Schmalz::ECBPi::ProcessDataIn_t *processDataIn;
            if (!gripper->getProcessDataIn(&processDataIn)) {
                logger->error("Could not read process data of gripper");
                this->moveErrored();
                if (!gripper->stopVaccum())
                    return;
            } else if (processDataIn->partPresent) {
                isMoving = false;
                this->moveFinished();
                logger->info("Got part");
            }

            // Part not grasped after a few seconds
            if (std::chrono::duration_cast<std::chrono::seconds>(std::chrono::steady_clock::now() - skillStartTime).count() > 8) {
                isMoving = false;
                gripper->stopVaccum();
                this->moveErrored();
                logger->info("Part not present. Grasp error.");
            }
            #else
            // Simulate get part after 2 seconds
            if (std::chrono::duration_cast<std::chrono::seconds>(std::chrono::steady_clock::now() - skillStartTime).count() > 2) {
                isMoving = false;
                this->moveFinished();
                logger->info("Got part");
            }
            #endif

        }

        bool halt() override {
            if (isMoving) {
                gripper->stopVaccum();
                isMoving = false;
                logger->info("Got halt");
                return true;
            }
            return false;
        };

        bool haltFromRelease() {
            moveErrored();
            isMoving = false;
            logger->info("Got halt from release");
            return true;
        }

        bool resume() override {
            if (!isMoving) {
                isMoving = true;
                return gripper->startVaccum();
            }
            return false;

        };

        bool suspend() override {
            if (isMoving) {
                gripper->stopVaccum();
                isMoving = false;
                logger->info("Got suspend");
                return true;
            }
            return false;

        };

        bool reset() override {
            gripper->stopVaccum();
            isMoving = false;
            logger->info("Got reset");
            return true;
        };

    };
}

#endif //ROBOTICS_GRASPRELEASEGRIPPERSKILLIMPL_HPP
