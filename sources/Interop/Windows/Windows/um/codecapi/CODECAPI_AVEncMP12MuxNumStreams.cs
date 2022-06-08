// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12MuxNumStreams.xml' path='doc/member[@name="CODECAPI_AVEncMP12MuxNumStreams"]/*' />
[Guid("F7164A41-DCED-4659-A8F2-FB693F2A4CD0")]
public partial struct CODECAPI_AVEncMP12MuxNumStreams : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMP12MuxNumStreams;
}
