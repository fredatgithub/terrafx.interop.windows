// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("06152247-6F50-465A-9245-118BFD3B6007")]
    public unsafe partial struct ID2D1Factory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION &")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return CreateDrawingStateBlock(null, null, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1Factory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1Factory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1Factory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReloadSystemMetrics()
        {
            return lpVtbl->ReloadSystemMetrics((ID2D1Factory*)Unsafe.AsPointer(ref this));
        }

        public void GetDesktopDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            lpVtbl->GetDesktopDpi((ID2D1Factory*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleGeometry([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle, [NativeTypeName("ID2D1RectangleGeometry **")] ID2D1RectangleGeometry** rectangleGeometry)
        {
            return lpVtbl->CreateRectangleGeometry((ID2D1Factory*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRoundedRectangleGeometry([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle, [NativeTypeName("ID2D1RoundedRectangleGeometry **")] ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            return lpVtbl->CreateRoundedRectangleGeometry((ID2D1Factory*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEllipseGeometry([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1EllipseGeometry **")] ID2D1EllipseGeometry** ellipseGeometry)
        {
            return lpVtbl->CreateEllipseGeometry((ID2D1Factory*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryGroup(D2D1_FILL_MODE fillMode, [NativeTypeName("ID2D1Geometry **")] ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, [NativeTypeName("ID2D1GeometryGroup **")] ID2D1GeometryGroup** geometryGroup)
        {
            return lpVtbl->CreateGeometryGroup((ID2D1Factory*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* sourceGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform, [NativeTypeName("ID2D1TransformedGeometry **")] ID2D1TransformedGeometry** transformedGeometry)
        {
            return lpVtbl->CreateTransformedGeometry((ID2D1Factory*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry([NativeTypeName("ID2D1PathGeometry **")] ID2D1PathGeometry** pathGeometry)
        {
            return lpVtbl->CreatePathGeometry((ID2D1Factory*)Unsafe.AsPointer(ref this), pathGeometry);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("ID2D1StrokeStyle **")] ID2D1StrokeStyle** strokeStyle)
        {
            return lpVtbl->CreateStrokeStyle((ID2D1Factory*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams, [NativeTypeName("ID2D1DrawingStateBlock **")] ID2D1DrawingStateBlock** drawingStateBlock)
        {
            return lpVtbl->CreateDrawingStateBlock((ID2D1Factory*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWicBitmapRenderTarget([NativeTypeName("IWICBitmap *")] IWICBitmap* target, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1RenderTarget **")] ID2D1RenderTarget** renderTarget)
        {
            return lpVtbl->CreateWicBitmapRenderTarget((ID2D1Factory*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHwndRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, [NativeTypeName("ID2D1HwndRenderTarget **")] ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            return lpVtbl->CreateHwndRenderTarget((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDxgiSurfaceRenderTarget([NativeTypeName("IDXGISurface *")] IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1RenderTarget **")] ID2D1RenderTarget** renderTarget)
        {
            return lpVtbl->CreateDxgiSurfaceRenderTarget((ID2D1Factory*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDCRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("ID2D1DCRenderTarget **")] ID2D1DCRenderTarget** dcRenderTarget)
        {
            return lpVtbl->CreateDCRenderTarget((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, int> ReloadSystemMetrics;

            [NativeTypeName("void (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, float*, float*, void> GetDesktopDpi;

            [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1RectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D_RECT_F*, ID2D1RectangleGeometry**, int> CreateRectangleGeometry;

            [NativeTypeName("HRESULT (const D2D1_ROUNDED_RECT *, ID2D1RoundedRectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_ROUNDED_RECT*, ID2D1RoundedRectangleGeometry**, int> CreateRoundedRectangleGeometry;

            [NativeTypeName("HRESULT (const D2D1_ELLIPSE *, ID2D1EllipseGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_ELLIPSE*, ID2D1EllipseGeometry**, int> CreateEllipseGeometry;

            [NativeTypeName("HRESULT (D2D1_FILL_MODE, ID2D1Geometry **, UINT32, ID2D1GeometryGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_FILL_MODE, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int> CreateGeometryGroup;

            [NativeTypeName("HRESULT (ID2D1Geometry *, const D2D1_MATRIX_3X2_F *, ID2D1TransformedGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, ID2D1TransformedGeometry**, int> CreateTransformedGeometry;

            [NativeTypeName("HRESULT (ID2D1PathGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, ID2D1PathGeometry**, int> CreatePathGeometry;

            [NativeTypeName("HRESULT (const D2D1_STROKE_STYLE_PROPERTIES *, const FLOAT *, UINT32, ID2D1StrokeStyle **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_STROKE_STYLE_PROPERTIES*, float*, uint, ID2D1StrokeStyle**, int> CreateStrokeStyle;

            [NativeTypeName("HRESULT (const D2D1_DRAWING_STATE_DESCRIPTION *, IDWriteRenderingParams *, ID2D1DrawingStateBlock **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_DRAWING_STATE_DESCRIPTION*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int> CreateDrawingStateBlock;

            [NativeTypeName("HRESULT (IWICBitmap *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, IWICBitmap*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int> CreateWicBitmapRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, const D2D1_HWND_RENDER_TARGET_PROPERTIES *, ID2D1HwndRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_RENDER_TARGET_PROPERTIES*, D2D1_HWND_RENDER_TARGET_PROPERTIES*, ID2D1HwndRenderTarget**, int> CreateHwndRenderTarget;

            [NativeTypeName("HRESULT (IDXGISurface *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, IDXGISurface*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int> CreateDxgiSurfaceRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1DCRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Factory*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1DCRenderTarget**, int> CreateDCRenderTarget;
        }
    }
}
