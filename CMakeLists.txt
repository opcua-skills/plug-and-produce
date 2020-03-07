cmake_minimum_required(VERSION 3.2)
project(pnp-demo)

# Debug
string(TOLOWER "${CMAKE_BUILD_TYPE}" BUILD_TYPE_LOWER_CASE)
if(BUILD_TYPE_LOWER_CASE STREQUAL "debug")
    if("x${CMAKE_C_COMPILER_ID}" STREQUAL "xClang")
        # Add default sanitizer settings when using clang and Debug build.
        # This allows e.g. CLion to find memory locations for SegFaults
        message(STATUS "Clang Sanitizer enabled")
        set(SANITIZER_FLAGS "-g -fno-omit-frame-pointer -gline-tables-only -fsanitize=address -fsanitize-address-use-after-scope -fsanitize-coverage=trace-pc-guard,trace-cmp -fsanitize=leak -fsanitize=undefined")
        set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} ${SANITIZER_FLAGS}")
        set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} ${SANITIZER_FLAGS}")
    endif()
endif()

add_subdirectory(robot/universal-robots)
add_subdirectory(software/kelvin-toolchanger)
add_subdirectory(software/semantic-mes)
add_subdirectory(software/composite-skills)
set(LOCAL_SIMULATION ON)
add_subdirectory(gripper/schmalz-ecbpi)
add_subdirectory(gripper/robotiq-2f)

find_package(open62541 1 REQUIRED COMPONENTS FullNamespace)

enable_testing()

cmake_host_system_information(RESULT HOSTNAME QUERY HOSTNAME)
file(GENERATE OUTPUT "${PROJECT_BINARY_DIR}/run_sim.sh" INPUT "${PROJECT_BINARY_DIR}/.run_sim_tmp.sh")
configure_file("run_sim_template.in.sh" "${PROJECT_BINARY_DIR}/.run_sim_tmp.sh")

file(GENERATE OUTPUT "${PROJECT_BINARY_DIR}/run_real.sh" INPUT "${PROJECT_BINARY_DIR}/.run_real_tmp.sh")
configure_file("run_real_template.in.sh" "${PROJECT_BINARY_DIR}/.run_real_tmp.sh")

file(GENERATE OUTPUT "${PROJECT_BINARY_DIR}/run_ur5_alpha.sh" INPUT "${PROJECT_BINARY_DIR}/.run_ur5_alpha_tmp.sh")
configure_file("run_ur5_alpha_template.in.sh" "${PROJECT_BINARY_DIR}/.run_ur5_alpha_tmp.sh")

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

#add_executable(demo src/demo.cpp)
#add_dependencies(demo generate_onto)
#target_link_libraries(demo open62541::open62541 config++)
