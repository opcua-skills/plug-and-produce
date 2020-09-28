/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef KELVIN_TOOLCHANGER_CHANGETOOLSKILL_HPP
#define KELVIN_TOOLCHANGER_CHANGETOOLSKILL_HPP


#include <common/opcua/skill/SkillBase.hpp>
#include <utility>
#include "common/opcua/skill/SkillParameter.hpp"

#define NAMESPACE_URI_KELVIN_TOOLCHANGER "https://fortiss.org/UA/KelvinToolchanger/"


namespace fortiss {
    namespace opcua {
        namespace skill {


            class ChangeToolSkill;

            class ChangeToolSkillImpl : virtual public SkillImpl {

            public:
                friend class ChangeToolSkill;

            protected:
                virtual bool start(
                        const UA_ThreeDFrame& toolPosition,
                        const std::string& expectedToolAppUri
                ) = 0;

                virtual bool halt() = 0;

                virtual bool resume() = 0;

                virtual bool suspend() = 0;

                virtual bool reset() = 0;

                std::function<void()> changeFinished;
                std::function<void()> changeErrored;
            };

            class ChangeToolSkill : virtual public SkillBase {


            protected:
                const size_t nsDiIdx;
                const size_t nsKelvinToolchangerId;


                const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                SkillParameter<UA_ThreeDFrame> toolPositionParameter;
                SkillParameter<std::string> toolAppUriParameter;

                UA_StatusCode readParameters() override {
                    UA_StatusCode retVal = readParameter<std::string, UA_String>(
                            toolAppUriParameter,
                            [this](const UA_String& x) {
                                if (x.length == 0)
                                    this->toolAppUriParameter.value = "";
                                else
                                    this->toolAppUriParameter.value = std::string((char*) x.data, x.length);
                            });
                    if (retVal != UA_STATUSCODE_GOOD)
                        return retVal;

                    return readParameter<UA_ThreeDFrame>(
                            toolPositionParameter,
                            [this](const UA_ThreeDFrame& x) {
                                UA_ThreeDFrame_copy(&x, &toolPositionParameter.value);
                            });
                }


            public:

                explicit ChangeToolSkill(
                        const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
                        std::shared_ptr<spdlog::logger>& logger,
                        const UA_NodeId& skillNodeId,
                        const std::string& eventSourceName
                ) :
                        SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server->getLocked().get(), NAMESPACE_URI_DI)),
                        nsKelvinToolchangerId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_KELVIN_TOOLCHANGER)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, skillNodeId,
                                                                          UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                                                                           const_cast<char*>("ParameterSet")))),
                        toolPositionParameter(&UA_TYPES[UA_TYPES_THREEDFRAME], "ToolPosition",
                                              UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                             UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsKelvinToolchangerId),
                                                                                              const_cast<char*>("ToolPosition")))),
                        toolAppUriParameter(&UA_TYPES[UA_TYPES_STRING], "ToolAppUri",
                                            UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                           UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsKelvinToolchangerId),
                                                                                            const_cast<char*>("ToolAppUri")))) {
                    // use dynamic cast to make sure polymorphic resolution is correct
                    auto selfProgram = dynamic_cast<Program*>(this);

                    LockedServer ls = server->getLocked();
                    if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                        throw std::runtime_error("Adding method context failed");
                    }
                }

                void changeFinished() {
                    if (!transition(ProgramStateNumber::READY)) {
                        logger->error("Failed to make transition after tool change has finished to ready");
                    }
                }

                void changeErrored() {
                    if (!transition(ProgramStateNumber::HALTED)) {
                        logger->error("Failed to make transition after tool change has failed to halted");
                    }
                }

                virtual void setImpl(
                        ChangeToolSkillImpl* impl,
                        std::function<void()> implDeleter
                ) {
                    SkillBase::setImpl(impl, std::move(implDeleter));

                    this->startCallback = [impl, this]() {
                        if (this->readParameters() != UA_STATUSCODE_GOOD)
                            return false;
                        return impl->start(this->toolPositionParameter.value, this->toolAppUriParameter.value);
                    };
                    this->haltCallback = std::bind(
                            &ChangeToolSkillImpl::halt, impl);
                    this->resumeCallback = std::bind(
                            &ChangeToolSkillImpl::resume, impl);
                    this->suspendCallback = std::bind(
                            &ChangeToolSkillImpl::suspend, impl);
                    this->resetCallback = std::bind(
                            &ChangeToolSkillImpl::reset, impl);
                    impl->changeFinished = std::bind(
                            &ChangeToolSkill::changeFinished, this);
                    impl->changeErrored = std::bind(
                            &ChangeToolSkill::changeErrored, this);
                }

            };
        }
    }
}


#endif //KELVIN_TOOLCHANGER_CHANGETOOLSKILL_HPP
