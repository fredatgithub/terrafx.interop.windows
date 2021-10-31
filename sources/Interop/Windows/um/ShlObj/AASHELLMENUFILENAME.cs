// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct AASHELLMENUFILENAME
    {
        public short cbTotal;

        [NativeTypeName("BYTE [12]")]
        public fixed byte rgbReserved[12];

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort szFileName[1];
    }
}
