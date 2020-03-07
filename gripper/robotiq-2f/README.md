# Robotiq 2F - ESP32

Robotiq 2F OPC UA Server on an ESP32 Chip.

This is tested on a TinyPICO board with additional 4MB psram.
An ESP32 chip with less than 1MB RAM (i.e., only built in RAM) is not enough.

## Building

### Building for local simulation

You can build the code to run it on a PC for simulation purposes.

```
mkdir build && cd build
cmake -DLOCAL_SIMULATION=ON ..
make -j
./schmalz-ecbpi
```

### Building for ESP32

As first step you need to configure the WIFI settings and other possible settings.

Execute:

```
idf.py --build-dir=cmake-build-debug -G "Unix Makefiles" menuconfig  
```

Build the `flash` target to flash it to the ESP32

It is recommended to set the `ESPTOOL_BAUD=1500000` environment variable to get faster flashing.


## Debugging on ESP32

If you get the error message

```
Error: libusb_open() failed with LIBUSB_ERROR_ACCESS
Error: no device found
Error: unable to open ftdi device with vid 15ba, pid 002b, description 'Olimex OpenOCD JTAG ARM-USB-OCD-H', serial '*' at bus location '*'
```

perform the following steps:

1. `wget https://raw.githubusercontent.com/espressif/openocd-esp32/master/contrib/60-openocd.rules`
2. `sudo mv 60-openocd.rules /etc/udev/rules.d/`
3. `sudo usermod -a -G plugdev $USER`
4. `sudo apt install libftdi1`
5. reboot
6. If you use the CLion OpenOCD ESP32 Plugin (https://github.com/daniel-sullivan/clion-embedded-esp32) make sure that you set up a new toolchain in the settings and set the correct gcc, g++ and gdb executable.
   Move that toolchain to the first position to set it as default.
