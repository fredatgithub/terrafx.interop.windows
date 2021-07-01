// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DISK_GEOMETRY_EX
    {
        public DISK_GEOMETRY Geometry;

        public LARGE_INTEGER DiskSize;

        [NativeTypeName("BYTE [1]")]
        public fixed byte Data[1];
    }
}
