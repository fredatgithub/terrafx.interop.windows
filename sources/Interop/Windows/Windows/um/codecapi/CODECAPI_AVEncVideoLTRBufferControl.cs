// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoLTRBufferControl.xml' path='doc/member[@name="CODECAPI_AVEncVideoLTRBufferControl"]/*' />
[Guid("A4A0E93D-4CBC-444C-89F4-826D310E92A7")]
public partial struct CODECAPI_AVEncVideoLTRBufferControl : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoLTRBufferControl;
}
