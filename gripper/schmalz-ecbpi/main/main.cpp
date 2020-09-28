/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include <esp_wifi.h>
#include <esp_event.h>
#include <esp_log.h>
#include <esp_system.h>
#include <sys/param.h>
#include <nvs_flash.h>

#include <stdio.h>
#include "sdkconfig.h"
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "esp_system.h"
#include "driver/uart.h"
#include "esp_log.h"

#include "esp_netif.h"
#include "ethernet_helper.h"

#include "TinyPico.h"

#ifdef CONFIG_IDF_TARGET_ESP32
#define CHIP_NAME "ESP32"
#endif

#ifdef CONFIG_IDF_TARGET_ESP32S2BETA
#define CHIP_NAME "ESP32-S2 Beta"
#endif

#ifndef UA_ARCHITECTURE_FREERTOSLWIP
#error UA_ARCHITECTURE_FREERTOSLWIP needs to be defined
#endif

#include <open62541.h>
#include <sstream>


#include <spdlog/spdlog.h>
#include <common/logging.h>
#include <esp_task_wdt.h>
#include <esp_sntp.h>
#include <iolma_ll_hsal_esp32.h>
#include <iolma_ll_hsal.h>
#include <iolma_hl_srvl.h>
#include <esp_sleep.h>

#include "opcua_task.hpp"

extern "C" {
    void app_main(void);
}

static const char *TAG = "ECBPI_APP";
static const char *TAG_IO = "IO-Link";

static bool serverCreated = false;


#define IOLMA_DEMOAPP_CLIENT_ID     0u      /*!< ID of the client who will use the IOLMA HL services */
#define IOLMA_HL_DEMOAPP_PRINTF(...) ESP_LOGI(TAG_IO, __VA_ARGS__)
#define COMM_TASK_PRIORITY ESP_TASK_PRIO_MAX
//ESP_TASK_TCPIP_PRIO + 1
#define OPCUA_TASK_PRIORITY ESP_TASK_MAIN_PRIO

/* Variable holding number of times ESP32 restarted since first boot.
 * It is placed into RTC memory using RTC_DATA_ATTR and
 * maintains its value when ESP32 wakes from deep sleep.
 */
RTC_DATA_ATTR static int boot_count = 0;

volatile bool running = true;


static E_IOLMA_PERIPHERAL_t e_comm_peripheral = E_IOLMA_PERIPHERAL_UNKNOWN;

void deinitIolink() {
    ESP_LOGW(TAG_IO, "Deinitializing IO Link");
    iolma_hl_srvl_comm_peripheral_terminate(IOLMA_DEMOAPP_CLIENT_ID, e_comm_peripheral);
    iolma_hl_srvl_terminate(IOLMA_DEMOAPP_CLIENT_ID);
    delete ioLinkGripper;
}

static void opcua_task(void *arg) {

    ESP_ERROR_CHECK(esp_task_wdt_add(NULL));

    ESP_LOGI(TAG_OPC, "Initializing OPC UA. Free Heap: %d bytes", xPortGetFreeHeapSize());

    if (!run_opcua(4840, &running, false)) {
        tinyPico->DotStar_SetPixelColor(255, 0, 0);
        return;
    }

    ioLinkGripper->stopGripper();
    // let io-link do some cycles
    for (size_t i=0; i<100; i++) {
        UA_sleep_ms(1);
        std::this_thread::yield();
    }

    deinitIolink();
    ESP_LOGW(TAG_OPC, "Shutdown finished. Going into endless loop");
    tinyPico->DotStar_SetPixelColor(255, 0, 255);

    ESP_ERROR_CHECK(esp_task_wdt_delete(NULL));

    while (true) {
        sleep(100000);
    }
    esp_deep_sleep_start();
}


static void disconnect_handler(void* arg, esp_event_base_t event_base,
                               int32_t event_id, void* event_data)
{
    /* UA_Server *server = *(UA_Server**) arg;
    if (server) {
        ESP_LOGI(TAG, "Stopping webserver");
        stop_webserver(*server);
        *server = NULL;
    }*/
}

void time_sync_notification_cb(struct timeval *tv)
{
    ESP_LOGI(TAG, "Notification of a time synchronization event");
}

static void initialize_sntp(void)
{
    ESP_LOGI(TAG, "Initializing SNTP");
    sntp_setoperatingmode(SNTP_OPMODE_POLL);
    sntp_setservername(0, "pool.ntp.org");
    sntp_set_time_sync_notification_cb(time_sync_notification_cb);
    sntp_init();
}

