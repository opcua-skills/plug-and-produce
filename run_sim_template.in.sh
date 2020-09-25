#!/usr/bin/env bash

# Send SIGTERM to the Java KB background job, because for some reason only its process signal mask ignores SIGINT (ctrl+c).
trap 'kill -SIGTERM $P_kb' SIGINT

echo "Starting rlCoach ..."
rlCoachMdl ${CMAKE_CURRENT_LIST_DIR}/models/demo.xml ${CMAKE_CURRENT_LIST_DIR}/models/ur5-alpha-mdl.xml  ${CMAKE_CURRENT_LIST_DIR}/models/ur5-bravo-mdl.xml &
P_coach=$!
# Wait until rlCoach is started before running Robot
sleep 4

echo "Starting Robot component ..."
$<TARGET_FILE:universal-robots> --config ${CMAKE_CURRENT_LIST_DIR}/configs/ur5-alpha.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/robot/universal-robots/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/robot/universal-robots/certs/client/${HOSTNAME} &
P_robot=$!

echo "Starting Robotiq 2F component ..."
$<TARGET_FILE:robotiq-2f> --config ${CMAKE_CURRENT_LIST_DIR}/configs/robotiq-2f.cfg &
P_robotiq=$!

echo "Starting Schmalz ECBPi component ..."
$<TARGET_FILE:schmalz-ecbpi> --config ${CMAKE_CURRENT_LIST_DIR}/configs/schmalz-ecbpi.cfg &
P_schmalz=$!

echo "Starting Toolchanger component ..."
$<TARGET_FILE:kelvin-toolchanger> --config ${CMAKE_CURRENT_LIST_DIR}/configs/toolchanger-alpha.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/software/kelvin-toolchanger/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/software/kelvin-toolchanger/certs/client/${HOSTNAME} &
P_gripper=$!

echo "Starting Composite Skills component ..."
$<TARGET_FILE:composite-skills> --config ${CMAKE_CURRENT_LIST_DIR}/configs/composite-skills.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/software/composite-skills/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/software/composite-skills/certs/client/${HOSTNAME} &
P_composite=$!

echo "Starting Semantic MES component ..."
$<TARGET_FILE:semantic-mes> --config ${CMAKE_CURRENT_LIST_DIR}/configs/semantic-mes-sim.cfg --certs-server=${CMAKE_CURRENT_LIST_DIR}/software/semantic-mes/certs/server/${HOSTNAME} --certs-client=${CMAKE_CURRENT_LIST_DIR}/software/semantic-mes/certs/client/${HOSTNAME} &
P_mes=$!

# After the trapped SIGINT interrupts wait, remove the trap and then wait for the background jobs to finish shutting down.
wait $P_coach $P_robot $P_robotiq $P_schmalz $P_gripper $P_composite $P_mes
trap - SIGINT
wait $P_coach $P_robot $P_robotiq $P_schmalz $P_gripper $P_composite $P_mes
