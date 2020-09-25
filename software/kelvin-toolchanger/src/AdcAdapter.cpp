/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include "AdcAdapter.h"

#include <utility>
#include <common/opcua/helper.hpp>
#include <open62541/client_highlevel.h>
#include <open62541/client_subscriptions.h>
#include <di_nodeids.h>


#define NAMESPACE_URI_ADC_ADAPTER "https://fortiss.org/UA/adc_adapter/"

// Values of the voltage divider which is soldered to the microcontroller to
// transform the 24V of the toolchanger to a measurable 3.3V of the microcontroller
// 10 kOhm
#define VOLTAGE_DIVIDER_RESISTOR_A 10000.0
// 1.5 kOhm
#define VOLTAGE_DIVIDER_RESISTOR_B 1500.0

#define VOLTAGE_DIVIDER_RATIO (VOLTAGE_DIVIDER_RESISTOR_B/(VOLTAGE_DIVIDER_RESISTOR_A+VOLTAGE_DIVIDER_RESISTOR_B))

// The following values are from the Kelvin Toolchanger Manual
#define KELVIN_V_READY 0
#define KELVIN_V_INTERMEDIATE 2.1f
#define KELVIN_V_NO_TOOL 4.9f
#define KELVIN_MAX_TOOLS 10
const float KELVIN_V_TOOLS[KELVIN_MAX_TOOLS] = {
    5.7f,
    6.7f,
    7.4f,
    8.4f,
    9.5f,
    10.8f,
    11.7f,
    12.4f,
    13.2f,
    14.1
};


AdcAdapter::AdcAdapter(std::shared_ptr<spdlog::logger> _logger, bool isSimulation):
    logger(std::move(_logger)), running(false), isSimulation(isSimulation) {
    // copy logger to change loglevel
    loggerClient = logger->clone(logger->name()+"-client");
    if (loggerClient->level() < spdlog::level::err)
        loggerClient->set_level(spdlog::level::err);
}

AdcAdapter::~AdcAdapter() {
    disconnect();
}

UA_StatusCode AdcAdapter::connect(const std::string& endpoint, const std::string& clientCertPath, const std::string& clientKeyPath, const std::string& clientAppUri) {
    if (client != nullptr)
        return UA_STATUSCODE_BADALREADYEXISTS;

    this->adcEndpoint = endpoint;

    if (isSimulation) {
        this->setStateSimulated(KELVIN_READY, 0);
        return UA_STATUSCODE_GOOD;
    }

    client = fortiss::opcua::UA_Helper_getClientForEndpoint(
            fortiss::opcua::getEndpointWithHighestSecurity(endpoint.c_str(), loggerClient),
            loggerClient,
            clientCertPath,
            clientKeyPath,
            clientAppUri,
            "fortiss - Component - Kelvin Toolchanger - ADC - Client"
    );
    if (!client) {
        logger->error("Could not connect to ADC Adapter on endpoint: {}", endpoint);
        return UA_STATUSCODE_BADNOTCONNECTED;
    }
    UA_ClientConfig *cnf = UA_Client_getConfig(client);
    cnf->timeout = 1000;

    UA_StatusCode retval = this->connectClient();
    if (retval != UA_STATUSCODE_GOOD)
        return retval;

    retval = initNodeId();

    if (retval != UA_STATUSCODE_GOOD)
        return retval;

    running = true;
    stepperThread = std::thread([&] { threadWorker(); });

    return UA_STATUSCODE_GOOD;
}

void AdcAdapter::disconnect() {

    if (setVoltageThread.joinable())
        // wait for previous thread exec to finish
        setVoltageThread.join();

    if (client == nullptr)
        return;

    if (!running)
        return;
    running = false;

    stepperThread.join();

    UA_Client_disconnect(client);
    UA_Client_delete(client);
    client = nullptr;
}


