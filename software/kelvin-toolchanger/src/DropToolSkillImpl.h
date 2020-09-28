/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef KELVIN_TOOLDROPR_DROPTOOLSKILLIMPL_H
#define KELVIN_TOOLDROPR_DROPTOOLSKILLIMPL_H

#include "DropToolSkill.hpp"

class KelvinToolchanger;

namespace fortiss {
    namespace kelvin_toolchanger {

        class DropToolSkillImpl
                : virtual public fortiss::opcua::skill::DropToolSkillImpl {

        private:

            std::shared_ptr<spdlog::logger> logger;
            std::chrono::steady_clock::time_point skillStartTime;
            KelvinToolchanger *kelvinToolchanger;


        public:
            explicit DropToolSkillImpl(std::shared_ptr<spdlog::logger> logger, KelvinToolchanger *kelvinToolchanger);

            virtual ~DropToolSkillImpl();

        protected:
            bool start() override;

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


#endif //KELVIN_TOOLDROPR_DROPTOOLSKILLIMPL_H
