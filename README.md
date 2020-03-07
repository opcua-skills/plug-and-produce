# Plug-and-Produce System Architecture for Robotic Applications

Proof of concept Plug&amp;Produce Architecture for Robot Systems and corresponding System components (Tools, Software, Algorithms)

Full video is available here: https://www.youtube.com/watch?v=iu85tnm0qfk

[![Watch the video](plug-produce-skills-simulation.gif)](https://www.youtube.com/watch?v=iu85tnm0qfk)

## License

As of now the code within this repository is not open source, but publicly available. All rights are reserved to fortiss.
This will most likely change in the near future to a more community-friendly License like BSD or MIT.

**NOTE:**
> THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
> AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
> THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR 
> PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS 
> BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
> CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE 
> GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
> HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 
> LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT 
> OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

## Install dependencies

This demo depends on a few packages:

* open62541: Open Source OPC UA Stack (https://github.com/open62541/open62541)
* RoboticsLibrary: Open Source Library for Robot Algorithms and Simulation (https://github.com/roboticslibrary/rl)
* CLI11: Command line parameter parsing (https://github.com/CLIUtils/CLI11)

To install the required dependencies follow these steps:

```bash
cd plug-and-produce
git submodule update --init --recursive

sudo apt-add-repository ppa:roblib/ppa && sudo apt update && sudo apt-get install -y --no-install-recommends freeglut3-dev libboost-dev libbullet-dev libbullet-extras-dev libcgal-dev libcurl4-openssl-dev libcoin80-dev libdc1394-22-dev libeigen3-dev freeglut3-dev libgraphviz-dev libnlopt-dev libode-dev libopencv-dev qtbase5-dev libsimage-dev libsoqt4-dev libsolid3d-dev libxml2-dev libxslt1-dev libzip-dev libconfig++-dev libmbedtls-dev

# This will install the Robotics Library on your system
./software/semantic-mes/deps/common/tools/install_rl.sh $(pwd)/install
    
# Install current master
./software/semantic-mes/deps/common/tools/install_open62541.sh 82611a487d4f2306ddfe6c9037a7686852517bf4 $(pwd)/install

./software/semantic-mes/deps/common/tools/install_cli11.sh $(pwd)/install
```

## Build project

After installing all dependencies as mentioned above, use cmake to build the project

```bash
cd plug-and-produce
mkdir build && cd build
cmake -DCMAKE_PREFIX_PATH=$(pwd)/../install ..
make -j3
```

## Run simulation

To run the simulation execute the following steps:

```bash
#!/bin/bash
cd plug-and-produce
./build/run_sim.sh
```

This will start all the simulation components, including rlCoachMdl which is the 3D simulation of the robot cell.
Make sure that the bin directory from the RoboticsLibrary is in your PATH so that rlCoachMdl is found.

The execution of the demo program will automatically start after 7 seconds. Alternatively you can also start the `ExecuteProcessSkill` on the semantic MES.

You can use UaExpert (or any other OPC UA client) to connect to any of the following simulated components.
If requested, the default OPC UA username is `demo` and the password `demo#PWD`.

* semantic MES: `opc.tcp://localhost:4840`
* Robotiq Gripper: `opc.tcp://localhost:10254`
* Schmalz Gripper: `opc.tcp://localhost:10255`
* Composite Skills: `opc.tcp://localhost:12346`
* Kelving Toolchanger: `opc.tcp://localhost:14840`
* Universal Robot: `opc.tcp://localhost:24840`

## Run on real components

The whole software stack provided in this repository can also be ran on real hardware.
This is at least possible with the Universal Robot UR5, by setting up the corresponding IP address on the UR5 controller and then using the `configs/real/ur5-alpha.cfg` config file.

Since custom hardware adapters for the other tools are required, it's not trivial to get the whole system up and running on your side.
Feel free to contact us for further assistance:
https://profanter.me/contact

