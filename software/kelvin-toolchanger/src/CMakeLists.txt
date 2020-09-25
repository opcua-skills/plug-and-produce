cmake_minimum_required(VERSION 3.9)

add_definitions(
        -Wall
        -Wcast-qual
        -Werror
        -Wextra
        -Wformat
        -Wformat-security
        -Winit-self
        -Wmultichar
        -Wno-overlength-strings
        -Wno-unused-parameter
        -Wno-cast-qual
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
find_package(rl 0.7.0 REQUIRED COMPONENTS math hal mdl)


set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-common")

file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")
include_directories("${GENERATE_OUTPUT_DIR}")

ua_generate_nodeset_and_datatypes(
        NAME "kelvin_toolchanger"
        TARGET_PREFIX "${PROJECT_NAME}-common"
        FILE_CSV "${PROJECT_SOURCE_DIR}/opcua/Published/KelvinToolchanger/KelvinToolchangerModel.csv"
        FILE_BSD "${PROJECT_SOURCE_DIR}/opcua/Published/KelvinToolchanger/KelvinToolchanger.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_IDX 5
        FILE_NS "${PROJECT_SOURCE_DIR}/opcua/Published/KelvinToolchanger/KelvinToolchanger.NodeSet2.xml"
        DEPENDS "fortiss_device"
        INTERNAL
)



add_executable(kelvin-toolchanger
               $<TARGET_OBJECTS:${PROJECT_NAME}-common>
               $<TARGET_OBJECTS:${PROJECT_NAME}-common-client>
               $<TARGET_OBJECTS:${PROJECT_NAME}-common-nodeset>
               $<TARGET_OBJECTS:${PROJECT_NAME}-common-skill-detector>
               ${UA_NODESET_KELVIN_TOOLCHANGER_SOURCES}
               ${UA_TYPES_KELVIN_TOOLCHANGER_SOURCES}
               main.cpp
               KelvinToolchanger.cpp
               KelvinToolchanger.h
               AdcAdapter.cpp
               AdcAdapter.h
               ChangeToolSkill.hpp
               ChangeToolSkillImpl.cpp
               ChangeToolSkillImpl.h
               DropToolSkill.hpp
               DropToolSkillImpl.cpp
               DropToolSkillImpl.h
               )


generate_certificate(
        TARGET_NAME "kelvin-toolchanger-certs-server"
        APP_URI "fortiss.component.software.kelvin-toolchanger"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/../certs/server"
)

generate_certificate(
        TARGET_NAME "kelvin-toolchanger-certs-client"
        APP_URI "fortiss.component.software.kelvin-toolchanger.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/../certs/client"
)

add_dependencies(kelvin-toolchanger
                 kelvin-toolchanger-common
                 kelvin-toolchanger-common-skill-detector
                 kelvin-toolchanger-common-ns-kelvin_toolchanger
                 kelvin-toolchanger-certs-server
                 kelvin-toolchanger-certs-client
        )


target_link_libraries(kelvin-toolchanger open62541::open62541 config++ ${RL_LIBRARIES})

target_include_directories(kelvin-toolchanger PRIVATE
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common,INTERFACE_INCLUDE_DIRECTORIES>
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common-skill-detector,INTERFACE_INCLUDE_DIRECTORIES>
                           )