void AdcAdapter::threadWorker() {
    while (running) {
        UA_SecureChannelState channelState;
        UA_SessionState sessionState;
        UA_StatusCode connectStatus;
        UA_Client_getState(client, &channelState, &sessionState, &connectStatus);

        if (channelState == UA_SECURECHANNELSTATE_CLOSED || sessionState == UA_SESSIONSTATE_CLOSED) {
            logger->warn("ADC Client reconnecting...");
            UA_StatusCode retVal = connectClient();
            if (retVal != UA_STATUSCODE_GOOD) {
                logger->error("Client reconnect error: {}", UA_StatusCode_name(retVal));
                continue;
            }
        }
        UA_StatusCode retVal;
        {
            //std::lock_guard<std::mutex> lk(clientMutex);
            retVal = UA_Client_run_iterate(client, 0);
        }
        if (retVal != UA_STATUSCODE_GOOD) {
            logger->error("Client_run_iterate error: {}", UA_StatusCode_name(retVal));
            return;
        }
        UA_Variant var;
        retVal = UA_Client_readValueAttribute(client, channel5NodeId, &var);
        if (retVal == UA_STATUSCODE_BADCONNECTIONCLOSED) {
            retVal = connectClient();
            if (retVal != UA_STATUSCODE_GOOD) {
                logger->error("Client reconnect error: {}", UA_StatusCode_name(retVal));
                continue;
            }
            retVal = UA_Client_readValueAttribute(client, channel5NodeId, &var);
        }
        if (retVal != UA_STATUSCODE_GOOD) {
            logger->error("Client read error: {}", UA_StatusCode_name(retVal));
            continue;
        }
        if (var.type != &UA_TYPES[UA_TYPES_DOUBLE]) {
            logger->error("Client read voltage value is not double!");
            return;
        }
        setToolFromVoltage(*(double*)var.data);


        std::this_thread::sleep_for(std::chrono::milliseconds(100));
    }
    running = false;
}

UA_StatusCode AdcAdapter::connectClient() {

    UA_SecureChannelState channelState;
    UA_SessionState sessionState;
    UA_StatusCode connectStatus;
    UA_Client_getState(client, &channelState, &sessionState, &connectStatus);
    if (sessionState >= UA_SESSIONSTATE_ACTIVATED) {
        UA_Client_run_iterate(client, 1);
        UA_Client_getState(client, &channelState, &sessionState, &connectStatus);
        if (sessionState >= UA_SESSIONSTATE_ACTIVATED) {
            return UA_STATUSCODE_GOOD;
        }
    }

    UA_Client_disconnect(client);

    UA_StatusCode retval;
    retval = UA_Client_connect(client, adcEndpoint.c_str());

    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Can not connect to ADC Adapter {}. Error {}", adcEndpoint.c_str(), UA_StatusCode_name(retval));
        return retval;
    }

    logger->info("ADC Client Connected");

    return UA_STATUSCODE_GOOD;
}

UA_StatusCode AdcAdapter::initNodeId() {

    UA_UInt16 adcNsIdx;
    UA_UInt16 diNsIdx;
    {
        UA_String nsUri = UA_String_fromChars(NAMESPACE_URI_DI);
        UA_StatusCode retval = UA_Client_NamespaceGetIndex(client, &nsUri, &diNsIdx);
        UA_String_clear(&nsUri);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Can not get namespace index of {} from {}: {}", NAMESPACE_URI_DI, adcEndpoint, UA_StatusCode_name(retval));
            return retval;
        }
    }
    {
        UA_String nsUri = UA_String_fromChars(NAMESPACE_URI_ADC_ADAPTER);
        UA_StatusCode retval = UA_Client_NamespaceGetIndex(client, &nsUri, &adcNsIdx);
        UA_String_clear(&nsUri);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Can not get namespace index of {} from {}: {}", NAMESPACE_URI_ADC_ADAPTER, adcEndpoint, UA_StatusCode_name(retval));
            return retval;
        }
    }

    {

        // Force array
        UA_BrowsePath bp;
        UA_BrowsePath_init(&bp);
        bp.startingNode = UA_NODEID_NUMERIC(diNsIdx, UA_DIID_DEVICESET);

        bp.relativePath.elementsSize = 3;
        bp.relativePath.elements = static_cast<UA_RelativePathElement *>(UA_Array_new(3,
                                                                                      &UA_TYPES[UA_TYPES_RELATIVEPATHELEMENT]));
        bp.relativePath.elements[0].targetName = UA_QUALIFIEDNAME(adcNsIdx, const_cast<char *>("AdcAdapter"));
        bp.relativePath.elements[0].referenceTypeId = UA_NODEID_NUMERIC(0, UA_NS0ID_ORGANIZES);
        bp.relativePath.elements[0].includeSubtypes = false;
        bp.relativePath.elements[0].isInverse = false;

        bp.relativePath.elements[1].targetName = UA_QUALIFIEDNAME(adcNsIdx, const_cast<char *>("ADC1"));
        bp.relativePath.elements[1].referenceTypeId = UA_NODEID_NUMERIC(0, UA_NS0ID_HASCOMPONENT);
        bp.relativePath.elements[1].includeSubtypes = false;
        bp.relativePath.elements[1].isInverse = false;

        bp.relativePath.elements[2].targetName = UA_QUALIFIEDNAME(adcNsIdx, const_cast<char *>("Channel5"));
        bp.relativePath.elements[2].referenceTypeId = UA_NODEID_NUMERIC(0, UA_NS0ID_HASCOMPONENT);
        bp.relativePath.elements[2].includeSubtypes = false;
        bp.relativePath.elements[2].isInverse = false;

        UA_TranslateBrowsePathsToNodeIdsRequest request;
        UA_TranslateBrowsePathsToNodeIdsRequest_init(&request);
        request.browsePaths = &bp;
        request.browsePathsSize = 1;

        UA_TranslateBrowsePathsToNodeIdsResponse res = UA_Client_Service_translateBrowsePathsToNodeIds(client, request);
        UA_free(bp.relativePath.elements);

        if (res.responseHeader.serviceResult != UA_STATUSCODE_GOOD) {
            UA_StatusCode retval = res.responseHeader.serviceResult;
            UA_TranslateBrowsePathsToNodeIdsResponse_deleteMembers(&res);
            logger->error("Can not get NodeId for Channel5 from {}: {}", adcEndpoint, UA_StatusCode_name(retval));
            return retval;
        }
        if (res.resultsSize != 1 || res.results[0].targetsSize != 1) {
            UA_TranslateBrowsePathsToNodeIdsResponse_deleteMembers(&res);
            logger->error("Did not get one result for Channel5 browse path from {}", adcEndpoint);
            return UA_STATUSCODE_BADNOTFOUND;
        }


        UA_NodeId_copy(&res.results[0].targets[0].targetId.nodeId, &channel5NodeId);
        UA_TranslateBrowsePathsToNodeIdsResponse_deleteMembers(&res);
    }

    return UA_STATUSCODE_GOOD;
}

