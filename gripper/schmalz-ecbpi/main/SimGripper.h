//
// Created by profanter on 21/01/2020.
// Copyright (c) 2020 fortiss GmbH. All rights reserved.
//

#ifndef SCHMALZ_ECBPI_SIMGRIPPER_H
#define SCHMALZ_ECBPI_SIMGRIPPER_H

#include <cstdint>

class SimGripper {

public:
    explicit SimGripper(uint8_t clientId, uint8_t portIndex) {};

    bool startVaccum();
    bool stopVaccum();
    bool dropOff();

};


#endif //SCHMALZ_ECBPI_SIMGRIPPER_H
