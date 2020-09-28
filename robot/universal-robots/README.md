OPC UA Robot Driver for Universal Robots
========================================

Uses the Robotics Library to control Universal Robots. Tested with a UR5

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
./universal-robots --config=/path/to/repo/component.cfg --certs-client=/path/to/repo/certs/client/$(hostname) --certs-server=/path/to/repo/certs/server/$(hostname)
```