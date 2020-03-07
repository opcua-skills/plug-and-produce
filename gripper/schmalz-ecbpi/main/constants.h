//
// Created by profanter on 26/11/2019.
// Copyright (c) 2019 fortiss GmbH. All rights reserved.
//

#ifndef IOLMA_HL_CMAKE_SRCDEMO_CONSTANTS_H
#define IOLMA_HL_CMAKE_SRCDEMO_CONSTANTS_H


#include <iolma_ll_globals.h>
#include <iolma_hl_globals.h>


static const char *_iolma_ret_to_string(E_IOLMA_RET_t e_iolma_ret)
{
    const char *p_ret;

    switch(e_iolma_ret)
    {
        case E_IOLMA_RET_OK:                                    { p_ret = "OK";                                    break; }
        case E_IOLMA_RET_ERROR_GENERAL_ERROR:                   { p_ret = "ERROR_GENERAL_ERROR";                   break; }
        case E_IOLMA_RET_ERROR_NULL_POINTER:                    { p_ret = "ERROR_NULL_POINTER";                    break; }
        case E_IOLMA_RET_ERROR_BUFFER_TOO_SMALL:                { p_ret = "ERROR_BUFFER_TOO_SMALL";                break; }

        case E_IOLMA_RET_ERROR_UNKNOWN_PERIPHERAL:              { p_ret = "ERROR_UNKNOWN_PERIPHERAL";              break; }
        case E_IOLMA_RET_ERROR_CANT_INITIALIZE_PERIPHERAL:      { p_ret = "ERROR_CANT_INITIALIZE_PERIPHERAL";      break; }
        case E_IOLMA_RET_ERROR_THE_GIVEN_FREQUENCY_IS_TOO_LOW:  { p_ret = "ERROR_THE_GIVEN_FREQUENCY_IS_TOO_LOW";  break; }
        case E_IOLMA_RET_ERROR_THE_GIVEN_FREQUENCY_IS_TOO_HIGH: { p_ret = "ERROR_THE_GIVEN_FREQUENCY_IS_TOO_HIGH"; break; }
        case E_IOLMA_RET_ERROR_CANT_SET_THE_GIVEN_FREQUENCY:    { p_ret = "ERROR_CANT_SET_THE_GIVEN_FREQUENCY";    break; }
        case E_IOLMA_RET_ERROR_WRONG_ANSWER:                    { p_ret = "ERROR_WRONG_ANSWER";                    break; }
        case E_IOLMA_RET_ERROR_WRONG_CRC:                       { p_ret = "ERROR_WRONG_CRC";                       break; }
        case E_IOLMA_RET_ERROR_REQUEST_ERROR:                   { p_ret = "ERROR_REQUEST_ERROR";                   break; }
        case E_IOLMA_RET_ERROR_INTERLEAVED_COUNTER_ERROR:       { p_ret = "ERROR_INTERLEAVED_COUNTER_ERROR";       break; }

        case E_IOLMA_RET_ERROR_MASTER_NOT_CONNECTED:            { p_ret = "ERROR_MASTER_NOT_CONNECTED";            break; }
        case E_IOLMA_RET_ERROR_TOO_MANY_LOST_TELEGRAMS:         { p_ret = "ERROR_TOO_MANY_LOST_TELEGRAMS";         break; }
        case E_IOLMA_RET_ERROR_COMM_CYCLE_TIME_TOO_SMALL:       { p_ret = "ERROR_COMM_CYCLE_TIME_TOO_SMALL";       break; }
        case E_IOLMA_RET_ERROR_INVALID_PORT_NUMBER:             { p_ret = "ERROR_INVALID_PORT_NUMBER";             break; }
        case E_IOLMA_RET_ERROR_PROGRESS_ONGOING:                { p_ret = "ERROR_PROGRESS_ONGOING";                break; }
        case E_IOLMA_RET_ERROR_TIMEOUT:                         { p_ret = "ERROR_TIMEOUT";                         break; }
        case E_IOLMA_RET_ERROR_SERVICE_TEMPORARY_UNAVAILABLE:   { p_ret = "ERROR_SERVICE_TEMPORARY_UNAVAILABLE";   break; }
        case E_IOLMA_RET_ERROR_INVALID_CONFIG:                  { p_ret = "ERROR_INVALID_CONFIG";                  break; }
        case E_IOLMA_RET_ERROR_PORT_NOT_OPERATING_IN_IOLINK:    { p_ret = "ERROR_PORT_NOT_OPERATING_IN_IOLINK";    break; }
        case E_IOLMA_RET_ERROR_STATE_CONFLICT:                  { p_ret = "ERROR_STATE_CONFLICT";                  break; }
        case E_IOLMA_RET_ERROR_SERVICE_NOT_SUPPORTED:           { p_ret = "ERROR_SERVICE_NOT_SUPPORTED";           break; }

        default:                                                { p_ret = "-";                                     break; }
    } /* switch */

    return p_ret;
} /* _iolma_ret_to_string */



