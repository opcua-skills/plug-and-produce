# The following lines of boilerplate have to be in your project's
# CMakeLists in this exact order for cmake to work correctly
cmake_minimum_required(VERSION 3.2)

if(NOT LOCAL_SIMULATION)
    set(LOCAL_SIMULATION OFF)
endif()

if(NOT LOCAL_SIMULATION)
    set(SUPPORTED_TARGETS esp32)
else()
    project(robotiq-2f)
endif()

find_package(PythonInterp REQUIRED)
set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++14")

if (NOT LOCAL_SIMULATION)
    set(open62541_REPO_DIR "${CMAKE_CURRENT_LIST_DIR}/components/open62541/repo")

    set(open62541_TOOLS_DIR "${open62541_REPO_DIR}/tools")
    set(open62541_NODESET_DIR "${open62541_REPO_DIR}/deps/ua-nodeset")
    include("${open62541_REPO_DIR}/tools/cmake/macros_public.cmake")
else()
    find_package(open62541 1 REQUIRED COMPONENTS FullNamespace)
endif()

set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/robotiq-2f")

file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")

ua_generate_nodeset_and_datatypes(
        NAME "di"
        TARGET_PREFIX "robotiq-2f"
        FILE_CSV "${open62541_NODESET_DIR}/DI/OpcUaDiModel.csv"
        FILE_BSD "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        BLACKLIST "${CMAKE_CURRENT_LIST_DIR}/nodes_blacklist.txt"
        NAMESPACE_IDX 2
        FILE_NS "${open62541_NODESET_DIR}/DI/Opc.Ua.Di.NodeSet2.xml"
        INTERNAL
)


ua_generate_nodeset_and_datatypes(
        NAME "fortiss_device"
        TARGET_PREFIX "robotiq-2f"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/main/deps/common/deps/robotics_cs/deps/device/Published/fortiss_Device/fortissDeviceModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/main/deps/common/deps/robotics_cs/deps/device/Published/fortiss_Device/fortiss_Device.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        BLACKLIST "${CMAKE_CURRENT_LIST_DIR}/nodes_blacklist.txt"
        NAMESPACE_IDX 3
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/main/deps/common/deps/robotics_cs/deps/device/Published/fortiss_Device/fortiss_Device.NodeSet2.xml"
        DEPENDS "di"
        INTERNAL
)


ua_generate_nodeset_and_datatypes(
        NAME "robotiq_2f"
        TARGET_PREFIX "robotiq-2f"
        FILE_CSV "${CMAKE_CURRENT_LIST_DIR}/main/opcua/Published/Robotiq/Robotiq2FModel.csv"
        FILE_BSD "${CMAKE_CURRENT_LIST_DIR}/main/opcua/Published/Robotiq/robotiq.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        BLACKLIST "${CMAKE_CURRENT_LIST_DIR}/nodes_blacklist.txt"
        NAMESPACE_IDX 4
        FILE_NS "${CMAKE_CURRENT_LIST_DIR}/main/opcua/Published/Robotiq/robotiq.NodeSet2.xml"
        DEPENDS "fortiss_device"
        INTERNAL
)

if(NOT LOCAL_SIMULATION)
    include($ENV{IDF_PATH}/tools/cmake/project.cmake)
endif()
project(robotiq-2f)

if(NOT LOCAL_SIMULATION)
    add_dependencies(__idf_main
                     robotiq-2f-ns-robotiq_2f
                     )
else()
    add_subdirectory(main)
    add_dependencies(robotiq-2f
                     robotiq-2f-ns-robotiq_2f
                     )
endif()


#add_custom_target(robotiq-2f)
#add_dependencies(robotiq-2f gen_project_binary bootloader)