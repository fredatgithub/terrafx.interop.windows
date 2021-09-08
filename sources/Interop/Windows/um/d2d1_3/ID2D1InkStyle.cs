// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
    [NativeTypeName("struct ID2D1InkStyle : ID2D1Resource")]
    [NativeInheritance("ID2D1Resource")]
    public unsafe partial struct ID2D1InkStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1InkStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1InkStyle*, uint>)(lpVtbl[1]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1InkStyle*, uint>)(lpVtbl[2]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1InkStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetNibTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged<ID2D1InkStyle*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[4]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged<ID2D1InkStyle*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetNibShape(D2D1_INK_NIB_SHAPE nibShape)
        {
            ((delegate* unmanaged<ID2D1InkStyle*, D2D1_INK_NIB_SHAPE, void>)(lpVtbl[6]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), nibShape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public D2D1_INK_NIB_SHAPE GetNibShape()
        {
            return ((delegate* unmanaged<ID2D1InkStyle*, D2D1_INK_NIB_SHAPE>)(lpVtbl[7]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }
    }
}
