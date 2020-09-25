/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE', which is part of this source code package.
 *
 *    Copyright (c) 2020 fortiss GmbH, Stefan Profanter
 *    All rights reserved.
 */

#include "UniversalRobotControl.h"

#include "rob_ur_nodeids.h"


#define NAMESPACE_URI_ROB_UR "https://fortiss.org/UA/universal_robots/"

fortiss::robot::UniversalRobotControl::UniversalRobotControl(
        const libconfig::Setting& robotSettings,
        const std::shared_ptr<fortiss::opcua::OpcUaServer>& uaServer
) :
        fortiss::opcua::robot::RlRobotControl<AXIS_COUNT>(fortiss::log::get("robot/ur"), robotSettings,
                                                          robotSettings["simulation"] ? nullptr :
                                                          new rl::hal::UniversalRobotsRtde(robotSettings["ip"]),
                                                          uaServer,
                                                          UA_NODEID_NUMERIC(
                                                                  fortiss::opcua::UA_Server_getNamespaceIdByName(
                                                                          uaServer, NAMESPACE_URI_ROB_UR),
                                                                  UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT),
                                                          UA_NODEID_NUMERIC(
                                                                  fortiss::opcua::UA_Server_getNamespaceIdByName(uaServer,
                                                                                                                 NAMESPACE_URI_ROB_UR),
                                                                  UA_ROB_URID_URMOTIONSYSTEM_CONTROLLERS_URCONTROLLER_SKILLS),
                                                          !robotSettings["simulation"],
                                                          !robotSettings["simulation"]),
        nsIdRobUr(fortiss::opcua::UA_Server_getNamespaceIdByName(uaServer, NAMESPACE_URI_ROB_UR)),
        isSimulation(robotSettings["simulation"]),
        connected(false) {
    if (!isSimulation) {
        dashboard = std::make_shared<rl::hal::UniversalRobotsDashboard>(robotSettings["ip"]);
    }

    // The default skills should work in all cases
    if (!(addDefaultCartesianLinearMoveSkill()
          && addDefaultCartesianPtpMoveSkill()
          && addDefaultCartesianLinearMoveSkill()
          && addDefaultJointLinearMoveSkill()
          && addDefaultJointPtpMoveSkill())) {
        throw std::runtime_error("Cannot add initialize skills. Check previous errors.");
    }
}

fortiss::robot::UniversalRobotControl::~UniversalRobotControl() {
    shutdown();
}

bool fortiss::robot::UniversalRobotControl::connect() {

    if (connected)
        return true;

    if (!RlRobotControl::connect())
        return false;

    try {
        if (!isSimulation) {
            dashboard->open();
            auto* ur = dynamic_cast<rl::hal::UniversalRobotsRtde*>(getRobot());


            currentRobotMode = ur->getRobotMode();
            currentSafetyMode = ur->getSafetyMode();
            currentRuntimeState = ur->getRuntimeState();

            if (ur->getRobotMode() != rl::hal::UniversalRobotsRtde::RobotMode::running ||
                ur->getSafetyMode() != rl::hal::UniversalRobotsRtde::SafetyMode::normal ||
                ur->getRuntimeState() != rl::hal::UniversalRobotsRtde::RuntimeState::playing) {
                logger->warn("Robot is not yet ready. Maybe E-Stopped?");
                return true;
            }
        }
    } catch (const rl::hal::Exception& rlex) {
        logger->error("rl::hal::Exception. {}", rlex.what());
        return false;
    }
    return true;
}

void fortiss::robot::UniversalRobotControl::shutdown() {
    try {
        RlRobotControl::shutdown();
        if (!isSimulation && dashboard->isConnected()) {
            dashboard->doPowerOff();
        }
    } catch (rl::hal::ComException& ex) {
        logger->error("Could not shut down robot. {}", ex.what());
    }
}

