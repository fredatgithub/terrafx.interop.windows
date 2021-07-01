// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct ANON_OBJECT_HEADER_BIGOBJ
    {
        [NativeTypeName("WORD")]
        public ushort Sig1;

        [NativeTypeName("WORD")]
        public ushort Sig2;

        [NativeTypeName("WORD")]
        public ushort Version;

        [NativeTypeName("WORD")]
        public ushort Machine;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("CLSID")]
        public Guid ClassID;

        [NativeTypeName("DWORD")]
        public uint SizeOfData;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint MetaDataSize;

        [NativeTypeName("DWORD")]
        public uint MetaDataOffset;

        [NativeTypeName("DWORD")]
        public uint NumberOfSections;

        [NativeTypeName("DWORD")]
        public uint PointerToSymbolTable;

        [NativeTypeName("DWORD")]
        public uint NumberOfSymbols;
    }
}
