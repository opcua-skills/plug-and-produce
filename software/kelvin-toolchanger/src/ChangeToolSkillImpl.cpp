/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include "ChangeToolSkillImpl.h"

#include "KelvinToolchanger.h"

using namespace fortiss::kelvin_toolchanger;

ChangeToolSkillImpl::ChangeToolSkillImpl(std::shared_ptr<spdlog::logger> logger, KelvinToolchanger *kelvinToolchanger) :
        logger(std::move(logger)), kelvinToolchanger(kelvinToolchanger) {

}

ChangeToolSkillImpl::~ChangeToolSkillImpl() {
}


bool ChangeToolSkillImpl::start(const UA_ThreeDFrame& toolPosition, const std::string& expectedToolAppUri) {

    if (kelvinToolchanger->getToolState() == KELVIN_INTERMEDIATE) {
        logger->error("Cannot start tool change while tool changer is in intermediate state! Reset it manually.");
        return false;
    }

    auto *frameCopy = (UA_ThreeDFrame *)UA_ThreeDFrame_new();
    UA_ThreeDFrame_init(frameCopy);
    UA_ThreeDFrame_copy(&toolPosition, frameCopy);

    std::thread t = std::thread([this, frameCopy, expectedToolAppUri]() {

        UA_StatusCode result = kelvinToolchanger->takeToolAtPosition(frameCopy, expectedToolAppUri);
        UA_ThreeDFrame_delete(frameCopy);

        auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(std::chrono::steady_clock::now() - skillStartTime);

        logger->info("Changing tool took {} ms. Result: {}", duration.count(), UA_StatusCode_name(result));

        if (result != UA_STATUSCODE_GOOD) {
            this->changeErrored();
        }
        else
            this->changeFinished();
    });
    t.detach();

    skillStartTime = std::chrono::steady_clock::now();
    return true;
};
