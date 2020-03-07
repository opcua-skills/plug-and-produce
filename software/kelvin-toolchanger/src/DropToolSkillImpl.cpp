//
// Created by profanter on 17/12/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#include "DropToolSkillImpl.h"

#include "KelvinToolchanger.h"

using namespace fortiss::kelvin_toolchanger;

DropToolSkillImpl::DropToolSkillImpl(std::shared_ptr<spdlog::logger> logger, KelvinToolchanger *kelvinToolchanger) :
        logger(std::move(logger)), kelvinToolchanger(kelvinToolchanger) {

}

DropToolSkillImpl::~DropToolSkillImpl() {
}


bool DropToolSkillImpl::start() {

    if (kelvinToolchanger->getToolState() == KELVIN_INTERMEDIATE) {
        logger->error("Cannot start tool drop while tool changer is in intermediate state! Reset it manually.");
        return false;
    }



    std::thread t = std::thread([this]() {

        UA_StatusCode result = kelvinToolchanger->dropCurrentTool();

        auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::steady_clock::now() - skillStartTime);

        logger->info("Dropping tool took {} ms", duration.count());

        if (result != UA_STATUSCODE_GOOD) {
            this->dropErrored();
        }
        else
            this->dropFinished();
    });
    t.detach();

    skillStartTime = std::chrono::steady_clock::now();
    return true;
};
