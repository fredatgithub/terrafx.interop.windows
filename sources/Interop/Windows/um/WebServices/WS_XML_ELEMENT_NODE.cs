// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_ELEMENT_NODE
    {
        public WS_XML_NODE node;

        public WS_XML_STRING* prefix;

        public WS_XML_STRING* localName;

        public WS_XML_STRING* ns;

        [NativeTypeName("ULONG")]
        public uint attributeCount;

        public WS_XML_ATTRIBUTE** attributes;

        [NativeTypeName("BOOL")]
        public int isEmpty;
    }
}
