// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FFBE2E23-F011-418A-AC56-5CEED7C5B94B")]
    public unsafe partial struct ID3D11RenderTargetView1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetResource([NativeTypeName("ID3D11Resource **")] ID3D11Resource** ppResource)
        {
            lpVtbl->GetResource((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), ppResource);
        }

        public void GetDesc([NativeTypeName("D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc)
        {
            lpVtbl->GetDesc((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), pDesc);
        }

        public void GetDesc1([NativeTypeName("D3D11_RENDER_TARGET_VIEW_DESC1 *")] D3D11_RENDER_TARGET_VIEW_DESC1* pDesc1)
        {
            lpVtbl->GetDesc1((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), pDesc1);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (ID3D11Resource **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, ID3D11Resource**, void> GetResource;

            [NativeTypeName("void (D3D11_RENDER_TARGET_VIEW_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, D3D11_RENDER_TARGET_VIEW_DESC*, void> GetDesc;

            [NativeTypeName("void (D3D11_RENDER_TARGET_VIEW_DESC1 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11RenderTargetView1*, D3D11_RENDER_TARGET_VIEW_DESC1*, void> GetDesc1;
        }
    }
}