static const char *_master_type_to_string(E_IOLMA_MASTER_TYPE_t e_master_type)
{
    const char *p_ret;

    switch(e_master_type)
    {
        case E_IOLMA_MASTER_TYPE_UNSPECIFIED: { p_ret = "UNSPECIFIED"; break; }
        case E_IOLMA_MASTER_TYPE_V11:         { p_ret = "V11";         break; }
        case E_IOLMA_MASTER_TYPE_FS:          { p_ret = "FS";          break; }
        case E_IOLMA_MASTER_TYPE_W:           { p_ret = "W";           break; }
        default:                              { p_ret = "-";           break; }
    } /* switch */

    return p_ret;
} /* _master_type_to_string */



static const char *_port_type_to_string(E_IOLMA_PORT_TYPE_t e_port_type)
{
    const char *p_ret;

    switch(e_port_type)
    {
        case E_IOLMA_PORT_TYPE_CLASS_A:                   { p_ret = "CLASS_A";                   break; }
        case E_IOLMA_PORT_TYPE_CLASS_A_WITH_POWER_OFF_ON: { p_ret = "CLASS_A_WITH_POWER_OFF_ON"; break; }
        case E_IOLMA_PORT_TYPE_CLASS_B:                   { p_ret = "CLASS_B";                   break; }
        case E_IOLMA_PORT_TYPE_FS_A_WITHOUT_OSSDE:        { p_ret = "FS_A_WITHOUT_OSSDE";        break; }
        case E_IOLMA_PORT_TYPE_FS_A_WITH_OSSDE:           { p_ret = "FS_A_WITH_OSSDE";           break; }
        case E_IOLMA_PORT_TYPE_FS_B:                      { p_ret = "FS_B";                      break; }
        case E_IOLMA_PORT_TYPE_W_MASTER:                  { p_ret = "W_MASTER";                  break; }
        default:                                          { p_ret = "-";                         break; }
    } /* switch */

    return p_ret;
} /* _port_type_to_string */



static const char *_port_status_info_to_string(E_IOLMA_PORT_STATUS_INFO_t e_port_status_info)
{
    const char *p_ret;

    switch(e_port_status_info)
    {
        case E_IOLMA_PORT_STATUS_INFO_NO_DEVICE:        { p_ret = "NO_DEVICE       "; break; }
        case E_IOLMA_PORT_STATUS_INFO_DEACTIVATED:      { p_ret = "DEACTIVATED     "; break; }
        case E_IOLMA_PORT_STATUS_INFO_INCORRECT_DEVICE: { p_ret = "INCORRECT_DEVICE"; break; }
        case E_IOLMA_PORT_STATUS_INFO_PREOPERATE:       { p_ret = "PREOPERATE      "; break; }
        case E_IOLMA_PORT_STATUS_INFO_OPERATE:          { p_ret = "OPERATE         "; break; }
        case E_IOLMA_PORT_STATUS_INFO_DI_CQ:            { p_ret = "DI_CQ           "; break; }
        case E_IOLMA_PORT_STATUS_INFO_DO_CQ:            { p_ret = "DO_CQ           "; break; }
        case E_IOLMA_PORT_STATUS_INFO_NOT_AVAILABLE:    { p_ret = "NOT_AVAILABLE   "; break; }
        default:                                        { p_ret = "-               "; break; }
    } /* switch */

    return p_ret;
} /* _port_status_info_to_string */



static const char *_transmission_rate_to_string(E_IOLMA_TRANSMISSION_RATE_t e_transmission_rate)
{
    const char *p_ret;

    switch(e_transmission_rate)
    {
        case E_IOLMA_TRANSMISSION_RATE_NOT_DETECTED: { p_ret = "NOT_DETECTED"; break; }
        case E_IOLMA_TRANSMISSION_RATE_COM1:         { p_ret = "COM1";         break; }
        case E_IOLMA_TRANSMISSION_RATE_COM2:         { p_ret = "COM2";         break; }
        case E_IOLMA_TRANSMISSION_RATE_COM3:         { p_ret = "COM3";         break; }
        default:                                     { p_ret = "-";            break; }
    } /* switch */

    return p_ret;
} /* _transmission_rate_to_string */



static const char *_event_instance_to_string(E_IOLMA_EVENT_INSTANCE_t e_event_instance)
{
    const char *p_ret;

    switch(e_event_instance)
    {
        case E_IOLMA_EVENT_INSTANCE_UNKNOWN:     { p_ret = "UNKNOWN    "; break; }
        case E_IOLMA_EVENT_INSTANCE_APPLICATION: { p_ret = "APPLICATION"; break; }
        default:                                 { p_ret = "-          "; break; }
    } /* switch */

    return p_ret;
} /* _event_instance_to_string */



