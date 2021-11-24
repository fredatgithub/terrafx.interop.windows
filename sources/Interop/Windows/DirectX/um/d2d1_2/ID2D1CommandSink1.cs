// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("9EB767FD-4269-4467-B8C2-EB30CB305743")]
[NativeTypeName("struct ID2D1CommandSink1 : ID2D1CommandSink")]
[NativeInheritance("ID2D1CommandSink")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct ID2D1CommandSink1 : ID2D1CommandSink1.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, uint>)(lpVtbl[1]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, uint>)(lpVtbl[2]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw()
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, int>)(lpVtbl[3]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, int>)(lpVtbl[4]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D1_ANTIALIAS_MODE, int>)(lpVtbl[5]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), antialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ulong, ulong, int>)(lpVtbl[6]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), tag1, tag2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D1_TEXT_ANTIALIAS_MODE, int>)(lpVtbl[7]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), textAntialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, IDWriteRenderingParams*, int>)(lpVtbl[8]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), textRenderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[9]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), transform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D1_PRIMITIVE_BLEND, int>)(lpVtbl[10]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), primitiveBlend);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D1_UNIT_MODE, int>)(lpVtbl[11]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), unitMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, DXGI_RGBA*, int>)(lpVtbl[12]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, int>)(lpVtbl[13]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[14]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[15]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)(lpVtbl[16]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DrawBitmap(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[17]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DrawImage(ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, int>)(lpVtbl[18]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1GdiMetafile*, D2D_POINT_2F*, int>)(lpVtbl[19]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int>)(lpVtbl[20]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), mesh, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, int>)(lpVtbl[21]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)(lpVtbl[22]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D_RECT_F*, ID2D1Brush*, int>)(lpVtbl[23]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), rect, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, int>)(lpVtbl[24]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1, ID2D1Layer* layer)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, int>)(lpVtbl[25]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), layerParameters1, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT PopAxisAlignedClip()
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, int>)(lpVtbl[26]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT PopLayer()
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, int>)(lpVtbl[27]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        return ((delegate* unmanaged<ID2D1CommandSink1*, D2D1_PRIMITIVE_BLEND, int>)(lpVtbl[28]))((ID2D1CommandSink1*)Unsafe.AsPointer(ref this), primitiveBlend);
    }

    public interface Interface : ID2D1CommandSink.Interface
    {
        [VtblIndex(28)]
        HRESULT SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, uint> Release;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, int> BeginDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, int> EndDraw;

        [NativeTypeName("HRESULT (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D1_ANTIALIAS_MODE, int> SetAntialiasMode;

        [NativeTypeName("HRESULT (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ulong, ulong, int> SetTags;

        [NativeTypeName("HRESULT (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D1_TEXT_ANTIALIAS_MODE, int> SetTextAntialiasMode;

        [NativeTypeName("HRESULT (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, IDWriteRenderingParams*, int> SetTextRenderingParams;

        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D_MATRIX_3X2_F*, int> SetTransform;

        [NativeTypeName("HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D1_PRIMITIVE_BLEND, int> SetPrimitiveBlend;

        [NativeTypeName("HRESULT (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D1_UNIT_MODE, int> SetUnitMode;

        [NativeTypeName("HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, DXGI_RGBA*, int> Clear;

        [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, int> DrawGlyphRun;

        [NativeTypeName("HRESULT (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, int> DrawLine;

        [NativeTypeName("HRESULT (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int> DrawGeometry;

        [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, int> DrawRectangle;

        [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, int> DrawBitmap;

        [NativeTypeName("HRESULT (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, int> DrawImage;

        [NativeTypeName("HRESULT (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1GdiMetafile*, D2D_POINT_2F*, int> DrawGdiMetafile;

        [NativeTypeName("HRESULT (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1Mesh*, ID2D1Brush*, int> FillMesh;

        [NativeTypeName("HRESULT (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, int> FillOpacityMask;

        [NativeTypeName("HRESULT (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int> FillGeometry;

        [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D_RECT_F*, ID2D1Brush*, int> FillRectangle;

        [NativeTypeName("HRESULT (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, int> PushAxisAlignedClip;

        [NativeTypeName("HRESULT (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, int> PushLayer;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, int> PopAxisAlignedClip;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, int> PopLayer;

        [NativeTypeName("HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1CommandSink1*, D2D1_PRIMITIVE_BLEND, int> SetPrimitiveBlend1;
    }
}
