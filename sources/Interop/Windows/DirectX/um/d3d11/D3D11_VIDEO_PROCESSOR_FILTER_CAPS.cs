// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS"]/*' />
[Flags]
public enum D3D11_VIDEO_PROCESSOR_FILTER_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS = 0x1,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST = 0x2,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE = 0x4,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION = 0x8,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION = 0x10,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT = 0x20,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING = 0x40,

    /// <include file='D3D11_VIDEO_PROCESSOR_FILTER_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_FILTER_CAPS.D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT"]/*' />
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT = 0x80,
}
