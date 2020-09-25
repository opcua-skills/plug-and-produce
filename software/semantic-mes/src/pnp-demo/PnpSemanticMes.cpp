/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include "PnpSemanticMes.h"

#include <utility>
#include <types_fortiss_device_generated.h>
#include <di_nodeids.h>
#include <open62541/client_highlevel.h>
#include <common/skill_detector/SkillHelper.hpp>
#include <rl/math/Constants.h>

// For Empress Video speed factor was 25.0
#define SPEED_FACTOR 25

PnpSemanticMes::PnpSemanticMes(
        std::shared_ptr<spdlog::logger> _logger,
        std::shared_ptr<spdlog::logger> _loggerOpcua,
        const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
        const std::string& clientCertPath,
        const std::string& clientKeyPath,
        const libconfig::Setting& pnpSetting,
        bool _isSimulation
) :
        SemanticMes(std::move(_logger), std::move(_loggerOpcua), server, clientCertPath, clientKeyPath),
        pnpSetting(pnpSetting),
        isSimulation(_isSimulation) {
    if (isSimulation) {
        logger->info("Starting sMES in Simulation");
    }
}

PnpSemanticMes::~PnpSemanticMes() = default;

UA_StatusCode PnpSemanticMes::startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
) {
    return startDemoExecution();
}

UA_StatusCode PnpSemanticMes::startDemoExecution() {

    UA_ThreeDFrame tool1 = {
            .cartesianCoordinates = {
                    .x = pnpSetting["tools"]["world_to_dock1"]["x"],
                    .y = pnpSetting["tools"]["world_to_dock1"]["y"],
                    .z = pnpSetting["tools"]["world_to_dock1"]["z"]
            },
            .orientation = {
                    .a = pnpSetting["tools"]["world_to_dock1"]["a"],
                    .b = pnpSetting["tools"]["world_to_dock1"]["b"],
                    .c = pnpSetting["tools"]["world_to_dock1"]["c"],
            }
    };

    UA_ThreeDFrame tool2 = {
            .cartesianCoordinates = {
                    .x = pnpSetting["tools"]["world_to_dock2"]["x"],
                    .y = pnpSetting["tools"]["world_to_dock2"]["y"],
                    .z = pnpSetting["tools"]["world_to_dock2"]["z"]
            },
            .orientation = {
                    .a = pnpSetting["tools"]["world_to_dock2"]["a"],
                    .b = pnpSetting["tools"]["world_to_dock2"]["b"],
                    .c = pnpSetting["tools"]["world_to_dock2"]["c"],
            }
    };


    for (size_t i = 0; i < 2; i++) {
        std::string tool1AppIri = "fortiss.component.gripper.schmalz.ecbpi";
        UA_StatusCode retval = takeToolAtPosition(&tool1, tool1AppIri);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed taking tool at dock 1: {}", UA_StatusCode_name(retval));
            return retval;
        }

        retval = demoPickPart(false, "fortiss - Robot - UR5 - Alpha", tool1AppIri);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed picking part with tool 1: {}", UA_StatusCode_name(retval));
            return retval;
        }


        std::string tool2AppIri = "fortiss.component.gripper.robotiq";

        retval = takeToolAtPosition(&tool2, tool2AppIri);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed taking tool at dock 2: {}", UA_StatusCode_name(retval));
            return retval;
        }
        retval = demoPickPart(true, "fortiss - Robot - UR5 - Alpha", tool2AppIri);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed picking part with tool 2: {}", UA_StatusCode_name(retval));
            return retval;
        }

    }

    dropCurrentTool();

    return 0;
}

