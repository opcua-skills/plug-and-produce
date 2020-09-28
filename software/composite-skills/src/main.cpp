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
#include "CLI/CLI.hpp"
#include "libconfig.h++"

#include <common/logging.h>
#include <common/logging_opcua.h>
#include <common/opcua/helper.hpp>

#include "CompositeSkills.h"

std::shared_ptr<spdlog::logger> logger;

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


    CLI::App app{"Composite Skills Server"};

    std::string configFile = "component.cfg";
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

    logger = fortiss::log::LoggerFactory::createLogger("software/composite-skills",
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
            logger->error("Encryption is enabled but no certificates are given. Use --certs command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting Composite Skills ...");

        uaServer = std::make_shared<fortiss::opcua::OpcUaServer>(
                settings,
                logger,
                "fortiss.component.software.composite-skills",
                "fortiss - Software - Composite Skills",
                certFiles,
                "fortiss.component.software.composite-skills.client",
                "fortiss - Software - Composite Skills - Client",
                clientCertFiles);


        std::string clientCert = clientCertFiles + "_cert.der";
        std::string clientKey = clientCertFiles + "_key.der";


        std::shared_ptr<spdlog::logger> loggerUa = logger->clone(logger->name() + "-ua");
        fortiss::log::LoggerFactory::setLoggerLevel(loggerUa, settings["logging"]["level"]["opcua"]);

        std::shared_ptr<CompositeSkills> compositeSkills = std::make_shared<CompositeSkills>(
                logger, loggerUa, uaServer, settings["composite_skills"], clientCert, clientKey,
                "fortiss.component.software.composite-skills",
                "fortiss - Software - Composite Skills");

        if (uaServer->init(
                true,
                std::bind(&CompositeSkills::onServerAnnounce, compositeSkills, std::placeholders::_1, std::placeholders::_1)
        ) == UA_STATUSCODE_GOOD) {

            while (running) {
                uaServer->iterate();
                std::this_thread::yield();
                std::this_thread::sleep_for(std::chrono::milliseconds(1));
            }
        }

    }
    catch (const libconfig::SettingNotFoundException& nfex) {
        logger->error("Setting missing in configuration file. {} -> {}", nfex.what(), nfex.getPath());
        logger->flush();
        exitCode = EXIT_FAILURE;
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize component. {} ", rex.what());
        logger->flush();
        exitCode = EXIT_FAILURE;
    }
    uaServer.reset();

    spdlog::shutdown();
    return exitCode;
}
