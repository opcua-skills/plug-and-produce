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

namespace robotiq
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
        /// The identifier for the Robotiq2FType_Lock_InitLock Method.
        /// </summary>
        public const uint Robotiq2FType_Lock_InitLock = 15015;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_RenewLock Method.
        /// </summary>
        public const uint Robotiq2FType_Lock_RenewLock = 15018;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_ExitLock Method.
        /// </summary>
        public const uint Robotiq2FType_Lock_ExitLock = 15020;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_BreakLock Method.
        /// </summary>
        public const uint Robotiq2FType_Lock_BreakLock = 15022;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_InitLock = 15050;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_RenewLock = 15053;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_ExitLock = 15055;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_BreakLock = 15057;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_InitLock Method.
        /// </summary>
        public const uint Robotiq2F_Lock_InitLock = 15085;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_RenewLock Method.
        /// </summary>
        public const uint Robotiq2F_Lock_RenewLock = 15088;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_ExitLock Method.
        /// </summary>
        public const uint Robotiq2F_Lock_ExitLock = 15090;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_BreakLock Method.
        /// </summary>
        public const uint Robotiq2F_Lock_BreakLock = 15092;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_InitLock = 15120;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_RenewLock = 15123;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_ExitLock = 15125;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_BreakLock = 15127;

        /// <summary>
        /// The identifier for the Robotiq2F_PowerOffDevice Method.
        /// </summary>
        public const uint Robotiq2F_PowerOffDevice = 15230;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Halt Method.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_Halt = 15174;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Reset Method.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_Reset = 15175;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Resume Method.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_Resume = 15176;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Suspend Method.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_Suspend = 15177;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Start Method.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_Start = 15178;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Halt Method.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_Halt = 15218;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Reset Method.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_Reset = 15219;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Resume Method.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_Resume = 15220;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Suspend Method.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_Suspend = 15221;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Start Method.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_Start = 15222;
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
        /// The identifier for the Robotiq2FType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_NetworkAddress = 15059;

        /// <summary>
        /// The identifier for the Robotiq2F Object.
        /// </summary>
        public const uint Robotiq2F = 15071;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_NetworkAddress = 15129;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills Object.
        /// </summary>
        public const uint Robotiq2F_Skills = 15141;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill Object.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill = 15142;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill Object.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill = 15186;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints Object.
        /// </summary>
        public const uint Robotiq2F_GripPoints = 15232;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip Object.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip = 15233;
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
        /// The identifier for the Robotiq2FType ObjectType.
        /// </summary>
        public const uint Robotiq2FType = 15001;
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
        /// The identifier for the Robotiq2FType_Lock_Locked Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_Locked = 15011;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_LockingClient Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_LockingClient = 15012;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_LockingUser Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_LockingUser = 15013;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_RemainingLockTime = 15014;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_InitLock_InputArguments = 15016;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_InitLock_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_RenewLock_OutputArguments = 15019;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_ExitLock_OutputArguments = 15021;

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_Lock_BreakLock_OutputArguments = 15023;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_Locked = 15046;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_LockingClient = 15047;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_LockingUser = 15048;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_RemainingLockTime = 15049;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_InitLock_InputArguments = 15051;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_InitLock_OutputArguments = 15052;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_RenewLock_OutputArguments = 15054;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_ExitLock_OutputArguments = 15056;

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2FType_CPIdentifier_Lock_BreakLock_OutputArguments = 15058;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_Locked Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_Locked = 15081;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_LockingClient Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_LockingClient = 15082;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_LockingUser Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_LockingUser = 15083;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_RemainingLockTime = 15084;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_InitLock_InputArguments = 15086;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_InitLock_OutputArguments = 15087;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_RenewLock_OutputArguments = 15089;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_ExitLock_OutputArguments = 15091;

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Lock_BreakLock_OutputArguments = 15093;

        /// <summary>
        /// The identifier for the Robotiq2F_Manufacturer Variable.
        /// </summary>
        public const uint Robotiq2F_Manufacturer = 15094;

        /// <summary>
        /// The identifier for the Robotiq2F_Model Variable.
        /// </summary>
        public const uint Robotiq2F_Model = 15096;

        /// <summary>
        /// The identifier for the Robotiq2F_HardwareRevision Variable.
        /// </summary>
        public const uint Robotiq2F_HardwareRevision = 15097;

        /// <summary>
        /// The identifier for the Robotiq2F_SoftwareRevision Variable.
        /// </summary>
        public const uint Robotiq2F_SoftwareRevision = 15098;

        /// <summary>
        /// The identifier for the Robotiq2F_DeviceRevision Variable.
        /// </summary>
        public const uint Robotiq2F_DeviceRevision = 15099;

        /// <summary>
        /// The identifier for the Robotiq2F_DeviceManual Variable.
        /// </summary>
        public const uint Robotiq2F_DeviceManual = 15101;

        /// <summary>
        /// The identifier for the Robotiq2F_SerialNumber Variable.
        /// </summary>
        public const uint Robotiq2F_SerialNumber = 15103;

        /// <summary>
        /// The identifier for the Robotiq2F_RevisionCounter Variable.
        /// </summary>
        public const uint Robotiq2F_RevisionCounter = 15105;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_Locked = 15116;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_LockingClient = 15117;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_LockingUser = 15118;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_RemainingLockTime = 15119;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_InitLock_InputArguments = 15121;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_InitLock_OutputArguments = 15122;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_RenewLock_OutputArguments = 15124;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_ExitLock_OutputArguments = 15126;

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_CPIdentifier_Lock_BreakLock_OutputArguments = 15128;

        /// <summary>
        /// The identifier for the Robotiq2F_PowerOffDevice_InputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_PowerOffDevice_InputArguments = 15231;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_CurrentState = 15143;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Id = 15144;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Number = 15146;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_LastTransition = 15148;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Id = 15149;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Number = 15151;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_TransitionTime = 15152;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Deletable Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_Deletable = 15156;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_AutoDelete = 15157;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_RecycleCount = 15158;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = 15160;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = 15161;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15162;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = 15163;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = 15164;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15165;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15166;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15167;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15168;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15169;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15170;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15171;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_MaxInstanceCount = 15173;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange = 15184;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_CurrentState Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_CurrentState = 15187;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_CurrentState_Id = 15188;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_CurrentState_Number = 15190;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_LastTransition = 15192;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_LastTransition_Id = 15193;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_LastTransition_Number = 15195;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_LastTransition_TransitionTime = 15196;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Deletable Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_Deletable = 15200;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_AutoDelete Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_AutoDelete = 15201;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_RecycleCount Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_RecycleCount = 15202;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId = 15204;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName = 15205;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime = 15206;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime = 15207;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall = 15208;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId = 15209;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments = 15210;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = 15211;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues = 15212;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues = 15213;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime = 15214;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = 15215;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_MaxInstanceCount = 15217;

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public const uint Robotiq2F_Skills_GraspGripperSkill_ParameterSet_Force_EURange = 15228;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Type Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Type = 15234;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset = 15235;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates = 15236;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_Orientation = 15238;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_X = 15243;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Y = 15244;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Z = 15245;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation_A Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_Orientation_A = 15246;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation_B Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_Orientation_B = 15247;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation_C Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Offset_Orientation_C = 15248;

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Range Variable.
        /// </summary>
        public const uint Robotiq2F_GripPoints_Tip_Range = 15249;
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
        /// The identifier for the Robotiq2FType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_InitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_Lock_InitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_RenewLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_Lock_RenewLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_ExitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_Lock_ExitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_BreakLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_Lock_BreakLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_CPIdentifier_Lock_InitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_CPIdentifier_Lock_RenewLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_CPIdentifier_Lock_ExitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(robotiq.Methods.Robotiq2FType_CPIdentifier_Lock_BreakLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_InitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Lock_InitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_RenewLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Lock_RenewLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_ExitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Lock_ExitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_BreakLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Lock_BreakLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_InitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_CPIdentifier_Lock_InitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_CPIdentifier_Lock_RenewLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_CPIdentifier_Lock_ExitLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(robotiq.Methods.Robotiq2F_CPIdentifier_Lock_BreakLock, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_PowerOffDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_PowerOffDevice = new ExpandedNodeId(robotiq.Methods.Robotiq2F_PowerOffDevice, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_Halt = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_ReleaseGripperSkill_Halt, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_Reset = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_ReleaseGripperSkill_Reset, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_Resume = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_ReleaseGripperSkill_Resume, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_Suspend = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_ReleaseGripperSkill_Suspend, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_Start = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_ReleaseGripperSkill_Start, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_Halt = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_GraspGripperSkill_Halt, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_Reset = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_GraspGripperSkill_Reset, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_Resume = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_GraspGripperSkill_Resume, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_Suspend = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_GraspGripperSkill_Suspend, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_Start = new ExpandedNodeId(robotiq.Methods.Robotiq2F_Skills_GraspGripperSkill_Start, robotiq.Namespaces.robotiq);
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
        /// The identifier for the Robotiq2FType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_NetworkAddress = new ExpandedNodeId(robotiq.Objects.Robotiq2FType_CPIdentifier_NetworkAddress, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F = new ExpandedNodeId(robotiq.Objects.Robotiq2F, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_NetworkAddress = new ExpandedNodeId(robotiq.Objects.Robotiq2F_CPIdentifier_NetworkAddress, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills = new ExpandedNodeId(robotiq.Objects.Robotiq2F_Skills, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill = new ExpandedNodeId(robotiq.Objects.Robotiq2F_Skills_ReleaseGripperSkill, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill = new ExpandedNodeId(robotiq.Objects.Robotiq2F_Skills_GraspGripperSkill, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints = new ExpandedNodeId(robotiq.Objects.Robotiq2F_GripPoints, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip Object.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip = new ExpandedNodeId(robotiq.Objects.Robotiq2F_GripPoints_Tip, robotiq.Namespaces.robotiq);
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
        /// The identifier for the Robotiq2FType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType = new ExpandedNodeId(robotiq.ObjectTypes.Robotiq2FType, robotiq.Namespaces.robotiq);
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
        /// The identifier for the Robotiq2FType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_Locked = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_Locked, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_LockingClient = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_LockingClient, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_LockingUser = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_LockingUser, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_RemainingLockTime = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_RemainingLockTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_InitLock_InputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_InitLock_InputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_InitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_InitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_RenewLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_ExitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_Lock_BreakLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_Locked = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_Locked, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_LockingClient, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_LockingUser, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_RemainingLockTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_InitLock_InputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_InitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_RenewLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_ExitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2FType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2FType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2FType_CPIdentifier_Lock_BreakLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_Locked = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_Locked, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_LockingClient = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_LockingClient, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_LockingUser = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_LockingUser, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_RemainingLockTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_RemainingLockTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_InitLock_InputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_InitLock_InputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_InitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_InitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_RenewLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_RenewLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_ExitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_ExitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Lock_BreakLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Lock_BreakLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Manufacturer = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Manufacturer, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Model = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Model, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_HardwareRevision = new ExpandedNodeId(robotiq.Variables.Robotiq2F_HardwareRevision, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_SoftwareRevision = new ExpandedNodeId(robotiq.Variables.Robotiq2F_SoftwareRevision, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_DeviceRevision = new ExpandedNodeId(robotiq.Variables.Robotiq2F_DeviceRevision, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_DeviceManual = new ExpandedNodeId(robotiq.Variables.Robotiq2F_DeviceManual, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_SerialNumber = new ExpandedNodeId(robotiq.Variables.Robotiq2F_SerialNumber, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_RevisionCounter = new ExpandedNodeId(robotiq.Variables.Robotiq2F_RevisionCounter, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_Locked = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_Locked, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_LockingClient, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_LockingUser, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_RemainingLockTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_InitLock_InputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_InitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_RenewLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_ExitLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_CPIdentifier_Lock_BreakLock_OutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_PowerOffDevice_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_PowerOffDevice_InputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_PowerOffDevice_InputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_CurrentState = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_CurrentState, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Id = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Id, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Number = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_CurrentState_Number, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_LastTransition = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_LastTransition, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Id = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Id, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Number = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_Number, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_LastTransition_TransitionTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_Deletable = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_Deletable, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_AutoDelete = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_AutoDelete, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_RecycleCount = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_RecycleCount, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateSessionId, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_CreateClientName, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_InvocationCreationTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastTransitionTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCall, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodSessionId, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodInputValues, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodOutputValues, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodCallTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_MaxInstanceCount = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_MaxInstanceCount, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_ReleaseGripperSkill_ParameterSet_Force_EURange, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_CurrentState = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_CurrentState, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_CurrentState_Id = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_CurrentState_Id, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_CurrentState_Number = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_CurrentState_Number, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_LastTransition = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_LastTransition, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_LastTransition_Id = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_LastTransition_Id, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_LastTransition_Number = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_LastTransition_Number, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_LastTransition_TransitionTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_LastTransition_TransitionTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_Deletable = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_Deletable, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_AutoDelete = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_AutoDelete, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_RecycleCount = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_RecycleCount, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateSessionId, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_CreateClientName, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_InvocationCreationTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastTransitionTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCall, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodSessionId, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputArguments, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodInputValues, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodOutputValues, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodCallTime, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ProgramDiagnostic_LastMethodReturnStatus, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_MaxInstanceCount = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_MaxInstanceCount, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_Skills_GraspGripperSkill_ParameterSet_Force_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_Skills_GraspGripperSkill_ParameterSet_Force_EURange = new ExpandedNodeId(robotiq.Variables.Robotiq2F_Skills_GraspGripperSkill_ParameterSet_Force_EURange, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Type = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Type, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_Orientation = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_Orientation, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_X = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_X, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Y = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Y, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Z = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_CartesianCoordinates_Z, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_Orientation_A = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_Orientation_A, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_Orientation_B = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_Orientation_B, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Offset_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Offset_Orientation_C = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Offset_Orientation_C, robotiq.Namespaces.robotiq);

        /// <summary>
        /// The identifier for the Robotiq2F_GripPoints_Tip_Range Variable.
        /// </summary>
        public static readonly ExpandedNodeId Robotiq2F_GripPoints_Tip_Range = new ExpandedNodeId(robotiq.Variables.Robotiq2F_GripPoints_Tip_Range, robotiq.Namespaces.robotiq);
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
        /// The BrowseName for the Robotiq2F component.
        /// </summary>
        public const string Robotiq2F = "Robotiq2F";

        /// <summary>
        /// The BrowseName for the Robotiq2FType component.
        /// </summary>
        public const string Robotiq2FType = "Robotiq2FType";
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
        /// The URI for the robotiq namespace (.NET code namespace is 'robotiq').
        /// </summary>
        public const string robotiq = "https://fortiss.org/UA/robotiq/";

        /// <summary>
        /// The URI for the robotiqXsd namespace (.NET code namespace is 'robotiq').
        /// </summary>
        public const string robotiqXsd = "https://fortiss.org/UA/robotiq/Types.xsd";

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