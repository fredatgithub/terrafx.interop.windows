// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct HELPINFO
    {
        public uint cbSize;

        public int iContextType;

        public int iCtrlId;

        public HANDLE hItemHandle;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwContextId;

        public POINT MousePos;
    }
}
