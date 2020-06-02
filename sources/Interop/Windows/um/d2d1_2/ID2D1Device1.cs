// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D21768E1-23A4-4823-A14B-7C3EBA85D658")]
    public unsafe partial struct ID2D1Device1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1Device1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1Device1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1Device1*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext **")] ID2D1DeviceContext** deviceContext)
        {
            return lpVtbl->CreateDeviceContext((ID2D1Device1*)Unsafe.AsPointer(ref this), options, deviceContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePrintControl([NativeTypeName("IWICImagingFactory *")] IWICImagingFactory* wicFactory, [NativeTypeName("IPrintDocumentPackageTarget *")] IPrintDocumentPackageTarget* documentTarget, [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, [NativeTypeName("ID2D1PrintControl **")] ID2D1PrintControl** printControl)
        {
            return lpVtbl->CreatePrintControl((ID2D1Device1*)Unsafe.AsPointer(ref this), wicFactory, documentTarget, printControlProperties, printControl);
        }

        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            lpVtbl->SetMaximumTextureMemory((ID2D1Device1*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            return lpVtbl->GetMaximumTextureMemory((ID2D1Device1*)Unsafe.AsPointer(ref this));
        }

        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            lpVtbl->ClearResources((ID2D1Device1*)Unsafe.AsPointer(ref this), millisecondsSinceUse);
        }

        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            return lpVtbl->GetRenderingPriority((ID2D1Device1*)Unsafe.AsPointer(ref this));
        }

        public void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority)
        {
            lpVtbl->SetRenderingPriority((ID2D1Device1*)Unsafe.AsPointer(ref this), renderingPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext1 **")] ID2D1DeviceContext1** deviceContext1)
        {
            return lpVtbl->CreateDeviceContext1((ID2D1Device1*)Unsafe.AsPointer(ref this), options, deviceContext1);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext**, int> CreateDeviceContext;

            [NativeTypeName("HRESULT (IWICImagingFactory *, IPrintDocumentPackageTarget *, const D2D1_PRINT_CONTROL_PROPERTIES *, ID2D1PrintControl **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, IWICImagingFactory*, IPrintDocumentPackageTarget*, D2D1_PRINT_CONTROL_PROPERTIES*, ID2D1PrintControl**, int> CreatePrintControl;

            [NativeTypeName("void (UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, ulong, void> SetMaximumTextureMemory;

            [NativeTypeName("UINT64 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, ulong> GetMaximumTextureMemory;

            [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, uint, void> ClearResources;

            [NativeTypeName("D2D1_RENDERING_PRIORITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, D2D1_RENDERING_PRIORITY> GetRenderingPriority;

            [NativeTypeName("void (D2D1_RENDERING_PRIORITY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, D2D1_RENDERING_PRIORITY, void> SetRenderingPriority;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Device1*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1**, int> CreateDeviceContext1;
        }
    }
}
