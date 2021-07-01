// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS
    {
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_NONE = 0,
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_Y = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y),
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_U = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U),
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_V = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V),
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_R = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R),
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_G = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G),
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_B = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B),
        D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_A = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A),
    }
}
