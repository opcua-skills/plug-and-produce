//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef KELVIN_TOOLCHANGER_DROPTOOLSKILL_HPP
#define KELVIN_TOOLCHANGER_DROPTOOLSKILL_HPP


#include <common/opcua/skill/SkillBase.hpp>
#include <utility>
#include "common/opcua/skill/SkillParameter.hpp"

#define NAMESPACE_URI_KELVIN_TOOLCHANGER "https://fortiss.org/UA/KelvinToolchanger/"


namespace fortiss {
    namespace opcua {
        namespace skill {


            class DropToolSkill;

            class DropToolSkillImpl : virtual public SkillImpl {

            public:
                friend class DropToolSkill;

            protected:
                virtual bool start() = 0;

                virtual bool halt() = 0;

                virtual bool resume() = 0;

                virtual bool suspend() = 0;

                virtual bool reset() = 0;

                std::function<void()> dropFinished;
                std::function<void()> dropErrored;
            };

            class DropToolSkill : virtual public SkillBase {


            protected:
                const size_t nsDiIdx;
                const size_t nsKelvinToolchangerId;


                const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                UA_StatusCode readParameters() override {
                    return UA_STATUSCODE_GOOD;
                }


            public:

                explicit DropToolSkill(
                        UA_Server* server,
                        std::shared_ptr<spdlog::logger>& logger,
                        const UA_NodeId& skillNodeId,
                        const std::string& eventSourceName
                ) :
                        SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsKelvinToolchangerId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_KELVIN_TOOLCHANGER)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, skillNodeId,
                                                                          UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                                                                           const_cast<char*>("ParameterSet")))) {
                    // use dynamic cast to make sure polymorphic resolution is correct
                    auto selfProgram = dynamic_cast<Program*>(this);

                    if (UA_Server_setNodeContext(server, skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                        throw std::runtime_error("Adding method context failed");
                    }
                }

                void dropFinished() {
                    if (!transition(ProgramStateNumber::READY)) {
                        logger->error("Failed to make transition after tool drop has finished to ready");
                    }
                }

                void dropErrored() {
                    if (!transition(ProgramStateNumber::HALTED)) {
                        logger->error("Failed to make transition after tool drop has failed to halted");
                    }
                }

                virtual void setImpl(
                        DropToolSkillImpl* impl,
                        std::function<void()> implDeleter
                ) {
                    SkillBase::setImpl(impl, std::move(implDeleter));

                    this->startCallback = [impl, this]() {
                        if (this->readParameters() != UA_STATUSCODE_GOOD)
                            return false;
                        return impl->start();
                    };
                    this->haltCallback = std::bind(
                            &DropToolSkillImpl::halt, impl);
                    this->resumeCallback = std::bind(
                            &DropToolSkillImpl::resume, impl);
                    this->suspendCallback = std::bind(
                            &DropToolSkillImpl::suspend, impl);
                    this->resetCallback = std::bind(
                            &DropToolSkillImpl::reset, impl);
                    impl->dropFinished = std::bind(
                            &DropToolSkill::dropFinished, this);
                    impl->dropErrored = std::bind(
                            &DropToolSkill::dropErrored, this);
                }

            };
        }
    }
}


#endif //KELVIN_TOOLCHANGER_DROPTOOLSKILL_HPP