static void obtain_time(void)
{
    initialize_sntp();

    ESP_ERROR_CHECK(esp_task_wdt_add(NULL));
    // wait for time to be set
    time_t now = 0;
    struct tm timeinfo;
    memset(&timeinfo, 0, sizeof(struct tm));
    int retry = 0;
    const int retry_count = 10;
    while (sntp_get_sync_status() == SNTP_SYNC_STATUS_RESET && ++retry < retry_count) {
        ESP_LOGI(TAG, "Waiting for system time to be set... (%d/%d)", retry, retry_count);
        vTaskDelay(2000 / portTICK_PERIOD_MS);
        ESP_ERROR_CHECK(esp_task_wdt_reset());
    }
    time(&now);
    localtime_r(&now, &timeinfo);
    ESP_ERROR_CHECK(esp_task_wdt_delete(NULL));
}

static void connect_handler(void* arg, esp_event_base_t event_base,
                            int32_t event_id, void* event_data)
{
    ESP_LOGI(TAG, "WIFI Connected");

    tinyPico->DotStar_SetPixelColor(0, 255, 255);

    time_t now;
    struct tm timeinfo;
    time(&now);
    localtime_r(&now, &timeinfo);
    // Is time set? If not, tm_year will be (1970 - 1900).
    if (timeinfo.tm_year < (2016 - 1900)) {
        ESP_LOGI(TAG, "Time is not set yet. Connecting to WiFi and getting time over NTP.");
        obtain_time();
        // update 'now' variable with current time
        time(&now);
    }

    tinyPico->DotStar_SetPixelColor(255, 255, 0);
    if (!serverCreated) {
        ESP_LOGI(TAG, "Starting OPC UA Task");
        xTaskCreate(opcua_task, "opcua_task", 26624, NULL, OPCUA_TASK_PRIORITY, NULL);
        serverCreated = true;
    }
}


static void port_event_callback(uint8_t iol_port, s_iolma_event_t s_occurred_event)
{
    (void)iol_port;
    (void)s_occurred_event;
    //printf("Port event occurred on port %d", iol_port);
} /* port_event_callback */



static void device_event_callback(uint8_t iol_port, s_iolma_event_t s_occurred_event)
{
    (void)s_occurred_event;
    iolma_hl_srvl_device_event_rsp(IOLMA_DEMOAPP_CLIENT_ID, iol_port);

    //ioLinkGripper->pushEvent(s_occurred_event);
    //printf("Device event occurred on port %d", iol_port);
    // /* normally, code like this should not appear in this callback... this printf is just for demo purposes */
} /* device_event_callback */



static void master_com_lost_callback(E_IOLMA_RET_t e_reason, uint16_t max_processing_time_in_ten_us)
{
    (void)max_processing_time_in_ten_us;
    IOLMA_HL_DEMOAPP_PRINTF("Lost communication with the IO-Link Master, because ");

    switch(e_reason)
    {
        case E_IOLMA_RET_OK:                              { IOLMA_HL_DEMOAPP_PRINTF("the user has stopped the cyclic communication with the IO-Link Master.");                                                                break; }
        case E_IOLMA_RET_ERROR_TOO_MANY_LOST_TELEGRAMS:   { IOLMA_HL_DEMOAPP_PRINTF("too many wrong telegrams or no telegrams were received from the IO-Link Master.");                                                       break; }
        case E_IOLMA_RET_ERROR_COMM_CYCLE_TIME_TOO_SMALL: { IOLMA_HL_DEMOAPP_PRINTF("the communication cycle time was too small. Increase the communication cycle time with respect to the maximum processing time!"); break; }
        default:                                          { IOLMA_HL_DEMOAPP_PRINTF("of an unknown reason.");                                                                                                                 break; }
    }

    IOLMA_HL_DEMOAPP_PRINTF("Press q and enter to terminate the application!");
} /* master_com_lost_callback */


