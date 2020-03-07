//
// Created by profanter on 21/01/2020.
// Copyright (c) 2020 fortiss GmbH. All rights reserved.
//

#ifndef SCHMALZ_ECBPI_SIMGRIPPER_H
#define SCHMALZ_ECBPI_SIMGRIPPER_H

#include <cstdint>
#include <rl/math/Real.h>
#include <string>

class SimGripper {

public:
    explicit SimGripper(const std::string& port) {};

    void setForcePercentage(rl::math::Real real);

    void setSpeedPercentage(rl::math::Real d);

    void setPositionPercentage(double i);

    void open();
    void close();

    void start();
    void stop();

    void step();

    const std::chrono::milliseconds getUpdateRate();
};


#endif //SCHMALZ_ECBPI_SIMGRIPPER_H
