
SET(IOLMA_OS "freertos")
SET(IOLMA_HARDWARE "esp32")
SET(IOLMA_HAS_USB OFF)

idf_component_register(
        SRCS
            repo/iolma_hl/inc/iolma_hl_globals.h
            repo/iolma_hl/inc/iolma_hl_osal.h
            repo/iolma_hl/inc/iolma_hl_srvl.h
            repo/iolma_hl/src/iolma_hl_srvl.c
            repo/iolma_hl_osal_${IOLMA_OS}/inc/iolma_hl_osal_${IOLMA_OS}.h
            repo/iolma_hl_osal_${IOLMA_OS}/src/iolma_hl_osal_${IOLMA_OS}.c
            repo/iolma_ll/inc/iolma_ll_dl.h
            repo/iolma_ll/inc/iolma_ll_globals.h
            repo/iolma_ll/inc/iolma_ll_hsal.h
            repo/iolma_ll/src/iolma_ll_dl.c
            repo/iolma_ll_hsal_${IOLMA_HARDWARE}/inc/iolma_ll_hsal_${IOLMA_HARDWARE}.h
            repo/iolma_ll_hsal_${IOLMA_HARDWARE}/src/iolma_ll_hsal_${IOLMA_HARDWARE}.c
        REQUIRES freertos
        INCLUDE_DIRS ${CMAKE_CURRENT_LIST_DIR}/inc repo/iolma_hl/inc repo/iolma_hl_osal_${IOLMA_OS}/inc repo/iolma_ll/inc repo/iolma_ll_hsal_${IOLMA_HARDWARE}/inc
        PRIV_INCLUDE_DIRS ${IDF_PATH}/components/freertos/include/freertos
)