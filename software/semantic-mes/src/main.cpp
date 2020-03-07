//
// Created by profanter on 11/29/18.
// Copyright (c) 2018 fortiss GmbH. All rights reserved.
//

#include <memory>
#include <chrono>

#include <spdlog/spdlog.h>
#include "CLI/CLI.hpp"
#include "libconfig.h++"

#include <common/logging.h>
#include <common/logging_opcua.h>
#include <common/opcua/helper.hpp>
#include <pnp-demo/PnpSemanticMes.h>

#include "SemanticMes.h"

std::shared_ptr<spdlog::logger> logger;

bool running = true;

static void stopHandler(int) {
    running = false;
    logger->warn("Received Ctrl-C. Shutting down...");
}

static void
registerServerCallback(
        const UA_RegisteredServer* registeredServer,
        void* data
) {
    auto mes = static_cast<SemanticMes*>(data);
    mes->onRegisterServer(registeredServer);
}

//#define AUTOSTART

int main(
        int argc,
        char* argv[]
) {


    // ------------- General initialization -------------------

    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);


    CLI::App app{"Semantic MES"};

    std::string configFile = "component.cfg";
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

    logger = fortiss::log::get("mes");

    UA_ServerConfig uaServerConfig;
    UA_Server* uaServer = nullptr;

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
            logger->error("Encryption is enabled but no certificates are given. Use --certs command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting Semantic MES ...");

        // ------------- OPC UA initialization -------------------
        if (fortiss::opcua::initServerConfig(
                loggerServer,
                &uaServerConfig,
                "fortiss.component.mes",
                "fortiss - MES",
                (UA_UInt16) ((int) settings["opcua"]["port"]),
                settings["opcua"]["encryption"],
                settings["opcua"]["anonymous"],
                certFiles) != UA_STATUSCODE_GOOD) {
            return EXIT_FAILURE;
        }
        //UA_String hostname = UA_STRING_ALLOC("10.200.2.2");
        //UA_ServerConfig_setCustomHostname(&uaServerConfig, hostname);

        uaServer = UA_Server_newWithConfig(&uaServerConfig);
        if (!uaServer) {
            logger->error("Can not create server instance");
            return EXIT_FAILURE;
        }


        std::string clientCert = clientCertFiles + "_cert.der";
        std::string clientKey = clientCertFiles + "_key.der";

        std::shared_ptr<PnpSemanticMes> semanticMES = std::make_shared<PnpSemanticMes>(
                logger, uaServer, clientCert, clientKey, settings["pnpdemo"]);

        UA_StatusCode retval = UA_Server_run_startup(uaServer);
        if (retval != UA_STATUSCODE_GOOD) {
            throw std::runtime_error("Starting up the server failed with " + std::string(UA_StatusCode_name(retval)));
        }

        const fortiss::opcua::serverOnNetworkCallbackData onLdsData = {
                .filterServerName = "",
                .callbackOnAnnounceOnly = false,
                .onServerAnnounce = [&semanticMES]
                        (
                                const UA_ServerOnNetwork* serverOnNetwork,
                                UA_Boolean isServerAnnounce
                        ) {
                    semanticMES->onServerAnnounce(serverOnNetwork, isServerAnnounce);
                }
        };
        fortiss::opcua::UA_Server_onServerAnnounce(uaServer, onLdsData);
        UA_Server_setRegisterServerCallback(uaServer, &registerServerCallback, (void*) semanticMES.get());

        semanticMES->start();

        //std::shared_ptr<SparqlJsonParser> sparqlJsonParser = std::make_shared<SparqlJsonParser>(logger);
        /* // quick testing of JSON parser 
        std::shared_ptr<JsonParserTests> jsonParserTests = std::make_shared<JsonParserTests>(logger, sparqlJsonParser);
        jsonParserTests->runTests(); */
        //UA_Server_run_iterate(uaServer, false);

#ifdef AUTOSTART
        std::chrono::steady_clock::time_point begin = std::chrono::steady_clock::now();
        bool started = false;
#endif

        while (running) {
            UA_Server_run_iterate(uaServer, false);
            std::this_thread::yield();
            std::this_thread::sleep_for(std::chrono::milliseconds(1));

            #ifdef AUTOSTART
            if (!started) {
                std::chrono::steady_clock::time_point end = std::chrono::steady_clock::now();
                if (std::chrono::duration_cast<std::chrono::seconds>(end - begin).count() > 7) {

                    started = true;
                    std::thread t = std::thread([semanticMES]() {

                         semanticMES->startDemoExecution();

                    });
                    t.detach();


                }
            }
            #endif
        }

    }
    catch (const libconfig::SettingNotFoundException& nfex) {
        logger->error("Setting missing in configuration file. {} -> {}", nfex.what(), nfex.getPath());
        logger->flush();
        return (EXIT_FAILURE);
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize sMES control. {} ", rex.what());
        logger->flush();

        exitCode = EXIT_FAILURE;
    }

    if (uaServer)
        UA_Server_run_shutdown(uaServer);


    UA_Server_delete(uaServer);

    logger->flush();
    return exitCode;
}