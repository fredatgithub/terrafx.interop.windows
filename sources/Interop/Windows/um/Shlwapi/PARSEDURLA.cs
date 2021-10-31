// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PARSEDURLA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszProtocol;

        public uint cchProtocol;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszSuffix;

        public uint cchSuffix;

        public uint nScheme;
    }
}
