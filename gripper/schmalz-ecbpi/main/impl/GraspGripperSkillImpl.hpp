//
// Created by profanter on 23/07/19.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

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

            gripper->startVaccum();


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
            } else if (processDataIn->partPresent) {
                isMoving = false;
                this->moveFinished();
                logger->info("Got part");
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
                this->moveFinished();
                logger->info("Got reset");
                return true;
            }
            return false;
        };

        bool resume() override {
            if (!isMoving) {
                isMoving = true;
                gripper->startVaccum();
                return true;
            }
            return false;

        };

        bool suspend() override {
            if (isMoving) {
                gripper->stopVaccum();
                isMoving = false;
                this->moveFinished();
                logger->info("Got reset");
                return true;
            }
            return false;

        };

        bool reset() override {
            if (isMoving) {
                gripper->stopVaccum();
                isMoving = false;
                this->moveFinished();
                logger->info("Got reset");
                return true;
            }
            return false;

        };

    };
}

#endif //ROBOTICS_GRASPRELEASEGRIPPERSKILLIMPL_HPP
