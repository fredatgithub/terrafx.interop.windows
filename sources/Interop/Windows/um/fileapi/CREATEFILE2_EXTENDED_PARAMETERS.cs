// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CREATEFILE2_EXTENDED_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        [NativeTypeName("DWORD")]
        public uint dwFileFlags;

        [NativeTypeName("DWORD")]
        public uint dwSecurityQosFlags;

        [NativeTypeName("LPSECURITY_ATTRIBUTES")]
        public SECURITY_ATTRIBUTES* lpSecurityAttributes;

        [NativeTypeName("HANDLE")]
        public IntPtr hTemplateFile;
    }
}
