// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AD18AC0-CFD2-4C2F-BB62-96E54FDB6879")]
    [NativeTypeName("struct IDCompositionShadowEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionShadowEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, uint>)(lpVtbl[1]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, uint>)(lpVtbl[2]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput(uint index, IUnknown* input, uint flags)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetStandardDeviation(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[5]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetStandardDeviation(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetColor([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, D2D_VECTOR_4F*, int>)(lpVtbl[6]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetRed(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[8]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetRed(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetGreen(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[10]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetGreen(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetBlue(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[12]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetBlue(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetAlpha(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[14]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetAlpha(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
