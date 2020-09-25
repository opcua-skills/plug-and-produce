/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

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
