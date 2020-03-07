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

namespace CompositeSkills
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
        /// The identifier for the CompositeSkillsType_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_InitLock = 15100;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_RenewLock = 15103;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_ExitLock = 15105;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkillsType_Lock_BreakLock = 15107;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_InitLock = 15135;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_RenewLock = 15138;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_ExitLock = 15140;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_BreakLock = 15142;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_InitLock = 15170;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_RenewLock = 15173;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_ExitLock = 15175;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkills_Lock_BreakLock = 15177;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_InitLock = 15205;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_RenewLock = 15208;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_ExitLock = 15210;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_BreakLock = 15212;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Halt Method.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_Halt = 15259;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Reset Method.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_Reset = 15260;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Resume Method.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_Resume = 15261;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Suspend Method.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_Suspend = 15262;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Start Method.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_Start = 15263;
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
        /// The identifier for the PickAndPlaceSkillType_ParameterSet Object.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_NetworkAddress = 15144;

        /// <summary>
        /// The identifier for the CompositeSkills Object.
        /// </summary>
        public const uint CompositeSkills = 15156;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_NetworkAddress = 15214;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills Object.
        /// </summary>
        public const uint CompositeSkills_Skills = 15226;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill Object.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill = 15227;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet Object.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet = 15264;
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
        /// The identifier for the PickAndPlaceSkillType ObjectType.
        /// </summary>
        public const uint PickAndPlaceSkillType = 15001;

        /// <summary>
        /// The identifier for the CompositeSkillsType ObjectType.
        /// </summary>
        public const uint CompositeSkillsType = 15086;
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
        /// The identifier for the PickAndPlaceSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_ObjectId Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_ObjectId = 15069;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_ToolSkillControllerEndpoint Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_ToolSkillControllerEndpoint = 15070;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_MoveSkillControllerEndpoint Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_MoveSkillControllerEndpoint = 15071;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition = 15072;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates = 15073;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation = 15075;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_X = 15080;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Y = 15081;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Z = 15082;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_A Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_A = 15083;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_B Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_B = 15084;

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_C Variable.
        /// </summary>
        public const uint PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_C = 15085;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_Locked = 15096;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_LockingClient = 15097;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_LockingUser = 15098;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_RemainingLockTime = 15099;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_InitLock_InputArguments = 15101;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_InitLock_OutputArguments = 15102;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_RenewLock_OutputArguments = 15104;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_ExitLock_OutputArguments = 15106;

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_Lock_BreakLock_OutputArguments = 15108;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_Locked = 15131;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_LockingClient = 15132;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_LockingUser = 15133;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime = 15134;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments = 15136;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments = 15137;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments = 15139;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments = 15141;

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments = 15143;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_Locked = 15166;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_LockingClient = 15167;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_LockingUser = 15168;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_RemainingLockTime = 15169;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_InitLock_InputArguments = 15171;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_InitLock_OutputArguments = 15172;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_RenewLock_OutputArguments = 15174;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_ExitLock_OutputArguments = 15176;

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Lock_BreakLock_OutputArguments = 15178;

        /// <summary>
        /// The identifier for the CompositeSkills_Manufacturer Variable.
        /// </summary>
        public const uint CompositeSkills_Manufacturer = 15179;

        /// <summary>
        /// The identifier for the CompositeSkills_Model Variable.
        /// </summary>
        public const uint CompositeSkills_Model = 15181;

        /// <summary>
        /// The identifier for the CompositeSkills_HardwareRevision Variable.
        /// </summary>
        public const uint CompositeSkills_HardwareRevision = 15182;

        /// <summary>
        /// The identifier for the CompositeSkills_SoftwareRevision Variable.
        /// </summary>
        public const uint CompositeSkills_SoftwareRevision = 15183;

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceRevision Variable.
        /// </summary>
        public const uint CompositeSkills_DeviceRevision = 15184;

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceManual Variable.
        /// </summary>
        public const uint CompositeSkills_DeviceManual = 15186;

        /// <summary>
        /// The identifier for the CompositeSkills_SerialNumber Variable.
        /// </summary>
        public const uint CompositeSkills_SerialNumber = 15188;

        /// <summary>
        /// The identifier for the CompositeSkills_RevisionCounter Variable.
        /// </summary>
        public const uint CompositeSkills_RevisionCounter = 15190;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_Locked = 15201;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_LockingClient = 15202;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_LockingUser = 15203;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_RemainingLockTime = 15204;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments = 15206;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments = 15207;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments = 15209;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments = 15211;

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments = 15213;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_CurrentState Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_CurrentState = 15228;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Id = 15229;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Number = 15231;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_LastTransition = 15233;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Id = 15234;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Number = 15236;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_TransitionTime = 15237;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Deletable Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_Deletable = 15241;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_AutoDelete Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_AutoDelete = 15242;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_RecycleCount Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_RecycleCount = 15243;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateSessionId = 15245;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateClientName = 15246;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_InvocationCreationTime = 15247;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastTransitionTime = 15248;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCall = 15249;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodSessionId = 15250;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputArguments = 15251;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputArguments = 15252;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputValues = 15253;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputValues = 15254;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCallTime = 15255;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodReturnStatus = 15256;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_MaxInstanceCount = 15258;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ObjectId Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ObjectId = 15265;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ToolSkillControllerEndpoint Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ToolSkillControllerEndpoint = 15266;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_MoveSkillControllerEndpoint Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_MoveSkillControllerEndpoint = 15267;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition = 15268;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates = 15269;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation = 15271;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_X Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_X = 15276;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Y = 15277;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Z = 15278;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_A Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_A = 15279;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_B Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_B = 15280;

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_C Variable.
        /// </summary>
        public const uint CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_C = 15281;
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
        /// The identifier for the CompositeSkillsType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkillsType_CPIdentifier_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_InitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_InitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_RenewLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_ExitLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_CPIdentifier_Lock_BreakLock, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_Halt = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_PickAndPlaceSkill_Halt, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_Reset = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_PickAndPlaceSkill_Reset, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_Resume = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_PickAndPlaceSkill_Resume, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_Suspend = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_PickAndPlaceSkill_Suspend, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_Start = new ExpandedNodeId(CompositeSkills.Methods.CompositeSkills_Skills_PickAndPlaceSkill_Start, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The identifier for the PickAndPlaceSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet = new ExpandedNodeId(CompositeSkills.Objects.PickAndPlaceSkillType_ParameterSet, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_NetworkAddress = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkillsType_CPIdentifier_NetworkAddress, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_NetworkAddress = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_CPIdentifier_NetworkAddress, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_Skills, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_Skills_PickAndPlaceSkill, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet = new ExpandedNodeId(CompositeSkills.Objects.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The identifier for the PickAndPlaceSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType = new ExpandedNodeId(CompositeSkills.ObjectTypes.PickAndPlaceSkillType, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType = new ExpandedNodeId(CompositeSkills.ObjectTypes.CompositeSkillsType, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The identifier for the PickAndPlaceSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_CurrentState_Id = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_CurrentState_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_CurrentState_Number = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_CurrentState_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_LastTransition_Id = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_LastTransition_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_LastTransition_Number = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_LastTransition_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_LastTransition_TransitionTime = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_LastTransition_TransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_CreateSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_CreateClientName, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_InvocationCreationTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastTransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCall, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodInputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodOutputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodCallTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ProgramDiagnostic_LastMethodReturnStatus, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_Halted_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_Halted_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_Ready_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_Ready_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_Running_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_Running_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_Suspended_StateNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_Suspended_StateNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_HaltedToReady_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ReadyToRunning_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_RunningToHalted_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_RunningToReady_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_RunningToSuspended_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_SuspendedToRunning_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_SuspendedToHalted_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_SuspendedToReady_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ReadyToHalted_TransitionNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_ObjectId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_ObjectId = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_ObjectId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_ToolSkillControllerEndpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_ToolSkillControllerEndpoint = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_ToolSkillControllerEndpoint, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_MoveSkillControllerEndpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_MoveSkillControllerEndpoint = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_MoveSkillControllerEndpoint, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_X = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_X, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Y = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Y, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Z = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_CartesianCoordinates_Z, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_A = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_A, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_B = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_B, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_C = new ExpandedNodeId(CompositeSkills.Variables.PickAndPlaceSkillType_ParameterSet_PlacePosition_Orientation_C, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkillsType_CPIdentifier_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Manufacturer = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Manufacturer, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Model = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Model, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_HardwareRevision = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_HardwareRevision, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_SoftwareRevision = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_SoftwareRevision, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_DeviceRevision = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_DeviceRevision, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_DeviceManual = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_DeviceManual, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_SerialNumber = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_SerialNumber, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_RevisionCounter = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_RevisionCounter, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_Locked = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_Locked, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_LockingClient, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_LockingUser, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_RemainingLockTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_InitLock_InputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_InitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_RenewLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_ExitLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_CPIdentifier_Lock_BreakLock_OutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_CurrentState = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_CurrentState, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Id = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Number = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_CurrentState_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_LastTransition = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_LastTransition, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Id = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Id, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Number = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_Number, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_TransitionTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_LastTransition_TransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_Deletable = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_Deletable, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_AutoDelete = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_AutoDelete, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_RecycleCount = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_RecycleCount, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_CreateClientName, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_InvocationCreationTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastTransitionTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCall, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodSessionId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputArguments, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodInputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodOutputValues, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodCallTime, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ProgramDiagnostic_LastMethodReturnStatus, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_MaxInstanceCount = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_MaxInstanceCount, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ObjectId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ObjectId = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ObjectId, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ToolSkillControllerEndpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ToolSkillControllerEndpoint = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_ToolSkillControllerEndpoint, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_MoveSkillControllerEndpoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_MoveSkillControllerEndpoint = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_MoveSkillControllerEndpoint, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_X = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_X, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Y = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Y, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Z = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_CartesianCoordinates_Z, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_A Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_A = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_A, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_B Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_B = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_B, CompositeSkills.Namespaces.CompositeSkills);

        /// <summary>
        /// The identifier for the CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_C = new ExpandedNodeId(CompositeSkills.Variables.CompositeSkills_Skills_PickAndPlaceSkill_ParameterSet_PlacePosition_Orientation_C, CompositeSkills.Namespaces.CompositeSkills);
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
        /// The BrowseName for the CompositeSkills component.
        /// </summary>
        public const string CompositeSkills = "CompositeSkills";

        /// <summary>
        /// The BrowseName for the CompositeSkillsType component.
        /// </summary>
        public const string CompositeSkillsType = "CompositeSkillsType";

        /// <summary>
        /// The BrowseName for the PickAndPlaceSkillType component.
        /// </summary>
        public const string PickAndPlaceSkillType = "PickAndPlaceSkill";
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
        /// The URI for the CompositeSkills namespace (.NET code namespace is 'CompositeSkills').
        /// </summary>
        public const string CompositeSkills = "https://fortiss.org/UA/CompositeSkills/";

        /// <summary>
        /// The URI for the CompositeSkillsXsd namespace (.NET code namespace is 'CompositeSkills').
        /// </summary>
        public const string CompositeSkillsXsd = "https://fortiss.org/UA/CompositeSkills/Types.xsd";

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