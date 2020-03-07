OPC UA Robot Driver for Universal Robots
========================================

This readme is still needs some more input...


Required dependencies:

## Install Robotics Library

```bash
git clone git@gitlab.com:roboticslibrary/rl.git
cd rl
mkdir RelWithDebInfo && cd RelWithDebInfo
cmake -DBUILD_RL_PLAN=OFF -DBUILD_DEMOS=ON -DUSE_QT5=OFF -DCMAKE_BUILD_TYPE=RelWithDebInfo -DCMAKE_INSTALL_PREFIX:PATH=$HOME/install/rl ..
make -j3
make install
```


## Install open62541

```bash
git clone https://github.com/open62541/open62541.git
cd open62541
git checkout master

mkdir build && cd build

cmake -DUA_ENABLE_SUBSCRIPTIONS_EVENTS=ON -DUA_NAMESPACE_ZERO=FULL -DUA_ENABLE_DISCOVERY_MULTICAST=ON ..
sudo make install
```

## Other package dependencies:

```bash
sudo apt install libconfig++-dev
```