static const char *_event_mode_to_string(E_IOLMA_EVENT_MODE_t e_event_mode)
{
    const char *p_ret;

    switch(e_event_mode)
    {
        case E_IOLMA_EVENT_MODE_SINGLE_SHOT: { p_ret = "SINGLE_SHOT"; break; }
        case E_IOLMA_EVENT_MODE_DISAPPEARS:  { p_ret = "DISAPPEARS "; break; }
        case E_IOLMA_EVENT_MODE_APPEARS:     { p_ret = "APPEARS    "; break; }
        default:                             { p_ret = "-          "; break; }
    } /* switch */

    return p_ret;
} /* _event_mode_to_string */



static const char *_event_type_to_string(E_IOLMA_EVENT_TYPE_t e_event_type)
{
    const char *p_ret;

    switch(e_event_type)
    {
        case E_IOLMA_EVENT_TYPE_NOTIFICATION: { p_ret = "NOTIFICATION"; break; }
        case E_IOLMA_EVENT_TYPE_WARNING:      { p_ret = "WARNING     "; break; }
        case E_IOLMA_EVENT_TYPE_ERROR:        { p_ret = "ERROR       "; break; }
        default:                              { p_ret = "-           "; break; }
    } /* switch */

    return p_ret;
} /* _event_type_to_string */



static const char *_event_origin_to_string(E_IOLMA_EVENT_ORIGIN_t e_event_origin)
{
    const char *p_ret;

    switch(e_event_origin)
    {
        case E_IOLMA_EVENT_ORIGIN_DEVICE: { p_ret = "DEVICE"; break; }
        case E_IOLMA_EVENT_ORIGIN_MASTER: { p_ret = "MASTER"; break; }
        default:                          { p_ret = "-     "; break; }
    } /* switch */

    return p_ret;
} /* _event_origin_to_string */



static const char *_port_mode_to_string(E_IOLMA_PORT_MODE_t e_port_mode)
{
    const char *p_ret;

    switch(e_port_mode)
    {
        case E_IOLMA_PORT_MODE_DEACTIVATED:   { p_ret = "DEACTIVATED";   break; }
        case E_IOLMA_PORT_MODE_IOL_MANUAL:    { p_ret = "IOL_MANUAL";    break; }
        case E_IOLMA_PORT_MODE_IOL_AUTOSTART: { p_ret = "IOL_AUTOSTART"; break; }
        case E_IOLMA_PORT_MODE_DI_CQ:         { p_ret = "DI_CQ";         break; }
        case E_IOLMA_PORT_MODE_DO_CQ:         { p_ret = "DO_CQ";         break; }
        case E_IOLMA_PORT_MODE_UNSPECIFIED:   { p_ret = "UNSPECIFIED";   break; }
        default:                              { p_ret = "-";             break; }
    } /* switch */

    return p_ret;
} /* _port_mode_to_string */



static const char *_validation_backup_to_string(E_IOLMA_VALIDATION_BACKUP_t e_validation_backup)
{
    const char *p_ret;

    switch(e_validation_backup)
    {
        case E_IOLMA_VALIDATION_BACKUP_NO_DEVICE_CHECK:                    { p_ret = "NO_DEVICE_CHECK";                    break; }
        case E_IOLMA_VALIDATION_BACKUP_TYPE_COMPATIBLE_V10:                { p_ret = "TYPE_COMPATIBLE_V10";                break; }
        case E_IOLMA_VALIDATION_BACKUP_TYPE_COMPATIBLE_V11:                { p_ret = "TYPE_COMPATIBLE_V11";                break; }
        case E_IOLMA_VALIDATION_BACKUP_TYPE_COMPATIBLE_V11_BACKUP_RESTORE: { p_ret = "TYPE_COMPATIBLE_V11_BACKUP_RESTORE"; break; }
        case E_IOLMA_VALIDATION_BACKUP_TYPE_COMPATIBLE_V11_RESTORE:        { p_ret = "TYPE_COMPATIBLE_V11_RESTORE";        break; }
        default:                                                           { p_ret = "-";                                  break; }
    } /* switch */

    return p_ret;
} /* _validation_backup_to_string */



static const char *_iq_behavior_to_string(E_IOLMA_IQ_BEHAVIOR_t e_iq_behavior)
{
    const char *p_ret;

    switch(e_iq_behavior)
    {
        case E_IOLMA_IQ_BEHAVIOR_NOT_SUPPORTED: { p_ret = "NOT_SUPPORTED"; break; }
        case E_IOLMA_IQ_BEHAVIOR_DI:            { p_ret = "DI";            break; }
        case E_IOLMA_IQ_BEHAVIOR_DO:            { p_ret = "DO";            break; }
        case E_IOLMA_IQ_BEHAVIOR_AI:            { p_ret = "AI";            break; }
        case E_IOLMA_IQ_BEHAVIOR_AO:            { p_ret = "AO";            break; }
        case E_IOLMA_IQ_BEHAVIOR_POWER_2:       { p_ret = "POWER_2";       break; }
        default:                                { p_ret = "-";             break; }
    } /* switch */

    return p_ret;
} /* _iq_behavior_to_string */


#endif //IOLMA_HL_CMAKE_SRCDEMO_CONSTANTS_H