bool fortiss::robot::UniversalRobotControl::step() {
    if (!RlRobotControl::step())
        return false;
    if (isSimulation)
        return true;

    auto* control = (rl::hal::UniversalRobotsRtde*) this->robotMove.getRobot();

    rl::math::Vector jointVelocity = control->getJointVelocity();
    rl::math::Vector jointCurrent = control->getJointCurrent();
    rl::math::Vector jointTemperature = control->getJointTemperature();
    //TODO joint voltage
    //TODO joint control current



    rl::math::Transform cartPosition = control->getCartesianPosition();
    rl::math::MotionVector cartSpeed = control->getCartesianVelocity();
    ::rl::math::ForceVector cartForce = control->getCartesianForce();

    UA_Int32 robotMode = (int)control->getRobotMode();
    UA_Int32 safetyMode = (int)control->getSafetyMode();

    return
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_1_PARAMETERSET_ACTUALSPEED),
                    "Axis1_Speed",
                    jointVelocity[0]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_1_PARAMETERSET_ACTUALCURRENT),
                    "Axis1_Current",
                    jointCurrent[0]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_1_PARAMETERSET_TEMPERATURE),
                    "Axis1_Temperature",
                    jointTemperature[0]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_2_PARAMETERSET_ACTUALSPEED),
                    "Axis2_Speed",
                    jointVelocity[1]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_2_PARAMETERSET_ACTUALCURRENT),
                    "Axis1_Current",
                    jointCurrent[1]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_2_PARAMETERSET_TEMPERATURE),
                    "Axis1_Temperature",
                    jointTemperature[1]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_3_PARAMETERSET_ACTUALSPEED),
                    "Axis3_Speed",
                    jointVelocity[2]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_3_PARAMETERSET_ACTUALCURRENT),
                    "Axis3_Current",
                    jointCurrent[2]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_3_PARAMETERSET_TEMPERATURE),
                    "Axis3_Temperature",
                    jointTemperature[2]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_4_PARAMETERSET_ACTUALSPEED),
                    "Axis4_Speed",
                    jointVelocity[3]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_4_PARAMETERSET_ACTUALCURRENT),
                    "Axis4_Current",
                    jointCurrent[3]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_4_PARAMETERSET_TEMPERATURE),
                    "Axis4_Temperature",
                    jointTemperature[3]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_5_PARAMETERSET_ACTUALSPEED),
                    "Axis5_Speed",
                    jointVelocity[4]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_5_PARAMETERSET_ACTUALCURRENT),
                    "Axis5_Current",
                    jointCurrent[4]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_5_PARAMETERSET_TEMPERATURE),
                    "Axis5_Temperature",
                    jointTemperature[4]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_6_PARAMETERSET_ACTUALSPEED),
                    "Axis6_Speed",
                    jointVelocity[5]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_6_PARAMETERSET_ACTUALCURRENT),
                    "Axis6_Current",
                    jointCurrent[5]) &&
            setVariableDouble(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_AXES_AXIS_6_PARAMETERSET_TEMPERATURE),
                    "Axis6_Temperature",
                    jointTemperature[5]) &&
            setVariable3DFrame(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_STATUS_TCPPOSITION),
                    "TcpPosition",
                    cartPosition
            ) &&
            setVariable3DVector(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_STATUS_TCPSPEED),
                    "TcpSpeed",
                    cartSpeed
            ) &&
            setVariable3DVector(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_STATUS_TCPFORCE),
                    "TcpForce",
                    cartForce
            ) &&
            setVariableInt32(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_STATUS_ROBOTMODE),
                    "RobotMode",
                    robotMode
            ) &&
            setVariableInt32(
                    UA_NODEID_NUMERIC(nsIdRobUr, UA_ROB_URID_URMOTIONSYSTEM_MOTIONDEVICES_URROBOT_STATUS_SAFETYMODE),
                    "SafetyMode",
                    safetyMode
            );

}

bool fortiss::robot::UniversalRobotControl::setVariableDouble(
        const UA_NodeId& id,
        const std::string& name,
        const UA_Double& val
) {
    UA_Variant var;
    UA_Variant_setScalar(&var, const_cast<UA_Double*>(&val), &UA_TYPES[UA_TYPES_DOUBLE]);
    LockedServer ls = uaServer->getLocked();
    if (const UA_StatusCode retval = UA_Server_writeValue(ls.get(), id, var) != UA_STATUSCODE_GOOD) {
        logger->error("Cannot write to server variable: {}. Error: {}", name, UA_StatusCode_name(retval));
        return false;
    }
    return true;
}

