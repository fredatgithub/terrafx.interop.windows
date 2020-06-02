// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcompanimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CBFD91D9-51B2-45e4-B3DE-D19CCFB863C5")]
    public unsafe partial struct IDCompositionAnimation
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAbsoluteBeginTime(LARGE_INTEGER beginTime)
        {
            return lpVtbl->SetAbsoluteBeginTime((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient)
        {
            return lpVtbl->AddCubic((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, constantCoefficient, linearCoefficient, quadraticCoefficient, cubicCoefficient);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase)
        {
            return lpVtbl->AddSinusoidal((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, bias, amplitude, frequency, phase);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRepeat(double beginOffset, double durationToRepeat)
        {
            return lpVtbl->AddRepeat((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, durationToRepeat);
        }

        [return: NativeTypeName("HRESULT")]
        public int End(double endOffset, float endValue)
        {
            return lpVtbl->End((IDCompositionAnimation*)Unsafe.AsPointer(ref this), endOffset, endValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, int> Reset;

            [NativeTypeName("HRESULT (LARGE_INTEGER) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, LARGE_INTEGER, int> SetAbsoluteBeginTime;

            [NativeTypeName("HRESULT (double, float, float, float, float) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, double, float, float, float, float, int> AddCubic;

            [NativeTypeName("HRESULT (double, float, float, float, float) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, double, float, float, float, float, int> AddSinusoidal;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, double, double, int> AddRepeat;

            [NativeTypeName("HRESULT (double, float) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAnimation*, double, float, int> End;
        }
    }
}
