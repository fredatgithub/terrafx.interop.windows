// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct NMTOOLBAR32W
{
    public NMHDR hdr;

    public int iItem;

    public TBBUTTON32 tbButton;

    public int cchText;

    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    public RECT rcButton;
}
