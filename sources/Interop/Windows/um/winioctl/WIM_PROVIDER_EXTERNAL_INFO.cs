// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WIM_PROVIDER_EXTERNAL_INFO
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public LARGE_INTEGER DataSourceId;

        [NativeTypeName("BYTE [20]")]
        public fixed byte ResourceHash[20];
    }
}
