// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_COMPOSITE_MODE;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_SPRITE_OPTIONS;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    [Guid("235A7496-8351-414C-BCD4-6672AB2D8E00")]
    public unsafe partial struct ID2D1DeviceContext3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DeviceContext3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DeviceContext3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DeviceContext3* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1DeviceContext3* This, ID2D1Factory** factory);

        /// <summary>Create a D2D bitmap by copying from memory, or create uninitialized.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [Optional] void* srcData, [NativeTypeName("UINT32")] uint pitch, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);

        /// <summary>Create a D2D bitmap by copying a WIC bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromWicBitmap(ID2D1DeviceContext3* This, IWICBitmapSource* wicBitmapSource, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);

        /// <summary>Create a D2D bitmap by sharing bits from another resource. The bitmap must be compatible with the render target for the call to succeed. For example, an IWICBitmap can be shared with a software target, or a DXGI surface can be shared with a DXGI render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedBitmap(ID2D1DeviceContext3* This, [NativeTypeName("REFIID")] Guid* riid, void* data, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);

        /// <summary>Creates a bitmap brush. The bitmap is scaled, rotated, skewed or tiled to fill or pen a geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapBrush(ID2D1DeviceContext3* This, [Optional] ID2D1Bitmap* bitmap, [Optional] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSolidColorBrush(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush);

        /// <summary>A gradient stop collection represents a set of stops in an ideal unit length. This is the source resource for a linear gradient and radial gradient brush.</summary>
        /// <param name="colorInterpolationGamma">Specifies which space the color interpolation occurs in.</param>
        /// <param name="extendMode">Specifies how the gradient will be extended outside of the unit length.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientStopCollection(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLinearGradientBrush(ID2D1DeviceContext3* This, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRadialGradientBrush(ID2D1DeviceContext3* This, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush);

        /// <summary>Creates a bitmap render target whose bitmap can be used as a source for rendering in the API.</summary>
        /// <param name="desiredSize">The requested size of the target in DIPs. If the pixel size is not specified, the DPI is inherited from the parent target. However, the render target will never contain a fractional number of pixels.</param>
        /// <param name="desiredPixelSize">The requested size of the render target in pixels. If the DIP size is also specified, the DPI is calculated from these two values. If the desired size is not specified, the DPI is inherited from the parent render target. If neither value is specified, the compatible render target will be the same size and have the same DPI as the parent target.</param>
        /// <param name="desiredFormat">The desired pixel format. The format must be compatible with the parent render target type. If the format is not specified, it will be inherited from the parent render target.</param>
        /// <param name="options">Allows the caller to retrieve a GDI compatible render target.</param>
        /// <param name="bitmapRenderTarget">The returned bitmap render target.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCompatibleRenderTarget(ID2D1DeviceContext3* This, [Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* desiredSize, [Optional, NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U* desiredPixelSize, [Optional] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget);

        /// <summary>Creates a layer resource that can be used on any target and which will resize under the covers if necessary.</summary>
        /// <param name="size">The resolution independent minimum size hint for the layer resource. Specify this to prevent unwanted reallocation of the layer backing store. The size is in DIPs, but, it is unaffected by the current world transform. If the size is unspecified, the returned resource is a placeholder and the backing store will be allocated to be the minimum size that can hold the content when the layer is pushed.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLayer(ID2D1DeviceContext3* This, [Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* size, ID2D1Layer** layer);

        /// <summary>Create a D2D mesh.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMesh(ID2D1DeviceContext3* This, ID2D1Mesh** mesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawLine(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawRectangle(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillRectangle(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawRoundedRectangle(ID2D1DeviceContext3* This, D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillRoundedRectangle(ID2D1DeviceContext3* This, D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawEllipse(ID2D1DeviceContext3* This, D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillEllipse(ID2D1DeviceContext3* This, D2D1_ELLIPSE* ellipse, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGeometry(ID2D1DeviceContext3* This, ID2D1Geometry* geometry, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        /// <param name="opacityBrush">An optionally specified opacity brush. Only the alpha channel of the corresponding brush will be sampled and will be applied to the entire fill of the geometry. If this brush is specified, the fill brush must be a bitmap brush with an extend mode of D2D1_EXTEND_MODE_CLAMP.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillGeometry(ID2D1DeviceContext3* This, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush = null);

        /// <summary>Fill a mesh. Since meshes can only render aliased content, the render target antialiasing mode must be set to aliased.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillMesh(ID2D1DeviceContext3* This, ID2D1Mesh* mesh, ID2D1Brush* brush);

        /// <summary>Fill using the alpha channel of the supplied opacity mask bitmap. The brush opacity will be modulated by the mask. The render target antialiasing mode must be set to aliased.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillOpacityMask(ID2D1DeviceContext3* This, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawBitmap(ID2D1DeviceContext3* This, ID2D1Bitmap* bitmap, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null);

        /// <summary>Draws the text within the given layout rectangle and by default also performs baseline snapping.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawText(ID2D1DeviceContext3* This, [NativeTypeName("WCHAR[]")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        /// <summary>Draw a text layout object. If the layout is not subsequently changed, this can be more efficient than DrawText when drawing the same layout repeatedly.</summary>
        /// <param name="options">The specified text options. If D2D1_DRAW_TEXT_OPTIONS_CLIP is used, the text is clipped to the layout bounds. These bounds are derived from the origin and the layout bounds of the corresponding IDWriteTextLayout object.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawTextLayout(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGlyphRun(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetAntialiasMode(ID2D1DeviceContext3* This, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_ANTIALIAS_MODE _GetAntialiasMode(ID2D1DeviceContext3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextAntialiasMode(ID2D1DeviceContext3* This, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_TEXT_ANTIALIAS_MODE _GetTextAntialiasMode(ID2D1DeviceContext3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextRenderingParams(ID2D1DeviceContext3* This, IDWriteRenderingParams* textRenderingParams = null);

        /// <summary>Retrieve the text render parameters. NOTE: If NULL is specified to SetTextRenderingParameters, NULL will be returned.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTextRenderingParams(ID2D1DeviceContext3* This, IDWriteRenderingParams** textRenderingParams);

        /// <summary>Set a tag to correspond to the succeeding primitives. If an error occurs rendering a primitive, the tags can be returned from the Flush or EndDraw call.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTags(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2);

        /// <summary>Retrieves the currently set tags. This does not retrieve the tags corresponding to any primitive that is in error.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTags(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null);

        /// <summary>Start a layer of drawing calls. The way in which the layer must be resolved is specified first as well as the logical resource that stores the layer parameters. The supplied layer resource might grow if the specified content cannot fit inside it. The layer will grow monotonically on each axis.  If a NULL ID2D1Layer is provided, then a layer resource will be allocated automatically.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushLayer(ID2D1DeviceContext3* This, D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer = null);

        /// <summary>Ends a layer that was defined with particular layer resources.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopLayer(ID2D1DeviceContext3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Flush(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null);

        /// <summary>Gets the current drawing state and saves it into the supplied IDrawingStatckBlock.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SaveDrawingState(ID2D1DeviceContext3* This, ID2D1DrawingStateBlock* drawingStateBlock);

        /// <summary>Copies the state stored in the block interface.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RestoreDrawingState(ID2D1DeviceContext3* This, ID2D1DrawingStateBlock* drawingStateBlock);

        /// <summary>Pushes a clip. The clip can be antialiased. The clip must be axis aligned. If the current world transform is not axis preserving, then the bounding box of the transformed clip rect will be used. The clip will remain in effect until a PopAxisAligned clip call is made.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushAxisAlignedClip(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopAxisAlignedClip(ID2D1DeviceContext3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* clearColor = null);

        /// <summary>Start drawing on this render target. Draw calls can only be issued between a BeginDraw and EndDraw call.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginDraw(ID2D1DeviceContext3* This);

        /// <summary>Ends drawing on the render target, error results can be retrieved at this time, or when calling flush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndDraw(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(ID2D1DeviceContext3* This, D2D1_PIXEL_FORMAT* _result);

        /// <summary>Sets the DPI on the render target. This results in the render target being interpreted to a different scale. Neither DPI can be negative. If zero is specified for both, the system DPI is chosen. If one is zero and the other unspecified, the DPI is not changed.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDpi(ID2D1DeviceContext3* This, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY);

        /// <summary>Return the current DPI from the target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(ID2D1DeviceContext3* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        /// <summary>Returns the size of the render target in DIPs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetSize(ID2D1DeviceContext3* This, D2D_SIZE_F* _result);

        /// <summary>Returns the size of the render target in pixels.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public delegate D2D_SIZE_U* _GetPixelSize(ID2D1DeviceContext3* This, D2D_SIZE_U* _result);

        /// <summary>Returns the maximum bitmap and render target size that is guaranteed to be supported by the render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetMaximumBitmapSize(ID2D1DeviceContext3* This);

        /// <summary>Returns true if the given properties are supported by this render target. The DPI is ignored. NOTE: If the render target type is software, then neither D2D1_FEATURE_LEVEL_9 nor D2D1_FEATURE_LEVEL_10 will be considered to be supported.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSupported(ID2D1DeviceContext3* This, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties);

        /// <summary>Creates a bitmap with extended bitmap properties, potentially from a block of memory.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap1(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [Optional] void* sourceData, [NativeTypeName("UINT32")] uint pitch, D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap);

        /// <summary>Create a D2D bitmap by copying a WIC bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromWicBitmap1(ID2D1DeviceContext3* This, IWICBitmapSource* wicBitmapSource, [Optional] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap);

        /// <summary>Creates a color context from a color space.  If the space is Custom, the context is initialized from the profile/profileSize arguments.  Otherwise the context is initialized with the profile bytes associated with the space and profile/profileSize are ignored.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(ID2D1DeviceContext3* This, D2D1_COLOR_SPACE space, [NativeTypeName("BYTE[]")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromFilename(ID2D1DeviceContext3* This, [NativeTypeName("PCWSTR")] ushort* filename, ID2D1ColorContext** colorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContextFromWicColorContext(ID2D1DeviceContext3* This, IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext);

        /// <summary>Creates a bitmap from a DXGI surface with a set of extended properties.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromDxgiSurface(ID2D1DeviceContext3* This, IDXGISurface* surface, [Optional] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap);

        /// <summary>Create a new effect, the effect must either be built in or previously registered through ID2D1Factory1::RegisterEffectFromStream or ID2D1Factory1::RegisterEffectFromString.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffect(ID2D1DeviceContext3* This, [NativeTypeName("REFCLSID")] Guid* effectId, ID2D1Effect** effect);

        /// <summary>A gradient stop collection represents a set of stops in an ideal unit length. This is the source resource for a linear gradient and radial gradient brush.</summary>
        /// <param name="preInterpolationSpace">Specifies both the input color space and the space in which the color interpolation occurs.</param>
        /// <param name="postInterpolationSpace">Specifies the color space colors will be converted to after interpolation occurs.</param>
        /// <param name="bufferPrecision">Specifies the precision in which the gradient buffer will be held.</param>
        /// <param name="extendMode">Specifies how the gradient will be extended outside of the unit length.</param>
        /// <param name="colorInterpolationMode">Determines if colors will be interpolated in straight alpha or premultiplied alpha space.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientStopCollection1(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, ID2D1GradientStopCollection1** gradientStopCollection1);

        /// <summary>Creates an image brush, the input image can be any type of image, including a bitmap, effect and a command list.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageBrush(ID2D1DeviceContext3* This, [Optional] ID2D1Image* image, D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1ImageBrush** imageBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapBrush1(ID2D1DeviceContext3* This, [Optional] ID2D1Bitmap* bitmap, [Optional] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush1** bitmapBrush);

        /// <summary>Creates a new command list.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCommandList(ID2D1DeviceContext3* This, ID2D1CommandList** commandList);

        /// <summary>Indicates whether the format is supported by D2D.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsDxgiFormatSupported(ID2D1DeviceContext3* This, DXGI_FORMAT format);

        /// <summary>Indicates whether the buffer precision is supported by D2D.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsBufferPrecisionSupported(ID2D1DeviceContext3* This, D2D1_BUFFER_PRECISION bufferPrecision);

        /// <summary>This retrieves the local-space bounds in DIPs of the current image using the device context DPI.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImageLocalBounds(ID2D1DeviceContext3* This, ID2D1Image* image, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* localBounds);

        /// <summary>This retrieves the world-space bounds in DIPs of the current image using the device context DPI.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImageWorldBounds(ID2D1DeviceContext3* This, ID2D1Image* image, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* worldBounds);

        /// <summary>Retrieves the world-space bounds in DIPs of the glyph run using the device context DPI.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphRunWorldBounds(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds);

        /// <summary>Retrieves the device associated with this device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID2D1DeviceContext3* This, ID2D1Device** device);

        /// <summary>Sets the target for this device context to point to the given image. The image can be a command list or a bitmap created with the D2D1_BITMAP_OPTIONS_TARGET flag.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTarget(ID2D1DeviceContext3* This, ID2D1Image* image = null);

        /// <summary>Gets the target that this device context is currently pointing to.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTarget(ID2D1DeviceContext3* This, ID2D1Image** image);

        /// <summary>Sets tuning parameters for internal rendering inside the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetRenderingControls(ID2D1DeviceContext3* This, D2D1_RENDERING_CONTROLS* renderingControls);

        /// <summary>This retrieves the rendering controls currently selected into the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetRenderingControls(ID2D1DeviceContext3* This, D2D1_RENDERING_CONTROLS* renderingControls);

        /// <summary>Changes the primitive blending mode for all of the rendering operations.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetPrimitiveBlend(ID2D1DeviceContext3* This, D2D1_PRIMITIVE_BLEND primitiveBlend);

        /// <summary>Returns the primitive blend currently selected into the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PRIMITIVE_BLEND _GetPrimitiveBlend(ID2D1DeviceContext3* This);

        /// <summary>Changes the units used for all of the rendering operations.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetUnitMode(ID2D1DeviceContext3* This, D2D1_UNIT_MODE unitMode);

        /// <summary>Returns the unit mode currently set on the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_UNIT_MODE _GetUnitMode(ID2D1DeviceContext3* This);

        /// <summary>Draws the glyph run with an extended description to describe the glyphs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGlyphRun1(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, [Optional] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        /// <summary>Draw an image to the device context. The image represents either a concrete bitmap or the output of an effect graph.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawImage(ID2D1DeviceContext3* This, ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER);

        /// <summary>Draw a metafile to the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGdiMetafile(ID2D1DeviceContext3* This, ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawBitmap1(ID2D1DeviceContext3* This, ID2D1Bitmap* bitmap, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("D2D1_MATRIX_4X4_F")] D2D_MATRIX_4X4_F* perspectiveTransform = null);

        /// <summary>Push a layer on the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushLayer1(ID2D1DeviceContext3* This, D2D1_LAYER_PARAMETERS1* layerParameters, ID2D1Layer* layer = null);

        /// <summary>This indicates that a portion of an effect's input is invalid. This method can be called many times.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InvalidateEffectInputRectangle(ID2D1DeviceContext3* This, ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* inputRectangle);

        /// <summary>Gets the number of invalid ouptut rectangles that have accumulated at the effect.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectInvalidRectangleCount(ID2D1DeviceContext3* This, ID2D1Effect* effect, [NativeTypeName("UINT32")] uint* rectangleCount);

        /// <summary>Gets the invalid rectangles that are at the output of the effect.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectInvalidRectangles(ID2D1DeviceContext3* This, ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount);

        /// <summary>Gets the maximum region of each specified input which would be used during a subsequent rendering operation</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectRequiredInputRectangles(ID2D1DeviceContext3* This, ID2D1Effect* renderEffect, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount);

        /// <summary>Fill using the alpha channel of the supplied opacity mask bitmap. The brush opacity will be modulated by the mask. The render target antialiasing mode must be set to aliased.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillOpacityMask1(ID2D1DeviceContext3* This, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFilledGeometryRealization(ID2D1DeviceContext3* This, ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1GeometryRealization** geometryRealization);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokedGeometryRealization(ID2D1DeviceContext3* This, ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGeometryRealization(ID2D1DeviceContext3* This, ID2D1GeometryRealization* geometryRealization, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInk(ID2D1DeviceContext3* This, D2D1_INK_POINT* startPoint, ID2D1Ink** ink);

        /// <summary>Creates a new ink style.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInkStyle(ID2D1DeviceContext3* This, [Optional] D2D1_INK_STYLE_PROPERTIES* inkStyleProperties, ID2D1InkStyle** inkStyle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientMesh(ID2D1DeviceContext3* This, [NativeTypeName("D2D1_GRADIENT_MESH_PATCH[]")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount, ID2D1GradientMesh** gradientMesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageSourceFromWic(ID2D1DeviceContext3* This, IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, ID2D1ImageSourceFromWic** imageSource);

        /// <summary>Creates a 3D lookup table for mapping a 3-channel input to a 3-channel output. The table data must be provided in 4-channel format.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLookupTable3D(ID2D1DeviceContext3* This, D2D1_BUFFER_PRECISION precision, [NativeTypeName("UINT32[]")] uint* extents, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32[]")] uint* strides, ID2D1LookupTable3D** lookupTable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateImageSourceFromDxgi(ID2D1DeviceContext3* This, [NativeTypeName("IDXGISurface*[]")] IDXGISurface** surfaces, [NativeTypeName("UINT32")] uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, ID2D1ImageSource** imageSource);

        /// <summary>Retrieves the world-space bounds in DIPs of the gradient mesh using the device context DPI.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGradientMeshWorldBounds(ID2D1DeviceContext3* This, ID2D1GradientMesh* gradientMesh, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* pBounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawInk(ID2D1DeviceContext3* This, ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGradientMesh(ID2D1DeviceContext3* This, ID2D1GradientMesh* gradientMesh);

        /// <summary>Draw a metafile to the device context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGdiMetafile1(ID2D1DeviceContext3* This, ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null);

        /// <summary>Creates an image source which shares resources with an original.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformedImageSource(ID2D1DeviceContext3* This, ID2D1ImageSource* imageSource, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties, ID2D1TransformedImageSource** transformedImageSource);

        /// <summary>Creates a new sprite batch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSpriteBatch(ID2D1DeviceContext3* This, ID2D1SpriteBatch** spriteBatch);

        /// <summary>Draws sprites in a sprite batch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawSpriteBatch(ID2D1DeviceContext3* This, ID2D1SpriteBatch* spriteBatch, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [Optional] void* srcData, [NativeTypeName("UINT32")] uint pitch, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)(This, size, srcData, pitch, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromWicBitmap>(lpVtbl->CreateBitmapFromWicBitmap)(This, wicBitmapSource, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("REFIID")] Guid* riid, void* data, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSharedBitmap>(lpVtbl->CreateSharedBitmap)(This, riid, data, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([Optional] ID2D1Bitmap* bitmap, [Optional] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapBrush>(lpVtbl->CreateBitmapBrush)(This, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSolidColorBrush>(lpVtbl->CreateSolidColorBrush)(This, color, brushProperties, solidColorBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGradientStopCollection>(lpVtbl->CreateGradientStopCollection)(This, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateLinearGradientBrush>(lpVtbl->CreateLinearGradientBrush)(This, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRadialGradientBrush>(lpVtbl->CreateRadialGradientBrush)(This, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* desiredSize, [Optional, NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U* desiredPixelSize, [Optional] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCompatibleRenderTarget>(lpVtbl->CreateCompatibleRenderTarget)(This, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* size, ID2D1Layer** layer)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateLayer>(lpVtbl->CreateLayer)(This, size, layer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMesh(ID2D1Mesh** mesh)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMesh>(lpVtbl->CreateMesh)(This, mesh);
            }
        }

        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawLine>(lpVtbl->DrawLine)(This, point0, point1, brush, strokeWidth, strokeStyle);
            }
        }

        public void DrawRectangle([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawRectangle>(lpVtbl->DrawRectangle)(This, rect, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillRectangle([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillRectangle>(lpVtbl->FillRectangle)(This, rect, brush);
            }
        }

        public void DrawRoundedRectangle(D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawRoundedRectangle>(lpVtbl->DrawRoundedRectangle)(This, roundedRect, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillRoundedRectangle(D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillRoundedRectangle>(lpVtbl->FillRoundedRectangle)(This, roundedRect, brush);
            }
        }

        public void DrawEllipse(D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawEllipse>(lpVtbl->DrawEllipse)(This, ellipse, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillEllipse(D2D1_ELLIPSE* ellipse, ID2D1Brush* brush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillEllipse>(lpVtbl->FillEllipse)(This, ellipse, brush);
            }
        }

        public void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGeometry>(lpVtbl->DrawGeometry)(This, geometry, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillGeometry>(lpVtbl->FillGeometry)(This, geometry, brush, opacityBrush);
            }
        }

        public void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillMesh>(lpVtbl->FillMesh)(This, mesh, brush);
            }
        }

        public void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillOpacityMask>(lpVtbl->FillOpacityMask)(This, opacityMask, brush, content, destinationRectangle, sourceRectangle);
            }
        }

        public void DrawBitmap(ID2D1Bitmap* bitmap, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawBitmap>(lpVtbl->DrawBitmap)(This, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
            }
        }

        public void DrawText([NativeTypeName("WCHAR[]")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawText>(lpVtbl->DrawText)(This, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }

        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawTextLayout>(lpVtbl->DrawTextLayout)(This, origin, textLayout, defaultFillBrush, options);
            }
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)(This, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
            }
        }

        public void SetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(This, transform);
            }
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(This, transform);
            }
        }

        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)(This, antialiasMode);
            }
        }

        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAntialiasMode>(lpVtbl->GetAntialiasMode)(This);
            }
        }

        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)(This, textAntialiasMode);
            }
        }

        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextAntialiasMode>(lpVtbl->GetTextAntialiasMode)(This);
            }
        }

        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTags>(lpVtbl->SetTags)(This, tag1, tag2);
            }
        }

        public void GetTags([NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTags>(lpVtbl->GetTags)(This, tag1, tag2);
            }
        }

        public void PushLayer(D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PushLayer>(lpVtbl->PushLayer)(This, layerParameters, layer);
            }
        }

        public void PopLayer()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopLayer>(lpVtbl->PopLayer)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Flush>(lpVtbl->Flush)(This, tag1, tag2);
            }
        }

        public void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SaveDrawingState>(lpVtbl->SaveDrawingState)(This, drawingStateBlock);
            }
        }

        public void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_RestoreDrawingState>(lpVtbl->RestoreDrawingState)(This, drawingStateBlock);
            }
        }

        public void PushAxisAlignedClip([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)(This, clipRect, antialiasMode);
            }
        }

        public void PopAxisAlignedClip()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)(This);
            }
        }

        public void Clear([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* clearColor = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)(This, clearColor);
            }
        }

        public void BeginDraw()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)(This, tag1, tag2);
            }
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                D2D1_PIXEL_FORMAT result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, &result);
            }
        }

        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDpi>(lpVtbl->SetDpi)(This, dpiX, dpiY);
            }
        }

        public void GetDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                D2D_SIZE_F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, &result);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                D2D_SIZE_U result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelSize>(lpVtbl->GetPixelSize)(This, &result);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumBitmapSize>(lpVtbl->GetMaximumBitmapSize)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSupported(D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsSupported>(lpVtbl->IsSupported)(This, renderTargetProperties);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap1([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [Optional] void* sourceData, [NativeTypeName("UINT32")] uint pitch, D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmap1>(lpVtbl->CreateBitmap1)(This, size, sourceData, pitch, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap1(IWICBitmapSource* wicBitmapSource, [Optional] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromWicBitmap1>(lpVtbl->CreateBitmapFromWicBitmap1)(This, wicBitmapSource, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("BYTE[]")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)(This, space, profile, profileSize, colorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromFilename>(lpVtbl->CreateColorContextFromFilename)(This, filename, colorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateColorContextFromWicColorContext>(lpVtbl->CreateColorContextFromWicColorContext)(This, wicColorContext, colorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromDxgiSurface(IDXGISurface* surface, [Optional] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromDxgiSurface>(lpVtbl->CreateBitmapFromDxgiSurface)(This, surface, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("REFCLSID")] Guid* effectId, ID2D1Effect** effect)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEffect>(lpVtbl->CreateEffect)(This, effectId, effect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection1([NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, ID2D1GradientStopCollection1** gradientStopCollection1)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGradientStopCollection1>(lpVtbl->CreateGradientStopCollection1)(This, straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, gradientStopCollection1);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([Optional] ID2D1Image* image, D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1ImageBrush** imageBrush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateImageBrush>(lpVtbl->CreateImageBrush)(This, image, imageBrushProperties, brushProperties, imageBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush1([Optional] ID2D1Bitmap* bitmap, [Optional] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush1** bitmapBrush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapBrush1>(lpVtbl->CreateBitmapBrush1)(This, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList(ID2D1CommandList** commandList)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCommandList>(lpVtbl->CreateCommandList)(This, commandList);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsDxgiFormatSupported(DXGI_FORMAT format)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsDxgiFormatSupported>(lpVtbl->IsDxgiFormatSupported)(This, format);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsBufferPrecisionSupported>(lpVtbl->IsBufferPrecisionSupported)(This, bufferPrecision);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImageLocalBounds(ID2D1Image* image, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* localBounds)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetImageLocalBounds>(lpVtbl->GetImageLocalBounds)(This, image, localBounds);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImageWorldBounds(ID2D1Image* image, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* worldBounds)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetImageWorldBounds>(lpVtbl->GetImageWorldBounds)(This, image, worldBounds);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunWorldBounds([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* bounds)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphRunWorldBounds>(lpVtbl->GetGlyphRunWorldBounds)(This, baselineOrigin, glyphRun, measuringMode, bounds);
            }
        }

        public void GetDevice(ID2D1Device** device)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, device);
            }
        }

        public void SetTarget(ID2D1Image* image = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTarget>(lpVtbl->SetTarget)(This, image);
            }
        }

        public void GetTarget(ID2D1Image** image)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTarget>(lpVtbl->GetTarget)(This, image);
            }
        }

        public void SetRenderingControls(D2D1_RENDERING_CONTROLS* renderingControls)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetRenderingControls>(lpVtbl->SetRenderingControls)(This, renderingControls);
            }
        }

        public void GetRenderingControls(D2D1_RENDERING_CONTROLS* renderingControls)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetRenderingControls>(lpVtbl->GetRenderingControls)(This, renderingControls);
            }
        }

        public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetPrimitiveBlend>(lpVtbl->SetPrimitiveBlend)(This, primitiveBlend);
            }
        }

        public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrimitiveBlend>(lpVtbl->GetPrimitiveBlend)(This);
            }
        }

        public void SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetUnitMode>(lpVtbl->SetUnitMode)(This, unitMode);
            }
        }

        public D2D1_UNIT_MODE GetUnitMode()
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetUnitMode>(lpVtbl->GetUnitMode)(This);
            }
        }

        public void DrawGlyphRun1([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, [Optional] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun1>(lpVtbl->DrawGlyphRun1)(This, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
            }
        }

        public void DrawImage(ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawImage>(lpVtbl->DrawImage)(This, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
            }
        }

        public void DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile>(lpVtbl->DrawGdiMetafile)(This, gdiMetafile, targetOffset);
            }
        }

        public void DrawBitmap1(ID2D1Bitmap* bitmap, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("D2D1_MATRIX_4X4_F")] D2D_MATRIX_4X4_F* perspectiveTransform = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawBitmap1>(lpVtbl->DrawBitmap1)(This, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
            }
        }

        public void PushLayer1(D2D1_LAYER_PARAMETERS1* layerParameters, ID2D1Layer* layer = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PushLayer1>(lpVtbl->PushLayer1)(This, layerParameters, layer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateEffectInputRectangle(ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* inputRectangle)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InvalidateEffectInputRectangle>(lpVtbl->InvalidateEffectInputRectangle)(This, effect, input, inputRectangle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangleCount(ID2D1Effect* effect, [NativeTypeName("UINT32")] uint* rectangleCount)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEffectInvalidRectangleCount>(lpVtbl->GetEffectInvalidRectangleCount)(This, effect, rectangleCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangles(ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEffectInvalidRectangles>(lpVtbl->GetEffectInvalidRectangles)(This, effect, rectangles, rectanglesCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEffectRequiredInputRectangles>(lpVtbl->GetEffectRequiredInputRectangles)(This, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
            }
        }

        public void FillOpacityMask1(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillOpacityMask1>(lpVtbl->FillOpacityMask1)(This, opacityMask, brush, destinationRectangle, sourceRectangle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFilledGeometryRealization(ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, ID2D1GeometryRealization** geometryRealization)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFilledGeometryRealization>(lpVtbl->CreateFilledGeometryRealization)(This, geometry, flatteningTolerance, geometryRealization);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokedGeometryRealization(ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float strokeWidth, [Optional] ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokedGeometryRealization>(lpVtbl->CreateStrokedGeometryRealization)(This, geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
            }
        }

        public void DrawGeometryRealization(ID2D1GeometryRealization* geometryRealization, ID2D1Brush* brush)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGeometryRealization>(lpVtbl->DrawGeometryRealization)(This, geometryRealization, brush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInk(D2D1_INK_POINT* startPoint, ID2D1Ink** ink)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInk>(lpVtbl->CreateInk)(This, startPoint, ink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInkStyle([Optional] D2D1_INK_STYLE_PROPERTIES* inkStyleProperties, ID2D1InkStyle** inkStyle)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInkStyle>(lpVtbl->CreateInkStyle)(This, inkStyleProperties, inkStyle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientMesh([NativeTypeName("D2D1_GRADIENT_MESH_PATCH[]")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount, ID2D1GradientMesh** gradientMesh)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGradientMesh>(lpVtbl->CreateGradientMesh)(This, patches, patchesCount, gradientMesh);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic(IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, ID2D1ImageSourceFromWic** imageSource)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateImageSourceFromWic>(lpVtbl->CreateImageSourceFromWic)(This, wicBitmapSource, loadingOptions, alphaMode, imageSource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [NativeTypeName("UINT32[]")] uint* extents, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32[]")] uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateLookupTable3D>(lpVtbl->CreateLookupTable3D)(This, precision, extents, data, dataCount, strides, lookupTable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromDxgi([NativeTypeName("IDXGISurface*[]")] IDXGISurface** surfaces, [NativeTypeName("UINT32")] uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, ID2D1ImageSource** imageSource)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateImageSourceFromDxgi>(lpVtbl->CreateImageSourceFromDxgi)(This, surfaces, surfaceCount, colorSpace, options, imageSource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGradientMeshWorldBounds(ID2D1GradientMesh* gradientMesh, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* pBounds)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGradientMeshWorldBounds>(lpVtbl->GetGradientMeshWorldBounds)(This, gradientMesh, pBounds);
            }
        }

        public void DrawInk(ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawInk>(lpVtbl->DrawInk)(This, ink, brush, inkStyle);
            }
        }

        public void DrawGradientMesh(ID2D1GradientMesh* gradientMesh)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGradientMesh>(lpVtbl->DrawGradientMesh)(This, gradientMesh);
            }
        }

        public void DrawGdiMetafile1(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGdiMetafile1>(lpVtbl->DrawGdiMetafile1)(This, gdiMetafile, destinationRectangle, sourceRectangle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedImageSource(ID2D1ImageSource* imageSource, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties, ID2D1TransformedImageSource** transformedImageSource)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateTransformedImageSource>(lpVtbl->CreateTransformedImageSource)(This, imageSource, properties, transformedImageSource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSpriteBatch(ID2D1SpriteBatch** spriteBatch)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSpriteBatch>(lpVtbl->CreateSpriteBatch)(This, spriteBatch);
            }
        }

        public void DrawSpriteBatch(ID2D1SpriteBatch* spriteBatch, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, ID2D1Bitmap* bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE)
        {
            fixed (ID2D1DeviceContext3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawSpriteBatch>(lpVtbl->DrawSpriteBatch)(This, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr CreateBitmap;

            public IntPtr CreateBitmapFromWicBitmap;

            public IntPtr CreateSharedBitmap;

            public IntPtr CreateBitmapBrush;

            public IntPtr CreateSolidColorBrush;

            public IntPtr CreateGradientStopCollection;

            public IntPtr CreateLinearGradientBrush;

            public IntPtr CreateRadialGradientBrush;

            public IntPtr CreateCompatibleRenderTarget;

            public IntPtr CreateLayer;

            public IntPtr CreateMesh;

            public IntPtr DrawLine;

            public IntPtr DrawRectangle;

            public IntPtr FillRectangle;

            public IntPtr DrawRoundedRectangle;

            public IntPtr FillRoundedRectangle;

            public IntPtr DrawEllipse;

            public IntPtr FillEllipse;

            public IntPtr DrawGeometry;

            public IntPtr FillGeometry;

            public IntPtr FillMesh;

            public IntPtr FillOpacityMask;

            public IntPtr DrawBitmap;

            public IntPtr DrawText;

            public IntPtr DrawTextLayout;

            public IntPtr DrawGlyphRun;

            public IntPtr SetTransform;

            public IntPtr GetTransform;

            public IntPtr SetAntialiasMode;

            public IntPtr GetAntialiasMode;

            public IntPtr SetTextAntialiasMode;

            public IntPtr GetTextAntialiasMode;

            public IntPtr SetTextRenderingParams;

            public IntPtr GetTextRenderingParams;

            public IntPtr SetTags;

            public IntPtr GetTags;

            public IntPtr PushLayer;

            public IntPtr PopLayer;

            public IntPtr Flush;

            public IntPtr SaveDrawingState;

            public IntPtr RestoreDrawingState;

            public IntPtr PushAxisAlignedClip;

            public IntPtr PopAxisAlignedClip;

            public IntPtr Clear;

            public IntPtr BeginDraw;

            public IntPtr EndDraw;

            public IntPtr GetPixelFormat;

            public IntPtr SetDpi;

            public IntPtr GetDpi;

            public IntPtr GetSize;

            public IntPtr GetPixelSize;

            public IntPtr GetMaximumBitmapSize;

            public IntPtr IsSupported;

            public IntPtr CreateBitmap1;

            public IntPtr CreateBitmapFromWicBitmap1;

            public IntPtr CreateColorContext;

            public IntPtr CreateColorContextFromFilename;

            public IntPtr CreateColorContextFromWicColorContext;

            public IntPtr CreateBitmapFromDxgiSurface;

            public IntPtr CreateEffect;

            public IntPtr CreateGradientStopCollection1;

            public IntPtr CreateImageBrush;

            public IntPtr CreateBitmapBrush1;

            public IntPtr CreateCommandList;

            public IntPtr IsDxgiFormatSupported;

            public IntPtr IsBufferPrecisionSupported;

            public IntPtr GetImageLocalBounds;

            public IntPtr GetImageWorldBounds;

            public IntPtr GetGlyphRunWorldBounds;

            public IntPtr GetDevice;

            public IntPtr SetTarget;

            public IntPtr GetTarget;

            public IntPtr SetRenderingControls;

            public IntPtr GetRenderingControls;

            public IntPtr SetPrimitiveBlend;

            public IntPtr GetPrimitiveBlend;

            public IntPtr SetUnitMode;

            public IntPtr GetUnitMode;

            public IntPtr DrawGlyphRun1;

            public IntPtr DrawImage;

            public IntPtr DrawGdiMetafile;

            public IntPtr DrawBitmap1;

            public IntPtr PushLayer1;

            public IntPtr InvalidateEffectInputRectangle;

            public IntPtr GetEffectInvalidRectangleCount;

            public IntPtr GetEffectInvalidRectangles;

            public IntPtr GetEffectRequiredInputRectangles;

            public IntPtr FillOpacityMask1;

            public IntPtr CreateFilledGeometryRealization;

            public IntPtr CreateStrokedGeometryRealization;

            public IntPtr DrawGeometryRealization;

            public IntPtr CreateInk;

            public IntPtr CreateInkStyle;

            public IntPtr CreateGradientMesh;

            public IntPtr CreateImageSourceFromWic;

            public IntPtr CreateLookupTable3D;

            public IntPtr CreateImageSourceFromDxgi;

            public IntPtr GetGradientMeshWorldBounds;

            public IntPtr DrawInk;

            public IntPtr DrawGradientMesh;

            public IntPtr DrawGdiMetafile1;

            public IntPtr CreateTransformedImageSource;

            public IntPtr CreateSpriteBatch;

            public IntPtr DrawSpriteBatch;
        }
    }
}
