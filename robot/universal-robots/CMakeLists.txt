cmake_minimum_required(VERSION 3.2)
project(universal-robots)

add_subdirectory(deps/common)
include_directories(${COMMON_INCLUDE_DIRS})

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_EXTENSIONS OFF)

find_package(open62541 0.4.0 REQUIRED COMPONENTS Events)
#find_package(open62541 0.4.0 REQUIRED COMPONENTS Events DiscoveryMulticast)

find_package(CLI11 CONFIG REQUIRED)
include_directories($<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>)

find_package(rl 0.7.0 REQUIRED COMPONENTS math hal mdl prog)

enable_testing()

add_subdirectory(src)
