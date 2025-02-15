// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_POOL_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_POOL_FLAGS"]/*' />
[Flags]
public enum D3D12_COMMAND_POOL_FLAGS
{
    /// <include file='D3D12_COMMAND_POOL_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_POOL_FLAGS.D3D12_COMMAND_POOL_FLAG_NONE"]/*' />
    D3D12_COMMAND_POOL_FLAG_NONE = 0,
}
