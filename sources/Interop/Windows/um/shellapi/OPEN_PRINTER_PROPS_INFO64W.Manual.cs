// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct OPEN_PRINTER_PROPS_INFO64W
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("LPWSTR")]
        public ushort* pszSheetName;

        public uint uSheetIndex;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public BOOL bModal;
    }
}
