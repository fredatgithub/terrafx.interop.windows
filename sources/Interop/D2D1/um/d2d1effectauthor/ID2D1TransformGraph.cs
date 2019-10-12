// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The implementation of the actual graph.</summary>
    [Guid("13D29038-C3E6-4034-9081-13B53A417992")]
    public unsafe partial struct ID2D1TransformGraph
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1TransformGraph* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1TransformGraph* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1TransformGraph* This);

        /// <summary>Return the number of input this graph has.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1TransformGraph* This);

        /// <summary>Sets the graph to contain a single transform whose inputs map 1:1 with effect inputs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSingleTransformNode(ID2D1TransformGraph* This, ID2D1TransformNode* node);

        /// <summary>Adds the given transform node to the graph.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddNode(ID2D1TransformGraph* This, ID2D1TransformNode* node);

        /// <summary>Removes the given transform node from the graph.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveNode(ID2D1TransformGraph* This, ID2D1TransformNode* node);

        /// <summary>Indicates that the given transform node should be considered to be the output node of the graph.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputNode(ID2D1TransformGraph* This, ID2D1TransformNode* node);

        /// <summary>Connects one node to another node inside the graph.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConnectNode(ID2D1TransformGraph* This, ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex);

        /// <summary>Connects a transform node inside the graph to the corresponding input of the encapsulating effect.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConnectToEffectInput(ID2D1TransformGraph* This, [NativeTypeName("UINT32")] uint toEffectInputIndex, ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex);

        /// <summary>Clears all nodes and connections from the transform graph.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1TransformGraph* This);

        /// <summary>Uses the specified input as the effect output.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPassthroughGraph(ID2D1TransformGraph* This, [NativeTypeName("UINT32")] uint effectInputIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSingleTransformNode(ID2D1TransformNode* node)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSingleTransformNode>(lpVtbl->SetSingleTransformNode)(This, node);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddNode(ID2D1TransformNode* node)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddNode>(lpVtbl->AddNode)(This, node);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveNode(ID2D1TransformNode* node)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveNode>(lpVtbl->RemoveNode)(This, node);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputNode(ID2D1TransformNode* node)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOutputNode>(lpVtbl->SetOutputNode)(This, node);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectNode(ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConnectNode>(lpVtbl->ConnectNode)(This, fromNode, toNode, toNodeInputIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectToEffectInput([NativeTypeName("UINT32")] uint toEffectInputIndex, ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConnectToEffectInput>(lpVtbl->ConnectToEffectInput)(This, toEffectInputIndex, node, toNodeInputIndex);
            }
        }

        public void Clear()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex)
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPassthroughGraph>(lpVtbl->SetPassthroughGraph)(This, effectInputIndex);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetInputCount;

            public IntPtr SetSingleTransformNode;

            public IntPtr AddNode;

            public IntPtr RemoveNode;

            public IntPtr SetOutputNode;

            public IntPtr ConnectNode;

            public IntPtr ConnectToEffectInput;

            public IntPtr Clear;

            public IntPtr SetPassthroughGraph;
        }
    }
}
