// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVPriorityControl.xml' path='doc/member[@name="CODECAPI_AVPriorityControl"]/*' />
[Guid("54BA3DC8-BDDE-4329-B187-2018BC5C2BA1")]
public partial struct CODECAPI_AVPriorityControl : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVPriorityControl;
}
