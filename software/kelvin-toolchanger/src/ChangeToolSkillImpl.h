//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef KELVIN_TOOLCHANGER_CHANGETOOLSKILLIMPL_H
#define KELVIN_TOOLCHANGER_CHANGETOOLSKILLIMPL_H

#include "ChangeToolSkill.hpp"

class KelvinToolchanger;

namespace fortiss {
    namespace kelvin_toolchanger {

        class ChangeToolSkillImpl
                : virtual public fortiss::opcua::skill::ChangeToolSkillImpl {

        private:

            std::shared_ptr<spdlog::logger> logger;
            std::chrono::steady_clock::time_point skillStartTime;
            KelvinToolchanger *kelvinToolchanger;


        public:
            explicit ChangeToolSkillImpl(std::shared_ptr<spdlog::logger> logger, KelvinToolchanger *kelvinToolchanger);

            virtual ~ChangeToolSkillImpl();

        protected:
            bool start(const UA_ThreeDFrame& toolPosition, const std::string& expectedToolAppUri) override;

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
}


#endif //KELVIN_TOOLCHANGER_CHANGETOOLSKILLIMPL_H
