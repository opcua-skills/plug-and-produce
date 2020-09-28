# Robotiq 2F - ESP32

Robotiq 2F OPC UA Server on an ESP32 Chip.

This is tested on a TinyPICO board with additional 4MB psram.
An ESP32 chip with less than 1MB RAM (i.e., only built in RAM) is not enough.

The ESP32 chip is connected via UART to a TeConecpt IO-Link Master Board which is connected via IO-Link to the Schmalz ECBPi Gripper.

![Hardware Setup](hardware_setup_io-link.svg "Hardware Setup")

## Install Dependencies

Before you do anything else, make sure that you followed the Getting Started guide of the ESP IDF Framework, especially install all the dependencies:

https://docs.espressif.com/projects/esp-idf/en/latest/get-started/

**This example example only works with the newest 4.1 Version.**

I tested with branch `release/v4.1` (commit 5ef1b390026270503634ac3ec9f1ec2e364e23b2)

The rest of this README assumes that the IDF_PATH and PATH environment variable are correctly set.

## Setting a fixed ttyUSB Port

If you plug in your microcontroller via USB, Linux will automatically assign a `/dev/ttyUSB` port, starting with index 0. Depending how many USB devices you have connected, it may happen that every time you plug the ESP32, it gets another `ttyUSB` name.
To statically asign a custom port, follow these steps (for Ubuntu):

1. Plug in the ESP32 and call `udevadm info -a -n /dev/ttyUSB0 | grep -E '({serial}|{idProduct}|{idVendor})' | head -n3` (make sure that `ttyUSB0` is the ESP32)
2. Create a new udev rule with `sudo nano /etc/udev/rules.d/99-usb-serial.rules` and the following content, where you need to replace the values whith the one from previous command.
    ```
    SUBSYSTEM=="tty", ATTRS{idVendor}=="10c4", ATTRS{idProduct}=="ea60", ATTRS{serial}=="01435008", SYMLINK+="ttyUSB9"
    ```
3. Now unplug and plug in ESP32 again, and it will be on `/dev/ttyUSB9`

See also:
http://hintshop.ludvig.co.nz/show/persistent-names-usb-serial-devices/

## Building

### Building for local simulation

You can build the code to run it on a PC for simulation purposes.

```bash
mkdir build && cd build
cmake -DLOCAL_SIMULATION=ON ..
make -j
```

Make sure to change `/path/to/repo` in the following command to the full path of this repo.

```
./schmalz-ecbpi --config=/path/to/repo/gripper.cfg --certs-client=/path/to/repo/certs/client/$(hostname) --certs-server=/path/to/repo/certs/server/$(hostname)
```

### Building for ESP32

As first step you need to configure the WIFI settings and other possible settings.

Execute:

```bash
idf.py --build-dir=cmake-build-debug -G "Unix Makefiles" menuconfig  
```

Build the `flash` target to flash it to the ESP32

It is recommended to set the `ESPTOOL_BAUD=1500000` environment variable to get faster flashing.

```bash
export ESPTOOL_BAUD=1500000
idf.py --build-dir=cmake-build-debug -G "Unix Makefiles" flash  
```

## Changing settings

To change e.g. the Hostname or the IP Address, use the menuconfig tool and re-flash the device:

```bash
idf.py --build-dir=cmake-build-debug -G "Unix Makefiles" menuconfig  
export ESPTOOL_BAUD=1500000
idf.py --build-dir=cmake-build-debug -G "Unix Makefiles" flash  
```

## Debugging on ESP32

See the following Page for instructions on how to set up the debugger:

https://github.com/Pro/open62541-arduino/wiki/Debugging-ESP32

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
