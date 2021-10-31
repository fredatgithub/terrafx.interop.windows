// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MENUITEMINFOW
    {
        public uint cbSize;

        public uint fMask;

        public uint fType;

        public uint fState;

        public uint wID;

        public HMENU hSubMenu;

        public HBITMAP hbmpChecked;

        public HBITMAP hbmpUnchecked;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwItemData;

        [NativeTypeName("LPWSTR")]
        public ushort* dwTypeData;

        public uint cch;

        public HBITMAP hbmpItem;
    }
}
