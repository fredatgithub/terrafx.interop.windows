// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CMSGHDR
    {
        [NativeTypeName("SIZE_T")]
        public nuint cmsg_len;

        public int cmsg_level;

        public int cmsg_type;
    }
}
