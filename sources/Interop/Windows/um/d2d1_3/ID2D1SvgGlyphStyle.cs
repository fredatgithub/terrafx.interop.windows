// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
    [NativeTypeName("struct ID2D1SvgGlyphStyle : ID2D1Resource")]
    [NativeInheritance("ID2D1Resource")]
    public unsafe partial struct ID2D1SvgGlyphStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1SvgGlyphStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[1]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[2]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFill(ID2D1Brush* brush)
        {
            return ((delegate* unmanaged<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)(lpVtbl[4]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void GetFill(ID2D1Brush** brush)
        {
            ((delegate* unmanaged<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)(lpVtbl[5]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetStroke(ID2D1Brush* brush, float strokeWidth = 1.0f, [NativeTypeName("const FLOAT *")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, float dashOffset = 1.0f)
        {
            return ((delegate* unmanaged<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)(lpVtbl[6]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT32")]
        public uint GetStrokeDashesCount()
        {
            return ((delegate* unmanaged<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[7]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetStroke(ID2D1Brush** brush, float* strokeWidth = null, float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, float* dashOffset = null)
        {
            ((delegate* unmanaged<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)(lpVtbl[8]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }
    }
}
