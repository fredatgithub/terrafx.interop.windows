// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12MuxMuxRate.xml' path='doc/member[@name="CODECAPI_AVEncMP12MuxMuxRate"]/*' />
[Guid("EE047C72-4BDB-4A9D-8E21-41926C823DA7")]
public partial struct CODECAPI_AVEncMP12MuxMuxRate : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMP12MuxMuxRate;
}
