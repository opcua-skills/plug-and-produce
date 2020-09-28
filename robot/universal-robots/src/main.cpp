/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

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
createNodesFromNodeset(
        const std::shared_ptr<fortiss::opcua::OpcUaServer>& uaServer
) {
    LockedServer ls = uaServer->getLocked();
    if (namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_rob_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the Robotics namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_fortiss_device_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss device namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_for_rob_generated(ls.get()) != UA_STATUSCODE_GOOD) {
        logger->error("Adding the fortiss Robotics namespace failed. Please check previous error output.");
        return false;
    }
    if (namespace_rob_ur_generated(ls.get()) != UA_STATUSCODE_GOOD) {
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
    std::string certFiles;
    std::string clientCertFiles;
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

    logger = fortiss::log::LoggerFactory::createLogger("robot/ur",
                                                       settings["logging"]["level"]["app"],
                                                       settings["logging"].exists("path") ? settings["logging"]["path"] : "");

    std::shared_ptr<fortiss::opcua::OpcUaServer> uaServer;

    int exitCode = EXIT_SUCCESS;

    try {
        if (clientCertFiles.empty()) {
            logger->error("Client certificates are required. Use --certs-client command line option.");
            return (EXIT_FAILURE);
        }

        if (settings["opcua"]["encryption"] && certFiles.empty()) {
            logger->error("Encryption is enabled but no certificates are given. Use --certs-server command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting Universal Robot Control - {} ...", settings["opcua"]["appName"].c_str());

        uaServer = std::make_shared<fortiss::opcua::OpcUaServer>(
                settings,
                logger,
                "fortiss.component.robot.universal-robot-ur5",
                settings["opcua"]["appName"],
                certFiles,
                "fortiss.component.robot.universal-robot-ur5.client",
                "fortiss - Robot - UR5 - Client",
                clientCertFiles);

        // Default is 100ms. We support 8ms here as fastest publishing interval
        uaServer->getServerConfig()->publishingIntervalLimits.min = 8;


        if (!createNodesFromNodeset(uaServer)) {
            throw std::runtime_error("Creating nodes from nodeset failed");
        }

        fortiss::robot::UniversalRobotControl control(settings["robot"], uaServer);

        if (!control.connect()) {
            throw std::runtime_error("Controller connect failed");
        }

        if (const UA_StatusCode retval = uaServer->init(true) != UA_STATUSCODE_GOOD) {
            throw std::runtime_error("Starting up the server failed with " + std::string(UA_StatusCode_name(retval)));
        }

        // TODO set tool

        while (running) {
            uaServer->iterate();
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
        exitCode = EXIT_FAILURE;
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize robot control. {} ", rex.what());
        logger->flush();

        exitCode = EXIT_FAILURE;
    }
    uaServer.reset();

    spdlog::shutdown();
    return exitCode;
}