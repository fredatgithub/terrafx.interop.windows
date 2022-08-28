// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.xml' path='doc/member[@name="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"]/*' />
public partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
{
    /// <include file='D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.xml' path='doc/member[@name="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.startPoint"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F startPoint;

    /// <include file='D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.xml' path='doc/member[@name="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.endPoint"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F endPoint;
}
