#!/usr/bin/env bash

cd cmake-build-debug
python $IDF_PATH/components/esptool_py/esptool/esptool.py -p $1 write_flash @flash_project_args
python $IDF_PATH/tools/idf_monitor.py -p $1 robotiq-2f-esp32.elf