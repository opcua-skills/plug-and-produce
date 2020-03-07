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
           "//8EYIACAQAAAAEAGwAAAENoYW5nZVRvb2xTa2lsbFR5cGVJbnN0YW5jZQEBmToBAZk6mToAAP////8M" +
           "AAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAZo6AC8BAMgKmjoAAAAV/////wEB/////wIAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQGbOgAuAESbOgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVt" +
           "YmVyAQGdOgAuAESdOgAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAATGFzdFRyYW5zaXRpb24B" +
           "AZ86AC8BAM8KnzoAAAAV/////wEB/////wMAAAAVYIkKAgAAAAAAAgAAAElkAQGgOgAuAESgOgAAABH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQGiOgAuAESiOgAAAAf/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUBAaM6AC4ARKM6AAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACQAAAERlbGV0YWJsZQEBqDoALgBEqDoAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CgAAAEF1dG9EZWxldGUBAak6AC4ARKk6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABSZWN5" +
           "Y2xlQ291bnQBAao6AC4ARKo6AAAABv////8BAf////8AAAAAFWCJCgIAAAAAABAAAABNYXhJbnN0YW5j" +
           "ZUNvdW50AQGsOgAuAESsOgAAAAf/////AQH/////AAAAAARhggoEAAAAAAAFAAAAU3RhcnQBAdY6AC8B" +
           "AHoJ1joAAAEBAQAAAAA1AQEBxjoAAAAABGGCCgQAAAAAAAcAAABTdXNwZW5kAQHXOgAvAQB7Cdc6AAAB" +
           "AQEAAAAANQEBAcw6AAAAAARhggoEAAAAAAAGAAAAUmVzdW1lAQHYOgAvAQB8Cdg6AAABAQEAAAAANQEB" +
           "Ac46AAAAAARhggoEAAAAAAAEAAAASGFsdAEB2ToALwEAfQnZOgAAAQEDAAAAADUBAQHIOgA1AQEB0DoA" +
           "NQEBAdQ6AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAdo6AC8BAH4J2joAAAEBAQAAAAA1AQEBxDoAAAAA" +
           "BGCACgEAAAACAAwAAABQYXJhbWV0ZXJTZXQBAdw6AC8AOtw6AAD/////AgAAADVgiQoCAAAAAQAMAAAA" +
           "VG9vbFBvc2l0aW9uAQGUOwMAAAAAQgAAAFBvc2l0aW9uIG9mIHRoZSB0b29sIHJlbGF0aXZlIHRvIHRo" +
           "ZSByb2JvdCBiYXNlIGluIGNhcnRlc2lhbiBzcGFjZQAvAQBnSZQ7AAABAH5J/////wMD/////wIAAAAV" +
           "YIkKAgAAAAAAFAAAAENhcnRlc2lhbkNvb3JkaW5hdGVzAQGVOwAvAQBWSZU7AAABAHpJ/////wEB////" +
           "/wMAAAAVYIkKAgAAAAAAAQAAAFgBAZw7AC8AP5w7AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAEA" +
           "AABZAQGdOwAvAD+dOwAAAAv/////AQH/////AAAAABVgiQoCAAAAAAABAAAAWgEBnjsALwA/njsAAAAL" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAE9yaWVudGF0aW9uAQGXOwAvAQBdSZc7AAABAHxJ////" +
           "/wEB/////wMAAAAVYIkKAgAAAAAAAQAAAEEBAZ87AC8AP587AAAAC/////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAEAAABCAQGgOwAvAD+gOwAAAAv/////AQH/////AAAAABVgiQoCAAAAAAABAAAAQwEBoTsALwA/" +
           "oTsAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAFRvb2xBcHBVcmkBAaM7AwAAAAAkAAAARXhw" +
           "ZWN0ZWQgYXBwbGljYXRpb24gdXJpIG9mIHRoZSB0b29sAC8AP6M7AAAADP////8DA/////8AAAAA";
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
           "//8EYIACAQAAAAEAGQAAAERyb3BUb29sU2tpbGxUeXBlSW5zdGFuY2UBAbc7AQG3O7c7AAD/////DAAA" +
           "ABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQG4OwAvAQDICrg7AAAAFf////8BAf////8CAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBuTsALgBEuTsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJl" +
           "cgEBuzsALgBEuzsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQG9" +
           "OwAvAQDPCr07AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBvjsALgBEvjsAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBwDsALgBEwDsAAAAH/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQHBOwAuAETBOwAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAkAAABEZWxldGFibGUBAcY7AC4ARMY7AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoA" +
           "AABBdXRvRGVsZXRlAQHHOwAuAETHOwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNs" +
           "ZUNvdW50AQHIOwAuAETIOwAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VD" +
           "b3VudAEByjsALgBEyjsAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQH0OwAvAQB6" +
           "CfQ7AAABAQEAAAAANQEBAeQ7AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEB9TsALwEAewn1OwAAAQEB" +
           "AAAAADUBAQHqOwAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEB9jsALwEAfAn2OwAAAQEBAAAAADUBAQHs" +
           "OwAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAfc7AC8BAH0J9zsAAAEBAwAAAAA1AQEB5jsANQEBAe47ADUB" +
           "AQHyOwAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQH4OwAvAQB+Cfg7AAABAQEAAAAANQEBAeI7AAAAAARg" +
           "gAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQH6OwAvADr6OwAA/////wAAAAA=";
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