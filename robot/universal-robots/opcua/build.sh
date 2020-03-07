#!/bin/bash

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"
pushd $(pwd)
cd $DIR/../deps/common/deps/robotics_cs/deps/device/model_compiler
./PublishModel.sh $DIR/universalRobotsModel universalRobots  $DIR/Published
popd
