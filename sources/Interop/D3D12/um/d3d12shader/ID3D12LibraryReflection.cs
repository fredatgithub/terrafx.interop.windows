// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E349D19-54DB-4A56-9DC9-119D87BDB804")]
    public unsafe partial struct ID3D12LibraryReflection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12LibraryReflection* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12LibraryReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12LibraryReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12LibraryReflection* This, D3D12_LIBRARY_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12FunctionReflection* _GetFunctionByIndex(ID3D12LibraryReflection* This, [NativeTypeName("INT")] int FunctionIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12LibraryReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12LibraryReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12LibraryReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D12_LIBRARY_DESC* pDesc)
        {
            fixed (ID3D12LibraryReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        public ID3D12FunctionReflection* GetFunctionByIndex([NativeTypeName("INT")] int FunctionIndex)
        {
            fixed (ID3D12LibraryReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFunctionByIndex>(lpVtbl->GetFunctionByIndex)(This, FunctionIndex);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetDesc;

            public IntPtr GetFunctionByIndex;
        }
    }
}
