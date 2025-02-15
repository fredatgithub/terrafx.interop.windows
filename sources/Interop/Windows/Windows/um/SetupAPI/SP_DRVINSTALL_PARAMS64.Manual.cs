// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct SP_DRVINSTALL_PARAMS64
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint Rank;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD_PTR")]
    public nuint PrivateData;

    [NativeTypeName("DWORD")]
    public uint Reserved;
}
