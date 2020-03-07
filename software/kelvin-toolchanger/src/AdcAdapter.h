//
// Created by profanter on 19/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef KELVIN_TOOLCHANGER_ADCADAPTER_H
#define KELVIN_TOOLCHANGER_ADCADAPTER_H

#include <functional>
#include <spdlog/logger.h>
#include <open62541/client_config.h>

enum KelvinToolState {
    KELVIN_UNKNOWN = 0,
    KELVIN_READY,
    KELVIN_INTERMEDIATE,
    KELVIN_NO_TOOL,
    KELVIN_TOOL_CONNECTED
};

class AdcAdapter {

private:

    KelvinToolState toolState = KELVIN_UNKNOWN;
    unsigned short toolId = 0;
    std::shared_ptr<spdlog::logger> logger;
    std::shared_ptr<spdlog::logger> loggerClient;

    std::string adcEndpoint;
    UA_Client *client = nullptr;

    std::thread stepperThread;
    bool running;

    bool isSimulation;

    UA_StatusCode connectClient();

    void setToolFromVoltage(double voltage);

    UA_StatusCode initNodeId();
    UA_NodeId channel5NodeId;

public:

    explicit AdcAdapter(std::shared_ptr<spdlog::logger> logger, bool isSimulation);
    virtual ~AdcAdapter();

    UA_StatusCode connect(const std::string &endpoint, const std::string& clientCertPath, const std::string& clientKeyPath, const std::string& clientAppUri);
    void disconnect();

    KelvinToolState getToolState() { return toolState; };
    unsigned short getToolId() { return toolId; };

    std::function<void(const KelvinToolState toolState, const short toolId)> toolChangeCallback;

    void voltageChangeCallback(UA_DataValue *value);

    bool setStateSimulated(const KelvinToolState toolState, const short toolId);

    void threadWorker();
};


#endif //KELVIN_TOOLCHANGER_ADCADAPTER_H
