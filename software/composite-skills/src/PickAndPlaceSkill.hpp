//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef COMPOSITE_SKILLS_PICKANDPLACESKILL_HPP
#define COMPOSITE_SKILLS_PICKANDPLACESKILL_HPP


#include <common/opcua/skill/SkillBase.hpp>
#include <utility>
#include "common/opcua/skill/SkillParameter.hpp"

#define NAMESPACE_URI_COMPOSITE_SKILLS "https://fortiss.org/UA/CompositeSkills/"


namespace fortiss {
    namespace opcua {
        namespace skill {


            class PickAndPlaceSkill;

            class PickAndPlaceSkillImpl : virtual public SkillImpl {

            public:
                friend class PickAndPlaceSkill;

            protected:
                virtual bool start(
                        const std::string& objectId,
                        const std::string& toolControllerEndpoint,
                        const std::string& moveControllerEndpoint,
                        const UA_ThreeDFrame& placePosition
                ) = 0;

                virtual bool halt() = 0;

                virtual bool resume() = 0;

                virtual bool suspend() = 0;

                virtual bool reset() = 0;

                std::function<void()> finished;
                std::function<void()> errored;
            };

            class PickAndPlaceSkill : virtual public SkillBase {


            protected:
                const size_t nsDiIdx;
                const size_t nsCompositeSkillsId;

                const std::shared_ptr<UA_NodeId> parameterSetNodeId;

                SkillParameter<std::string> objectId;
                SkillParameter<std::string> toolControllerEndpoint;
                SkillParameter<std::string> moveControllerEndpoint;
                SkillParameter<UA_ThreeDFrame> objectPlacePosition;

                UA_StatusCode readParameters() override {
                    UA_StatusCode retVal = readParameter<std::string, UA_String>(
                            objectId,
                            [this](const UA_String& x) {
                                if (x.length == 0)
                                    this->objectId.value = "";
                                else
                                    this->objectId.value = std::string((char*) x.data, x.length);
                            });
                    if (retVal != UA_STATUSCODE_GOOD)
                        return retVal;
                    retVal = readParameter<std::string, UA_String>(
                            toolControllerEndpoint,
                            [this](const UA_String& x) {
                                if (x.length == 0)
                                    this->toolControllerEndpoint.value = "";
                                else
                                    this->toolControllerEndpoint.value = std::string((char*) x.data, x.length);
                            });
                    if (retVal != UA_STATUSCODE_GOOD)
                        return retVal;
                    retVal = readParameter<std::string, UA_String>(
                            moveControllerEndpoint,
                            [this](const UA_String& x) {
                                if (x.length == 0)
                                    this->moveControllerEndpoint.value = "";
                                else
                                    this->moveControllerEndpoint.value = std::string((char*) x.data, x.length);
                            });
                    if (retVal != UA_STATUSCODE_GOOD)
                        return retVal;

                    return readParameter<UA_ThreeDFrame>(
                            objectPlacePosition,
                            [this](const UA_ThreeDFrame& x) {
                                UA_ThreeDFrame_copy(&x, &objectPlacePosition.value);
                            });
                }


            public:

                explicit PickAndPlaceSkill(
                        UA_Server* server,
                        std::shared_ptr<spdlog::logger>& logger,
                        const UA_NodeId& skillNodeId,
                        const std::string& eventSourceName
                ) :
                        SkillBase(server, logger, skillNodeId, eventSourceName),
                        nsDiIdx(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_DI)),
                        nsCompositeSkillsId(UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_COMPOSITE_SKILLS)),
                        parameterSetNodeId(UA_Server_getObjectComponentId(server, skillNodeId,
                                                                          UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsDiIdx),
                                                                                           const_cast<char*>("ParameterSet")))),
                        objectId(&UA_TYPES[UA_TYPES_STRING], "ObjectId",
                                 UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCompositeSkillsId),
                                                                                 const_cast<char*>("ObjectId")))),
                        toolControllerEndpoint(&UA_TYPES[UA_TYPES_STRING], "ToolSkillControllerEndpoint",
                                               UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCompositeSkillsId),
                                                                                               const_cast<char*>("ToolSkillControllerEndpoint")))),
                        moveControllerEndpoint(&UA_TYPES[UA_TYPES_STRING], "MoveSkillControllerEndpoint",
                                               UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                              UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCompositeSkillsId),
                                                                                               const_cast<char*>("MoveSkillControllerEndpoint")))),
                        objectPlacePosition(&UA_TYPES[UA_TYPES_THREEDFRAME], "PlacePosition",
                                            UA_Server_getObjectComponentId(server, *parameterSetNodeId,
                                                                           UA_QUALIFIEDNAME(static_cast<UA_UInt16>(nsCompositeSkillsId),
                                                                                            const_cast<char*>("PlacePosition")))) {
                    // use dynamic cast to make sure polymorphic resolution is correct
                    auto selfProgram = dynamic_cast<Program*>(this);

                    if (UA_Server_setNodeContext(server, skillNodeId, selfProgram) != UA_STATUSCODE_GOOD) {
                        throw std::runtime_error("Adding method context failed");
                    }
                }

                void finished() {
                    if (!transition(ProgramStateNumber::READY)) {
                        logger->error("Failed to make transition after tool change has finished to ready");
                    }
                }

                void errored() {
                    if (!transition(ProgramStateNumber::HALTED)) {
                        logger->error("Failed to make transition after tool change has failed to halted");
                    }
                }

                virtual void setImpl(
                        PickAndPlaceSkillImpl* impl,
                        std::function<void()> implDeleter
                ) {
                    SkillBase::setImpl(impl, std::move(implDeleter));

                    this->startCallback = [impl, this]() {
                        if (this->readParameters() != UA_STATUSCODE_GOOD)
                            return false;
                        return impl->start(
                                this->objectId.value,
                                this->toolControllerEndpoint.value,
                                this->moveControllerEndpoint.value,
                                this->objectPlacePosition.value);
                    };
                    this->haltCallback = std::bind(
                            &PickAndPlaceSkillImpl::halt, impl);
                    this->resumeCallback = std::bind(
                            &PickAndPlaceSkillImpl::resume, impl);
                    this->suspendCallback = std::bind(
                            &PickAndPlaceSkillImpl::suspend, impl);
                    this->resetCallback = std::bind(
                            &PickAndPlaceSkillImpl::reset, impl);
                    impl->finished = std::bind(
                            &PickAndPlaceSkill::finished, this);
                    impl->errored = std::bind(
                            &PickAndPlaceSkill::errored, this);
                }

            };
        }
    }
}


#endif //COMPOSITE_SKILLS_PICKANDPLACESKILL_HPP
