// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget"]/*' />
[Guid("5E5A32A3-8DFF-4773-9FF6-0696EAB77267")]
[NativeTypeName("struct IDWriteBitmapRenderTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteBitmapRenderTarget : IDWriteBitmapRenderTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteBitmapRenderTarget));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, uint>)(lpVtbl[1]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, uint>)(lpVtbl[2]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.DrawGlyphRun"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, IDWriteRenderingParams* renderingParams, COLORREF textColor, RECT* blackBoxRect = null)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, RECT*, int>)(lpVtbl[3]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.GetMemoryDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HDC GetMemoryDC()
    {
        return ((HDC)(((delegate* unmanaged<IDWriteBitmapRenderTarget*, void*>)(lpVtbl[4]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.GetPixelsPerDip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public float GetPixelsPerDip()
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, float>)(lpVtbl[5]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.SetPixelsPerDip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPixelsPerDip(float pixelsPerDip)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, float, int>)(lpVtbl[6]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), pixelsPerDip);
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.GetCurrentTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentTransform(DWRITE_MATRIX* transform)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, DWRITE_MATRIX*, int>)(lpVtbl[7]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.SetCurrentTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, DWRITE_MATRIX*, int>)(lpVtbl[8]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.GetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSize(SIZE* size)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, SIZE*, int>)(lpVtbl[9]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), size);
    }

    /// <include file='IDWriteBitmapRenderTarget.xml' path='doc/member[@name="IDWriteBitmapRenderTarget.Resize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height)
    {
        return ((delegate* unmanaged<IDWriteBitmapRenderTarget*, uint, uint, int>)(lpVtbl[10]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), width, height);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, IDWriteRenderingParams* renderingParams, COLORREF textColor, RECT* blackBoxRect = null);

        [VtblIndex(4)]
        HDC GetMemoryDC();

        [VtblIndex(5)]
        float GetPixelsPerDip();

        [VtblIndex(6)]
        HRESULT SetPixelsPerDip(float pixelsPerDip);

        [VtblIndex(7)]
        HRESULT GetCurrentTransform(DWRITE_MATRIX* transform);

        [VtblIndex(8)]
        HRESULT SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform);

        [VtblIndex(9)]
        HRESULT GetSize(SIZE* size);

        [VtblIndex(10)]
        HRESULT Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, IDWriteRenderingParams *, COLORREF, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, RECT*, int> DrawGlyphRun;

        [NativeTypeName("HDC () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetMemoryDC;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetPixelsPerDip;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetPixelsPerDip;

        [NativeTypeName("HRESULT (DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_MATRIX*, int> GetCurrentTransform;

        [NativeTypeName("HRESULT (const DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_MATRIX*, int> SetCurrentTransform;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> GetSize;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Resize;
    }
}
