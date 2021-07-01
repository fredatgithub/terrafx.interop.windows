// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct KEY_TYPE_SUBTYPE
    {
        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("GUID")]
        public Guid Type;

        [NativeTypeName("GUID")]
        public Guid Subtype;
    }
}