UA_StatusCode PnpSemanticMes::takeToolAtPosition(
        const UA_ThreeDFrame* toolPosition,
        const std::string& expectedToolAppUri
) {

    std::shared_ptr<RegisteredSkill> toolchangerSkill;

    {
        if (this->skillDetector->registeredSkills.count("ChangeToolSkill") == 0) {
            logger->error("No skill registered for Type ChangeToolSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (this->skillDetector->registeredSkills.count("ChangeToolSkill") > 1) {
            logger->error("More than one skill registered for Type ChangeToolSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        std::pair<std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator, std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator> skillIterator;
        skillIterator = this->skillDetector->registeredSkills.equal_range("ChangeToolSkill");
        toolchangerSkill = skillIterator.first->second;
    }

    // TODO handle the case where we may have multiple robots with a toolchanger. We need an intelligent way here to choose the correct robot and toolchanger combi

    logger->info("Executing skill {} on {}", toolchangerSkill->getSkillNameStr(),
                 toolchangerSkill->getParentComponent()->endpointUrl);

    std::vector<std::shared_ptr<SkillParameter>> skillParameters = std::vector<std::shared_ptr<SkillParameter>>();
    skillParameters.reserve(2);

    {
        UA_Variant val;
        UA_Variant_init(&val);
        UA_StatusCode retval = UA_Variant_setScalarCopy(&val, toolPosition,
                                                        &UA_TYPES[UA_TYPES_THREEDFRAME]);

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed to copy targetCartesianPosition. {}", UA_StatusCode_name(retval));
            return retval;
        }

        std::shared_ptr<SkillParameter> param = std::make_shared<SkillParameter>(
                "ToolPosition",
                "",
                "");
        param->setValue(val);
        UA_Variant_clear(&val);
        skillParameters.emplace_back(param);
    }

    {
        UA_Variant val;
        UA_Variant_init(&val);

        const UA_String str = {
                expectedToolAppUri.length(),
                (UA_Byte*) const_cast<char*>(expectedToolAppUri.c_str())
        };

        UA_StatusCode retval = UA_Variant_setScalarCopy(&val, &str,
                                                        &UA_TYPES[UA_TYPES_STRING]);

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed to copy expectedToolAppUri. {}", UA_StatusCode_name(retval));
            return retval;
        }

        std::shared_ptr<SkillParameter> param = std::make_shared<SkillParameter>(
                "ToolAppUri",
                "",
                "");
        param->setValue(val);
        UA_Variant_clear(&val);
        skillParameters.emplace_back(param);
    }

    UA_StatusCode result = UA_STATUSCODE_GOOD;
    std::chrono::steady_clock::time_point begin = std::chrono::steady_clock::now();
    bool success = false;
    try {
        success = toolchangerSkill->execute(logger, loggerOpcua, skillParameters).get();
        if (!success) {
            logger->warn("Skill execution returned false. Probably there was an issue while running.");
        }
    } catch (fortiss::opcua::StatusCodeException& ex) {
        logger->error("Skill execution failed with error {}", UA_StatusCode_name(ex.get_code()));
        result = ex.get_code();
    }
    std::chrono::steady_clock::time_point end = std::chrono::steady_clock::now();

    logger->info("Finished skill execution {} on {}.\n\tDuration: {} [ms]\n\tResult: {}\n\tSuccess: {}",
                 toolchangerSkill->getSkillNameStr(),
                 toolchangerSkill->getParentComponent()->endpointUrl,
                 std::chrono::duration_cast<std::chrono::milliseconds>(end - begin).count(),
                 UA_StatusCode_name(result), success);

    if (!success)
        return UA_STATUSCODE_BADINTERNALERROR;

    return result;
}

UA_StatusCode PnpSemanticMes::dropCurrentTool() {

    std::shared_ptr<RegisteredSkill> dropSkill;

    {
        if (this->skillDetector->registeredSkills.count("DropToolSkill") == 0) {
            logger->error("No skill registered for Type DropToolSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (this->skillDetector->registeredSkills.count("DropToolSkill") > 1) {
            logger->error("More than one skill registered for Type DropToolSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        std::pair<std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator, std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator> skillIterator;
        skillIterator = this->skillDetector->registeredSkills.equal_range("DropToolSkill");
        dropSkill = skillIterator.first->second;
    }

    // TODO handle the case where we may have multiple robots with a toolchanger. We need an intelligent way here to choose the correct robot and toolchanger combi

    logger->info("Executing skill {} on {}", dropSkill->getSkillNameStr(),
                 dropSkill->getParentComponent()->endpointUrl);

    std::vector<std::shared_ptr<SkillParameter>> skillParameters = std::vector<std::shared_ptr<SkillParameter>>();

    UA_StatusCode result = UA_STATUSCODE_GOOD;
    std::chrono::steady_clock::time_point begin = std::chrono::steady_clock::now();
    bool success = false;
    try {
        success = dropSkill->execute(logger, loggerOpcua, skillParameters).get();
        if (!success) {
            logger->warn("Skill execution returned false. Probably there was an issue while running.");
        }
    } catch (fortiss::opcua::StatusCodeException& ex) {
        logger->error("Skill execution failed with error {}", UA_StatusCode_name(ex.get_code()));
        result = ex.get_code();
    }
    std::chrono::steady_clock::time_point end = std::chrono::steady_clock::now();

    logger->info("Finished skill execution {} on {}.\n\tDuration: {} [ms]\n\tResult: {}\n\tSuccess: {}",
                 dropSkill->getSkillNameStr(),
                 dropSkill->getParentComponent()->endpointUrl,
                 std::chrono::duration_cast<std::chrono::milliseconds>(end - begin).count(),
                 UA_StatusCode_name(result), success);

    if (!success)
        return UA_STATUSCODE_BADINTERNALERROR;

    return result;
}

UA_StatusCode PnpSemanticMes::demoPickPart(
        bool reverse,
        const std::string& robotName,
        const std::string& toolUri
) {

    std::shared_ptr<RegisteredComponent> robotComponent;
    {
        auto comp = this->skillDetector->getComponentForAppName(robotName);
        if (comp.empty()) {
            logger->error("Component '{}' not registered.", robotName);
            return UA_STATUSCODE_BADNOTFOUND;
        }
        if (comp.size() > 1) {
            logger->error("More than one component with name '{}' registered.", robotName);
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        robotComponent = comp.at(0);
    }

    std::shared_ptr<RegisteredComponent> toolComponent;
    {
        std::vector<std::shared_ptr<RegisteredComponent>> comp;
        // wait a bit after toolchange to allow new connected tool to register itself
        for (size_t i = 0; i < 10 && comp.empty(); i++) {
            comp = this->skillDetector->getComponentForAppUri(toolUri);
            if (comp.empty())
                std::this_thread::sleep_for(std::chrono::milliseconds(500));
            else
                break;
        }
        if (comp.empty()) {
            logger->error("Component '{}' not registered.", toolUri);
            return UA_STATUSCODE_BADNOTFOUND;
        }
        if (comp.size() > 1) {
            logger->error("More than one component with name '{}' registered.", toolUri);
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        toolComponent = comp.at(0);
    }

    if (!reverse) {
        UA_ThreeDFrame placePos = {
                .cartesianCoordinates = {
                        .x = -0.05,
                        .y = -0.10,
                        .z = 0.0,
                },
                .orientation = {
                        .a = 0.0,
                        .b = 0.0,
                        .c = 0.0
                }
        };

        return pickAndPlaceObject(
                "cube-green",
                toolComponent->endpointUrl,
                robotComponent->endpointUrl,
                placePos
        );
    } else {
        UA_ThreeDFrame placePos = {
                .cartesianCoordinates = {
                        .x = 0.05,
                        .y = 0.10,
                        .z = 0.0,
                },
                .orientation = {
                        .a = 0.0,
                        .b = 0.0,
                        .c = 0.0
                }
        };

        return pickAndPlaceObject(
                "cube-green",
                toolComponent->endpointUrl,
                robotComponent->endpointUrl,
                placePos
        );
    }
}

UA_StatusCode
PnpSemanticMes::pickAndPlaceObject(
        const std::string& objectId,
        const std::string& toolControllerEndpoint,
        const std::string& moveControllerEndpoint,
        const UA_ThreeDFrame& placePosition
) {

    std::shared_ptr<RegisteredSkill> pickAndPlaceSkill;

    {
        if (this->skillDetector->registeredSkills.count("PickAndPlaceSkill") == 0) {
            logger->error("No skill registered for Type PickAndPlaceSkill");
            return UA_STATUSCODE_BADNOTFOUND;
        }

        if (this->skillDetector->registeredSkills.count("PickAndPlaceSkill") > 1) {
            logger->error("More than one skill registered for Type PickAndPlaceSkill");
            return UA_STATUSCODE_BADINVALIDSTATE;
        }
        std::pair<std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator, std::multimap<const std::string, std::shared_ptr<RegisteredSkill>>::iterator> skillIterator;
        skillIterator = this->skillDetector->registeredSkills.equal_range("PickAndPlaceSkill");
        pickAndPlaceSkill = skillIterator.first->second;
    }

    logger->info("Executing skill {} on {}", pickAndPlaceSkill->getSkillNameStr(),
                 pickAndPlaceSkill->getParentComponent()->endpointUrl);

    std::vector<std::shared_ptr<SkillParameter>> skillParameters = std::vector<std::shared_ptr<SkillParameter>>();
    skillParameters.reserve(4);


    {
        UA_Variant val;
        UA_Variant_init(&val);

        const UA_String str = {
                objectId.length(),
                (UA_Byte*) const_cast<char*>(objectId.c_str())
        };

        UA_StatusCode retval = UA_Variant_setScalarCopy(&val, &str,
                                                        &UA_TYPES[UA_TYPES_STRING]);

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed to copy objectId. {}", UA_StatusCode_name(retval));
            return retval;
        }

        std::shared_ptr<SkillParameter> param = std::make_shared<SkillParameter>(
                "ObjectId",
                "",
                "");
        param->setValue(val);
        UA_Variant_clear(&val);
        skillParameters.emplace_back(param);
    }


    {
        UA_Variant val;
        UA_Variant_init(&val);

        const UA_String str = {
                toolControllerEndpoint.length(),
                (UA_Byte*) const_cast<char*>(toolControllerEndpoint.c_str())
        };

        UA_StatusCode retval = UA_Variant_setScalarCopy(&val, &str,
                                                        &UA_TYPES[UA_TYPES_STRING]);

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed to copy toolSkillControllerEndpoint. {}", UA_StatusCode_name(retval));
            return retval;
        }

        std::shared_ptr<SkillParameter> param = std::make_shared<SkillParameter>(
                "ToolSkillControllerEndpoint",
                "",
                "");
        param->setValue(val);
        UA_Variant_clear(&val);
        skillParameters.emplace_back(param);
    }


    {
        UA_Variant val;
        UA_Variant_init(&val);

        const UA_String str = {
                moveControllerEndpoint.length(),
                (UA_Byte*) const_cast<char*>(moveControllerEndpoint.c_str())
        };

        UA_StatusCode retval = UA_Variant_setScalarCopy(&val, &str,
                                                        &UA_TYPES[UA_TYPES_STRING]);

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed to copy moveSkillControllerEndpoint. {}", UA_StatusCode_name(retval));
            return retval;
        }

        std::shared_ptr<SkillParameter> param = std::make_shared<SkillParameter>(
                "MoveSkillControllerEndpoint",
                "",
                "");
        param->setValue(val);
        UA_Variant_clear(&val);
        skillParameters.emplace_back(param);
    }


    {
        UA_Variant val;
        UA_Variant_init(&val);
        UA_StatusCode retval = UA_Variant_setScalarCopy(&val, &placePosition,
                                                        &UA_TYPES[UA_TYPES_THREEDFRAME]);

        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Failed to copy targetCartesianPosition. {}", UA_StatusCode_name(retval));
            return retval;
        }

        std::shared_ptr<SkillParameter> param = std::make_shared<SkillParameter>(
                "PlacePosition",
                "",
                "");
        param->setValue(val);
        UA_Variant_clear(&val);
        skillParameters.emplace_back(param);
    }

    UA_StatusCode result = UA_STATUSCODE_GOOD;
    std::chrono::steady_clock::time_point begin = std::chrono::steady_clock::now();
    bool success = false;
    try {
        success = pickAndPlaceSkill->execute(logger, loggerOpcua, skillParameters).get();
        if (!success) {
            logger->warn("Skill execution returned false. Probably there was an issue while running.");
        }
    } catch (fortiss::opcua::StatusCodeException& ex) {
        logger->error("Skill execution failed with error {}", UA_StatusCode_name(ex.get_code()));
        result = ex.get_code();
    }
    std::chrono::steady_clock::time_point end = std::chrono::steady_clock::now();

    logger->info("Finished skill execution {} on {}.\n\tDuration: {} [ms]\n\tResult: {}\n\tSuccess: {}",
                 pickAndPlaceSkill->getSkillNameStr(),
                 pickAndPlaceSkill->getParentComponent()->endpointUrl,
                 std::chrono::duration_cast<std::chrono::milliseconds>(end - begin).count(),
                 UA_StatusCode_name(result), success);

    if (!success)
        return UA_STATUSCODE_BADINTERNALERROR;

    return result;
}