void AdcAdapter::voltageChangeCallback(UA_DataValue *value) {

    if(!UA_Variant_hasScalarType(&value->value, &UA_TYPES[UA_TYPES_DOUBLE])) {
        logger->error("Got invalid datatype for voltage montioring");
        return;
    }
    this->setToolFromVoltage(*(UA_Double *) value->value.data);
}

void AdcAdapter::setToolFromVoltage(double voltage) {

    // scale 3.3V back to 24V
    double v24 = voltage/VOLTAGE_DIVIDER_RATIO;

    // now check the ranges for the voltage value.
    // use the middle between two values as range border

    KelvinToolState newState = KELVIN_UNKNOWN;
    unsigned short newId = 0;

    if (v24 < (KELVIN_V_INTERMEDIATE+KELVIN_V_READY)/2.0) {
        newState = KELVIN_READY;
        newId = 0;
    } else if (v24 < (KELVIN_V_NO_TOOL+KELVIN_V_INTERMEDIATE)/2.0) {
        newState = KELVIN_INTERMEDIATE;
        newId = 0;
    } else if (v24 < (KELVIN_V_TOOLS[0]+KELVIN_V_NO_TOOL)/2.0) {
        newState = KELVIN_NO_TOOL;
        newId = 0;
    } else {
        newState = KELVIN_TOOL_CONNECTED;
        newId = KELVIN_MAX_TOOLS;
        for (size_t i=0; i<KELVIN_MAX_TOOLS-1; i++) {
            if (v24 < (KELVIN_V_TOOLS[i+1]+KELVIN_V_TOOLS[i])/2.0) {
                newId = i+1;
                break;
            }
        }
    }

    if (newId != this->toolId || toolState != newState) {
        logger->info("Tool changed:\n\tState: {} -> {}\n\tId: {} -> {}", this->toolState, newState, this->toolId, newId);
        this->toolId = newId;
        this->toolState = newState;
        if (this->toolChangeCallback)
            this->toolChangeCallback(newState, newId);
    }

}

bool AdcAdapter::setStateSimulated(const KelvinToolState newState, const short newId) {
    if (!isSimulation)
        return false;
    // run in different thread to simulate same behaviour as for client subscription
    if (setVoltageThread.joinable())
        // wait for previous thread exec to finish
        setVoltageThread.join();
    setVoltageThread = std::thread([&, newState, newId] {
        if (newId != this->toolId || toolState != newState) {
            logger->info("Tool changed:\n\tState: {} -> {}\n\tId: {} -> {}", this->toolState, newState, this->toolId, newId);
            this->toolId = newId;
            this->toolState = newState;
            if (this->toolChangeCallback)
                this->toolChangeCallback(newState, newId);
        }
    });
    return true;
}
