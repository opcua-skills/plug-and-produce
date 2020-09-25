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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss_Device;

namespace KelvinToolchanger
{
    #region ChangeToolSkillState Class
    #if (!OPCUA_EXCLUDE_ChangeToolSkillState)
    /// <summary>
    /// Stores an instance of the ChangeToolSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChangeToolSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChangeToolSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(KelvinToolchanger.ObjectTypes.ChangeToolSkillType, KelvinToolchanger.Namespaces.KelvinToolchanger, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACkAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0tlbHZpblRvb2xjaGFuZ2VyLx8AAABodHRwOi8v" +
           "b3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL///" +
           "//+EYIACAQAAAAEAGwAAAENoYW5nZVRvb2xTa2lsbFR5cGVJbnN0YW5jZQEBmToBAZk6mToAAAH/////" +
           "DAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGaOgAvAQDICpo6AAAAFf////8BAf////8CAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBmzoALgBEmzoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51" +
           "bWJlcgEBnToALgBEnToAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9u" +
           "AQGfOgAvAQDPCp86AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBoDoALgBEoDoAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBojoALgBEojoAAAAH/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQGjOgAuAESjOgAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAkAAABEZWxldGFibGUBAag6AC4ARKg6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAoAAABBdXRvRGVsZXRlAQGpOgAuAESpOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVj" +
           "eWNsZUNvdW50AQGqOgAuAESqOgAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFu" +
           "Y2VDb3VudAEBrDoALgBErDoAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQHWOgAv" +
           "AQB6CdY6AAABAQEAAAAANQEBAcY6AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEB1zoALwEAewnXOgAA" +
           "AQEBAAAAADUBAQHMOgAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEB2DoALwEAfAnYOgAAAQEBAAAAADUB" +
           "AQHOOgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAdk6AC8BAH0J2ToAAAEBAwAAAAA1AQEByDoANQEBAdA6" +
           "ADUBAQHUOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQHaOgAvAQB+Cdo6AAABAQEAAAAANQEBAcQ6AAAA" +
           "AARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHcOgAvADrcOgAA/////wIAAAA1YIkKAgAAAAEADAAA" +
           "AFRvb2xQb3NpdGlvbgEBlDsDAAAAAEIAAABQb3NpdGlvbiBvZiB0aGUgdG9vbCByZWxhdGl2ZSB0byB0" +
           "aGUgcm9ib3QgYmFzZSBpbiBjYXJ0ZXNpYW4gc3BhY2UALwEAZ0mUOwAAAQB+Sf////8DA/////8CAAAA" +
           "FWCJCgIAAAAAABQAAABDYXJ0ZXNpYW5Db29yZGluYXRlcwEBlTsALwEAVkmVOwAAAQB6Sf////8BAf//" +
           "//8DAAAAFWCJCgIAAAAAAAEAAABYAQGcOwAvAD+cOwAAAAv/////AQH/////AAAAABVgiQoCAAAAAAAB" +
           "AAAAWQEBnTsALwA/nTsAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAAAQAAAFoBAZ47AC8AP547AAAA" +
           "C/////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABPcmllbnRhdGlvbgEBlzsALwEAXUmXOwAAAQB8Sf//" +
           "//8BAf////8DAAAAFWCJCgIAAAAAAAEAAABBAQGfOwAvAD+fOwAAAAv/////AQH/////AAAAABVgiQoC" +
           "AAAAAAABAAAAQgEBoDsALwA/oDsAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAAAQAAAEMBAaE7AC8A" +
           "P6E7AAAAC/////8BAf////8AAAAANWCJCgIAAAABAAoAAABUb29sQXBwVXJpAQGjOwMAAAAAJAAAAEV4" +
           "cGVjdGVkIGFwcGxpY2F0aW9uIHVyaSBvZiB0aGUgdG9vbAAvAD+jOwAAAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region DropToolSkillState Class
    #if (!OPCUA_EXCLUDE_DropToolSkillState)
    /// <summary>
    /// Stores an instance of the DropToolSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DropToolSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DropToolSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(KelvinToolchanger.ObjectTypes.DropToolSkillType, KelvinToolchanger.Namespaces.KelvinToolchanger, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACkAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0tlbHZpblRvb2xjaGFuZ2VyLx8AAABodHRwOi8v" +
           "b3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL///" +
           "//+EYIACAQAAAAEAGQAAAERyb3BUb29sU2tpbGxUeXBlSW5zdGFuY2UBAbc7AQG3O7c7AAAB/////wwA" +
           "AAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBuDsALwEAyAq4OwAAABX/////AQH/////AgAAABVg" +
           "iQoCAAAAAAACAAAASWQBAbk7AC4ARLk7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1i" +
           "ZXIBAbs7AC4ARLs7AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABMYXN0VHJhbnNpdGlvbgEB" +
           "vTsALwEAzwq9OwAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAASWQBAb47AC4ARL47AAAAEf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAcA7AC4ARMA7AAAAB/////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQEBwTsALgBEwTsAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAJAAAARGVsZXRhYmxlAQHGOwAuAETGOwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAK" +
           "AAAAQXV0b0RlbGV0ZQEBxzsALgBExzsAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAFJlY3lj" +
           "bGVDb3VudAEByDsALgBEyDsAAAAG/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAE1heEluc3RhbmNl" +
           "Q291bnQBAco7AC4ARMo7AAAAB/////8BAf////8AAAAABGGCCgQAAAAAAAUAAABTdGFydAEB9DsALwEA" +
           "egn0OwAAAQEBAAAAADUBAQHkOwAAAAAEYYIKBAAAAAAABwAAAFN1c3BlbmQBAfU7AC8BAHsJ9TsAAAEB" +
           "AQAAAAA1AQEB6jsAAAAABGGCCgQAAAAAAAYAAABSZXN1bWUBAfY7AC8BAHwJ9jsAAAEBAQAAAAA1AQEB" +
           "7DsAAAAABGGCCgQAAAAAAAQAAABIYWx0AQH3OwAvAQB9Cfc7AAABAQMAAAAANQEBAeY7ADUBAQHuOwA1" +
           "AQEB8jsAAAAABGGCCgQAAAAAAAUAAABSZXNldAEB+DsALwEAfgn4OwAAAQEBAAAAADUBAQHiOwAAAAAE" +
           "YIAKAQAAAAIADAAAAFBhcmFtZXRlclNldAEB+jsALwA6+jsAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region ToolInfoState Class
    #if (!OPCUA_EXCLUDE_ToolInfoState)
    /// <summary>
    /// Stores an instance of the ToolInfoType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolInfoState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ToolInfoState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(KelvinToolchanger.ObjectTypes.ToolInfoType, KelvinToolchanger.Namespaces.KelvinToolchanger, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACkAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0tlbHZpblRvb2xjaGFuZ2VyLx8AAABodHRwOi8v" +
           "b3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL///" +
           "//8EYIACAQAAAAEAFAAAAFRvb2xJbmZvVHlwZUluc3RhbmNlAQGiOwEBojuiOwAA/////wQAAAA1YIkK" +
           "AgAAAAEABQAAAFJlYWR5AQGSOwMAAAAAMAAAAFRydWUgaWYgdGhlIGNvbm5lY3RlZCB0b29sIGlzIHJl" +
           "YWR5IChzdGFydGVkIHVwKQAvAD+SOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQACAAAASWQBAd06" +
           "AwAAAAA2AAAAVGhlIGlkIG9mIHRoZSB0b29sIGJhc2VkIG9uIHRoZSBLZWx2aW4gVG9vbGNoYW5nZXIg" +
           "SURzAC8AP906AAAABf////8BAf////8AAAAANWCJCgIAAAABAAsAAABEZXNjcmlwdGlvbgEBpDsDAAAA" +
           "ADEAAABUaGUgYXBwbGljYXRpb24gZGVzY3JpcHRpb24gb2YgdGhlIGNvbm5lY3RlZCB0b29sAC8AP6Q7" +
           "AAABADQB/////wEB/////wAAAAA1YIkKAgAAAAEACAAAAEVuZHBvaW50AQEhPAMAAAAAJgAAAFRoZSBl" +
           "bmRwb2ludCB1cmwgb2YgdGhlIGNvbm5lY3RlZCB0b29sAC8APyE8AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Ready
        {
            get
            {
                return m_ready;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ready, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ready = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ApplicationDescription> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Endpoint
        {
            get
            {
                return m_endpoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_endpoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_endpoint = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_ready != null)
            {
                children.Add(m_ready);
            }

            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_endpoint != null)
            {
                children.Add(m_endpoint);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case KelvinToolchanger.BrowseNames.Ready:
                {
                    if (createOrReplace)
                    {
                        if (Ready == null)
                        {
                            if (replacement == null)
                            {
                                Ready = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Ready = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Ready;
                    break;
                }

                case KelvinToolchanger.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case KelvinToolchanger.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new BaseDataVariableState<ApplicationDescription>(this);
                            }
                            else
                            {
                                Description = (BaseDataVariableState<ApplicationDescription>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case KelvinToolchanger.BrowseNames.Endpoint:
                {
                    if (createOrReplace)
                    {
                        if (Endpoint == null)
                        {
                            if (replacement == null)
                            {
                                Endpoint = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Endpoint = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Endpoint;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_ready;
        private BaseDataVariableState<ushort> m_id;
        private BaseDataVariableState<ApplicationDescription> m_description;
        private BaseDataVariableState<string> m_endpoint;
        #endregion
    }
    #endif
    #endregion

    #region KelvinToolchangerState Class
    #if (!OPCUA_EXCLUDE_KelvinToolchangerState)
    /// <summary>
    /// Stores an instance of the KelvinToolchangerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class KelvinToolchangerState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public KelvinToolchangerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(KelvinToolchanger.ObjectTypes.KelvinToolchangerType, KelvinToolchanger.Namespaces.KelvinToolchanger, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACkAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0tlbHZpblRvb2xjaGFuZ2VyLx8AAABodHRwOi8v" +
           "b3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL///" +
           "//8EYIACAQAAAAEAHQAAAEtlbHZpblRvb2xjaGFuZ2VyVHlwZUluc3RhbmNlAQHfOgEB3zrfOgAA////" +
           "/wgAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEB9joDAAAAADAAAABOYW1lIG9mIHRoZSBjb21w" +
           "YW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBE9joAAAAV/////wEB/////wAAAAA1YIkK" +
           "AgAAAAIABQAAAE1vZGVsAQH4OgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAET4OgAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB+ToDAAAAACwAAABS" +
           "ZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAET5OgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEB+joDAAAAADUAAABSZXZpc2lvbiBs" +
           "ZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAET6OgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAfs6AwAAAAAkAAAAT3ZlcmFsbCByZXZp" +
           "c2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARPs6AAAADP////8BAf////8AAAAANWCJCgIAAAACAAwA" +
           "AABEZXZpY2VNYW51YWwBAf06AwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lz" +
           "dGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4A" +
           "RP06AAAADP////8BAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAf86AwAAAABNAAAA" +
           "SWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwg" +
           "YSBkZXZpY2UgaW5zdGFuY2UALgBE/zoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlz" +
           "aW9uQ291bnRlcgEBATsDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhl" +
           "IG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4g" +
           "bW9kaWZpZWQALgBEATsAAAAG/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}