static
bool initIolink() {
    static s_iolma_uart_config_t s_comm_uart_config;
    static void *p_s_comm_peripheral_config;
    static uint16_t comm_cycle_time_in_ten_us;
    static E_IOLMA_BOOL_t e_b_comm_interleaved;

    s_comm_uart_config.baud_rate = 115200ul;
    s_comm_uart_config.uart_port = UART_NUM_1;
    s_comm_uart_config.rx_io_num = 21;
    s_comm_uart_config.tx_io_num = 22;
    s_comm_uart_config.rts_io_num = 32; // not used
    s_comm_uart_config.cts_io_num = 33; // not used

    p_s_comm_peripheral_config = &s_comm_uart_config;
    e_comm_peripheral = E_IOLMA_PERIPHERAL_UART;

    comm_cycle_time_in_ten_us = 370;
    e_b_comm_interleaved = E_IOLMA_BOOL_FALSE;

    static uint8_t standard_comm_task_buffer[IOLMA_REQUEST_AND_RESPONSE_MAX_LENGTH];
    static uint8_t interleaved_comm_task_buffer[IOLMA_REQUEST_AND_RESPONSE_MAX_LENGTH];

    if (iolma_ll_hsal_timer_configure(NULL) != E_IOLMA_RET_OK) {
        IOLMA_HL_DEMOAPP_PRINTF("Failed to initialize the High-Level Timer...");
        return false;
    }

    IOLMA_HL_DEMOAPP_PRINTF("Initializing the High-Level IO-Link Master Access service layer... ");
    E_IOLMA_RET_t ret = iolma_hl_srvl_init(IOLMA_DEMOAPP_CLIENT_ID, standard_comm_task_buffer, sizeof(standard_comm_task_buffer),
            interleaved_comm_task_buffer, sizeof(interleaved_comm_task_buffer), master_com_lost_callback, device_event_callback, port_event_callback);
    if(ret != E_IOLMA_RET_OK)
    {
        IOLMA_HL_DEMOAPP_PRINTF("Failed to initialize the High-Level IO-Link Master Access service layer: %d", ret);
        return false;
    }

    IOLMA_HL_DEMOAPP_PRINTF("OK");
    IOLMA_HL_DEMOAPP_PRINTF("Configuring the communication peripheral... ");
    if(iolma_hl_srvl_comm_peripheral_configure(IOLMA_DEMOAPP_CLIENT_ID, e_comm_peripheral, p_s_comm_peripheral_config) != E_IOLMA_RET_OK)
    {
        IOLMA_HL_DEMOAPP_PRINTF("Failed to configure the communication peripheral...");
        iolma_hl_srvl_terminate(IOLMA_DEMOAPP_CLIENT_ID);
        return false;
    }

    IOLMA_HL_DEMOAPP_PRINTF("OK");
    IOLMA_HL_DEMOAPP_PRINTF("Connecting to the IO-Link Master... ");
    if(iolma_hl_srvl_connect_to_master(IOLMA_DEMOAPP_CLIENT_ID, e_comm_peripheral) != E_IOLMA_RET_OK) {
        IOLMA_HL_DEMOAPP_PRINTF("Failed to connect to the IO-Link Master...");
        iolma_hl_srvl_comm_peripheral_terminate(IOLMA_DEMOAPP_CLIENT_ID, e_comm_peripheral);
        iolma_hl_srvl_terminate(IOLMA_DEMOAPP_CLIENT_ID);
        return false;
    }

    IOLMA_HL_DEMOAPP_PRINTF("OK");
    IOLMA_HL_DEMOAPP_PRINTF("Starting %s communication with the IO-Link Master, the cycle time is %d microseconds... ", (e_b_comm_interleaved == E_IOLMA_BOOL_FALSE) ? ("standard") : ("interleaved"), comm_cycle_time_in_ten_us * 10u);


    static uint8_t pcpda_port_priorities[IOLMA_MAX_NUMBER_OF_MASTER_PORTS];
    for(size_t i = 0u; i < sizeof(pcpda_port_priorities); i++)
    {
        pcpda_port_priorities[i] = (uint8_t)(sizeof(pcpda_port_priorities) - i - 1u);
    }

    if(iolma_hl_srvl_start_communication(IOLMA_DEMOAPP_CLIENT_ID, COMM_TASK_PRIORITY, comm_cycle_time_in_ten_us, e_b_comm_interleaved, E_IOLMA_BOOL_FALSE, 0u, 0u, pcpda_port_priorities) != E_IOLMA_RET_OK) {
        IOLMA_HL_DEMOAPP_PRINTF("Failed to start cyclic communication with the IO-Link Master...");
        iolma_hl_srvl_comm_peripheral_terminate(IOLMA_DEMOAPP_CLIENT_ID, e_comm_peripheral);
        iolma_hl_srvl_terminate(IOLMA_DEMOAPP_CLIENT_ID);
        return false;
    }

    IOLMA_HL_DEMOAPP_PRINTF("OK");

    ioLinkGripper = new IoLinkGripper(IOLMA_DEMOAPP_CLIENT_ID, 0);
    if (!ioLinkGripper->startGripper()) {
        ESP_LOGE(TAG, "Could not initialize IO Link Gripper");
        return false;
    }

    return true;
}

