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


#include <rl/hal/RobotiqModelC.h>
#include <sstream>
#include <rl/math/Real.h>


#include <spdlog/spdlog.h>
#include <common/logging.h>
#include <esp_task_wdt.h>
#include <esp_sntp.h>
#include <robotiq_2f_nodeids.h>
#include "namespace_di_generated.h"
#include "di_nodeids.h"
#include "namespace_fortiss_device_generated.h"
#include "namespace_robotiq_2f_generated.h"

#include "GripperOPCUA.h"
#include "opcua_task.hpp"

// Use UART2.
#define RS_485_RXD2 16 //RX2 pin
#define RS_485_TXD2 17 //TX2 pin
#define RS_485_RTS 21 // DE and /RE pin

// CTS is not used in RS485 Half-Duplex Mode
#define RS_485_CTS  UART_PIN_NO_CHANGE

#define BUF_SIZE        (127)
#define BAUD_RATE       (115200)

// Read packet timeout
#define PACKET_READ_TICS        (100 / portTICK_RATE_MS)
#define RS485_TASK_STACK_SIZE    (16384)
#define RS485_TASK_PRIO          (10)
#define RS485_UART_PORT          UART_NUM_2

#define fortiss_LDS_URI "fortiss.component.mes"

extern "C" {
    void app_main(void);
}

static const char *TAG = "RS485_APP";

static bool serverCreated = false;

#define OPCUA_TASK_PRIORITY ESP_TASK_TCPIP_PRIO -1

/* Variable holding number of times ESP32 restarted since first boot.
 * It is placed into RTC memory using RTC_DATA_ATTR and
 * maintains its value when ESP32 wakes from deep sleep.
 */
RTC_DATA_ATTR static int boot_count = 0;

volatile bool running = true;

static void opcua_task(void *arg) {

    ESP_ERROR_CHECK(esp_task_wdt_add(NULL));

    ESP_LOGI(TAG_OPC, "Initializing OPC UA. Free Heap: %d bytes", xPortGetFreeHeapSize());

    if (!run_opcua(4840, &running, false)) {
        tinyPico->DotStar_SetPixelColor(255, 0, 0);
        return;
    }

    ESP_LOGW(TAG_OPC, "Shutdown finished. Going into endless loop");
    tinyPico->DotStar_SetPixelColor(255, 0, 255);

    ESP_ERROR_CHECK(esp_task_wdt_delete(NULL));

    while (true) {
        sleep(100000);
    }
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

    //ethernet_helper_init_mdns();

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