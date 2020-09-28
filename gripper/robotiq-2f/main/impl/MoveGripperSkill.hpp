/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef ROBOTICS_MOVEGRIPPER_SKILL_GRIPPER_H
#define ROBOTICS_MOVEGRIPPER_SKILL_GRIPPER_H
#pragma once

#include <future>
#include <memory>
#include <functional>
#include <utility>
#include "common/opcua/skill/SkillBase.hpp"


namespace fortiss {
    namespace opcua {
        namespace skill {
            namespace gripper {

                class MoveGripperSkill;

                class MoveGripperSkillImpl : virtual public SkillImpl {

                public:
                    friend class MoveGripperSkill;

                protected:
                    virtual bool start(
                            double width,
                            double force
                    ) = 0;

                    virtual bool halt() = 0;

                    virtual bool resume() = 0;

                    virtual bool suspend() = 0;

                    virtual bool reset() = 0;

                    std::function<void()> moveFinished;
                    std::function<void()> moveErrored;
                };

                class MoveGripperSkill : virtual public SkillBase {

                protected:
                    const size_t nsDiIdx;
                    const size_t nsForDiIdx;

                    const std::shared_ptr<UA_NodeId> parameterSetNodeId;


                    SkillParameter<UA_Double> widthParameter;
                    SkillParameter<UA_Double> forceParameter;

                    UA_StatusCode readParameters() override {
                        UA_StatusCode ret = readParameter<UA_Double>(
                                widthParameter,
                                [this](const UA_Double& x) {
                                    widthParameter.value = x;
                                });
                        if (ret != UA_STATUSCODE_GOOD)
                            return ret;
                        return readParameter<UA_Double>(
                                forceParameter,
                                [this](const UA_Double& x) {
                                    forceParameter.value = x;
                                });
                    }


                public:
                    explicit MoveGripperSkill(
                            const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
                            std::shared_ptr<spdlog::logger>& logger,
                            const UA_NodeId& skillNodeId,
                            const std::string& eventSourceName
                    )
                            : SkillBase(server, logger, skillNodeId, eventSourceName),
                              nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                              nsForDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_FORTISS_DEVICE)),
                              parameterSetNodeId(UA_Server_getObjectComponentId(server, skillNodeId,
                                                                                UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                                                                                 const_cast<char*>("ParameterSet")))),
                              widthParameter(&UA_TYPES[UA_TYPES_DOUBLE], "Width",
                                             UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                            UA_QUALIFIEDNAME(
                                                                                    static_cast<UA_UInt16>(nsForDiIdx),
                                                                                    const_cast<char*>("Width")))),
                              forceParameter(&UA_TYPES[UA_TYPES_DOUBLE], "Force",
                                             UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                            UA_QUALIFIEDNAME(
                                                                                    static_cast<UA_UInt16>(nsForDiIdx),
                                                                                    const_cast<char*>("Force")))) {

                        // use dynamic cast to make sure polymorphic resolution is correct
                        auto selfProgram = dynamic_cast<Program*>(this);

                        LockedServer ls = server->getLocked();
                        if (UA_Server_setNodeContext(ls.get(), skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                            throw std::runtime_error("Adding method context failed");
                        }

                    }

                    virtual void setImpl(
                            MoveGripperSkillImpl* impl,
                            std::function<void()> implDeleter = nullptr
                    ) {
                        SkillBase::setImpl(impl, std::move(implDeleter));

                        this->startCallback = [impl, this]() {
                            if (this->readParameters() != UA_STATUSCODE_GOOD)
                                return false;
                            return impl->start(widthParameter.value, forceParameter.value);
                        };
                        this->haltCallback = std::bind(
                                &MoveGripperSkillImpl::halt, impl);
                        this->resumeCallback = std::bind(
                                &MoveGripperSkillImpl::resume, impl);
                        this->suspendCallback = std::bind(
                                &MoveGripperSkillImpl::suspend, impl);
                        this->resetCallback = std::bind(
                                &MoveGripperSkillImpl::reset, impl);
                        impl->moveErrored = std::bind(
                                &MoveGripperSkill::gripperErrored, this);
                        impl->moveFinished = std::bind(
                                &MoveGripperSkill::gripperFinished, this);
                    }

                    void gripperFinished() {
                        if (!transition(ProgramStateNumber::READY)) {
                            logger->error("Failed to make transition after gripper has finished to ready");
                        }
                    }

                    void gripperErrored() {
                        if (!transition(ProgramStateNumber::HALTED)) {
                            logger->error("Failed to make transition after gripper has finished to halted");
                        }
                    }


                };
            }
        }
    }
}


#endif //ROBOTICS_MOVEGRIPPER_SKILL_GRIPPER_H