bool fortiss::robot::UniversalRobotControl::setVariable3DFrame(
        const UA_NodeId& id,
        const std::string& name,
        const rl::math::Transform& val
) {
    UA_Variant var;
    UA_ThreeDFrame f;
    f.cartesianCoordinates.x = val.translation().x();
    f.cartesianCoordinates.y = val.translation().y();
    f.cartesianCoordinates.z = val.translation().z();
    rl::math::Vector3 vec = val.rotation().eulerAngles(2, 1, 0).reverse();
    f.orientation.a = vec.x();
    f.orientation.b = vec.y();
    f.orientation.c = vec.z();
    UA_Variant_setScalar(&var, &f, &UA_TYPES[UA_TYPES_THREEDFRAME]);
    LockedServer ls = uaServer->getLocked();
    if (const UA_StatusCode retval = UA_Server_writeValue(ls.get(), id, var) != UA_STATUSCODE_GOOD) {
        logger->error("Cannot write to server variable: {}. Error: {}", name, UA_StatusCode_name(retval));
        return false;
    }
    return true;
}

bool fortiss::robot::UniversalRobotControl::setVariable3DVector(
        const UA_NodeId& id,
        const std::string& name,
        const rl::math::MotionVector& val
) {
    UA_Variant var;
    UA_ThreeDVector v;
    v.x = val.angular().x();
    v.y = val.angular().y();
    v.z = val.angular().z();
    UA_Variant_setScalar(&var, &v, &UA_TYPES[UA_TYPES_THREEDVECTOR]);
    LockedServer ls = uaServer->getLocked();
    if (const UA_StatusCode retval = UA_Server_writeValue(ls.get(), id, var) != UA_STATUSCODE_GOOD) {
        logger->error("Cannot write to server variable: {}. Error: {}", name, UA_StatusCode_name(retval));
        return false;
    }
    return true;
}

bool fortiss::robot::UniversalRobotControl::setVariable3DVector(
        const UA_NodeId& id,
        const std::string& name,
        const rl::math::ForceVector& val
) {
    UA_Variant var;
    UA_ThreeDVector v;
    v.x = val.force().x();
    v.y = val.force().y();
    v.z = val.force().z();
    UA_Variant_setScalar(&var, &v, &UA_TYPES[UA_TYPES_THREEDVECTOR]);
    LockedServer ls = uaServer->getLocked();
    if (const UA_StatusCode retval = UA_Server_writeValue(ls.get(), id, var) != UA_STATUSCODE_GOOD) {
        logger->error("Cannot write to server variable: {}. Error: {}", name, UA_StatusCode_name(retval));
        return false;
    }
    return true;
}

bool fortiss::robot::UniversalRobotControl::setVariableInt32(
        const UA_NodeId& id,
        const std::string& name,
        const UA_Int32& val
) {
    UA_Variant var;
    UA_Variant_setScalar(&var, const_cast<UA_Int32*>(&val), &UA_TYPES[UA_TYPES_INT32]);
    LockedServer ls = uaServer->getLocked();
    if (const UA_StatusCode retval = UA_Server_writeValue(ls.get(), id, var) != UA_STATUSCODE_GOOD) {
        logger->error("Cannot write to server variable: {}. Error: {}", name, UA_StatusCode_name(retval));
        return false;
    }
    return true;
}

