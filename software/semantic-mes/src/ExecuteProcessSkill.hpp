/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef DATA_BACKBONE_EXECUTEPROCESSSKILL_HPP
#define DATA_BACKBONE_EXECUTEPROCESSSKILL_HPP


#include <common/opcua/skill/SkillBase.hpp>
#include <utility>
#include "common/opcua/skill/SkillParameter.hpp"

#define NAMESPACE_URI_SEMANTIC_MES "https://fortiss.org/UA/SemanticMES/"

namespace fortiss {
    namespace opcua {
        namespace skill {


            class ExecuteProcessSkill;

            class ExecuteProcessSkillImpl : virtual public SkillImpl {

            public:
                friend class ExecuteProcessSkill;

            protected:
                virtual bool start(
                        const std::string& abstractProcessIri,
                        const std::string& executionMode
                ) = 0;

                virtual bool halt() = 0;

                virtual bool resume() = 0;

                virtual bool suspend() = 0;

                virtual bool reset() = 0;

                std::function<void()> executionFinished;
                std::function<void()> executionErrored;
            };

            class ExecuteProcessSkill : virtual public SkillBase {


            protected:
                const size_t nsDiIdx;
                const size_t nsSemanticMesIdx;


                const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                SkillParameter<std::string> abstractProcessIriParameter;
                SkillParameter<std::string> executionModeParameter;

                UA_StatusCode readParameters() override {
                    UA_StatusCode retVal = readParameter<std::string, UA_String>(
                            abstractProcessIriParameter,
                            [this](const UA_String& x) {
                                if (x.length == 0)
                                    this->abstractProcessIriParameter.value = "";
                                else
                                    this->abstractProcessIriParameter.value = std::string((char*) x.data, x.length);
                            });
                    if (retVal != UA_STATUSCODE_GOOD)
                        return retVal;
                    retVal = readParameter<std::string, UA_String>(
                            executionModeParameter,
                            [this](const UA_String& x) {
                                if (x.length == 0)
                                    this->executionModeParameter.value = "";
                                else
                                    this->executionModeParameter.value = std::string((char*) x.data, x.length);
                            });
                    return retVal;
                }


            public:

                explicit ExecuteProcessSkill(
                        const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
                        std::shared_ptr<spdlog::logger>& logger,
                        const UA_NodeId& skillNodeId,
                        const std::string& eventSourceName
                ) :
                        SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsSemanticMesIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_SEMANTIC_MES)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, skillNodeId,
                                                                          UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                                                                           const_cast<char*>("ParameterSet")))),
                        abstractProcessIriParameter(&UA_TYPES[UA_TYPES_STRING], "AbstractProcessIri",
                                                    UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                                   UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsSemanticMesIdx),
                                                                                                    const_cast<char*>("AbstractProcessIri")))),
                        executionModeParameter(&UA_TYPES[UA_TYPES_STRING], "ExecutionMode",
                                               UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsSemanticMesIdx),
                                                                                               const_cast<char*>("ExecutionMode")))) {
                    // use dynamic cast to make sure polymorphic resolution is correct
                    auto selfProgram = dynamic_cast<Program*>(this);

                    LockedServer ls = server->getLocked();
                    if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                        throw std::runtime_error("Adding method context failed");
                    }
                }

                void executionFinished() {
                    if (!transition(ProgramStateNumber::READY)) {
                        logger->error("Failed to make transition after execution has finished to ready");
                    }
                }

                void executionErrored() {
                    if (!transition(ProgramStateNumber::HALTED)) {
                        logger->error("Failed to make transition after execution has failed to halted");
                    }
                }

                virtual void setImpl(
                        ExecuteProcessSkillImpl* impl,
                        std::function<void()> implDeleter
                ) {
                    SkillBase::setImpl(impl, std::move(implDeleter));

                    this->startCallback = [impl, this]() {
                        if (this->readParameters() != UA_STATUSCODE_GOOD)
                            return false;
                        return impl->start(this->abstractProcessIriParameter.value,
                                           this->executionModeParameter.value);
                    };
                    this->haltCallback = std::bind(
                            &ExecuteProcessSkillImpl::halt, impl);
                    this->resumeCallback = std::bind(
                            &ExecuteProcessSkillImpl::resume, impl);
                    this->suspendCallback = std::bind(
                            &ExecuteProcessSkillImpl::suspend, impl);
                    this->resetCallback = std::bind(
                            &ExecuteProcessSkillImpl::reset, impl);
                    impl->executionFinished = std::bind(
                            &ExecuteProcessSkill::executionFinished, this);
                    impl->executionErrored = std::bind(
                            &ExecuteProcessSkill::executionErrored, this);
                }

            };
        }
    }
}

#endif //DATA_BACKBONE_EXECUTEPROCESSSKILL_HPP
