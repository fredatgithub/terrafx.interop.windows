// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDF57CBA-9543-46E4-A12B-F207A0FE7FED")]
    public unsafe partial struct ID3D11ClassLinkage
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassInstance([NativeTypeName("LPCSTR")] sbyte* pClassInstanceName, [NativeTypeName("UINT")] uint InstanceIndex, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppInstance)
        {
            return lpVtbl->GetClassInstance((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), pClassInstanceName, InstanceIndex, ppInstance);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClassInstance([NativeTypeName("LPCSTR")] sbyte* pClassTypeName, [NativeTypeName("UINT")] uint ConstantBufferOffset, [NativeTypeName("UINT")] uint ConstantVectorOffset, [NativeTypeName("UINT")] uint TextureOffset, [NativeTypeName("UINT")] uint SamplerOffset, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppInstance)
        {
            return lpVtbl->CreateClassInstance((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCSTR, UINT, ID3D11ClassInstance **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, sbyte*, uint, ID3D11ClassInstance**, int> GetClassInstance;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT, UINT, UINT, ID3D11ClassInstance **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ClassLinkage*, sbyte*, uint, uint, uint, uint, ID3D11ClassInstance**, int> CreateClassInstance;
        }
    }
}
