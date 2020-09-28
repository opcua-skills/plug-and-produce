cmake_minimum_required(VERSION 3.2)

add_definitions(
        -Wall
        -Wcast-qual
        -Wconversion
        -Werror
        -Wextra
        -Wformat
        -Wformat-security
        -Winit-self
        -Wmultichar
        -Wno-overlength-strings
        -Wno-unused-parameter
        -Wpointer-arith
        -Wstrict-overflow
        -Wuninitialized
        -fPIC
        -fvisibility=hidden
        -Wno-ignored-qualifiers
        -Wno-sign-conversion
        -pipe)

set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++14")

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-robotics-opcua-common-base")

file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")
include_directories("${GENERATE_OUTPUT_DIR}")

set(TARGET_NAME universal-robots)

ua_generate_nodeset_and_datatypes(
        NAME "rob_ur"
        TARGET_PREFIX "${PROJECT_NAME}-common"
        FILE_CSV "${PROJECT_SOURCE_DIR}/opcua/Published/universalRobots/universalRobotsModel.csv"
        FILE_BSD "${PROJECT_SOURCE_DIR}/opcua/Published/universalRobots/universal_robots.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_IDX 6
        FILE_NS "${PROJECT_SOURCE_DIR}/opcua/Published/universalRobots/universal_robots.NodeSet2.xml"
        DEPENDS "for_rob"
        INTERNAL
)


generate_certificate(
        TARGET_NAME "${TARGET_NAME}-certs-server"
        APP_URI "fortiss.component.robot.universal-robot-ur5"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/../certs/server"
)
generate_certificate(
        TARGET_NAME "${TARGET_NAME}-certs-client"
        APP_URI "fortiss.component.robot.universal-robot-ur5.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/../certs/client"
)

add_executable(universal-robots main.cpp
        ${UA_NODESET_ROB_UR_SOURCES}
        ${UA_TYPES_ROB_UR_SOURCES}
        $<TARGET_OBJECTS:${PROJECT_NAME}-common>
        $<TARGET_OBJECTS:${PROJECT_NAME}-common-nodeset>
        UniversalRobotControl.cpp UniversalRobotControl.h)

add_dependencies(${TARGET_NAME}
                 ${TARGET_NAME}-certs-client
                 ${TARGET_NAME}-certs-server
                 ${PROJECT_NAME}-common
                 ${PROJECT_NAME}-common-nodeset
                 ${PROJECT_NAME}-common-ns-rob_ur)

target_link_libraries(${TARGET_NAME} open62541::open62541 config++ ${RL_LIBRARIES})
target_include_directories(${TARGET_NAME} PUBLIC
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common,INTERFACE_INCLUDE_DIRECTORIES>
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common-nodeset,INTERFACE_INCLUDE_DIRECTORIES>
                           )
