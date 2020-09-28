/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#ifndef DATA_BACKBONE_PNPSEMANTICMES_H
#define DATA_BACKBONE_PNPSEMANTICMES_H

#include <types_fortiss_device_generated.h>
#include "SemanticMes.h"

class PnpSemanticMes : public SemanticMes {

public:
    explicit PnpSemanticMes(
            std::shared_ptr<spdlog::logger> _logger,
            std::shared_ptr<spdlog::logger> _loggerOpcua,
            const std::shared_ptr<fortiss::opcua::OpcUaServer>& server,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const libconfig::Setting& pnpSetting,
            bool isSimulation
    );

    ~PnpSemanticMes() override;

    UA_StatusCode startDemoExecution();

    UA_StatusCode startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
    ) override;

private:
    const libconfig::Setting& pnpSetting;
    bool isSimulation;

    std::map<std::string, rl::math::Transform> objectPositions;

    UA_StatusCode takeToolAtPosition(
            const UA_ThreeDFrame* toolPosition,
            const std::string& expectedToolAppUri
    );

    UA_StatusCode dropCurrentTool();

    UA_StatusCode pickAndPlaceObject(
            const std::string& objectId,
            const std::string& toolControllerEndpoint,
            const std::string& moveControllerEndpoint,
            const UA_ThreeDFrame& placePosition
    );

    UA_StatusCode demoPickPart(
            bool reverse,
            const std::string& robotName,
            const std::string& toolIri
    );
};


#endif //DATA_BACKBONE_PNPSEMANTICMES_H
