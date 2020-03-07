//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef COMPOSITE_SKILLS_PICKANDPLACESKILLIMPL_H
#define COMPOSITE_SKILLS_PICKANDPLACESKILLIMPL_H

#include <rl/math/Transform.h>
#include <types_fortiss_device_generated.h>
#include "PickAndPlaceSkill.hpp"

class CompositeSkills;

namespace fortiss {
    namespace composite_skills {

        class PickAndPlaceSkillImpl
                : virtual public fortiss::opcua::skill::PickAndPlaceSkillImpl {

        private:

            std::shared_ptr<spdlog::logger> logger;
            std::chrono::steady_clock::time_point skillStartTime;

            CompositeSkills* compositeSkills;

        public:
            explicit PickAndPlaceSkillImpl(
                    std::shared_ptr<spdlog::logger> logger,
                    CompositeSkills* compositeSkills
            );

            virtual ~PickAndPlaceSkillImpl();

        protected:
            bool start(
                    const std::string& objectId,
                    const std::string& toolControllerEndpoint,
                    const std::string& moveControllerEndpoint,
                    const UA_ThreeDFrame& placePosition
            ) override;

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

            UA_StatusCode getToolPickOffset(
                    const std::string& toolControllerEndpoint,
                    rl::math::Transform* toolOffset,
                    UA_GripTypeEnumeration* gripType
            );

            UA_StatusCode pickAndPlaceObject(
                    const std::string& objectId,
                    const std::string& toolControllerEndpoint,
                    const std::string& moveControllerEndpoint,
                    const UA_ThreeDFrame* placePosition
            );


            UA_StatusCode moveRobotTo(
                    const UA_ThreeDFrame& position,
                    bool linear,
                    const std::string& toolFrame = "",
                    const double maxVelocity[6] = nullptr,
                    const double maxAcceleration[6] = nullptr
            );

            UA_StatusCode moveRobotTo(
                    const rl::math::Transform& position,
                    bool linear,
                    const std::string& toolFrame = "",
                    const double maxVelocity[6] = nullptr,
                    const double maxAcceleration[6] = nullptr
            );

        };
    }
}


#endif //COMPOSITE_SKILLS_PICKANDPLACESKILLIMPL_H
