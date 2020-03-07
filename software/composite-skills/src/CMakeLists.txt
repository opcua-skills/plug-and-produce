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
include_directories(${RL_INCLUDES})


set(GENERATE_OUTPUT_DIR "${CMAKE_BINARY_DIR}/src_generated/${PROJECT_NAME}-common")

file(MAKE_DIRECTORY "${GENERATE_OUTPUT_DIR}")
include_directories("${GENERATE_OUTPUT_DIR}")

ua_generate_nodeset_and_datatypes(
        NAME "composite_skills"
        TARGET_PREFIX "${PROJECT_NAME}-common"
        FILE_CSV "${PROJECT_SOURCE_DIR}/opcua/Published/CompositeSkills/CompositeSkillsModel.csv"
        FILE_BSD "${PROJECT_SOURCE_DIR}/opcua/Published/CompositeSkills/CompositeSkills.Types.bsd"
        OUTPUT_DIR "${GENERATE_OUTPUT_DIR}"
        NAMESPACE_IDX 5
        FILE_NS "${PROJECT_SOURCE_DIR}/opcua/Published/CompositeSkills/CompositeSkills.NodeSet2.xml"
        DEPENDS "fortiss_device"
        INTERNAL
)



add_executable(composite-skills
               $<TARGET_OBJECTS:${PROJECT_NAME}-common-client>
               $<TARGET_OBJECTS:${PROJECT_NAME}-common-nodeset>
               $<TARGET_OBJECTS:${PROJECT_NAME}-common-skill-detector>
               ${UA_NODESET_COMPOSITE_SKILLS_SOURCES}
               ${UA_TYPES_COMPOSITE_SKILLS_SOURCES}
               main.cpp
               CompositeSkills.cpp
               CompositeSkills.h
               PickAndPlaceSkill.hpp
               PickAndPlaceSkillImpl.cpp
               PickAndPlaceSkillImpl.h

               )


generate_certificate(
        TARGET_NAME "composite-skills-certs-server"
        APP_URI "fortiss.component.software.composite-skills"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/../certs/server"
)

generate_certificate(
        TARGET_NAME "composite-skills-certs-client"
        APP_URI "fortiss.component.software.composite-skills.client"
        OUTPUT_DIR "${CMAKE_CURRENT_LIST_DIR}/../certs/client"
)

add_dependencies(composite-skills
                 composite-skills-common
                 composite-skills-common-skill-detector
                 composite-skills-common-ns-composite_skills
                 composite-skills-certs-server
                 composite-skills-certs-client
        )


target_link_libraries(composite-skills open62541::open62541 config++ ${RL_LIBRARIES})

target_include_directories(composite-skills PRIVATE
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common,INTERFACE_INCLUDE_DIRECTORIES>
                           $<TARGET_PROPERTY:${PROJECT_NAME}-common-skill-detector,INTERFACE_INCLUDE_DIRECTORIES>
                           )
