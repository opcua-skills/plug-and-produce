/*!
******************************************************************************************************************************************************
* @file             iolma_config.h
* @authors          MM
* @brief            Header file that contains the configuration macros for the Low-Level and High-Level IO-Link Master Access Module
* @copyright        Copyright (c) by TEConcept GmbH. All rights reserved.
* @since            Created on 2018-06-28
******************************************************************************************************************************************************
*/



/******************************************************************************************************************************************************
*** Notes
******************************************************************************************************************************************************/



/******************************************************************************************************************************************************
*** Start of header file
******************************************************************************************************************************************************/

#ifndef _INC_IOLMA_CONFIG_H_
#define _INC_IOLMA_CONFIG_H_



/******************************************************************************************************************************************************
*** Includes
******************************************************************************************************************************************************/



/******************************************************************************************************************************************************
*** Start of C linkage-specification
******************************************************************************************************************************************************/

#ifdef __cplusplus
extern "C"
{
#endif



/******************************************************************************************************************************************************
*** External macro constant definitions
******************************************************************************************************************************************************/

/* Select the platform */

/**
 * @brief Select the platform
 * @note If IOLMA_PLATFORM_EMBEDDED is defined, it means the IOLMA will be used on an embedded environment
 * @note If IOLMA_PLATFORM_EMBEDDED is not defined, it means the IOLMA will be used on a desktop environment
 * */
#define IOLMA_PLATFORM_EMBEDDED

/* #undef IOLMA_HAS_USB */

/* Select the Hardware-Software Abstraction Layer implementation */

/** @brief Define the header file name of the used Hardware-Software Abstraction Layer */
#define IOLMA_HSAL_HEADER_FILE_NAME     "iolma_ll_hsal_esp32.h"



/* Select the Operating System Abstraction Layer implementation */

/** @brief Define the header file name of the used Operating System Abstraction Layer */
#define IOLMA_OSAL_HEADER_FILE_NAME     "iolma_hl_osal_freertos.h"



/* Define enumeration behaviour */

 /**
 * @brief Define IOLMA_ENUMS_AS_ENUMS in order to treat enumerations as enumerations
 * @note Without this macro defined enumerations treated like uint8_t variables
 * @note This macro should only be defined while developing
 * @note This macro should not be defined for end products
 */
/* #define IOLMA_ENUMS_AS_ENUMS */



/* Set the actual number of IO-Link Master ports */

/** @brief Define IOLMA_MAX_NUMBER_OF_MASTER_PORTS to set the actual number of IO-Link Master ports */
#define IOLMA_MAX_NUMBER_OF_MASTER_PORTS        (1u)



/* Define the processing time of the IO-Link Master */

/**
 * @brief Define the processing time of the IO-Link Master in 10 microsecond resolution
 * @note The processing time of the IO-Link Master is the time it takes for the IO-Link Master to process the request and compose the response in the worst case
 * @note The IOLMA_MASTER_PROCESSING_TIME_IN_TEN_US macro is only taken into account on embedded platforms and when communicating with the IO-Link Master through SPI
 * @note If IOLMA_MASTER_PROCESSING_TIME_IN_TEN_US is not defined, the default processing time of the IO-Link Master will be taken into account (which is 250 microseconds)
 * @example To set the processing time of the IO-Link Master to 100 microseconds, define this macro like this: #define IOLMA_MASTER_PROCESSING_TIME_IN_TEN_US (10u)
 */
/* #define IOLMA_MASTER_PROCESSING_TIME_IN_TEN_US      (25u) */







/* Other macro definitions */



/******************************************************************************************************************************************************
*** External macro operation definitions
******************************************************************************************************************************************************/



/******************************************************************************************************************************************************
*** External type definitions
******************************************************************************************************************************************************/



/******************************************************************************************************************************************************
*** External function declarations
******************************************************************************************************************************************************/



/******************************************************************************************************************************************************
*** External variable declarations
******************************************************************************************************************************************************/



/******************************************************************************************************************************************************
*** End of C linkage-specification
******************************************************************************************************************************************************/

#ifdef __cplusplus
}
#endif



/******************************************************************************************************************************************************
*** End of header file
******************************************************************************************************************************************************/

#endif /* _INC_IOLMA_CONFIG_H_ */


