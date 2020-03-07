cmake_minimum_required(VERSION 3.2)
project(kelvin-toolchanger)

# -------------
# Project setup
# -------------

add_subdirectory(deps/common)
include_directories(${COMMON_INCLUDE_DIRS})

find_package(open62541 1.0 REQUIRED COMPONENTS FullNamespace Events Encryption)

find_package(CLI11 CONFIG REQUIRED)
include_directories($<TARGET_PROPERTY:CLI11::CLI11,INTERFACE_INCLUDE_DIRECTORIES>)

enable_testing()

# -------------
# Your own config
# -------------

# find_package(rl 0.7.0 REQUIRED COMPONENTS math hal mdl)
# include_directories(${RL_INCLUDES})

add_subdirectory(src)
