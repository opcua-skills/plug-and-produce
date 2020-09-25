/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include <memory>
#include <chrono>

#include <spdlog/spdlog.h>
#include <iostream>
#include "CLI/CLI.hpp"
#include "libconfig.h++"

#include "common/logging.h"
#include "common/logging_opcua.h"
#include "common/opcua/helper.hpp"
#include "opcua_task.hpp"

bool running = true;

static void stopHandler(int) {
    logger->warn("Received Ctrl-C. Shutting down...");
    logger->flush();
    running = false;
}


int main(
        int argc,
        char* argv[]
) {
    // ------------- General initialization -------------------

    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);

    CLI::App app{"Robotiq 2F"};

    std::string configFile = "gripper.cfg";
    app.add_option("--config", configFile, "Configuration file path", true);

    CLI11_PARSE(app, argc, argv);

    libconfig::Config cfg;
    // Read the file. If there is an error, report it and exit.
    try {
        cfg.readFile(configFile.c_str());
    }
    catch (const libconfig::FileIOException& fioex) {
        std::cerr << "I/O error while reading configuration file." << fioex.what() << std::endl;
        #ifdef USE_RASPI
        ledDaemonClient.setStatus(LedColor::RED, LedStatus::BLINK);
        #endif
        return (EXIT_FAILURE);
    }
    catch (const libconfig::ParseException& pex) {
        std::cerr << "Configuration file parse error at " << pex.getFile() << ":" << pex.getLine()
                  << " - " << pex.getError() << std::endl;
        #ifdef USE_RASPI
        ledDaemonClient.setStatus(LedColor::RED, LedStatus::BLINK);
        #endif
        return (EXIT_FAILURE);
    }
    const libconfig::Setting& settings = cfg.getRoot();

    logger = fortiss::log::LoggerFactory::createLogger("robot/robotiq2f",
                                                       settings["logging"]["level"]["app"],
                                                       settings["logging"].exists("path") ? settings["logging"]["path"] : "");
    std::shared_ptr<spdlog::logger> loggerServer = logger->clone(logger->name() + "-ua-server");
    fortiss::log::LoggerFactory::setLoggerLevel(loggerServer, settings["logging"]["level"]["opcua"]);
    std::shared_ptr<spdlog::logger> loggerClient = logger->clone(logger->name() + "-ua-reg");
    fortiss::log::LoggerFactory::setLoggerLevel(loggerClient, settings["logging"]["level"]["opcua"]);

    try {
        logger->info("Starting Gripper Robotiq 2F ...");
        if (!run_opcua((UA_UInt16) ((int) settings["opcua"]["port"]), &running, true, logger, loggerServer, loggerClient)) {
            logger->error("Could not start schmalz-ecbpi opcua");
            return EXIT_FAILURE;
        }
    }
    catch (const libconfig::SettingNotFoundException& nfex) {
        logger->error("Setting missing in configuration file {}. {} in {}", nfex.getPath(), nfex.what());
        logger->flush();
        return (EXIT_FAILURE);
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize gripper control. {} ", rex.what());
        logger->flush();
        return EXIT_FAILURE;
    }

    spdlog::shutdown();
    return EXIT_SUCCESS;
}