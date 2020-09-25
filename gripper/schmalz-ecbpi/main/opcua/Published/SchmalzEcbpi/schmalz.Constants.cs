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
using fortiss_Device;
using Opc.Ua.Di;
using Opc.Ua;

namespace schmalz
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
        /// The identifier for the SchmalzEcbpiType_Lock_InitLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_InitLock = 15244;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_RenewLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_RenewLock = 15247;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_ExitLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_ExitLock = 15249;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_BreakLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_BreakLock = 15251;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_InitLock = 15279;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_RenewLock = 15282;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_ExitLock = 15284;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_BreakLock = 15286;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_InitLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_InitLock = 15314;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_RenewLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_RenewLock = 15317;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_ExitLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_ExitLock = 15319;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_BreakLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_BreakLock = 15321;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_InitLock = 15349;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_RenewLock = 15352;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_ExitLock = 15354;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_BreakLock = 15356;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_PowerOffDevice Method.
        /// </summary>
        public const uint SchmalzEcbpi_PowerOffDevice = 15001;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Halt Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_Halt = 15403;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Reset Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_Reset = 15404;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Resume Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_Resume = 15405;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Suspend Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_Suspend = 15406;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Start Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_Start = 15407;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Halt Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_Halt = 15447;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Reset Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_Reset = 15448;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Resume Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_Resume = 15449;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Suspend Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_Suspend = 15450;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Start Method.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_Start = 15451;
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
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_NetworkAddress = 15288;

        /// <summary>
        /// The identifier for the SchmalzEcbpi Object.
        /// </summary>
        public const uint SchmalzEcbpi = 15300;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_NetworkAddress = 15358;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills Object.
        /// </summary>
        public const uint SchmalzEcbpi_Skills = 15370;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill Object.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill = 15371;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill Object.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill = 15415;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints Object.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints = 15003;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint Object.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint = 15004;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status Object.
        /// </summary>
        public const uint SchmalzEcbpi_Status = 15020;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the SchmalzEcbpiType ObjectType.
        /// </summary>
        public const uint SchmalzEcbpiType = 15230;
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
        /// The identifier for the SchmalzEcbpiType_Lock_Locked Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_Locked = 15240;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_LockingClient Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_LockingClient = 15241;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_LockingUser Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_LockingUser = 15242;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_RemainingLockTime = 15243;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_InitLock_InputArguments = 15245;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_InitLock_OutputArguments = 15246;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_RenewLock_OutputArguments = 15248;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_ExitLock_OutputArguments = 15250;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_Lock_BreakLock_OutputArguments = 15252;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_Locked = 15275;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_LockingClient = 15276;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_LockingUser = 15277;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_RemainingLockTime = 15278;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_InitLock_InputArguments = 15280;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_InitLock_OutputArguments = 15281;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_RenewLock_OutputArguments = 15283;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_ExitLock_OutputArguments = 15285;

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpiType_CPIdentifier_Lock_BreakLock_OutputArguments = 15287;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_Locked Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_Locked = 15310;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_LockingClient Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_LockingClient = 15311;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_LockingUser Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_LockingUser = 15312;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_RemainingLockTime = 15313;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_InitLock_InputArguments = 15315;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_InitLock_OutputArguments = 15316;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_RenewLock_OutputArguments = 15318;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_ExitLock_OutputArguments = 15320;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Lock_BreakLock_OutputArguments = 15322;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Manufacturer Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Manufacturer = 15323;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Model Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Model = 15325;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_HardwareRevision Variable.
        /// </summary>
        public const uint SchmalzEcbpi_HardwareRevision = 15326;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_SoftwareRevision Variable.
        /// </summary>
        public const uint SchmalzEcbpi_SoftwareRevision = 15327;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_DeviceRevision Variable.
        /// </summary>
        public const uint SchmalzEcbpi_DeviceRevision = 15328;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_DeviceManual Variable.
        /// </summary>
        public const uint SchmalzEcbpi_DeviceManual = 15330;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_SerialNumber Variable.
        /// </summary>
        public const uint SchmalzEcbpi_SerialNumber = 15332;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_RevisionCounter Variable.
        /// </summary>
        public const uint SchmalzEcbpi_RevisionCounter = 15334;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_Locked = 15345;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_LockingClient = 15346;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_LockingUser = 15347;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_RemainingLockTime = 15348;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_InitLock_InputArguments = 15350;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_InitLock_OutputArguments = 15351;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_RenewLock_OutputArguments = 15353;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_ExitLock_OutputArguments = 15355;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_CPIdentifier_Lock_BreakLock_OutputArguments = 15357;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_PowerOffDevice_InputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_PowerOffDevice_InputArguments = 15002;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState = 15372;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Id = 15373;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Number = 15375;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition = 15377;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Id = 15378;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Number = 15380;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_TransitionTime = 15381;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Deletable Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_Deletable = 15385;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_AutoDelete = 15386;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_RecycleCount = 15387;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = 15389;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = 15390;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15391;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = 15392;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = 15393;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15394;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15395;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15396;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15397;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15398;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15399;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15400;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_MaxInstanceCount = 15402;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange = 15413;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState = 15416;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Id = 15417;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Number = 15419;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition = 15421;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Id = 15422;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Number = 15424;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_TransitionTime = 15425;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Deletable Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_Deletable = 15429;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_AutoDelete = 15430;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_RecycleCount = 15431;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId = 15433;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName = 15434;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15435;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime = 15436;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall = 15437;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15438;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15439;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15440;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15441;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15442;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15443;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15444;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_MaxInstanceCount = 15446;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Skills_GraspGripperSkill_ParameterSet_Force_EURange = 15457;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Type Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Type = 15005;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset = 15006;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates = 15007;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation = 15009;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_X = 15014;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Y = 15015;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Z = 15016;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_A Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_A = 15017;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_B Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_B = 15018;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_C Variable.
        /// </summary>
        public const uint SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_C = 15019;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_PartPresent Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Status_PartPresent = 15021;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_InControlRange Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Status_InControlRange = 15025;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_PartDetached Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Status_PartDetached = 15022;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_VacuumLive Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Status_VacuumLive = 15023;

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_ActualPower Variable.
        /// </summary>
        public const uint SchmalzEcbpi_Status_ActualPower = 15029;
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
        /// The identifier for the SchmalzEcbpiType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_InitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_Lock_InitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_RenewLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_Lock_RenewLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_ExitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_Lock_ExitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_BreakLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_Lock_BreakLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_CPIdentifier_Lock_InitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_CPIdentifier_Lock_RenewLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_CPIdentifier_Lock_ExitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpiType_CPIdentifier_Lock_BreakLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_InitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Lock_InitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_RenewLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Lock_RenewLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_ExitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Lock_ExitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_BreakLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Lock_BreakLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_InitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_CPIdentifier_Lock_InitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_CPIdentifier_Lock_RenewLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_CPIdentifier_Lock_ExitLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_CPIdentifier_Lock_BreakLock, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_PowerOffDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_PowerOffDevice = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_PowerOffDevice, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_Halt = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_ReleaseGripperSkill_Halt, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_Reset = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_ReleaseGripperSkill_Reset, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_Resume = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_ReleaseGripperSkill_Resume, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_Suspend = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_ReleaseGripperSkill_Suspend, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_Start = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_ReleaseGripperSkill_Start, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_Halt = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_GraspGripperSkill_Halt, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_Reset = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_GraspGripperSkill_Reset, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_Resume = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_GraspGripperSkill_Resume, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_Suspend = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_GraspGripperSkill_Suspend, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_Start = new ExpandedNodeId(schmalz.Methods.SchmalzEcbpi_Skills_GraspGripperSkill_Start, schmalz.Namespaces.schmalz);
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
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_NetworkAddress = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpiType_CPIdentifier_NetworkAddress, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_NetworkAddress = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_CPIdentifier_NetworkAddress, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_Skills, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_Skills_ReleaseGripperSkill, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_Skills_GraspGripperSkill, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_GripPoints, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_GripPoints_VaccumPoint, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Status = new ExpandedNodeId(schmalz.Objects.SchmalzEcbpi_Status, schmalz.Namespaces.schmalz);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the SchmalzEcbpiType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType = new ExpandedNodeId(schmalz.ObjectTypes.SchmalzEcbpiType, schmalz.Namespaces.schmalz);
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
        /// The identifier for the SchmalzEcbpiType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_Locked = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_Locked, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_LockingClient = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_LockingClient, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_LockingUser = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_LockingUser, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_RemainingLockTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_RemainingLockTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_InitLock_InputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_InitLock_InputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_InitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_InitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_RenewLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_ExitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_Lock_BreakLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_Locked = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_Locked, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_LockingClient, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_LockingUser, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_RemainingLockTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_InitLock_InputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_InitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_RenewLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_ExitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpiType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpiType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpiType_CPIdentifier_Lock_BreakLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_Locked = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_Locked, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_LockingClient = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_LockingClient, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_LockingUser = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_LockingUser, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_RemainingLockTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_RemainingLockTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_InitLock_InputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_InitLock_InputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_InitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_InitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_RenewLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_RenewLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_ExitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_ExitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Lock_BreakLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Lock_BreakLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Manufacturer = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Manufacturer, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Model = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Model, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_HardwareRevision = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_HardwareRevision, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_SoftwareRevision = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_SoftwareRevision, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_DeviceRevision = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_DeviceRevision, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_DeviceManual = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_DeviceManual, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_SerialNumber = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_SerialNumber, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_RevisionCounter = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_RevisionCounter, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_Locked = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_Locked, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_LockingClient, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_LockingUser, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_RemainingLockTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_InitLock_InputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_InitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_RenewLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_ExitLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_CPIdentifier_Lock_BreakLock_OutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_PowerOffDevice_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_PowerOffDevice_InputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_PowerOffDevice_InputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Id = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Id, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Number = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_CurrentState_Number, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Id = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Id, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Number = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_Number, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_LastTransition_TransitionTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_Deletable = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_Deletable, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_AutoDelete = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_AutoDelete, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_RecycleCount = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_RecycleCount, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_MaxInstanceCount = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_MaxInstanceCount, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Id = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Id, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Number = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_CurrentState_Number, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Id = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Id, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Number = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_Number, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_LastTransition_TransitionTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_Deletable = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_Deletable, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_AutoDelete = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_AutoDelete, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_RecycleCount = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_RecycleCount, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_MaxInstanceCount = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_MaxInstanceCount, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Skills_GraspGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Skills_GraspGripperSkill_ParameterSet_Force_EURange = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Skills_GraspGripperSkill_ParameterSet_Force_EURange, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Type = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Type, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_X = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_X, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Y = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Y, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Z = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_CartesianCoordinates_Z, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_A = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_A, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_B = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_B, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_C = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_GripPoints_VaccumPoint_Offset_Orientation_C, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_PartPresent Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Status_PartPresent = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Status_PartPresent, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_InControlRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Status_InControlRange = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Status_InControlRange, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_PartDetached Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Status_PartDetached = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Status_PartDetached, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_VacuumLive Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Status_VacuumLive = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Status_VacuumLive, schmalz.Namespaces.schmalz);

        /// <summary>
        /// The identifier for the SchmalzEcbpi_Status_ActualPower Variable.
        /// </summary>
        public static readonly ExpandedNodeId SchmalzEcbpi_Status_ActualPower = new ExpandedNodeId(schmalz.Variables.SchmalzEcbpi_Status_ActualPower, schmalz.Namespaces.schmalz);
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
        /// The BrowseName for the SchmalzEcbpi component.
        /// </summary>
        public const string SchmalzEcbpi = "SchmalzEcbpi";

        /// <summary>
        /// The BrowseName for the SchmalzEcbpiType component.
        /// </summary>
        public const string SchmalzEcbpiType = "SchmalzEcbpiType";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";
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
        /// The URI for the schmalz namespace (.NET code namespace is 'schmalz').
        /// </summary>
        public const string schmalz = "https://fortiss.org/UA/schmalz/";

        /// <summary>
        /// The URI for the schmalzXsd namespace (.NET code namespace is 'schmalz').
        /// </summary>
        public const string schmalzXsd = "https://fortiss.org/UA/schmalz/Types.xsd";

        /// <summary>
        /// The URI for the fortissDevice namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDevice = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The URI for the fortissDeviceXsd namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDeviceXsd = "https://fortiss.org/UA/Device/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}