// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_CALLBACK_DATA
    {
        [NativeTypeName("UINT32")]
        public uint Size;

        public PRJ_CALLBACK_DATA_FLAGS Flags;

        public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT NamespaceVirtualizationContext;

        [NativeTypeName("INT32")]
        public int CommandId;

        public Guid FileId;

        public Guid DataStreamId;

        [NativeTypeName("PCWSTR")]
        public ushort* FilePathName;

        public PRJ_PLACEHOLDER_VERSION_INFO* VersionInfo;

        [NativeTypeName("UINT32")]
        public uint TriggeringProcessId;

        [NativeTypeName("PCWSTR")]
        public ushort* TriggeringProcessImageFileName;

        public void* InstanceContext;
    }
}
