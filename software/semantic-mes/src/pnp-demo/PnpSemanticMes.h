//
// Created by profanter on 13/01/2020.
// Copyright (c) 2020 fortiss GmbH. All rights reserved.
//

#ifndef DATA_BACKBONE_PNPSEMANTICMES_H
#define DATA_BACKBONE_PNPSEMANTICMES_H

#include "SemanticMes.h"

class PnpSemanticMes : public SemanticMes {

public:
    explicit PnpSemanticMes(
            std::shared_ptr<spdlog::logger> _logger,
            UA_Server* server,
            const std::string& clientCertPath,
            const std::string& clientKeyPath,
            const libconfig::Setting& pnpSetting
    );

    virtual ~PnpSemanticMes();

    UA_StatusCode startDemoExecution();

    UA_StatusCode startExecution(
            const std::string& abstractProcessIri,
            const std::string& executionMode
    ) override;

private:
    const libconfig::Setting& pnpSetting;

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
