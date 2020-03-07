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
using fortiss_Device;

namespace SemanticMES
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
        /// The identifier for the SemanticMesType_Lock_InitLock Method.
        /// </summary>
        public const uint SemanticMesType_Lock_InitLock = 15085;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_RenewLock Method.
        /// </summary>
        public const uint SemanticMesType_Lock_RenewLock = 15088;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_ExitLock Method.
        /// </summary>
        public const uint SemanticMesType_Lock_ExitLock = 15090;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_BreakLock Method.
        /// </summary>
        public const uint SemanticMesType_Lock_BreakLock = 15092;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_InitLock = 15120;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_RenewLock = 15123;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_ExitLock = 15125;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_BreakLock = 15127;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_InitLock Method.
        /// </summary>
        public const uint SemanticMes_Lock_InitLock = 15155;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_RenewLock Method.
        /// </summary>
        public const uint SemanticMes_Lock_RenewLock = 15158;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_ExitLock Method.
        /// </summary>
        public const uint SemanticMes_Lock_ExitLock = 15160;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_BreakLock Method.
        /// </summary>
        public const uint SemanticMes_Lock_BreakLock = 15162;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_InitLock = 15190;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_RenewLock = 15193;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_ExitLock = 15195;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_BreakLock = 15197;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Halt Method.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_Halt = 15271;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Reset Method.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_Reset = 15272;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Resume Method.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_Resume = 15273;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Suspend Method.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_Suspend = 15274;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Start Method.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_Start = 15275;
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
        /// The identifier for the ExecuteProcessSkillType_ParameterSet Object.
        /// </summary>
        public const uint ExecuteProcessSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_NetworkAddress = 15129;

        /// <summary>
        /// The identifier for the SemanticMes Object.
        /// </summary>
        public const uint SemanticMes = 15141;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_NetworkAddress = 15199;

        /// <summary>
        /// The identifier for the SemanticMes_Skills Object.
        /// </summary>
        public const uint SemanticMes_Skills = 15211;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill Object.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill = 15212;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ParameterSet Object.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ParameterSet = 15276;

        /// <summary>
        /// The identifier for the SemanticMes_Status Object.
        /// </summary>
        public const uint SemanticMes_Status = 15279;
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
        /// The identifier for the ExecuteProcessSkillType ObjectType.
        /// </summary>
        public const uint ExecuteProcessSkillType = 15001;

        /// <summary>
        /// The identifier for the SemanticMesType ObjectType.
        /// </summary>
        public const uint SemanticMesType = 15071;
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
        /// The identifier for the ExecuteProcessSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ParameterSet_AbstractProcessIri Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ParameterSet_AbstractProcessIri = 15069;

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ParameterSet_ExecutionMode Variable.
        /// </summary>
        public const uint ExecuteProcessSkillType_ParameterSet_ExecutionMode = 15070;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_Locked Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_Locked = 15081;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_LockingClient Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_LockingClient = 15082;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_LockingUser Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_LockingUser = 15083;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_RemainingLockTime = 15084;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_InitLock_InputArguments = 15086;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_InitLock_OutputArguments = 15087;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_RenewLock_OutputArguments = 15089;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_ExitLock_OutputArguments = 15091;

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_Lock_BreakLock_OutputArguments = 15093;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_Locked = 15116;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_LockingClient = 15117;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_LockingUser = 15118;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_RemainingLockTime = 15119;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_InitLock_InputArguments = 15121;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_InitLock_OutputArguments = 15122;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_RenewLock_OutputArguments = 15124;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_ExitLock_OutputArguments = 15126;

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMesType_CPIdentifier_Lock_BreakLock_OutputArguments = 15128;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_Locked Variable.
        /// </summary>
        public const uint SemanticMes_Lock_Locked = 15151;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_LockingClient Variable.
        /// </summary>
        public const uint SemanticMes_Lock_LockingClient = 15152;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_LockingUser Variable.
        /// </summary>
        public const uint SemanticMes_Lock_LockingUser = 15153;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SemanticMes_Lock_RemainingLockTime = 15154;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Lock_InitLock_InputArguments = 15156;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Lock_InitLock_OutputArguments = 15157;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Lock_RenewLock_OutputArguments = 15159;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Lock_ExitLock_OutputArguments = 15161;

        /// <summary>
        /// The identifier for the SemanticMes_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Lock_BreakLock_OutputArguments = 15163;

        /// <summary>
        /// The identifier for the SemanticMes_Manufacturer Variable.
        /// </summary>
        public const uint SemanticMes_Manufacturer = 15164;

        /// <summary>
        /// The identifier for the SemanticMes_Model Variable.
        /// </summary>
        public const uint SemanticMes_Model = 15166;

        /// <summary>
        /// The identifier for the SemanticMes_HardwareRevision Variable.
        /// </summary>
        public const uint SemanticMes_HardwareRevision = 15167;

        /// <summary>
        /// The identifier for the SemanticMes_SoftwareRevision Variable.
        /// </summary>
        public const uint SemanticMes_SoftwareRevision = 15168;

        /// <summary>
        /// The identifier for the SemanticMes_DeviceRevision Variable.
        /// </summary>
        public const uint SemanticMes_DeviceRevision = 15169;

        /// <summary>
        /// The identifier for the SemanticMes_DeviceManual Variable.
        /// </summary>
        public const uint SemanticMes_DeviceManual = 15171;

        /// <summary>
        /// The identifier for the SemanticMes_SerialNumber Variable.
        /// </summary>
        public const uint SemanticMes_SerialNumber = 15173;

        /// <summary>
        /// The identifier for the SemanticMes_RevisionCounter Variable.
        /// </summary>
        public const uint SemanticMes_RevisionCounter = 15175;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_Locked = 15186;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_LockingClient = 15187;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_LockingUser = 15188;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_RemainingLockTime = 15189;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_InitLock_InputArguments = 15191;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_InitLock_OutputArguments = 15192;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_RenewLock_OutputArguments = 15194;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_ExitLock_OutputArguments = 15196;

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_CPIdentifier_Lock_BreakLock_OutputArguments = 15198;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_CurrentState Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_CurrentState = 15213;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Id = 15214;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Number = 15216;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_LastTransition = 15218;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Id = 15219;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Number = 15221;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_LastTransition_TransitionTime = 15222;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Deletable Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_Deletable = 15226;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_AutoDelete Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_AutoDelete = 15227;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_RecycleCount Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_RecycleCount = 15228;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateSessionId = 15230;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateClientName = 15231;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_InvocationCreationTime = 15232;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastTransitionTime = 15233;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCall = 15234;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodSessionId = 15235;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputArguments = 15236;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputArguments = 15237;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputValues = 15238;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputValues = 15239;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCallTime = 15240;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodReturnStatus = 15241;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_MaxInstanceCount = 15244;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_AbstractProcessIri Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_AbstractProcessIri = 15277;

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_ExecutionMode Variable.
        /// </summary>
        public const uint SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_ExecutionMode = 15278;
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
        /// The identifier for the SemanticMesType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_InitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_Lock_InitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_RenewLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_Lock_RenewLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_ExitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_Lock_ExitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_BreakLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_Lock_BreakLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_CPIdentifier_Lock_InitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_CPIdentifier_Lock_RenewLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_CPIdentifier_Lock_ExitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMesType_CPIdentifier_Lock_BreakLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_InitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Lock_InitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_RenewLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Lock_RenewLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_ExitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Lock_ExitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_BreakLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Lock_BreakLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_InitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_CPIdentifier_Lock_InitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_CPIdentifier_Lock_RenewLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_CPIdentifier_Lock_ExitLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_CPIdentifier_Lock_BreakLock, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_Halt = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Skills_ExecuteProcessSkill_Halt, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_Reset = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Skills_ExecuteProcessSkill_Reset, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_Resume = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Skills_ExecuteProcessSkill_Resume, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_Suspend = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Skills_ExecuteProcessSkill_Suspend, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_Start = new ExpandedNodeId(SemanticMES.Methods.SemanticMes_Skills_ExecuteProcessSkill_Start, SemanticMES.Namespaces.SemanticMES);
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
        /// The identifier for the ExecuteProcessSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ParameterSet = new ExpandedNodeId(SemanticMES.Objects.ExecuteProcessSkillType_ParameterSet, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_NetworkAddress = new ExpandedNodeId(SemanticMES.Objects.SemanticMesType_CPIdentifier_NetworkAddress, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes = new ExpandedNodeId(SemanticMES.Objects.SemanticMes, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_NetworkAddress = new ExpandedNodeId(SemanticMES.Objects.SemanticMes_CPIdentifier_NetworkAddress, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills = new ExpandedNodeId(SemanticMES.Objects.SemanticMes_Skills, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill = new ExpandedNodeId(SemanticMES.Objects.SemanticMes_Skills_ExecuteProcessSkill, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ParameterSet = new ExpandedNodeId(SemanticMES.Objects.SemanticMes_Skills_ExecuteProcessSkill_ParameterSet, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Status = new ExpandedNodeId(SemanticMES.Objects.SemanticMes_Status, SemanticMES.Namespaces.SemanticMES);
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
        /// The identifier for the ExecuteProcessSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType = new ExpandedNodeId(SemanticMES.ObjectTypes.ExecuteProcessSkillType, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType = new ExpandedNodeId(SemanticMES.ObjectTypes.SemanticMesType, SemanticMES.Namespaces.SemanticMES);
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
        /// The identifier for the ExecuteProcessSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_CurrentState_Id = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_CurrentState_Id, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_CurrentState_Number = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_CurrentState_Number, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_LastTransition_Id = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_LastTransition_Id, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_LastTransition_Number = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_LastTransition_Number, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_LastTransition_TransitionTime = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_LastTransition_TransitionTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_CreateSessionId, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_CreateClientName, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_InvocationCreationTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastTransitionTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCall, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodSessionId, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodInputValues, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodOutputValues, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodCallTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ProgramDiagnostic_LastMethodReturnStatus, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_Halted_StateNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_Halted_StateNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_Ready_StateNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_Ready_StateNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_Running_StateNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_Running_StateNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_Suspended_StateNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_Suspended_StateNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_HaltedToReady_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ReadyToRunning_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_RunningToHalted_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_RunningToReady_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_RunningToSuspended_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_SuspendedToRunning_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_SuspendedToHalted_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_SuspendedToReady_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ReadyToHalted_TransitionNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ParameterSet_AbstractProcessIri Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ParameterSet_AbstractProcessIri = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ParameterSet_AbstractProcessIri, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the ExecuteProcessSkillType_ParameterSet_ExecutionMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecuteProcessSkillType_ParameterSet_ExecutionMode = new ExpandedNodeId(SemanticMES.Variables.ExecuteProcessSkillType_ParameterSet_ExecutionMode, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_Locked = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_Locked, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_LockingClient = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_LockingClient, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_LockingUser = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_LockingUser, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_RemainingLockTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_RemainingLockTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_InitLock_InputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_InitLock_InputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_InitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_InitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_RenewLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_ExitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_Lock_BreakLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_Locked = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_Locked, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_LockingClient, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_LockingUser, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_RemainingLockTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_InitLock_InputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_InitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_RenewLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_ExitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMesType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMesType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMesType_CPIdentifier_Lock_BreakLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_Locked = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_Locked, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_LockingClient = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_LockingClient, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_LockingUser = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_LockingUser, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_RemainingLockTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_RemainingLockTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_InitLock_InputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_InitLock_InputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_InitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_InitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_RenewLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_ExitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Lock_BreakLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Manufacturer = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Manufacturer, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Model = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Model, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_HardwareRevision = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_HardwareRevision, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_SoftwareRevision = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_SoftwareRevision, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_DeviceRevision = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_DeviceRevision, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_DeviceManual = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_DeviceManual, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_SerialNumber = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_SerialNumber, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_RevisionCounter = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_RevisionCounter, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_Locked = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_Locked, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_LockingClient, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_LockingUser, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_RemainingLockTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_InitLock_InputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_InitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_RenewLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_ExitLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_CPIdentifier_Lock_BreakLock_OutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_CurrentState = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_CurrentState, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Id = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Id, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Number = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_CurrentState_Number, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_LastTransition = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_LastTransition, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Id = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Id, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Number = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_LastTransition_Number, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_LastTransition_TransitionTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_LastTransition_TransitionTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_Deletable = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_Deletable, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_AutoDelete = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_AutoDelete, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_RecycleCount = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_RecycleCount, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateSessionId, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_CreateClientName, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_InvocationCreationTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastTransitionTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCall, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodSessionId, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputArguments, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodInputValues, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodOutputValues, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodCallTime, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ProgramDiagnostic_LastMethodReturnStatus, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_MaxInstanceCount = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_MaxInstanceCount, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_AbstractProcessIri Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_AbstractProcessIri = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_AbstractProcessIri, SemanticMES.Namespaces.SemanticMES);

        /// <summary>
        /// The identifier for the SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_ExecutionMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_ExecutionMode = new ExpandedNodeId(SemanticMES.Variables.SemanticMes_Skills_ExecuteProcessSkill_ParameterSet_ExecutionMode, SemanticMES.Namespaces.SemanticMES);
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
        /// The BrowseName for the ExecuteProcessSkillType component.
        /// </summary>
        public const string ExecuteProcessSkillType = "ExecuteProcessSkill";

        /// <summary>
        /// The BrowseName for the SemanticMes component.
        /// </summary>
        public const string SemanticMes = "SemanticMes";

        /// <summary>
        /// The BrowseName for the SemanticMesType component.
        /// </summary>
        public const string SemanticMesType = "SemanticMesType";

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
        /// The URI for the SemanticMES namespace (.NET code namespace is 'SemanticMES').
        /// </summary>
        public const string SemanticMES = "https://fortiss.org/UA/SemanticMES/";

        /// <summary>
        /// The URI for the SemanticMESXsd namespace (.NET code namespace is 'SemanticMES').
        /// </summary>
        public const string SemanticMESXsd = "https://fortiss.org/UA/SemanticMES/Types.xsd";

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
        /// The URI for the fortissDevice namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDevice = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The URI for the fortissDeviceXsd namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDeviceXsd = "https://fortiss.org/UA/Device/Types.xsd";
    }
    #endregion
}