// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_RT_FORMAT_ARRAY
{
    public D3D12_RT_FORMAT_ARRAY([NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pFormats, uint NumFormats)
    {
        Unsafe.SkipInit(out this);

        NumRenderTargets = NumFormats;
        Buffer.MemoryCopy(pFormats, Unsafe.AsPointer(ref RTFormats), sizeof(_RTFormats_e__FixedBuffer), sizeof(_RTFormats_e__FixedBuffer));
    }
}
