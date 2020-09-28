# Kelvin Toolchanger Device Adapter

This repo implements the OPC UA device adapter for the Kelvin Toolchanger.
More specifically, it uses the ADC Adapter (https://git.fortiss.org/robotics/component/sensor/adc-esp32) to get the
current Status of the Tool Changer, and implements the following skills:

- ChangeToolSkill: Uses robot moves and the ADC Adapter to attach/detach any tool in a docking station
- DetachToolSkill: Uses robot moves to detach a previously attached tool on the cached original tool position

## How to build

Install all dependencies as given in the Docker Container file:

https://git.fortiss.org/robotics/component/common/-/blob/master/ci/Dockerfile

Then build:

```bash
mkdir build
cd build
cmake ..
make -j
```

## How to run

Make sure to change `/path/to/repo` in the following command to the full path of this repo.

```
./kelvin-toolchanger --config=/path/to/repo/component.cfg --certs-client=/path/to/repo/certs/client/$(hostname) --certs-server=/path/to/repo/certs/server/$(hostname)
```