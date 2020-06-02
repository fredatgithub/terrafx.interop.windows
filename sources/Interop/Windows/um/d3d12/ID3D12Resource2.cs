// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BE36EC3B-EA85-4AEB-A45A-E9D76404A495")]
    public unsafe partial struct ID3D12Resource2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12Resource2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12Resource2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12Resource2*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetDevice((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange, [NativeTypeName("void **")] void** ppData)
        {
            return lpVtbl->Map((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
        }

        public void Unmap([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange)
        {
            lpVtbl->Unmap((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
        }

        public D3D12_RESOURCE_DESC GetDesc()
        {
            D3D12_RESOURCE_DESC result;
            return *lpVtbl->GetDesc((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong GetGPUVirtualAddress()
        {
            return lpVtbl->GetGPUVirtualAddress((ID3D12Resource2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteToSubresource([NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            return lpVtbl->WriteToSubresource((ID3D12Resource2*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFromSubresource([NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            return lpVtbl->ReadFromSubresource((ID3D12Resource2*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeapProperties([NativeTypeName("D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, [NativeTypeName("D3D12_HEAP_FLAGS *")] D3D12_HEAP_FLAGS* pHeapFlags)
        {
            return lpVtbl->GetHeapProperties((ID3D12Resource2*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppProtectedSession)
        {
            return lpVtbl->GetProtectedResourceSession((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }

        public D3D12_RESOURCE_DESC1 GetDesc1()
        {
            D3D12_RESOURCE_DESC1 result;
            return *lpVtbl->GetDesc1((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, Guid*, void**, int> GetDevice;

            [NativeTypeName("HRESULT (UINT, const D3D12_RANGE *, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, uint, D3D12_RANGE*, void**, int> Map;

            [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, uint, D3D12_RANGE*, void> Unmap;

            [NativeTypeName("D3D12_RESOURCE_DESC () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_DESC*> GetDesc;

            [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, ulong> GetGPUVirtualAddress;

            [NativeTypeName("HRESULT (UINT, const D3D12_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, uint, D3D12_BOX*, void*, uint, uint, int> WriteToSubresource;

            [NativeTypeName("HRESULT (void *, UINT, UINT, UINT, const D3D12_BOX *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, void*, uint, uint, uint, D3D12_BOX*, int> ReadFromSubresource;

            [NativeTypeName("HRESULT (D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS*, int> GetHeapProperties;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, Guid*, void**, int> GetProtectedResourceSession;

            [NativeTypeName("D3D12_RESOURCE_DESC1 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Resource2*, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_DESC1*> GetDesc1;
        }
    }
}
