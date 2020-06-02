// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A248FD3F-3E6C-4E63-9F03-7F68ECC91DB9")]
    public unsafe partial struct ID2D1EffectImpl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1EffectImpl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1EffectImpl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("ID2D1EffectContext *")] ID2D1EffectContext* effectContext, [NativeTypeName("ID2D1TransformGraph *")] ID2D1TransformGraph* transformGraph)
        {
            return lpVtbl->Initialize((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), effectContext, transformGraph);
        }

        [return: NativeTypeName("HRESULT")]
        public int PrepareForRender(D2D1_CHANGE_TYPE changeType)
        {
            return lpVtbl->PrepareForRender((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), changeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGraph([NativeTypeName("ID2D1TransformGraph *")] ID2D1TransformGraph* transformGraph)
        {
            return lpVtbl->SetGraph((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), transformGraph);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1EffectImpl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1EffectImpl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1EffectImpl*, uint> Release;

            [NativeTypeName("HRESULT (ID2D1EffectContext *, ID2D1TransformGraph *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int> Initialize;

            [NativeTypeName("HRESULT (D2D1_CHANGE_TYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1EffectImpl*, D2D1_CHANGE_TYPE, int> PrepareForRender;

            [NativeTypeName("HRESULT (ID2D1TransformGraph *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1EffectImpl*, ID2D1TransformGraph*, int> SetGraph;
        }
    }
}
