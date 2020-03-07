//
// Created by profanter on 11/29/18.
// Copyright (c) 2018 fortiss GmbH. All rights reserved.
//

#include <common/component.h>
#include <common/logging_opcua.h>
#include <common/opcua/helper.hpp>

#include "CLI/CLI.hpp"
#include "libconfig.h++"

#include <rl/util/process.h>
#include <rl/util/thread.h>


#include "namespace_di_generated.h"
#include "namespace_fortiss_device_generated.h"
#include "namespace_rob_generated.h"
#include "namespace_for_rob_generated.h"
#include "namespace_rob_ur_generated.h"

#include "UniversalRobotControl.h"

std::shared_ptr<spdlog::logger> logger;

UA_Boolean running = true;

static void stopHandler(int) {
    logger->warn("received ctrl-c");
    running = false;
}

static bool
createNodesFromNodeset(UA_Server* uaServer) {
    if (namespace_di_generated(uaServer) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_rob_generated(uaServer) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Robotics namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(uaServer) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_for_rob_generated(uaServer) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss Robotics namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_rob_ur_generated(uaServer) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Universal Robot namespace failed. Please check previous error output.");
        return false;
    }
    return true;
}

int main(
        int argc,
        char* argv[]
) {
    // ------------- General initialization -------------------

    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);

    try {
        rl::util::this_process::set_priority(rl::util::this_process::get_priority_max());
        rl::util::this_process::memory_lock_all();
        rl::util::this_process::memory_reserve(100 * 1024 * 1024);
        rl::util::this_thread::set_priority(rl::util::this_thread::get_priority_max());
    } catch (std::exception& ex) {
        std::cerr << "ERROR: Could not set process priority! You need to start the process with root rights." << std::endl;
    }


    CLI::App app{"Universal Robot OPC UA Control"};

    std::string configFile = "universal-robots.cfg";
    std::string certFiles = "";
    std::string clientCertFiles = "";
    app.add_option("--config", configFile, "Configuration file path", true);
    app.add_option("--certs-server", certFiles, "The server certificate files without extension", true);
    app.add_option("--certs-client", clientCertFiles, "The client certificate files without extension", false);

    CLI11_PARSE(app, argc, argv);

    libconfig::Config cfg;
    // Read the file. If there is an error, report it and exit.
    try {
        cfg.readFile(configFile.c_str());
    }
    catch (const libconfig::FileIOException& fioex) {
        std::cerr << "I/O error while reading configuration file." << fioex.what() << std::endl;
        return (EXIT_FAILURE);
    }
    catch (const libconfig::ParseException& pex) {
        std::cerr << "Configuration file parse error at " << pex.getFile() << ":" << pex.getLine()
                  << " - " << pex.getError() << std::endl;
        return (EXIT_FAILURE);
    }
    const libconfig::Setting& settings = cfg.getRoot();

    logger = fortiss::log::get("robot/ur");

    UA_ServerConfig uaServerConfig;
    UA_Server* uaServer = nullptr;
    UA_Client* clientRegister = nullptr;
    int exitCode = EXIT_SUCCESS;

    std::shared_ptr<spdlog::logger> loggerClient = logger->clone(logger->name() + "-reg");
    if (loggerClient->level() < spdlog::level::err)
        loggerClient->set_level(spdlog::level::err);
    std::shared_ptr<spdlog::logger> loggerServer = logger->clone(logger->name());
    if (loggerServer->level() < spdlog::level::err)
        loggerServer->set_level(spdlog::level::err);

    try {
        std::string logLevel = settings["log"];
        if (logLevel == "trace")
            logger->set_level(spdlog::level::level_enum::trace);
        else if (logLevel == "debug")
            logger->set_level(spdlog::level::level_enum::debug);
        else if (logLevel == "info")
            logger->set_level(spdlog::level::level_enum::info);
        else if (logLevel == "warn")
            logger->set_level(spdlog::level::level_enum::warn);
        else if (logLevel == "err")
            logger->set_level(spdlog::level::level_enum::err);
        else if (logLevel == "critical")
            logger->set_level(spdlog::level::level_enum::critical);
        else if (logLevel == "off")
            logger->set_level(spdlog::level::level_enum::off);
        else {
            std::cerr
                    << "Invalid 'log' setting in configuration file. Must be one of [trace, debug, info, warn, err, critical, off]"
                    << std::endl;
            return (EXIT_FAILURE);
        }

        if (clientCertFiles.empty()) {
            logger->error("Client certificates are required. Use --certs-client command line option.");
            return (EXIT_FAILURE);
        }

        if (settings["opcua"]["encryption"] && certFiles.empty()) {
            logger->error("Encryption is enabled but no certificates are given. Use --certs-server command line option.");
            return (EXIT_FAILURE);
        }

        // ------------- OPC UA initialization -------------------
        if (fortiss::opcua::initServerConfig(
                loggerServer,
                &uaServerConfig,
                "fortiss.component.robot.universal-robot-ur5",
                settings["opcua"]["appName"],
                (UA_UInt16) ((int) settings["opcua"]["port"]),
                settings["opcua"]["encryption"],
                settings["opcua"]["anonymous"],
                certFiles) != UA_STATUSCODE_GOOD) {
            return EXIT_FAILURE;
        }

        // Default is 100ms. We support 8ms here as fastest publishing interval
        uaServerConfig.publishingIntervalLimits.min = 8;

        uaServer = UA_Server_newWithConfig(&uaServerConfig);
        if (!uaServer) {
            logger->error("Can not create server instance");
            return EXIT_FAILURE;
        }
        if (!createNodesFromNodeset(uaServer)) {
            throw std::runtime_error("Creating nodes from nodeset failed");
        }

        // ------------- OPC UA Model initialization -------------------
        logger->info("Starting Universal Robot Control ...");
        fortiss::robot::UniversalRobotControl control(settings["robot"], uaServer);

        if (!control.connect()) {
            throw std::runtime_error("Controller connect failed");
        }

        UA_StatusCode retval = UA_Server_run_startup(uaServer);
        if (retval != UA_STATUSCODE_GOOD) {
            throw std::runtime_error("Starting up the server failed with " + std::string(UA_StatusCode_name(retval)));
        }

        // TODO set tool

        UA_UInt64 periodicCallbackId = 0;
        const fortiss::opcua::serverOnNetworkCallbackData onLdsData = {
                .filterServerName = std::string(settings["lds-uri"].c_str()),
                .callbackOnAnnounceOnly = true,
                .onServerAnnounce = [uaServer, &periodicCallbackId, &clientRegister, &clientCertFiles, &loggerClient]
                        (
                                const UA_ServerOnNetwork* serverOnNetwork,
                                UA_Boolean isServerAnnounce
                        ) {
                    if (clientRegister)
                        return;
                    logger->info("Found LDS Server on {}", std::string((char*) serverOnNetwork->discoveryUrl.data, serverOnNetwork->discoveryUrl.length));
                    if (periodicCallbackId != 0)
                        UA_Server_removeCallback(uaServer, periodicCallbackId);

                    std::string clientCert = clientCertFiles + "_cert.der";
                    std::string clientKey = clientCertFiles + "_key.der";

                    fortiss::opcua::UA_Server_setPeriodicRegister(
                            uaServer,
                            loggerClient,
                            clientCert,
                            clientKey,
                            "fortiss.component.robot.universal-robot-ur5.client",
                            "fortiss - Robot - UR5 - Client",
                            serverOnNetwork,
                            &periodicCallbackId,
                            &clientRegister);
                }
        };
        fortiss::opcua::UA_Server_onServerAnnounce(uaServer, onLdsData);

        while (running) {
            UA_Server_run_iterate(uaServer, false);
            if (!control.step()) {
                break;
            }
            std::this_thread::yield();
            std::this_thread::sleep_for(std::chrono::milliseconds(1));
        }

    }
    catch (const libconfig::SettingNotFoundException& nfex) {
        logger->error("Setting missing in configuration file. {} -> {}", nfex.what(), nfex.getPath());
        logger->flush();
        return (EXIT_FAILURE);
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize robot control. {} ", rex.what());
        logger->flush();

        exitCode = EXIT_FAILURE;
    }

    // cppcheck-suppress knownConditionTrueFalse
    if (clientRegister != nullptr) {
        UA_StatusCode retval = UA_Server_unregister_discovery(uaServer, clientRegister);
        if (retval != UA_STATUSCODE_GOOD) {
            logger->error("Can not unregister from discovery server: {}", UA_StatusCode_name(retval));
        }
        UA_Client_disconnect(clientRegister);
        UA_Client_delete(clientRegister);
    }

    UA_Server_run_shutdown(uaServer);
    UA_Server_delete(uaServer);

    logger->flush();
    return exitCode;
}