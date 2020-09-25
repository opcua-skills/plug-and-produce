# Composite Skills Component

Component to collect various hierarchically composed skills based on other skills in the system.
Currently implemented skills:

- PickAndPlaceSkill: Uses robot move skills and gripper skills to provide a simple Pick & Place skill

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
./composite-skills --config=/path/to/repo/component.cfg --certs-client=/path/to/repo/certs/client/$(hostname) --certs-server=/path/to/repo/certs/server/$(hostname)
```