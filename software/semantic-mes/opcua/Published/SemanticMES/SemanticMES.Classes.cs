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

namespace SemanticMES
{
    #region ExecuteProcessSkillState Class
    #if (!OPCUA_EXCLUDE_ExecuteProcessSkillState)
    /// <summary>
    /// Stores an instance of the ExecuteProcessSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExecuteProcessSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ExecuteProcessSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(SemanticMES.ObjectTypes.ExecuteProcessSkillType, SemanticMES.Namespaces.SemanticMES, namespaceUris);
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
           "AwAAACMAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1NlbWFudGljTUVTLx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////8EYIAC" +
           "AQAAAAEAHwAAAEV4ZWN1dGVQcm9jZXNzU2tpbGxUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAD/////DAAA" +
           "ABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGaOgAvAQDICpo6AAAAFf////8BAf////8CAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBmzoALgBEmzoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJl" +
           "cgEBnToALgBEnToAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQGf" +
           "OgAvAQDPCp86AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBoDoALgBEoDoAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBojoALgBEojoAAAAH/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQGjOgAuAESjOgAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAkAAABEZWxldGFibGUBAag6AC4ARKg6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoA" +
           "AABBdXRvRGVsZXRlAQGpOgAuAESpOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNs" +
           "ZUNvdW50AQGqOgAuAESqOgAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VD" +
           "b3VudAEBrDoALgBErDoAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQHWOgAvAQB6" +
           "CdY6AAABAQEAAAAANQEBAcY6AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEB1zoALwEAewnXOgAAAQEB" +
           "AAAAADUBAQHMOgAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEB2DoALwEAfAnYOgAAAQEBAAAAADUBAQHO" +
           "OgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAdk6AC8BAH0J2ToAAAEBAwAAAAA1AQEByDoANQEBAdA6ADUB" +
           "AQHUOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQHaOgAvAQB+Cdo6AAABAQEAAAAANQEBAcQ6AAAAAARg" +
           "gAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHcOgAvADrcOgAA/////wIAAAA1YKkKAgAAAAEAEgAAAEFi" +
           "c3RyYWN0UHJvY2Vzc0lyaQEB3ToDAAAAACUAAABUaGUgSVJJIG9mIHRoZSBwcm9jZXNzIHRvIGJlIGV4" +
           "ZWN1dGVkAC8AP906AAAMOwAAAGh0dHA6Ly93d3cuZm9ydGlzcy5vcmcvb250L2RhdGFiYWNrYm9uZS9w" +
           "cm9jZXNzLTEjUHJvY2Vzcy0xAAz/////AwP/////AAAAADVgqQoCAAAAAQANAAAARXhlY3V0aW9uTW9k" +
           "ZQEB3joDAAAAAB0AAABUaGUgSVJJIG9mIHRoZSBleGVjdXRpb24gbW9kZQAvAD/eOgAADEQAAABodHRw" +
           "Oi8vd3d3LmZvcnRpc3Mub3JnL29udC9yb2JvdGljcy9jb3JlI0V4ZWN1dGlvbk1vZGUtUmVhbEV4ZWN1" +
           "dGlvbgAM/////wMD/////wAAAAA=";
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

    #region SemanticMesState Class
    #if (!OPCUA_EXCLUDE_SemanticMesState)
    /// <summary>
    /// Stores an instance of the SemanticMesType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SemanticMesState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SemanticMesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(SemanticMES.ObjectTypes.SemanticMesType, SemanticMES.Namespaces.SemanticMES, namespaceUris);
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
           "AwAAACMAAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL1NlbWFudGljTUVTLx8AAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlL/////8EYIAC" +
           "AQAAAAEAFwAAAFNlbWFudGljTWVzVHlwZUluc3RhbmNlAQHfOgEB3zrfOgAA/////wgAAAA1YIkKAgAA" +
           "AAIADAAAAE1hbnVmYWN0dXJlcgEB9joDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFu" +
           "dWZhY3R1cmVkIHRoZSBkZXZpY2UALgBE9joAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIABQAAAE1v" +
           "ZGVsAQH4OgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAET4OgAAABX/////AQH/////" +
           "AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB+ToDAAAAACwAAABSZXZpc2lvbiBsZXZl" +
           "bCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAET5OgAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEB+joDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "c29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAET6OgAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAfs6AwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBv" +
           "ZiB0aGUgZGV2aWNlAC4ARPs6AAAADP////8BAf////8AAAAANWCJCgIAAAACAAwAAABEZXZpY2VNYW51" +
           "YWwBAf06AwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJM" +
           "IHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARP06AAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAf86AwAAAABNAAAASWRlbnRpZmllciB0" +
           "aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5z" +
           "dGFuY2UALgBE/zoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEB" +
           "ATsDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0" +
           "aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE" +
           "ATsAAAAG/////wEB/////wAAAAA=";
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