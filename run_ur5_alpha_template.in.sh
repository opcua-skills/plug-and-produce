#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Robot component ..."
(cd ${CMAKE_CURRENT_LIST_DIR};sudo $<TARGET_FILE:universal-robots> --config ${CMAKE_CURRENT_LIST_DIR}/configs/real/ur5-alpha.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/robot/universal-robots/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/robot/universal-robots/certs/client/${HOSTNAME}) &
P_robot=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_robot
trap - SIGINT
wait $P_robot
