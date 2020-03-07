//
// Created by profanter on 07/08/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef DATA_BACKBONE_EXECUTEPROCESSSKILLIMPL_H
#define DATA_BACKBONE_EXECUTEPROCESSSKILLIMPL_H

#include "ExecuteProcessSkill.hpp"

class SemanticMes;

namespace fortiss {
    namespace semantic_mes {

        class ExecuteProcessSkillImpl
                : virtual public fortiss::opcua::skill::ExecuteProcessSkillImpl {

        private:

            std::shared_ptr<spdlog::logger> logger;
            std::chrono::steady_clock::time_point skillStartTime;
            SemanticMes *semanticMes;


        public:
            explicit ExecuteProcessSkillImpl(std::shared_ptr<spdlog::logger> logger, SemanticMes *semanticMes);

            virtual ~ExecuteProcessSkillImpl();

        protected:
            bool start(const std::string& abstractProcessIri,
                       const std::string& executionMode) override;

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

#endif //DATA_BACKBONE_EXECUTEPROCESSSKILLIMPL_H
