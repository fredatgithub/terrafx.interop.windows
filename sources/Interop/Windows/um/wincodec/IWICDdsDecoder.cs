// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("409CD537-8532-40CB-9774-E2FEB2DF4E9C")]
    public unsafe partial struct IWICDdsDecoder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDdsDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return lpVtbl->GetParameters((IWICDdsDecoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrame([NativeTypeName("UINT")] uint arrayIndex, [NativeTypeName("UINT")] uint mipLevel, [NativeTypeName("UINT")] uint sliceIndex, [NativeTypeName("IWICBitmapFrameDecode **")] IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return lpVtbl->GetFrame((IWICDdsDecoder*)Unsafe.AsPointer(ref this), arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsDecoder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsDecoder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsDecoder*, uint> Release;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsDecoder*, WICDdsParameters*, int> GetParameters;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int> GetFrame;
        }
    }
}
