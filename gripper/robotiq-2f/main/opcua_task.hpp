/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

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
createNodesFromNodeset(
        const std::shared_ptr<fortiss::opcua::OpcUaServer>& server
) {
    LockedServer ls = server->getLocked();
    if (namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_robotiq_2f_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Sommer Automatic namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}


static bool run_opcua(
        UA_UInt16 port,
        volatile bool* running,
        bool ignore_poweroff,
        std::shared_ptr<spdlog::logger> _logger = nullptr,
        std::shared_ptr<spdlog::logger> _loggerServer = nullptr,
        std::shared_ptr<spdlog::logger> _loggerClient = nullptr
) {

    //The default 64KB of memory for sending and receicing buffer caused problems to many users. With the code below, they are reduced to ~16KB
    UA_UInt32 sendBufferSize = 16000;       //64 KB was too much for my platform
    UA_UInt32 recvBufferSize = 16000;       //64 KB was too much for my platform

    std::shared_ptr<spdlog::logger> loggerServer;
    std::shared_ptr<spdlog::logger> loggerClient;
    if (!logger) {
        logger = fortiss::log::get("gripper/robotiq2f");
        logger->set_level(spdlog::level::level_enum::info);
        loggerServer = logger->clone(logger->name() + "-ua");
        loggerServer->set_level(spdlog::level::level_enum::err);
        loggerClient = logger->clone(logger->name() + "-ua-reg");
        loggerClient->set_level(spdlog::level::level_enum::err);
    } else {
        logger = _logger;
        loggerServer = _loggerServer;
        loggerClient = _loggerClient;
    }

    UA_ServerConfig *uaServerConfig = (UA_ServerConfig*) UA_malloc(sizeof(UA_ServerConfig));
    if (!uaServerConfig) {
        logger->error("Can not create server config");
        throw std::runtime_error("Cannot create server config");
    }
    // ------------- OPC UA initialization -------------------
    if (fortiss::opcua::initServerConfig(
            loggerServer,
            uaServerConfig,
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
    UA_String_clear(&uaServerConfig->customHostname);
    UA_String_copy(&str, &uaServerConfig->customHostname);

    tcpip_adapter_ip_info_t default_ip;
    esp_err_t ret = tcpip_adapter_get_ip_info(tcpip_adapter_if_t::TCPIP_ADAPTER_IF_STA, &default_ip);
    if ((ESP_OK == ret) && (default_ip.ip.addr != INADDR_ANY)) {
        uaServerConfig->mdnsIpAddressListSize = 1;
        uaServerConfig->mdnsIpAddressList = (uint32_t *)UA_malloc(sizeof(uint32_t)*uaServerConfig->mdnsIpAddressListSize);
        memcpy(uaServerConfig->mdnsIpAddressList, &default_ip.ip.addr, sizeof(uint32_t));
    } else {
        ESP_LOGI(TAG_OPC, "Could not get default IP Address!");
    }
    #endif


    std::shared_ptr<fortiss::opcua::OpcUaServer> server = std::make_shared<fortiss::opcua::OpcUaServer>(
            logger,
            loggerServer,
            loggerClient,
            "fortiss.component.gripper.robotiq2f.client",
            "fortiss - Gripper - Robotiq 2F - Client",
            "",
            std::string(fortiss_LDS_URI),
            uaServerConfig);

    if (!createNodesFromNodeset(server)) {
        throw std::runtime_error("Creating nodes from nodeset failed");
    }

    GripperOPCUA gripperOPCUA(logger, server);

    if (const UA_StatusCode retval = server->init(
            true
    ) != UA_STATUSCODE_GOOD) {
        logger->error("Starting up the server failed with " + std::string(UA_StatusCode_name(retval)));
        return false;
    }

    const fortiss::opcua::powerOffDeviceCallbackData onPowerOffDeviceData = {
            .logger = logger,
            .onPowerOffDevice = [running, ignore_poweroff](UA_UInt32 delayMs) {
                logger->warn("Got PowerOffDevice Method call! Shutting down OPC UA Server.");
                if (!ignore_poweroff)
                    *running = false;
                return UA_STATUSCODE_GOOD;
            }
    };
    {
        LockedServer ls = server->getLocked();
        UA_StatusCode retval = fortiss::opcua::setPowerOffHandler(ls.get(), UA_NODEID_NUMERIC(
                fortiss::opcua::UA_Server_getNamespaceIdByName(server, NAMESPACE_URI_ROBOTIQ),
                UA_ROBOTIQ_2FID_ROBOTIQ2F), onPowerOffDeviceData);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Adding PowerOffHandler failed: " + std::string(UA_StatusCode_name(retval)));
            return false;
        }
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
        server->iterate();
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
    server->iterate(true);
    gripperOPCUA.step();
    gripperOPCUA.shutdown();

    server.reset();

    spdlog::shutdown();
    return true;
}

#endif //ROBOTIQ_2FOPCUA_TASK_HPP
