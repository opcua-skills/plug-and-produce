//
// Created by profanter on 12/11/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#include "Serial.h"
#include "esp_log.h"

// Use UART2.
#define RS_485_RXD2 21 //RX2 pin
#define RS_485_TXD2 22 //TX2 pin
#define RS_485_RTS 32 // DE and /RE pin

// CTS is not used in RS485 Half-Duplex Mode
#define RS_485_CTS  UART_PIN_NO_CHANGE

#define BUF_SIZE        (127)
#define BAUD_RATE       (115200)

// Read packet timeout
#define PACKET_READ_TICS        (10 / portTICK_RATE_MS)
#define RS485_TASK_STACK_SIZE    (2048)
#define RS485_TASK_PRIO          (10)
#define RS485_UART_PORT          UART_NUM_1


static const char *LOG_TAG = "RS485";

Serial::Serial(): connected(false) {
    uart_config_t uart_config = {
            .baud_rate = BAUD_RATE,
            .data_bits = UART_DATA_8_BITS,
            .parity = UART_PARITY_DISABLE,
            .stop_bits = UART_STOP_BITS_1,
            .flow_ctrl = UART_HW_FLOWCTRL_DISABLE,
            .rx_flow_ctrl_thresh = 122,
            .use_ref_tick = false
    };


    uart_param_config(RS485_UART_PORT, &uart_config);
    uart_set_pin(RS485_UART_PORT, RS_485_TXD2, RS_485_RXD2, RS_485_RTS, RS_485_CTS);
}


bool
Serial::isConnected() const
{
    return this->connected;
}

void
Serial::setConnected(const bool& connected)
{
    this->connected = connected;
}

void Serial::open() {
    // Install UART driver (we don't need an event queue here)
    // In this example we don't even use a buffer for sending data.
    uart_driver_install(RS485_UART_PORT, BUF_SIZE * 2, 0, 0, NULL, 0);
    uart_set_mode(RS485_UART_PORT, UART_MODE_RS485_HALF_DUPLEX);
}

void Serial::close() {
    uart_driver_delete(RS485_UART_PORT);
}

::std::size_t Serial::read(void *buf, const ::std::size_t& count) {

    int bytes = uart_read_bytes(RS485_UART_PORT, (uint8_t *)buf, count, PACKET_READ_TICS);
    if (bytes > 0) {
        /*ESP_LOGI(LOG_TAG, "Received %u bytes:", bytes);
        printf("[ ");
        for (int i = 0; i < bytes; i++) {
            printf("0x%.2X ", (uint8_t)((uint8_t *)buf)[i]);
        }
        printf("] \n");*/
        return bytes;
    } else if (bytes < 0) {
        ESP_LOGE(LOG_TAG, "uart_read_bytes < 0");
    }
    return 0;
}

::std::size_t Serial::write(const void *buf, const ::std::size_t& count) {
    //int bytes = uart_write_bytes(RS485_UART_PORT, (const char *)buf, count);
    int bytes = uart_tx_chars(RS485_UART_PORT, (const char *)buf, count);

    ESP_ERROR_CHECK(uart_wait_tx_done(RS485_UART_PORT, 100));
    /*ESP_LOGI(LOG_TAG, "Written %u bytes:", bytes);
    printf("[ ");
    for (int i = 0; i < bytes; i++) {
        printf("0x%.2X ", (uint8_t)((uint8_t *)buf)[i]);
    }
    printf("] \n");*/
    return bytes;
}