void app_main(void)
{
    ++boot_count;
    ESP_LOGI(TAG, "Boot count: %d", boot_count);

    /* Print chip information */
    esp_chip_info_t chip_info;
    esp_chip_info(&chip_info);
    printf("This is %s chip with %d CPU cores, WiFi%s%s, ",
           CHIP_NAME,
           chip_info.cores,
           (chip_info.features & CHIP_FEATURE_BT) ? "/BT" : "",
           (chip_info.features & CHIP_FEATURE_BLE) ? "/BLE" : "");

    spi_flash_init();

    printf("silicon revision %d, ", chip_info.revision);

    printf("%dMB %s flash\n", spi_flash_get_chip_size() / (1024 * 1024),
           (chip_info.features & CHIP_FEATURE_EMB_FLASH) ? "embedded" : "external");

    printf("Heap Info:\n");
    printf("\tInternal free: %d bytes\n", heap_caps_get_free_size(MALLOC_CAP_INTERNAL));
    printf("\tSPI free: %d bytes\n", heap_caps_get_free_size(MALLOC_CAP_SPIRAM));
    printf("\tDefault free: %d bytes\n", heap_caps_get_free_size(MALLOC_CAP_DEFAULT));
    printf("\tAll free: %d bytes\n", xPortGetFreeHeapSize());


    //static UA_Server *server = NULL;

    ESP_ERROR_CHECK(nvs_flash_init());
    esp_netif_init();
    ESP_ERROR_CHECK(esp_event_loop_create_default());


    tinyPico = new TinyPICO();

    tinyPico->DotStar_SetPixelColor(0, 0, 128);


    ESP_ERROR_CHECK(esp_task_wdt_init(30, true));
    // Remove idle tasks from watchdog
    ESP_ERROR_CHECK(esp_task_wdt_delete(xTaskGetIdleTaskHandleForCPU(0)));
    ESP_ERROR_CHECK(esp_task_wdt_delete(xTaskGetIdleTaskHandleForCPU(1)));

    if (!initIolink()) {
        tinyPico->DotStar_SetPixelColor(255, 0, 0);
        return;
    }

    /* Register event handlers to stop the server when Wi-Fi or Ethernet is disconnected,
     * and re-start it upon connection.
     */
#ifdef CONFIG_ETHERNET_HELPER_WIFI
    ESP_ERROR_CHECK(esp_event_handler_register(IP_EVENT, IP_EVENT_STA_GOT_IP, &connect_handler, NULL));
    ESP_ERROR_CHECK(esp_event_handler_register(WIFI_EVENT, WIFI_EVENT_STA_DISCONNECTED, &disconnect_handler, NULL));
#endif // CONFIG_ETHERNET_HELPER_WIFI
#ifdef CONFIG_ETHERNET_HELPER_ETHERNET
    ESP_ERROR_CHECK(esp_event_handler_register(IP_EVENT, IP_EVENT_ETH_GOT_IP, &connect_handler, &server));
    ESP_ERROR_CHECK(esp_event_handler_register(ETH_EVENT, ETHERNET_EVENT_DISCONNECTED, &disconnect_handler, &server));
#endif // CONFIG_ETHERNET_HELPER_ETHERNET

    /* This helper function configures Wi-Fi or Ethernet, as selected in menuconfig.
     * Read "Establishing Wi-Fi or Ethernet Connection" section in
     * examples/protocols/README.md for more information about this function.
     */
    ESP_ERROR_CHECK(ethernet_helper_connect());

    ESP_LOGI(TAG, "Waiting for wifi connection. OnConnect will start OPC UA...");

    //A uart read/write example without event queue;
    //xTaskCreate(serial_task, "uart_serial_task", RS485_TASK_STACK_SIZE, NULL, RS485_TASK_PRIO, NULL);

    //opcua_task(NULL);

    /*if(NULL == sys_thread_new("opcua_thread", opcua_task, NULL, 8000, 8))
        ESP_LOGE(TAG,"opcua(): Task creation failed.");*/

    /*for (int i = 10; i >= 0; i--) {
        printf("Restarting in %d seconds...\n", i);
        vTaskDelay(1000 / portTICK_PERIOD_MS);
    }
    printf("Restarting now.\n");
    fflush(stdout);
    esp_restart();*/

}