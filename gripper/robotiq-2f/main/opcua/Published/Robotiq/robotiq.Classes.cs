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
using fortiss_Device;
using Opc.Ua.Di;
using Opc.Ua;

namespace robotiq
{
    #region Robotiq2FState Class
    #if (!OPCUA_EXCLUDE_Robotiq2FState)
    /// <summary>
    /// Stores an instance of the Robotiq2FType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Robotiq2FState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Robotiq2FState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(robotiq.ObjectTypes.Robotiq2FType, robotiq.Namespaces.robotiq, namespaceUris);
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
           "AwAAAB8AAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL3JvYm90aXEvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAA" +
           "AQAVAAAAUm9ib3RpcTJGVHlwZUluc3RhbmNlAQGZOgEBmTqZOgAA/////wgAAAA1YIkKAgAAAAMADAAA" +
           "AE1hbnVmYWN0dXJlcgEBsDoDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1" +
           "cmVkIHRoZSBkZXZpY2UALgBEsDoAAAAV/////wEB/////wAAAAA1YIkKAgAAAAMABQAAAE1vZGVsAQGy" +
           "OgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRldmljZQAuAESyOgAAABX/////AQH/////AAAAADVg" +
           "iQoCAAAAAwAQAAAASGFyZHdhcmVSZXZpc2lvbgEBszoDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0" +
           "aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAESzOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAwAQ" +
           "AAAAU29mdHdhcmVSZXZpc2lvbgEBtDoDAAAAADUAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdh" +
           "cmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAES0OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAwAO" +
           "AAAARGV2aWNlUmV2aXNpb24BAbU6AwAAAAAkAAAAT3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUg" +
           "ZGV2aWNlAC4ARLU6AAAADP////8BAf////8AAAAANWCJCgIAAAADAAwAAABEZXZpY2VNYW51YWwBAbc6" +
           "AwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4gdGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2Vi" +
           "IGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0aGUgZGV2aWNlAC4ARLc6AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAADAAwAAABTZXJpYWxOdW1iZXIBAbk6AwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVu" +
           "aXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UA" +
           "LgBEuToAAAAM/////wEB/////wAAAAA1YIkKAgAAAAMADwAAAFJldmlzaW9uQ291bnRlcgEBuzoDAAAA" +
           "AGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0" +
           "aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBEuzoAAAAG" +
           "/////wEB/////wAAAAA=";
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