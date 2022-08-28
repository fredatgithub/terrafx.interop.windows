// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES"]/*' />
[NativeTypeName("int")]
[SupportedOSPlatform("windows6.2")]
public enum CO_MARSHALING_CONTEXT_ATTRIBUTES : uint
{
    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_SOURCE_IS_APP_CONTAINER"]/*' />
    CO_MARSHALING_SOURCE_IS_APP_CONTAINER = 0,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1 = 0x80000000,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2 = 0x80000001,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_3"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_3 = 0x80000002,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_4"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_4 = 0x80000003,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_5"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_5 = 0x80000004,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_6"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_6 = 0x80000005,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_7"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_7 = 0x80000006,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_8"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_8 = 0x80000007,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_9"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_9 = 0x80000008,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_10"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_10 = 0x80000009,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_11"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_11 = 0x8000000a,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_12"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_12 = 0x8000000b,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_13"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_13 = 0x8000000c,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_14"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_14 = 0x8000000d,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_15"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_15 = 0x8000000e,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_16"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_16 = 0x8000000f,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_17"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_17 = 0x80000010,

    /// <include file='CO_MARSHALING_CONTEXT_ATTRIBUTES.xml' path='doc/member[@name="CO_MARSHALING_CONTEXT_ATTRIBUTES.CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_18"]/*' />
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_18 = 0x80000011,
}
