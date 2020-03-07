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

namespace KelvinToolchanger
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
        /// The identifier for the KelvinToolchangerType_Lock_InitLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_InitLock = 15085;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_RenewLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_RenewLock = 15088;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_ExitLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_ExitLock = 15090;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_BreakLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_BreakLock = 15092;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_InitLock = 15120;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_RenewLock = 15123;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_ExitLock = 15125;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_BreakLock = 15127;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_InitLock Method.
        /// </summary>
        public const uint KelvinToolchanger_Lock_InitLock = 15155;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_RenewLock Method.
        /// </summary>
        public const uint KelvinToolchanger_Lock_RenewLock = 15158;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_ExitLock Method.
        /// </summary>
        public const uint KelvinToolchanger_Lock_ExitLock = 15160;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_BreakLock Method.
        /// </summary>
        public const uint KelvinToolchanger_Lock_BreakLock = 15162;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_InitLock = 15190;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_RenewLock = 15193;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_ExitLock = 15195;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_BreakLock = 15197;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Halt Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_Halt = 15244;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Reset Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_Reset = 15245;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Resume Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_Resume = 15246;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Suspend Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_Suspend = 15247;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Start Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_Start = 15248;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Halt Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_Halt = 15387;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Reset Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_Reset = 15388;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Resume Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_Resume = 15389;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Suspend Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_Suspend = 15390;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Start Method.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_Start = 15391;
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
        /// The identifier for the ChangeToolSkillType_ParameterSet Object.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the DropToolSkillType_ParameterSet Object.
        /// </summary>
        public const uint DropToolSkillType_ParameterSet = 15354;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_NetworkAddress = 15129;

        /// <summary>
        /// The identifier for the KelvinToolchanger Object.
        /// </summary>
        public const uint KelvinToolchanger = 15141;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_NetworkAddress = 15199;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills Object.
        /// </summary>
        public const uint KelvinToolchanger_Skills = 15211;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill Object.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill = 15212;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet Object.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet = 15249;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill Object.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill = 15355;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ParameterSet Object.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ParameterSet = 15392;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool Object.
        /// </summary>
        public const uint KelvinToolchanger_CurrentTool = 15284;
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
        /// The identifier for the ChangeToolSkillType ObjectType.
        /// </summary>
        public const uint ChangeToolSkillType = 15001;

        /// <summary>
        /// The identifier for the DropToolSkillType ObjectType.
        /// </summary>
        public const uint DropToolSkillType = 15287;

        /// <summary>
        /// The identifier for the ToolInfoType ObjectType.
        /// </summary>
        public const uint ToolInfoType = 15266;

        /// <summary>
        /// The identifier for the KelvinToolchangerType ObjectType.
        /// </summary>
        public const uint KelvinToolchangerType = 15071;
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
        /// The identifier for the ChangeToolSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint ChangeToolSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint ChangeToolSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint ChangeToolSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint ChangeToolSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ChangeToolSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition = 15252;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates = 15253;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_Orientation = 15255;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_X = 15260;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Y = 15261;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Z = 15262;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_A Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_A = 15263;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_B Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_B = 15264;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_C Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_C = 15265;

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolAppUri Variable.
        /// </summary>
        public const uint ChangeToolSkillType_ParameterSet_ToolAppUri = 15267;

        /// <summary>
        /// The identifier for the DropToolSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint DropToolSkillType_CurrentState_Id = 15289;

        /// <summary>
        /// The identifier for the DropToolSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint DropToolSkillType_CurrentState_Number = 15291;

        /// <summary>
        /// The identifier for the DropToolSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint DropToolSkillType_LastTransition_Id = 15294;

        /// <summary>
        /// The identifier for the DropToolSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint DropToolSkillType_LastTransition_Number = 15296;

        /// <summary>
        /// The identifier for the DropToolSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint DropToolSkillType_LastTransition_TransitionTime = 15297;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_CreateSessionId = 15309;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_CreateClientName = 15310;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_InvocationCreationTime = 15311;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastTransitionTime = 15312;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodCall = 15313;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodSessionId = 15314;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodInputArguments = 15315;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15316;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodInputValues = 15317;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodOutputValues = 15318;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodCallTime = 15319;

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint DropToolSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15320;

        /// <summary>
        /// The identifier for the DropToolSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_Halted_StateNumber = 15323;

        /// <summary>
        /// The identifier for the DropToolSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_Ready_StateNumber = 15325;

        /// <summary>
        /// The identifier for the DropToolSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_Running_StateNumber = 15327;

        /// <summary>
        /// The identifier for the DropToolSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_Suspended_StateNumber = 15329;

        /// <summary>
        /// The identifier for the DropToolSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_HaltedToReady_TransitionNumber = 15331;

        /// <summary>
        /// The identifier for the DropToolSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_ReadyToRunning_TransitionNumber = 15333;

        /// <summary>
        /// The identifier for the DropToolSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_RunningToHalted_TransitionNumber = 15335;

        /// <summary>
        /// The identifier for the DropToolSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_RunningToReady_TransitionNumber = 15337;

        /// <summary>
        /// The identifier for the DropToolSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_RunningToSuspended_TransitionNumber = 15339;

        /// <summary>
        /// The identifier for the DropToolSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_SuspendedToRunning_TransitionNumber = 15341;

        /// <summary>
        /// The identifier for the DropToolSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_SuspendedToHalted_TransitionNumber = 15343;

        /// <summary>
        /// The identifier for the DropToolSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_SuspendedToReady_TransitionNumber = 15345;

        /// <summary>
        /// The identifier for the DropToolSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint DropToolSkillType_ReadyToHalted_TransitionNumber = 15347;

        /// <summary>
        /// The identifier for the ToolInfoType_Ready Variable.
        /// </summary>
        public const uint ToolInfoType_Ready = 15250;

        /// <summary>
        /// The identifier for the ToolInfoType_Id Variable.
        /// </summary>
        public const uint ToolInfoType_Id = 15069;

        /// <summary>
        /// The identifier for the ToolInfoType_Description Variable.
        /// </summary>
        public const uint ToolInfoType_Description = 15268;

        /// <summary>
        /// The identifier for the ToolInfoType_Endpoint Variable.
        /// </summary>
        public const uint ToolInfoType_Endpoint = 15393;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_Locked Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_Locked = 15081;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_LockingClient Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_LockingClient = 15082;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_LockingUser Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_LockingUser = 15083;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_RemainingLockTime = 15084;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_InitLock_InputArguments = 15086;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_InitLock_OutputArguments = 15087;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_RenewLock_OutputArguments = 15089;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_ExitLock_OutputArguments = 15091;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_Lock_BreakLock_OutputArguments = 15093;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_Locked = 15116;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_LockingClient = 15117;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_LockingUser = 15118;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_RemainingLockTime = 15119;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_InitLock_InputArguments = 15121;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_InitLock_OutputArguments = 15122;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_RenewLock_OutputArguments = 15124;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_ExitLock_OutputArguments = 15126;

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchangerType_CPIdentifier_Lock_BreakLock_OutputArguments = 15128;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_Locked Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_Locked = 15151;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_LockingClient Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_LockingClient = 15152;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_LockingUser Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_LockingUser = 15153;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_RemainingLockTime = 15154;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_InitLock_InputArguments = 15156;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_InitLock_OutputArguments = 15157;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_RenewLock_OutputArguments = 15159;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_ExitLock_OutputArguments = 15161;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Lock_BreakLock_OutputArguments = 15163;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Manufacturer Variable.
        /// </summary>
        public const uint KelvinToolchanger_Manufacturer = 15164;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Model Variable.
        /// </summary>
        public const uint KelvinToolchanger_Model = 15166;

        /// <summary>
        /// The identifier for the KelvinToolchanger_HardwareRevision Variable.
        /// </summary>
        public const uint KelvinToolchanger_HardwareRevision = 15167;

        /// <summary>
        /// The identifier for the KelvinToolchanger_SoftwareRevision Variable.
        /// </summary>
        public const uint KelvinToolchanger_SoftwareRevision = 15168;

        /// <summary>
        /// The identifier for the KelvinToolchanger_DeviceRevision Variable.
        /// </summary>
        public const uint KelvinToolchanger_DeviceRevision = 15169;

        /// <summary>
        /// The identifier for the KelvinToolchanger_DeviceManual Variable.
        /// </summary>
        public const uint KelvinToolchanger_DeviceManual = 15171;

        /// <summary>
        /// The identifier for the KelvinToolchanger_SerialNumber Variable.
        /// </summary>
        public const uint KelvinToolchanger_SerialNumber = 15173;

        /// <summary>
        /// The identifier for the KelvinToolchanger_RevisionCounter Variable.
        /// </summary>
        public const uint KelvinToolchanger_RevisionCounter = 15175;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_Locked = 15186;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_LockingClient = 15187;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_LockingUser = 15188;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_RemainingLockTime = 15189;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_InitLock_InputArguments = 15191;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_InitLock_OutputArguments = 15192;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_RenewLock_OutputArguments = 15194;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_ExitLock_OutputArguments = 15196;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_CPIdentifier_Lock_BreakLock_OutputArguments = 15198;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_CurrentState Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_CurrentState = 15213;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Id = 15214;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Number = 15216;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_LastTransition = 15218;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Id = 15219;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Number = 15221;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_TransitionTime = 15222;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Deletable Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_Deletable = 15226;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_AutoDelete Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_AutoDelete = 15227;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_RecycleCount Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_RecycleCount = 15228;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateSessionId = 15230;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateClientName = 15231;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_InvocationCreationTime = 15232;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastTransitionTime = 15233;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCall = 15234;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodSessionId = 15235;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputArguments = 15236;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputArguments = 15237;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputValues = 15238;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputValues = 15239;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCallTime = 15240;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodReturnStatus = 15241;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_MaxInstanceCount = 15243;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition = 15269;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates = 15270;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation = 15272;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_X = 15277;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Y = 15278;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Z = 15279;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_A Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_A = 15280;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_B Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_B = 15281;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_C Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_C = 15282;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolAppUri Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolAppUri = 15285;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_CurrentState Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_CurrentState = 15356;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_CurrentState_Id = 15357;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_CurrentState_Number = 15359;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_LastTransition = 15361;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_LastTransition_Id = 15362;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_LastTransition_Number = 15364;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_LastTransition_TransitionTime = 15365;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Deletable Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_Deletable = 15369;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_AutoDelete Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_AutoDelete = 15370;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_RecycleCount Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_RecycleCount = 15371;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateSessionId = 15373;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateClientName = 15374;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_InvocationCreationTime = 15375;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastTransitionTime = 15376;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCall = 15377;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodSessionId = 15378;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputArguments = 15379;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputArguments = 15380;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputValues = 15381;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputValues = 15382;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCallTime = 15383;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodReturnStatus = 15384;

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint KelvinToolchanger_Skills_DropToolSkill_MaxInstanceCount = 15386;

        /// <summary>
        /// The identifier for the KelvinToolchanger_HasTool Variable.
        /// </summary>
        public const uint KelvinToolchanger_HasTool = 15283;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Ready Variable.
        /// </summary>
        public const uint KelvinToolchanger_CurrentTool_Ready = 15251;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Id Variable.
        /// </summary>
        public const uint KelvinToolchanger_CurrentTool_Id = 15070;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Description Variable.
        /// </summary>
        public const uint KelvinToolchanger_CurrentTool_Description = 15286;

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Endpoint Variable.
        /// </summary>
        public const uint KelvinToolchanger_CurrentTool_Endpoint = 15394;
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
        /// The identifier for the KelvinToolchangerType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_InitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_Lock_InitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_RenewLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_Lock_RenewLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_ExitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_Lock_ExitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_BreakLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_Lock_BreakLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_CPIdentifier_Lock_InitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_CPIdentifier_Lock_RenewLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_CPIdentifier_Lock_ExitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchangerType_CPIdentifier_Lock_BreakLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_InitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Lock_InitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_RenewLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Lock_RenewLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_ExitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Lock_ExitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_BreakLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Lock_BreakLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_InitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_CPIdentifier_Lock_InitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_CPIdentifier_Lock_RenewLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_CPIdentifier_Lock_ExitLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_CPIdentifier_Lock_BreakLock, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_Halt = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_ChangeToolSkill_Halt, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_Reset = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_ChangeToolSkill_Reset, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_Resume = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_ChangeToolSkill_Resume, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_Suspend = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_ChangeToolSkill_Suspend, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_Start = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_ChangeToolSkill_Start, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_Halt = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_DropToolSkill_Halt, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_Reset = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_DropToolSkill_Reset, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_Resume = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_DropToolSkill_Resume, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_Suspend = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_DropToolSkill_Suspend, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_Start = new ExpandedNodeId(KelvinToolchanger.Methods.KelvinToolchanger_Skills_DropToolSkill_Start, KelvinToolchanger.Namespaces.KelvinToolchanger);
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
        /// The identifier for the ChangeToolSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet = new ExpandedNodeId(KelvinToolchanger.Objects.ChangeToolSkillType_ParameterSet, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ParameterSet = new ExpandedNodeId(KelvinToolchanger.Objects.DropToolSkillType_ParameterSet, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_NetworkAddress = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchangerType_CPIdentifier_NetworkAddress, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_NetworkAddress = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_CPIdentifier_NetworkAddress, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_Skills, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_Skills_ChangeToolSkill, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_Skills_DropToolSkill, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ParameterSet = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_Skills_DropToolSkill_ParameterSet, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool Object.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CurrentTool = new ExpandedNodeId(KelvinToolchanger.Objects.KelvinToolchanger_CurrentTool, KelvinToolchanger.Namespaces.KelvinToolchanger);
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
        /// The identifier for the ChangeToolSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType = new ExpandedNodeId(KelvinToolchanger.ObjectTypes.ChangeToolSkillType, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType = new ExpandedNodeId(KelvinToolchanger.ObjectTypes.DropToolSkillType, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ToolInfoType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ToolInfoType = new ExpandedNodeId(KelvinToolchanger.ObjectTypes.ToolInfoType, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType = new ExpandedNodeId(KelvinToolchanger.ObjectTypes.KelvinToolchangerType, KelvinToolchanger.Namespaces.KelvinToolchanger);
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
        /// The identifier for the ChangeToolSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_CurrentState_Id = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_CurrentState_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_CurrentState_Number = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_CurrentState_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_LastTransition_Id = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_LastTransition_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_LastTransition_Number = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_LastTransition_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_LastTransition_TransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_LastTransition_TransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_CreateSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_CreateClientName, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_InvocationCreationTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastTransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodCall, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodInputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodInputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodOutputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodCallTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ProgramDiagnostic_LastMethodReturnStatus, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_Halted_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_Halted_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_Ready_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_Ready_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_Running_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_Running_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_Suspended_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_Suspended_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_HaltedToReady_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ReadyToRunning_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_RunningToHalted_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_RunningToReady_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_RunningToSuspended_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_SuspendedToRunning_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_SuspendedToHalted_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_SuspendedToReady_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ReadyToHalted_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_Orientation = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_Orientation, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_X = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_X, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Y = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Y, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Z = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_CartesianCoordinates_Z, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_A = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_A, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_B = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_B, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_C = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolPosition_Orientation_C, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ChangeToolSkillType_ParameterSet_ToolAppUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChangeToolSkillType_ParameterSet_ToolAppUri = new ExpandedNodeId(KelvinToolchanger.Variables.ChangeToolSkillType_ParameterSet_ToolAppUri, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_CurrentState_Id = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_CurrentState_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_CurrentState_Number = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_CurrentState_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_LastTransition_Id = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_LastTransition_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_LastTransition_Number = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_LastTransition_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_LastTransition_TransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_LastTransition_TransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_CreateSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_CreateClientName, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_InvocationCreationTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastTransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodCall, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodInputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodOutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodInputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodOutputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodCallTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ProgramDiagnostic_LastMethodReturnStatus, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_Halted_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_Halted_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_Ready_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_Ready_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_Running_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_Running_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_Suspended_StateNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_Suspended_StateNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_HaltedToReady_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ReadyToRunning_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_RunningToHalted_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_RunningToReady_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_RunningToSuspended_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_SuspendedToRunning_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_SuspendedToHalted_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_SuspendedToReady_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the DropToolSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DropToolSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(KelvinToolchanger.Variables.DropToolSkillType_ReadyToHalted_TransitionNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ToolInfoType_Ready Variable.
        /// </summary>
        public static readonly ExpandedNodeId ToolInfoType_Ready = new ExpandedNodeId(KelvinToolchanger.Variables.ToolInfoType_Ready, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ToolInfoType_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ToolInfoType_Id = new ExpandedNodeId(KelvinToolchanger.Variables.ToolInfoType_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ToolInfoType_Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId ToolInfoType_Description = new ExpandedNodeId(KelvinToolchanger.Variables.ToolInfoType_Description, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the ToolInfoType_Endpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId ToolInfoType_Endpoint = new ExpandedNodeId(KelvinToolchanger.Variables.ToolInfoType_Endpoint, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_Locked = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_Locked, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_LockingClient = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_LockingClient, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_LockingUser = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_LockingUser, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_RemainingLockTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_RemainingLockTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_InitLock_InputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_InitLock_InputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_InitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_InitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_RenewLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_ExitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_Lock_BreakLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_Locked = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_Locked, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_LockingClient, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_LockingUser, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_RemainingLockTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_InitLock_InputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_InitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_RenewLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_ExitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchangerType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchangerType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchangerType_CPIdentifier_Lock_BreakLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_Locked = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_Locked, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_LockingClient = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_LockingClient, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_LockingUser = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_LockingUser, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_RemainingLockTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_RemainingLockTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_InitLock_InputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_InitLock_InputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_InitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_InitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_RenewLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_RenewLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_ExitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_ExitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Lock_BreakLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Lock_BreakLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Manufacturer = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Manufacturer, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Model = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Model, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_HardwareRevision = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_HardwareRevision, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_SoftwareRevision = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_SoftwareRevision, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_DeviceRevision = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_DeviceRevision, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_DeviceManual = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_DeviceManual, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_SerialNumber = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_SerialNumber, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_RevisionCounter = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_RevisionCounter, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_Locked = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_Locked, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_LockingClient, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_LockingUser, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_RemainingLockTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_InitLock_InputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_InitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_RenewLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_ExitLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CPIdentifier_Lock_BreakLock_OutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_CurrentState = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_CurrentState, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Id = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Number = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_CurrentState_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_LastTransition = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_LastTransition, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Id = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Number = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_TransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_LastTransition_TransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_Deletable = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_Deletable, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_AutoDelete = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_AutoDelete, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_RecycleCount = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_RecycleCount, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_CreateClientName, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_InvocationCreationTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastTransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCall, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodInputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodOutputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodCallTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ProgramDiagnostic_LastMethodReturnStatus, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_MaxInstanceCount = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_MaxInstanceCount, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_X = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_X, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Y = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Y, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Z = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_CartesianCoordinates_Z, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_A = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_A, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_B = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_B, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_C = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolPosition_Orientation_C, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolAppUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolAppUri = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_ChangeToolSkill_ParameterSet_ToolAppUri, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_CurrentState = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_CurrentState, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_CurrentState_Id = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_CurrentState_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_CurrentState_Number = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_CurrentState_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_LastTransition = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_LastTransition, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_LastTransition_Id = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_LastTransition_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_LastTransition_Number = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_LastTransition_Number, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_LastTransition_TransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_LastTransition_TransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_Deletable = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_Deletable, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_AutoDelete = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_AutoDelete, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_RecycleCount = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_RecycleCount, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_CreateClientName, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_InvocationCreationTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastTransitionTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCall, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodSessionId, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputArguments, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodInputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodOutputValues, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodCallTime, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_ProgramDiagnostic_LastMethodReturnStatus, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_Skills_DropToolSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_Skills_DropToolSkill_MaxInstanceCount = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_Skills_DropToolSkill_MaxInstanceCount, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_HasTool Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_HasTool = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_HasTool, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Ready Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CurrentTool_Ready = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CurrentTool_Ready, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CurrentTool_Id = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CurrentTool_Id, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CurrentTool_Description = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CurrentTool_Description, KelvinToolchanger.Namespaces.KelvinToolchanger);

        /// <summary>
        /// The identifier for the KelvinToolchanger_CurrentTool_Endpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId KelvinToolchanger_CurrentTool_Endpoint = new ExpandedNodeId(KelvinToolchanger.Variables.KelvinToolchanger_CurrentTool_Endpoint, KelvinToolchanger.Namespaces.KelvinToolchanger);
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
        /// The BrowseName for the ChangeToolSkillType component.
        /// </summary>
        public const string ChangeToolSkillType = "ChangeToolSkill";

        /// <summary>
        /// The BrowseName for the CurrentTool component.
        /// </summary>
        public const string CurrentTool = "CurrentTool";

        /// <summary>
        /// The BrowseName for the Description component.
        /// </summary>
        public const string Description = "Description";

        /// <summary>
        /// The BrowseName for the DropToolSkillType component.
        /// </summary>
        public const string DropToolSkillType = "DropToolSkill";

        /// <summary>
        /// The BrowseName for the Endpoint component.
        /// </summary>
        public const string Endpoint = "Endpoint";

        /// <summary>
        /// The BrowseName for the HasTool component.
        /// </summary>
        public const string HasTool = "HasTool";

        /// <summary>
        /// The BrowseName for the Id component.
        /// </summary>
        public const string Id = "Id";

        /// <summary>
        /// The BrowseName for the KelvinToolchanger component.
        /// </summary>
        public const string KelvinToolchanger = "KelvinToolchanger";

        /// <summary>
        /// The BrowseName for the KelvinToolchangerType component.
        /// </summary>
        public const string KelvinToolchangerType = "KelvinToolchangerType";

        /// <summary>
        /// The BrowseName for the Ready component.
        /// </summary>
        public const string Ready = "Ready";

        /// <summary>
        /// The BrowseName for the ToolInfoType component.
        /// </summary>
        public const string ToolInfoType = "ToolInfoType";
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
        /// The URI for the KelvinToolchanger namespace (.NET code namespace is 'KelvinToolchanger').
        /// </summary>
        public const string KelvinToolchanger = "https://fortiss.org/UA/KelvinToolchanger/";

        /// <summary>
        /// The URI for the KelvinToolchangerXsd namespace (.NET code namespace is 'KelvinToolchanger').
        /// </summary>
        public const string KelvinToolchangerXsd = "https://fortiss.org/UA/KelvinToolchanger/Types.xsd";

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