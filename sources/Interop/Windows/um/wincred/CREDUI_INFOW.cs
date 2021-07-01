// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CREDUI_INFOW
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("PCWSTR")]
        public ushort* pszMessageText;

        [NativeTypeName("PCWSTR")]
        public ushort* pszCaptionText;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmBanner;
    }
}
