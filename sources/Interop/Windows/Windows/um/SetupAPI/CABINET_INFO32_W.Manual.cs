// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct CABINET_INFO32_W
{
    [NativeTypeName("PCWSTR")]
    public ushort* CabinetPath;

    [NativeTypeName("PCWSTR")]
    public ushort* CabinetFile;

    [NativeTypeName("PCWSTR")]
    public ushort* DiskName;

    [NativeTypeName("USHORT")]
    public ushort SetId;

    [NativeTypeName("USHORT")]
    public ushort CabinetNumber;
}
