
# Create empty dummy files so that we can call idf_component_register
set(NODESET_SRCS
    ${UA_NODESET_DI_SOURCES}
    ${UA_NODESET_FORTISS_DEVICE_SOURCES}
    ${UA_NODESET_ROBOTIQ_2F_SOURCES}
    ${UA_TYPES_DI_SOURCES}
    ${UA_TYPES_FORTISS_DEVICE_SOURCES}
    ${UA_TYPES_ROBOTIQ_2F_SOURCES})
foreach(f ${NODESET_SRCS})
    if(NOT EXISTS "${f}")
        FILE(WRITE "${f}"
             "#error open62541 not yet generated"
             )
    endif()
endforeach()
#MESSAGE(STATUS "Nodeset Sources:   ${NODESET_SRCS}")

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/robotiq-2f")
file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")

if(NOT LOCAL_SIMULATION)
    idf_component_register(SRCS "main.cpp"
                           rl/hal/CyclicDevice.cpp
                           rl/hal/Device.cpp
                           rl/hal/DeviceException.cpp
                           rl/hal/Endian.cpp
                           rl/hal/Exception.cpp
                           rl/hal/Gripper.cpp
                           rl/hal/RobotiqModelC.cpp
                           Serial.cpp
                           GripperOPCUA.cpp
                           TinyPico.cpp
                           ${NODESET_SRCS}
                           deps/common/server/OpcUaServer.cpp
                           INCLUDE_DIRS "./deps/common/deps/spdlog/include" "./deps/common/include" "${GENERATE_OUTPUT_DIR}" "."
                           REQUIRES open62541 ethernet_helper nvs_flash esp_adc_cal)

    # Build static library, do not build test executables
    option(BUILD_SHARED_LIBS OFF)
    option(BUILD_TESTING OFF)
else()

    find_package(CLI11 CONFIG REQUIRED)
    include_directories($<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>)

    add_subdirectory(deps/common)
    add_executable(robotiq-2f
                   $<TARGET_OBJECTS:${PROJECT_NAME}-common>
                   main_local.cpp
                   GripperOPCUA.cpp
                   SimGripper.cpp
                   SimGripper.h
                   ${NODESET_SRCS}
                   )
    include_directories("./deps/common/deps/spdlog/include" "./deps/common/include" "${GENERATE_OUTPUT_DIR}" "." ${CMAKE_BINARY_DIR}/open62541)

    target_link_libraries(robotiq-2f open62541::open62541 config++)
endif()


# ESP32 is little endian
if(NOT LOCAL_SIMULATION)
    add_definitions(-DHAVE_LITTLE_ENDIAN -DUA_ENABLE_AMALGAMATION -D_AIX -DUA_ARCHITECTURE_FREERTOSLWIP -DSPDLOG_NO_THREAD_ID)
    add_definitions(-Wno-ignored-qualifiers)

    # Unfortunately the library performs install and export. Would
    # have been nice if devs made that an option like BUILD_SHARED_LIBS
    # and BUILD_TESTING. Override install() and export() to do nothing
    # instead.
    function(install)
    endfunction()

    function(export)
    endfunction()

else()
    add_definitions(-DLOCAL_SIMULATION)
endif()
