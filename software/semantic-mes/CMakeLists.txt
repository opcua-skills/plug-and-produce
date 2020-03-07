cmake_minimum_required(VERSION 3.2)
project(semantic-mes)

# -------------
# Project setup
# -------------

find_package(Boost COMPONENTS regex)

# Typically you don't care so much for a third party library's tests to be
# run from your own project's code.
set(JSON_BuildTests OFF CACHE INTERNAL "")

add_subdirectory(deps/common)
include_directories(include)
include_directories(${COMMON_INCLUDE_DIRS}
        deps/robotics_cs_client/include/
        src
        )

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/rob-client")
include_directories("${GENERATE_OUTPUT_DIR}")

find_package(open62541 REQUIRED COMPONENTS FullNamespace)

find_package(CLI11 CONFIG REQUIRED)
include_directories($<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>)

enable_testing()

# -------------
# Your own config
# -------------

find_package(rl 0.7.0 REQUIRED COMPONENTS math hal mdl prog)
include_directories(${RL_INCLUDES})

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

# remove lower part if you compile source from scratch
set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++14")

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-robotics-opcua-common-base")

file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")
include_directories("${GENERATE_OUTPUT_DIR}")

ua_generate_nodeset_and_datatypes(
        NAME "semantic_mes"
        TARGET_PREFIX "${PROJECT_NAME}-common"
        FILE_CSV "${PROJECT_SOURCE_DIR}/opcua/Published/SemanticMES/SemanticMESModel.csv"
        FILE_BSD "${PROJECT_SOURCE_DIR}/opcua/Published/SemanticMES/SemanticMES.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_IDX 5
        FILE_NS "${PROJECT_SOURCE_DIR}/opcua/Published/SemanticMES/SemanticMES.NodeSet2.xml"
        DEPENDS "fortiss_device"
        INTERNAL
)

generate_certificate(
        TARGET_NAME "semantic-mes-certs-server"
        APP_URI "fortiss.component.mes"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/server"
)

generate_certificate(
        TARGET_NAME "semantic-mes-certs-client"
        APP_URI "fortiss.component.mes.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/certs/client"
)

add_executable(semantic-mes
        $<TARGET_OBJECTS:${PROJECT_NAME}-common-client>
        $<TARGET_OBJECTS:${PROJECT_NAME}-common-nodeset>
        $<TARGET_OBJECTS:${PROJECT_NAME}-common-skill-detector>
       ${UA_NODESET_SEMANTIC_MES_SOURCES}
       ${UA_TYPES_SEMANTIC_MES_SOURCES}
        src/main.cpp
        src/ExecuteProcessSkillImpl.cpp
        src/SemanticMes.cpp
        src/SemanticMes.h
        src/pnp-demo/PnpSemanticMes.cpp
        src/pnp-demo/PnpSemanticMes.h
               )

target_include_directories(semantic-mes PUBLIC
                           deps/date
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common-client,INTERFACE_INCLUDE_DIRECTORIES>
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common-skill-detector,INTERFACE_INCLUDE_DIRECTORIES>
                           )

add_dependencies(semantic-mes
                 semantic-mes-certs-server
                 semantic-mes-certs-client
                 ${PROJECT_NAME}-common-client
                 ${PROJECT_NAME}-common-nodeset
                 ${PROJECT_NAME}-common-ns-semantic_mes
                 )
target_link_libraries(semantic-mes open62541::open62541 config++ ${RL_LIBRARIES} ${Boost_LIBRARIES})