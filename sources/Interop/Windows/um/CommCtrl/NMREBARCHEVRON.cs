// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NMREBARCHEVRON
    {
        public NMHDR hdr;

        public uint uBand;

        public uint wID;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public RECT rc;

        [NativeTypeName("LPARAM")]
        public nint lParamNM;
    }
}
