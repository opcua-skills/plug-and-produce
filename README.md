# Plug-and-Produce System Architecture for Robotic Applications using OPC UA

Proof of concept Plug&amp;Produce Architecture for Robot Systems and corresponding System components (Tools, Software, Algorithms) using OPC UA

The concept behind this repository and system architecture is presented in the following publication:


**A Generic Plug Produce System composed of Semantic OPC UA Skills**.
Stefan Profanter, Alexander Perzylo, Markus Rickert and Alois Knoll.
IEEE Open Journal of the Industrial Electronics Society, 2021.

[Available as Open Access in the IEEE Open Journal of the Industrial Electronics Society](https://ieeexplore.ieee.org/document/9340379)


Full video is available here: https://www.youtube.com/watch?v=iu85tnm0qfk

[![Watch the video](plug-produce-skills-simulation.gif)](https://www.youtube.com/watch?v=iu85tnm0qfk)

## License

As of now the code within this repository is not open source, but publicly available. All rights are reserved to fortiss.

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

* Ubuntu 20.04
* open62541: Open Source OPC UA Stack (https://github.com/open62541/open62541), Commit: [dac2c98d3b9722fb1971780d34996ea64bf65445](https://github.com/open62541/open62541/commit/dac2c98d3b9722fb1971780d34996ea64bf65445)
* RoboticsLibrary: Open Source Library for Robot Algorithms and Simulation (https://github.com/roboticslibrary/rl), Commit: [cba76ed3e54676d430205a0dfdf03ce33ed3850c](https://github.com/roboticslibrary/rl/commit/cba76ed3e54676d430205a0dfdf03ce33ed3850c)
* CLI11: Command line parameter parsing (https://github.com/CLIUtils/CLI11)


A full list of dependencies which are required for building this repo should be taken from the corresponding CI Pipeline configuration:

[main.yml](.github/workflows/main.yml)


To summarize, you will need the following packages:

`libconfig++-dev`, `open62541`, `cli11`, and a current `RoboticsLibrary` version.

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