/*
void fortiss::robot::UniversalRobotControl::recoverFromSafetyStop() {

    rl::hal::UniversalRobotsRtde::RobotMode robotMode = robot->getRobotMode();
    rl::hal::UniversalRobotsRtde::SafetyMode safetyMode = robot->getSafetyMode();

    std::uint32_t robotStatus = robot->getRobotStatusBits();
    std::uint32_t safetyStatus = robot->getSafetyStatusBits();

    if (unlockProtectiveStop) {
        unlockProtectiveStop = false;
        lastSafetyStatusProtective = false;
        dashboard->doUnlockProtectiveStop();
    }

    switch (safetyMode) {
        case rl::hal::UniversalRobotsRtde::SAFETY_MODE_NORMAL:
            switch (robotMode) {
                case rl::hal::UniversalRobotsRtde::ROBOT_MODE_POWER_OFF:
                    dashboard->doPowerOn();
                    if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                        logger->warn("Recovery from safety: power on");
                    break;
                case rl::hal::UniversalRobotsRtde::ROBOT_MODE_IDLE:
                    dashboard->doBrakeRelease();
                    if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                        logger->warn("Recovery from safety: brake release");
                    break;
                case rl::hal::UniversalRobotsRtde::ROBOT_MODE_RUNNING:
                    if (!(rl::hal::UniversalRobotsRtde::ROBOT_STATUS_PROGRAM_RUNNING & robotStatus) &&
                        !(rl::hal::UniversalRobotsRtde::SAFETY_STATUS_SAFEGUARD_STOPPED & safetyStatus)) {
                        robot->start();
                        if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                            logger->warn("Recovery from safety: robot start");
                    }
                    break;
                default:
                    break;
            }
            break;
        case rl::hal::UniversalRobotsRtde::SAFETY_MODE_PROTECTIVE_STOP:
            lastSafetyStatusProtective = true;
            if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                logger->error(
                        "Protective stop. Remove object which blocks the robot and press the Emergency Stop, then release it to recover.");
            break;
        case rl::hal::UniversalRobotsRtde::SAFETY_MODE_ROBOT_EMERGENCY_STOP:
        case rl::hal::UniversalRobotsRtde::SAFETY_MODE_SYSTEM_EMERGENCY_STOP:
            if (lastSafetyStatusProtective)
                unlockProtectiveStop = true;
            if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                logger->warn("Recovery from safety: ROBOT EMERGENCY STOPPED");
            break;
        case rl::hal::UniversalRobotsRtde::SAFETY_MODE_SAFEGUARD_STOP:
            if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                logger->warn("Recovery from safety: ROBOT SAFEGUARD STOPPED");
            break;
        case rl::hal::UniversalRobotsRtde::SAFETY_MODE_FAULT:
            if (robotMode != currentRobotMode && safetyMode != currentSafetyMode)
                logger->critical("Recovery from safety: ROBOT FAULT. Controller restart required");
            break;
        default:
            break;
    }
}*/


/*void fortiss::robot::UniversalRobotControl::updateControlLoop() {
    double timeStepReal = std::chrono::duration_cast<std::chrono::duration<float> >(robot->getUpdateRate()).count();

    rl::math::Vector qDelta = targetJointPosition - kinematic->getPosition(); //previousPosition;
    rl::math::Vector qdDesired = qDelta / timeStepReal * 0.5;

    // clamp to joint velocity limits (without changing direction)

    // TODO do not use minimum speed but separate speed for each axis
    const double minSpeedValue = targetJointSpeed.minCoeff();

    rl::math::Real qdOverload = (qdDesired.array().abs() / (kinematic->getSpeed().array() * minSpeedValue)).maxCoeff();
    if (qdOverload > 1.0f) {
        qdDesired /= qdOverload;
    }

    // clamp to joint acceleration limits
    rl::math::Vector qddControl = (qdDesired - kinematic->getVelocity()) / timeStepReal;
    rl::math::Real qddOverload = (qddControl.array().abs() / maximumAcceleration * 2).maxCoeff();
    if (qddOverload > 1.0f) {
        qddControl /= qddOverload;
    }

    // apply veloctiy
    rl::math::Vector qdControl = kinematic->getVelocity() + qddControl * timeStepReal;
    kinematic->setVelocity(qdControl);

    // apply position
    rl::math::Vector qControl = kinematic->getPosition() + qdControl * timeStepReal;
    kinematic->setPosition(qControl);
    dynamic_cast<rl::hal::JointPositionActuator*>(robot.get())->setJointPosition(qControl);
}*/

