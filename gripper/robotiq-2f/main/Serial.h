//
// Created by profanter on 12/11/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef ROBOTIQ_2F_SERIAL_H
#define ROBOTIQ_2F_SERIAL_H

#include <string>
#include <utility>
#include "driver/uart.h"

class Serial {

public:

    explicit Serial();
    virtual ~Serial() = default;

    bool isConnected() const;

    virtual void open();
    virtual void close();


    virtual ::std::size_t read(void* buf, const ::std::size_t& count);
    virtual ::std::size_t write(const void* buf, const ::std::size_t& count);

protected:
    void setConnected(const bool& connected);

private:
    bool connected;
    uart_config_t uart_config;
};


#endif //ROBOTIQ_2F_SERIAL_H
