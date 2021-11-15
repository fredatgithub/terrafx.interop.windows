// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SOURCEFILEW
    {
        [NativeTypeName("DWORD64")]
        public ulong ModBase;

        [NativeTypeName("PWSTR")]
        public ushort* FileName;
    }
}
