//
// Created by profanter on 01/21/20.
// Copyright (c) 2020 fortiss GmbH. All rights reserved.
//

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
    running = false;
    logger->warn("Received Ctrl-C. Shutting down...");
}



int main(int argc, char *argv[]) {


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
    catch (const libconfig::FileIOException &fioex) {
        std::cerr << "I/O error while reading configuration file." << fioex.what() << std::endl;
        #ifdef USE_RASPI
        ledDaemonClient.setStatus(LedColor::RED, LedStatus::BLINK);
        #endif
        return (EXIT_FAILURE);
    }
    catch (const libconfig::ParseException &pex) {
        std::cerr << "Configuration file parse error at " << pex.getFile() << ":" << pex.getLine()
                  << " - " << pex.getError() << std::endl;
        #ifdef USE_RASPI
        ledDaemonClient.setStatus(LedColor::RED, LedStatus::BLINK);
        #endif
        return (EXIT_FAILURE);
    }
    const libconfig::Setting &settings = cfg.getRoot();


    logger = fortiss::log::get("gripper/robotiq2f");


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

        logger->info("Starting Gripper Robotiq 2F ...");
        if (!run_opcua((UA_UInt16) ((int) settings["opcua"]["port"]), &running, true)) {
            logger->error("Could not start schmalz-ecbpi opcua");
            return EXIT_FAILURE;
        }
    }
    catch (const libconfig::SettingNotFoundException &nfex) {
        logger->error("Setting missing in configuration file {}. {} in {}",nfex.getPath(), nfex.what());
        logger->flush();
        return (EXIT_FAILURE);
    }
    catch (const std::runtime_error &rex) {
        logger->critical("Could not initialize gripper control. {} ", rex.what());
        logger->flush();
        return EXIT_FAILURE;
    }

    return EXIT_SUCCESS;
}