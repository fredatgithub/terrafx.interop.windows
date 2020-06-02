// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("433685FE-E22B-4CA0-A8DB-B5B4F4DD0E4A")]
    public unsafe partial struct ID3D12Fence1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12Fence1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12Fence1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12Fence1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12Fence1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12Fence1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12Fence1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12Fence1*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetDevice((ID3D12Fence1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetCompletedValue()
        {
            return lpVtbl->GetCompletedValue((ID3D12Fence1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, [NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return lpVtbl->SetEventOnCompletion((ID3D12Fence1*)Unsafe.AsPointer(ref this), Value, hEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal([NativeTypeName("UINT64")] ulong Value)
        {
            return lpVtbl->Signal((ID3D12Fence1*)Unsafe.AsPointer(ref this), Value);
        }

        public D3D12_FENCE_FLAGS GetCreationFlags()
        {
            return lpVtbl->GetCreationFlags((ID3D12Fence1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, Guid*, void**, int> GetDevice;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, ulong> GetCompletedValue;

            [NativeTypeName("HRESULT (UINT64, HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, ulong, IntPtr, int> SetEventOnCompletion;

            [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, ulong, int> Signal;

            [NativeTypeName("D3D12_FENCE_FLAGS () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Fence1*, D3D12_FENCE_FLAGS> GetCreationFlags;
        }
    }
}
