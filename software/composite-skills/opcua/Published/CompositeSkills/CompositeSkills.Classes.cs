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

namespace CompositeSkills
{
    #region PickAndPlaceSkillState Class
    #if (!OPCUA_EXCLUDE_PickAndPlaceSkillState)
    /// <summary>
    /// Stores an instance of the PickAndPlaceSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PickAndPlaceSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PickAndPlaceSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(CompositeSkills.ObjectTypes.PickAndPlaceSkillType, CompositeSkills.Namespaces.CompositeSkills, namespaceUris);
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
           "AwAAACcAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0NvbXBvc2l0ZVNraWxscy8fAAAAaHR0cDovL29w" +
           "Y2ZvdW5kYXRpb24ub3JnL1VBL0RJLx4AAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0RldmljZS//////" +
           "BGCAAgEAAAABAB0AAABQaWNrQW5kUGxhY2VTa2lsbFR5cGVJbnN0YW5jZQEBmToBAZk6mToAAP////8M" +
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
           "BGCACgEAAAACAAwAAABQYXJhbWV0ZXJTZXQBAdw6AC8AOtw6AAD/////BAAAADVgiQoCAAAAAQAIAAAA" +
           "T2JqZWN0SWQBAd06AwAAAAAoAAAASWQgb2YgdGhlIG9iamVjdCB3aGljaCBzaG91bGQgYmUgcGlja2Vk" +
           "LgAvAD/dOgAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAbAAAAVG9vbFNraWxsQ29udHJvbGxlckVu" +
           "ZHBvaW50AQHeOgMAAAAAUwAAAFRoZSBlbmRwb2ludCBVUkwgb2YgdGhlIGdyaXBwZXIgdG9vbCBjb250" +
           "cm9sbGVyIHdoaWNoIHNob3VsZCBiZSB1c2VkIGZvciB0aGlzIHNraWxsAC8AP946AAAADP////8DA///" +
           "//8AAAAANWCJCgIAAAABABsAAABNb3ZlU2tpbGxDb250cm9sbGVyRW5kcG9pbnQBAd86AwAAAABLAAAA" +
           "VGhlIGVuZHBvaW50IFVSTCBvZiB0aGUgbW92ZSBjb250cm9sbGVyIHdoaWNoIHNob3VsZCBiZSB1c2Vk" +
           "IGZvciB0aGlzIHNraWxsAC8AP986AAAADP////8DA/////8AAAAANWCJCgIAAAABAA0AAABQbGFjZVBv" +
           "c2l0aW9uAQHgOgMAAAAAVAAAAFBvc2l0aW9uIHdoZXJlIHRoZSBvYmplY3Qgc2hvdWxkIGJlIHBsYWNl" +
           "ZCwgYmFzZWQgb24gdGhlIHdvcmxkIGZyYW1lIHRvIG9iamVjdCBmcmFtZQAvAQBnSeA6AAABAH5J////" +
           "/wMD/////wIAAAAVYIkKAgAAAAAAFAAAAENhcnRlc2lhbkNvb3JkaW5hdGVzAQHhOgAvAQBWSeE6AAAB" +
           "AHpJ/////wEB/////wMAAAAVYIkKAgAAAAAAAQAAAFgBAeg6AC8AP+g6AAAAC/////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAEAAABZAQHpOgAvAD/pOgAAAAv/////AQH/////AAAAABVgiQoCAAAAAAABAAAAWgEB" +
           "6joALwA/6joAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAE9yaWVudGF0aW9uAQHjOgAvAQBd" +
           "SeM6AAABAHxJ/////wEB/////wMAAAAVYIkKAgAAAAAAAQAAAEEBAes6AC8AP+s6AAAAC/////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAEAAABCAQHsOgAvAD/sOgAAAAv/////AQH/////AAAAABVgiQoCAAAAAAAB" +
           "AAAAQwEB7ToALwA/7ToAAAAL/////wEB/////wAAAAA=";
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

    #region CompositeSkillsState Class
    #if (!OPCUA_EXCLUDE_CompositeSkillsState)
    /// <summary>
    /// Stores an instance of the CompositeSkillsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CompositeSkillsState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CompositeSkillsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(CompositeSkills.ObjectTypes.CompositeSkillsType, CompositeSkills.Namespaces.CompositeSkills, namespaceUris);
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
           "AwAAACcAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0NvbXBvc2l0ZVNraWxscy8fAAAAaHR0cDovL29w" +
           "Y2ZvdW5kYXRpb24ub3JnL1VBL0RJLx4AAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0RldmljZS//////" +
           "BGCAAgEAAAABABsAAABDb21wb3NpdGVTa2lsbHNUeXBlSW5zdGFuY2UBAe46AQHuOu46AAD/////CAAA" +
           "ADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQEFOwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkg" +
           "dGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAEQFOwAAABX/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAFAAAATW9kZWwBAQc7AwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARAc7AAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQEIOwMAAAAALAAAAFJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARAg7AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQEJOwMAAAAANQAAAFJldmlzaW9uIGxldmVs" +
           "IG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARAk7AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBCjsDAAAAACQAAABPdmVyYWxsIHJldmlzaW9u" +
           "IGxldmVsIG9mIHRoZSBkZXZpY2UALgBECjsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERl" +
           "dmljZU1hbnVhbAEBDDsDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0g" +
           "b3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEDDsA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBDjsDAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAEQOOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQEQOwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAEQQOwAAAAb/////AQH/////AAAAAA==";
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