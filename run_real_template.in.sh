#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting Toolchanger component ..."
$<TARGET_FILE:kelvin-toolchanger> --config ${CMAKE_CURRENT_LIST_DIR}/configs/real/toolchanger-alpha.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/software/kelvin-toolchanger/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/software/kelvin-toolchanger/certs/client/${HOSTNAME} &
P_gripper=$!

echo "Starting Composite Skills component ..."
$<TARGET_FILE:composite-skills> --config ${CMAKE_CURRENT_LIST_DIR}/configs/real/composite-skills.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/software/composite-skills/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/software/composite-skills/certs/client/${HOSTNAME} &
P_composite=$!

echo "Starting Semantic MES component ..."
$<TARGET_FILE:semantic-mes> --config ${CMAKE_CURRENT_LIST_DIR}/configs/semantic-mes.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/software/semantic-mes/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/software/semantic-mes/certs/client/${HOSTNAME} &
P_mes=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_gripper $P_composite $P_mes
trap - SIGINT
wait $P_gripper $P_composite $P_mes
