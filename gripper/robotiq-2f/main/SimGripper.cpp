/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include <chrono>
#include "SimGripper.h"


void SimGripper::setSpeedPercentage(rl::math::Real d) {

}

void SimGripper::setForcePercentage(rl::math::Real real) {

}

void SimGripper::setPositionPercentage(double i) {

}

void SimGripper::open() {

}

void SimGripper::close() {

}

void SimGripper::start() {

}


void SimGripper::stop() {

}

void SimGripper::step() {

}

const std::chrono::milliseconds SimGripper::getUpdateRate() {
    return std::chrono::milliseconds(8);
}
