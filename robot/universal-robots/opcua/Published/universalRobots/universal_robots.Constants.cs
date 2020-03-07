/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using Opc.Ua.Robotics;
using fortiss_Device;
using fortiss_Robotics;

namespace universal_robots
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Lock_InitLock = 15015;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Lock_RenewLock = 15018;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Lock_ExitLock = 15020;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Lock_BreakLock = 15022;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock = 15909;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock = 16022;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock = 16024;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock = 16026;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock = 16378;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock = 16381;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock = 16383;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock = 16385;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock = 16732;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = 16735;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = 16737;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = 16739;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = 16794;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = 16797;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = 16799;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = 16801;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock = 16829;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock = 16832;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock = 16834;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock = 16836;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock = 16868;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock = 16871;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock = 16873;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock = 16875;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock = 16904;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock = 16907;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock = 16909;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock = 16911;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock = 16940;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock = 16943;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock = 16945;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock = 16947;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock = 17011;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock = 17014;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock = 17016;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock = 17018;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock = 15232;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock = 15235;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock = 15237;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock = 15239;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock = 17075;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock = 17078;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock = 17080;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock = 17082;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock = 17156;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = 17159;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = 17161;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = 17163;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = 17207;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = 17210;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = 17212;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = 17214;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet = 15011;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeToolClear Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeToolClear = 15063;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock = 15316;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock = 15319;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock = 15321;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock = 15323;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock = 15452;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock = 15455;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock = 15457;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock = 15459;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock = 15588;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock = 15591;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock = 15593;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock = 15595;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock = 15724;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock = 15727;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock = 15729;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock = 15731;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock = 15860;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock = 15863;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock = 15865;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock = 15867;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock = 15996;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock = 15999;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock = 16001;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock = 16003;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_InitLock = 16141;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_RenewLock = 16144;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_ExitLock = 16146;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_BreakLock = 16148;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock = 17500;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock = 17503;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock = 17505;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock = 17507;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock = 17535;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock = 17538;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock = 17540;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock = 17542;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock = 17570;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock = 17573;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock = 17575;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock = 17577;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Halt Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Halt = 15058;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Reset Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Reset = 15059;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Resume Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Resume = 15060;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Suspend Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Suspend = 15061;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Start Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Start = 15062;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Halt Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Halt = 15114;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Reset Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Reset = 15115;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Resume Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Resume = 15116;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Suspend Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Suspend = 15117;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Start Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Start = 15118;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Halt Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Halt = 15165;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Reset Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Reset = 15166;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Resume Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Resume = 15167;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Suspend Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Suspend = 15168;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Start Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Start = 15169;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Halt Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Halt = 15218;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Reset Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Reset = 15219;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Resume Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Resume = 15228;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Suspend Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Suspend = 15241;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Start Method.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Start = 15242;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the UrMotionSystem Object.
        /// </summary>
        public const uint UrMotionSystem = 15001;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices = 15025;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet = 15752;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes = 16295;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet = 16297;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains = 16719;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers = 15110;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser = 16852;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software = 16891;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls = 16927;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet = 16929;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates Object.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates = 15194;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet = 17000;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot = 15220;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet = 15221;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes = 15248;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet = 17064;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains = 17143;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad = 15285;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool = 15094;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1 Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1 = 15304;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet = 15305;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2 Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2 = 15440;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet = 15441;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3 Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3 = 15576;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet = 15577;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4 Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4 = 15712;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet = 15713;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5 Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5 = 15848;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet = 15849;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6 Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6 = 15984;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet = 15985;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status Object.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status = 15289;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController = 16129;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_CurrentUser Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_CurrentUser = 17484;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software = 16156;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls = 16182;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet = 17559;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills = 16212;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill = 15024;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet = 15064;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill = 15078;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet = 15119;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill = 15133;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet = 15170;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill = 15185;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet = 15243;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_Locked = 15480;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_LockingClient = 15012;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_LockingUser = 15013;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_RemainingLockTime = 15014;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_InitLock_InputArguments = 15016;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_InitLock_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_RenewLock_OutputArguments = 15019;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_ExitLock_OutputArguments = 15021;

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Lock_BreakLock_OutputArguments = 15023;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked = 15887;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient = 15888;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser = 15889;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime = 15890;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments = 15946;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments = 15992;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments = 16023;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments = 16025;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments = 16045;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer = 16082;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Model Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Model = 16165;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode = 16232;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber = 16235;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory = 16240;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride = 16294;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked = 16304;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient = 16305;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser = 16306;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime = 16377;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments = 16379;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = 16380;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = 16382;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = 16384;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = 16386;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile = 16674;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass = 16676;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = 16681;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = 16683;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = 16685;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 16690;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 16691;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 16692;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = 16693;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = 16694;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = 16695;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = 16698;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = 16699;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = 16700;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition = 16701;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = 16706;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = 16712;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = 16718;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked = 16728;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = 16729;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = 16730;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = 16731;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = 16733;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = 16734;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = 16736;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = 16738;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = 16740;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass = 16756;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits = 16761;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates = 16763;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation = 16765;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X = 16770;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = 16771;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = 16772;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A = 16773;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B = 16774;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C = 16775;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X = 16778;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y = 16779;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z = 16780;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = 16790;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = 16791;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = 16792;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = 16793;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = 16795;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = 16796;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = 16798;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = 16800;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = 16802;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_Locked = 16825;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient = 16826;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser = 16827;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime = 16828;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments = 16830;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments = 16831;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments = 16833;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments = 16835;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments = 16837;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Manufacturer = 16838;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Model Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Model = 16840;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ProductCode Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_ProductCode = 16844;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_SerialNumber Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_SerialNumber = 16847;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level = 16853;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked = 16864;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient = 16865;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser = 16866;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime = 16867;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments = 16869;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = 16870;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = 16872;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = 16874;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = 16876;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked = 16900;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient = 16901;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser = 16902;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime = 16903;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = 16905;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = 16906;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = 16908;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = 16910;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = 16912;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer = 16913;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model = 16915;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision = 16917;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked = 16936;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient = 16937;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser = 16938;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = 16939;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = 16941;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = 16942;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = 16944;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = 16946;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = 16948;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName = 16962;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = 16963;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = 16964;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits = 16974;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits = 16980;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits = 16986;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits = 16992;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits = 16998;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked = 17007;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient = 17008;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser = 17009;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime = 17010;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments = 17012;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments = 17013;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments = 17015;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments = 17017;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments = 17019;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name = 17036;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active = 17037;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name = 17040;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled = 17041;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active = 17042;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode = 17043;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop = 17044;

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop Variable.
        /// </summary>
        public const uint UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop = 17045;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_Locked = 17046;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_LockingClient = 15229;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_LockingUser = 15230;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_RemainingLockTime = 15231;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_InputArguments = 15233;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_OutputArguments = 15234;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock_OutputArguments = 15236;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock_OutputArguments = 15238;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock_OutputArguments = 15240;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Manufacturer Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Manufacturer = 17047;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Model Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Model = 17049;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ProductCode Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ProductCode = 17053;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_SerialNumber Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_SerialNumber = 17054;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_MotionDeviceCategory Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_MotionDeviceCategory = 17059;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_SpeedOverride = 17062;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_Locked = 17071;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingClient = 17072;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingUser = 17073;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RemainingLockTime = 17074;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments = 17076;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = 17077;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = 17079;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = 17081;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = 17083;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_MotionProfile = 17098;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass = 17100;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = 17105;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17107;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = 17109;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17114;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17115;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17116;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = 17117;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = 17118;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = 17119;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = 17122;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = 17123;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = 17124;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition = 17125;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = 17130;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = 17136;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = 17142;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked = 17152;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = 17153;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = 17154;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = 17155;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = 17157;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = 17158;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = 17160;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = 17162;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = 17164;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass = 15286;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass_EngineeringUnits = 17183;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates = 17184;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation = 17186;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X = 17188;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = 17189;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = 17190;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_A = 17191;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_B = 17192;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_C = 17193;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_X = 16533;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Y = 16534;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Z = 16535;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = 17203;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = 17204;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = 17205;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = 17206;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = 17208;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = 17209;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = 17211;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = 17213;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = 17215;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet_InputArguments = 15034;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_Name Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_Name = 15095;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame = 17230;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates = 17231;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation = 17233;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X = 17238;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y = 17239;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z = 17240;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_A = 17241;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_B = 17242;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_C = 17243;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase = 15261;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates = 15262;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation = 15264;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_X = 15269;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Y = 15270;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Z = 15271;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_A = 15272;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_B = 15273;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_C = 15274;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_Locked = 17244;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingClient = 15313;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingUser = 15314;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RemainingLockTime = 15315;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_InputArguments = 15317;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_OutputArguments = 15318;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments = 15320;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments = 15322;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments = 15324;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_MotionProfile = 15326;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass = 15341;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits = 17263;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17264;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation = 17266;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17268;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17269;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17270;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A = 17271;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B = 17272;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C = 17273;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_X = 16542;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y = 16543;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z = 16544;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition = 15328;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits = 15333;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed = 15334;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EURange Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EURange = 15338;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits = 17279;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualCurrent = 15275;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_Temperature Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_Temperature = 15276;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_Locked = 17280;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingClient = 15449;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingUser = 15450;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RemainingLockTime = 15451;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_InputArguments = 15453;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_OutputArguments = 15454;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments = 15456;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments = 15458;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments = 15460;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_MotionProfile = 15462;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass = 15477;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits = 17299;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17300;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation = 17302;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17304;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17305;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17306;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A = 17307;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B = 17308;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C = 17309;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_X = 16553;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y = 16554;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z = 16555;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition = 15464;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits = 15469;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed = 15470;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits = 15475;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits = 17315;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualCurrent = 15277;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_Temperature Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_Temperature = 15278;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_Locked = 17316;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingClient = 15585;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingUser = 15586;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RemainingLockTime = 15587;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_InputArguments = 15589;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_OutputArguments = 15590;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments = 15592;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments = 15594;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments = 15596;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_MotionProfile = 15598;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass = 15613;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits = 17335;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17336;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation = 17338;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17340;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17341;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17342;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A = 17343;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B = 17344;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C = 17345;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_X = 16564;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y = 16565;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z = 16566;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition = 15600;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits = 15605;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed = 15606;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits = 15611;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits = 17351;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualCurrent = 15279;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_Temperature Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_Temperature = 15280;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_Locked = 17352;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingClient = 15721;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingUser = 15722;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RemainingLockTime = 15723;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_InputArguments = 15725;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_OutputArguments = 15726;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments = 15728;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments = 15730;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments = 15732;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_MotionProfile = 15734;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass = 15749;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits = 17371;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17372;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation = 17374;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17376;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17377;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17378;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A = 17379;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B = 17380;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C = 17381;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_X = 16575;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y = 16576;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z = 16577;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition = 15736;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits = 15741;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed = 15742;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits = 15747;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits = 17387;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualCurrent = 15281;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_Temperature Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_Temperature = 15282;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_Locked = 17388;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingClient = 15857;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingUser = 15858;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RemainingLockTime = 15859;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_InputArguments = 15861;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_OutputArguments = 15862;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments = 15864;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments = 15866;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments = 15868;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_MotionProfile = 15870;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass = 15885;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits = 17407;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17408;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation = 17410;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17412;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17413;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17414;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A = 17415;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B = 17416;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C = 17417;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_X = 16586;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y = 16587;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z = 16588;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition = 15872;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits = 15877;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed = 15878;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits = 15883;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits = 17423;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualCurrent = 15283;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_Temperature Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_Temperature = 15284;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_Locked = 17424;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingClient = 15993;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingUser = 15994;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RemainingLockTime = 15995;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_InputArguments = 15997;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_OutputArguments = 15998;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments = 16000;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments = 16002;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments = 16004;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_MotionProfile Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_MotionProfile = 16006;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass = 16021;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits = 17443;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates = 17444;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation = 17446;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = 17448;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = 17449;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = 17450;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A = 17451;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B = 17452;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C = 17453;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_X = 16597;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y = 16598;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z = 16599;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition = 16008;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits = 16013;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed = 16014;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits = 16019;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits = 17459;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualCurrent = 15287;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_Temperature Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_Temperature = 15288;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition = 15290;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates = 15291;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation = 15294;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_X = 15299;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Y = 15300;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Z = 15312;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_A Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_A = 15327;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_B Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_B = 15342;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_C Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_C = 15343;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed = 15344;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_X = 15376;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Y = 15377;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Z = 15378;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce = 15359;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_X Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_X = 15380;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Y Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Y = 15381;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Z Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Z = 15382;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_RobotMode Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_RobotMode = 15373;

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_SafetyMode Variable.
        /// </summary>
        public const uint UrMotionSystem_MotionDevices_UrRobot_Status_SafetyMode = 15374;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_Locked = 17470;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_LockingClient = 16138;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_LockingUser = 16139;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_RemainingLockTime = 16140;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_InitLock_InputArguments = 16142;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_InitLock_OutputArguments = 16143;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_RenewLock_OutputArguments = 16145;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_ExitLock_OutputArguments = 16147;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Lock_BreakLock_OutputArguments = 16149;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Manufacturer Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Manufacturer = 17471;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Model Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Model = 17473;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ProductCode Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_ProductCode = 17477;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_SerialNumber Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_SerialNumber = 17479;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_CurrentUser_Level Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_CurrentUser_Level = 17485;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_Locked = 17496;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingClient = 17497;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingUser = 17498;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RemainingLockTime = 17499;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_InputArguments = 17501;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = 17502;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = 17504;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = 17506;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = 17508;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_Locked = 17531;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingClient = 17532;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingUser = 17533;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RemainingLockTime = 17534;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = 17536;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = 17537;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = 17539;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = 17541;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = 17543;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Manufacturer = 17544;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Model = 17546;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_SoftwareRevision = 17548;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_Locked = 17566;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingClient = 17567;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingUser = 17568;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = 17569;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = 17571;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = 17572;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = 17574;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = 17576;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = 17578;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ComponentName = 17592;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = 17593;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = 17594;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_ParameterSet_TotalEnergyConsumption_EngineeringUnits = 17602;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_ParameterSet_CabinetFanSpeed_EngineeringUnits = 17608;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_ParameterSet_CPUFanSpeed_EngineeringUnits = 17614;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_ParameterSet_InputVoltage_EngineeringUnits = 17620;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_ParameterSet_Temperature_EngineeringUnits = 17626;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState = 15026;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Id = 15027;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Number = 15029;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition = 15031;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Id = 15032;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Number = 15035;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime = 15036;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Deletable Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Deletable = 15040;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_AutoDelete = 15041;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_RecycleCount = 15042;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId = 15044;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName = 15045;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = 15046;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = 15047;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall = 15048;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = 15049;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 15050;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 15051;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = 15052;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 15053;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = 15054;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 15055;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_MaxInstanceCount = 15057;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame = 15065;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration = 15066;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = 15071;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity = 15072;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = 15077;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState = 15079;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Id = 15080;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Number = 15082;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition = 15084;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Id = 15085;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Number = 15087;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime = 15088;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Deletable Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Deletable = 15092;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_AutoDelete = 15096;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_RecycleCount = 15097;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId = 15099;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName = 15100;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = 15101;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = 15102;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall = 15103;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = 15104;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 15105;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 15106;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = 15107;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 15108;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = 15109;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 15111;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_MaxInstanceCount = 15113;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame = 15120;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration = 15121;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = 15126;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity = 15127;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = 15132;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState = 15134;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Id = 15135;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Number = 15137;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition = 15139;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Id = 15140;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Number = 15142;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime = 15143;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Deletable Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Deletable = 15147;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_AutoDelete = 15148;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_RecycleCount = 15149;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId = 15151;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName = 15152;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = 15153;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = 15154;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall = 15155;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = 15156;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 15157;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 15158;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = 15159;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 15160;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = 15161;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 15162;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_MaxInstanceCount = 15164;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame = 15171;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration = 15172;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = 15177;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity = 15178;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = 15183;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds = 15184;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState = 15186;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Id = 15187;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Number = 15189;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition = 15191;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Id = 15192;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Number = 15195;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime = 15196;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Deletable Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Deletable = 15200;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_AutoDelete = 15201;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_RecycleCount = 15202;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId = 15204;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName = 15205;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = 15206;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = 15207;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall = 15208;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = 15209;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = 15210;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = 15211;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = 15212;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = 15213;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = 15214;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = 15215;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_MaxInstanceCount = 15217;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame = 15244;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration = 15245;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = 15253;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity = 15254;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = 15259;

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public const uint UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds = 15260;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeToolClear Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeToolClear = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_FlangeToolClear, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Halt = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Halt, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Reset = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Reset, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Resume = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Resume, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Suspend = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Suspend, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Start = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Start, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Halt = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Halt, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Reset = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Reset, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Resume = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Resume, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Suspend = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Suspend, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Start = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Start, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Halt = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Halt, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Reset = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Reset, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Resume = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Resume, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Suspend = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Suspend, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Start = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Start, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Halt = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Halt, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Reset = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Reset, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Resume = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Resume, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Suspend = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Suspend, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Start = new ExpandedNodeId(universal_robots.Methods.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Start, universal_robots.Namespaces.universalRobots);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the UrMotionSystem Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_ControllerIdentifier_Software, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_SafetyStates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_PowerTrains, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_FlangeTool, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1 Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1 = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2 Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2 = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3 Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3 = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4 Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4 = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5 Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5 = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6 Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6 = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_MotionDevices_UrRobot_Status, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_CurrentUser Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_CurrentUser = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_CurrentUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Software, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_TaskControls, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet = new ExpandedNodeId(universal_robots.Objects.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet, universal_robots.Namespaces.universalRobots);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Manufacturer, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Model = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Model, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ProductCode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_SerialNumber, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_MotionDeviceCategory, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_ParameterSet_SpeedOverride, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_FlangeLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_MotionDeviceIdentifier_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Manufacturer = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Manufacturer, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Model = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Model, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_ProductCode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_ProductCode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_SerialNumber = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_SerialNumber, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_CurrentUser_Level, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Manufacturer, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_Model, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_Software_SoftwareIdentifier_SoftwareRevision, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ComponentName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_TotalEnergyConsumption_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CabinetFanSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_CPUFanSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_InputVoltage_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_ControllerIdentifier_ParameterSet_Temperature_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Name, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_EmergencyStopFunctions_EmergencyStopFunctionIdentifier_Active, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Name, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Enabled, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ProtectiveStopFunctions_ProtectiveStopFunctionIdentifier_Active, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_OperationalMode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_EmergencyStop, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_SafetyStates_SafetyStateIdentifier_ParameterSet_ProtectiveStop, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Manufacturer = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Manufacturer, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Model = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Model, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ProductCode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ProductCode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_SerialNumber = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_SerialNumber, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_MotionDeviceCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_MotionDeviceCategory = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_MotionDeviceCategory, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_SpeedOverride Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_SpeedOverride = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_SpeedOverride, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_AxisIdentifier_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_PowerTrains_PowerTrainIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_AdditionalComponents_AdditionalComponentIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeToolSet_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_Name = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_Name, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_FlangeTool_ThreeDFrame_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_ParameterSet_WorldToRobotBase_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EURange = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualSpeed_EURange, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualCurrent = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_ActualCurrent, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_Temperature = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_1_ParameterSet_Temperature, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualCurrent = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_ActualCurrent, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_Temperature = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_2_ParameterSet_Temperature, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualCurrent = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_ActualCurrent, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_Temperature = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_3_ParameterSet_Temperature, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualCurrent = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_ActualCurrent, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_Temperature = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_4_ParameterSet_Temperature, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualCurrent = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_ActualCurrent, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_Temperature = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_5_ParameterSet_Temperature, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_MotionProfile Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_MotionProfile = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_MotionProfile, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Mass_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_CenterOfMass_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_AdditionalLoad_Inertia_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualPosition_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualCurrent = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_ActualCurrent, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_Temperature = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Axes_Axis_6_ParameterSet_Temperature, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_CartesianCoordinates_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_A = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_A, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_B = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_B, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_C = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpPosition_Orientation_C, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpSpeed_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_X = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_X, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Y = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Y, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Z = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_TcpForce_Z, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_RobotMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_RobotMode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_RobotMode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_MotionDevices_UrRobot_Status_SafetyMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_MotionDevices_UrRobot_Status_SafetyMode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_MotionDevices_UrRobot_Status_SafetyMode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Manufacturer = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Manufacturer, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Model = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Model, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_ProductCode = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_ProductCode, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_SerialNumber = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_SerialNumber, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_CurrentUser_Level Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_CurrentUser_Level = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_CurrentUser_Level, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Components_ComponentIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Manufacturer = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Manufacturer, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Model = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_Model, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_SoftwareRevision = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Software_SoftwareIdentifier_SoftwareRevision, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_Locked = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_Locked, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingClient = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingClient, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingUser = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_LockingUser, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RemainingLockTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_InputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_InitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_RenewLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_ExitLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_Lock_BreakLock_OutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ComponentName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ComponentName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_TaskControls_TaskControlIdentifier_ParameterSet_TaskProgramLoaded, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_TotalEnergyConsumption_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_ParameterSet_TotalEnergyConsumption_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_ParameterSet_TotalEnergyConsumption_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_CabinetFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_ParameterSet_CabinetFanSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_ParameterSet_CabinetFanSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_CPUFanSpeed_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_ParameterSet_CPUFanSpeed_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_ParameterSet_CPUFanSpeed_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_InputVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_ParameterSet_InputVoltage_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_ParameterSet_InputVoltage_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_ParameterSet_Temperature_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_ParameterSet_Temperature_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_ParameterSet_Temperature_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_CurrentState_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_LastTransition_TransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Deletable = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_Deletable, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_AutoDelete = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_AutoDelete, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_RecycleCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_RecycleCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_CreateClientName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastTransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCall, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_MaxInstanceCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_MaxInstanceCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_ToolFrame, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_CurrentState_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_LastTransition_TransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Deletable = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_Deletable, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_AutoDelete = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_AutoDelete, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_RecycleCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_RecycleCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_CreateClientName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastTransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCall, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_MaxInstanceCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_MaxInstanceCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_ToolFrame, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_JointPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_CurrentState_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_LastTransition_TransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Deletable = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_Deletable, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_AutoDelete = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_AutoDelete, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_RecycleCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_RecycleCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_CreateClientName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_InvocationCreationTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastTransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCall, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodInputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodOutputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodCallTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_MaxInstanceCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_MaxInstanceCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_ToolFrame, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianLinearMoveSkill_ParameterSet_AxisBounds, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_CurrentState_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Id = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Id, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Number = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_Number, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_LastTransition_TransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Deletable = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_Deletable, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_AutoDelete = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_AutoDelete, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_RecycleCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_RecycleCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_CreateClientName, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_InvocationCreationTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastTransitionTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCall, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodSessionId, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputArguments, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodInputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodOutputValues, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodCallTime, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ProgramDiagnostic_LastMethodReturnStatus, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_MaxInstanceCount = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_MaxInstanceCount, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_ToolFrame, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxAcceleration_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_MaxVelocity_EngineeringUnits, universal_robots.Namespaces.universalRobots);

        /// <summary>
        /// The identifier for the UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds Variable.
        /// </summary>
        public static readonly ExpandedNodeId UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds = new ExpandedNodeId(universal_robots.Variables.UrMotionSystem_Controllers_UrController_Skills_CartesianPtpMoveSkill_ParameterSet_AxisBounds, universal_robots.Namespaces.universalRobots);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the UrMotionSystem component.
        /// </summary>
        public const string UrMotionSystem = "UrMotionSystem";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the universalRobots namespace (.NET code namespace is 'universal_robots').
        /// </summary>
        public const string universalRobots = "https://fortiss.org/UA/universal_robots/";

        /// <summary>
        /// The URI for the universalRobotsXsd namespace (.NET code namespace is 'universal_robots').
        /// </summary>
        public const string universalRobotsXsd = "https://fortiss.org/UA/universal_robots/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaRobotics namespace (.NET code namespace is 'Opc.Ua.Robotics').
        /// </summary>
        public const string OpcUaRobotics = "http://opcfoundation.org/UA/Robotics/";

        /// <summary>
        /// The URI for the OpcUaRoboticsXsd namespace (.NET code namespace is 'Opc.Ua.Robotics').
        /// </summary>
        public const string OpcUaRoboticsXsd = "http://opcfoundation.org/UA/Robotics/Types.xsd";

        /// <summary>
        /// The URI for the fortissDevice namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDevice = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The URI for the fortissDeviceXsd namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDeviceXsd = "https://fortiss.org/UA/Device/Types.xsd";

        /// <summary>
        /// The URI for the fortissRobotics namespace (.NET code namespace is 'fortiss_Robotics').
        /// </summary>
        public const string fortissRobotics = "https://fortiss.org/UA/Robotics/";

        /// <summary>
        /// The URI for the fortissRoboticsXsd namespace (.NET code namespace is 'fortiss_Robotics').
        /// </summary>
        public const string fortissRoboticsXsd = "https://fortiss.org/UA/Robotics/Types.xsd";
    }
    #endregion
}