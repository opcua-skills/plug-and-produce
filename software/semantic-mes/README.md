OPC UA Semantic MES
========================================

This readme is still needs some more input...


Required dependencies:

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