//
// Created by profanter on 07/08/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#include "ExecuteProcessSkillImpl.h"
#include "SemanticMes.h"

using namespace fortiss::semantic_mes;

ExecuteProcessSkillImpl::ExecuteProcessSkillImpl(std::shared_ptr<spdlog::logger> logger, SemanticMes *semanticMes) :
        logger(std::move(logger)), semanticMes(semanticMes) {

}

ExecuteProcessSkillImpl::~ExecuteProcessSkillImpl() {
}


bool ExecuteProcessSkillImpl::start(const std::string& abstractProcessIri,
                                    const std::string& executionMode) {
    std::thread t = std::thread([this, abstractProcessIri, executionMode]() {
        logger->info("Start Process Exeuction: {} with exeuction mode {}",
                     abstractProcessIri, executionMode);

        UA_StatusCode result = semanticMes->startExecution(abstractProcessIri, executionMode);
        if (result != UA_STATUSCODE_GOOD) {
            this->executionErrored();
        }
        else
            this->executionFinished();
    });
    t.detach();

    skillStartTime = std::chrono::steady_clock::now();
    return true;
};

