//
// Created by profanter on 21/01/2020.
// Copyright (c) 2020 fortiss GmbH. All rights reserved.
//

#ifndef ROBOTIQ_2FOPCUA_TASK_HPP
#define ROBOTIQ_2FOPCUA_TASK_HPP

#ifdef UA_ENABLE_AMALGAMATION
#include <open62541.h>
#else
#include <open62541/server_config_default.h>
#endif

#include <spdlog/spdlog.h>
#include <common/logging.h>
#include <robotiq_2f_nodeids.h>


#include "namespace_di_generated.h"
#include "di_nodeids.h"
#include "namespace_fortiss_device_generated.h"
#include "namespace_robotiq_2f_generated.h"

#include "GripperOPCUA.h"

#define fortiss_LDS_URI "fortiss.component.mes"

std::shared_ptr<spdlog::logger> logger;

#ifndef LOCAL_SIMULATION
#include <esp_log.h>
#include "TinyPico.h"
static const char *TAG_OPC = "OPC UA";
TinyPICO *tinyPico;
#endif

static bool
createNodesFromNodeset(UA_Server *server) {
    if (namespace_di_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_robotiq_2f_generated(server) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Sommer Automatic namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}


static bool run_opcua(UA_UInt16 port, volatile bool *running, bool ignore_poweroff) {

    //The default 64KB of memory for sending and receicing buffer caused problems to many users. With the code below, they are reduced to ~16KB
    UA_UInt32 sendBufferSize = 16000;       //64 KB was too much for my platform
    UA_UInt32 recvBufferSize = 16000;       //64 KB was too much for my platform

    logger = fortiss::log::get("gripper/robotiq2f");
    logger->set_level(spdlog::level::level_enum::info);


    UA_ServerConfig uaServerConfig;
    // ------------- OPC UA initialization -------------------
    if (fortiss::opcua::initServerConfig(
            logger,
            &uaServerConfig,
            "fortiss.component.gripper.robotiq",
            "fortiss - Gripper - Robotiq",
            (UA_UInt16) ((int) port),
            false,
            false,
            "",
            sendBufferSize,
            recvBufferSize,
            true) != UA_STATUSCODE_GOOD) {
        return false;
    }

    #ifndef LOCAL_SIMULATION
        #ifndef CONFIG_ETHERNET_HELPER_CUSTOM_HOSTNAME
        #ifndef ETHERNET_HELPER_STATIC_IP4
        #error You need to set a static IP or a custom hostname with menuconfig
        #else
        UA_String str = UA_STRING(CONFIG_ETHERNET_HELPER_STATIC_IP4_ADDRESS);
        #endif
        #else
        UA_String str = UA_STRING((char*)CONFIG_ETHERNET_HELPER_CUSTOM_HOSTNAME_STR);
        #endif
        UA_ServerConfig_setCustomHostname(&uaServerConfig, str);

        tcpip_adapter_ip_info_t default_ip;
        esp_err_t ret = tcpip_adapter_get_ip_info(tcpip_adapter_if_t::TCPIP_ADAPTER_IF_STA, &default_ip);
        if ((ESP_OK == ret) && (default_ip.ip.addr != INADDR_ANY)) {
            uaServerConfig.discovery.ipAddressListSize = 1;
            uaServerConfig.discovery.ipAddressList = (uint32_t *)UA_malloc(sizeof(uint32_t)*uaServerConfig.discovery.ipAddressListSize);
            memcpy(uaServerConfig.discovery.ipAddressList, &default_ip.ip.addr, sizeof(uint32_t));
        } else {
            ESP_LOGI(TAG_OPC, "Could not get default IP Address!");
        }
    #endif

    UA_Server *server = UA_Server_newWithConfig(&uaServerConfig);
    if (!server) {
        logger->error("Can not create server instance");
        return false;
    }

    if (!createNodesFromNodeset(server)) {
        throw std::runtime_error("Creating nodes from nodeset failed");
    }

    GripperOPCUA gripperOPCUA(logger, server);

    UA_StatusCode retval = UA_Server_run_startup(server);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Starting up the server failed with " + std::string(UA_StatusCode_name(retval)));
        return false;
    }


    std::shared_ptr<spdlog::logger> loggerClient = logger->clone(logger->name()+"-reg");
    if (loggerClient->level() < spdlog::level::warn)
        loggerClient->set_level(spdlog::level::warn);

    UA_Client *clientRegister = NULL;
    UA_UInt64 periodicCallbackId = 0;
    const fortiss::opcua::serverOnNetworkCallbackData onLdsData = {
            .filterServerName = std::string(fortiss_LDS_URI),
            .callbackOnAnnounceOnly = true,
            .onServerAnnounce = [server, &periodicCallbackId, &clientRegister, &loggerClient](const UA_ServerOnNetwork *serverOnNetwork, UA_Boolean isServerAnnounce) {
                logger->info("Found LDS Server on {}", std::string((char*)serverOnNetwork->discoveryUrl.data,  serverOnNetwork->discoveryUrl.length));
                if (periodicCallbackId != 0)
                    UA_Server_removeCallback(server, periodicCallbackId);
                if (clientRegister) {
                    UA_Client_disconnect(clientRegister);
                    UA_Client_delete(clientRegister);
                }

                fortiss::opcua::UA_Server_setPeriodicRegister(
                        server,
                        loggerClient,
                        "",
                        "",
                        "fortiss.component.gripper.robotiq2f.client",
                        "fortiss - Gripper - Robotiq 2F - Client",
                        serverOnNetwork,
                        &periodicCallbackId,
                        &clientRegister);
            }
    };
    fortiss::opcua::UA_Server_onServerAnnounce(server, onLdsData);

    const fortiss::opcua::powerOffDeviceCallbackData onPowerOffDeviceData = {
            .logger = logger,
            .onPowerOffDevice = [running, ignore_poweroff](UA_UInt32 delayMs) {
                logger->warn("Got PowerOffDevice Method call! Shutting down OPC UA Server.");
                if (!ignore_poweroff)
                    *running = false;
                return UA_STATUSCODE_GOOD;
            }
    };
    retval = fortiss::opcua::setPowerOffHandler(server, UA_NODEID_NUMERIC(
            fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_ROBOTIQ),
            UA_ROBOTIQ_2FID_ROBOTIQ2F), onPowerOffDeviceData);
    if (retval != UA_STATUSCODE_GOOD) {
        logger->error("Adding PowerOffHandler failed: " + std::string(UA_StatusCode_name(retval)));
        return false;
    }

    if (!gripperOPCUA.connect()) {
        logger->error("gripperOPCUA connect failed!");
        return false;
    }


    #ifndef LOCAL_SIMULATION
    ESP_LOGI(TAG_OPC, "Starting server loop. Free Heap: %d bytes", xPortGetFreeHeapSize());
    tinyPico->DotStar_SetPixelColor(0, 255, 0);
    #endif

    while (*running) {
        UA_Server_run_iterate(server, false);
        #ifndef LOCAL_SIMULATION
        try {
            gripperOPCUA.step();
        } catch( rl::hal::DeviceException &ex) {
            ESP_LOGE(TAG_OPC, "DeviceException: %s", ex.what());
            tinyPico->DotStar_SetPixelColor(255, 0, 0);
            break;
        }
        ESP_ERROR_CHECK(esp_task_wdt_reset());
        #else
        gripperOPCUA.step();
        std::this_thread::sleep_for(std::chrono::milliseconds(1));
        #endif
        std::this_thread::yield();
    }
    // do one last iteration
    UA_Server_run_iterate(server, true);
    gripperOPCUA.step();
    UA_Server_run_shutdown(server);

    UA_Server_delete(server);

    return true;
}

#endif //ROBOTIQ_2FOPCUA_TASK_HPP
