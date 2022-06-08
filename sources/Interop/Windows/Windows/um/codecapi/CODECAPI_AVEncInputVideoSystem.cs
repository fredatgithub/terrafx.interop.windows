// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncInputVideoSystem.xml' path='doc/member[@name="CODECAPI_AVEncInputVideoSystem"]/*' />
[Guid("BEDE146D-B616-4DC7-92B2-F5D9FA9298F7")]
public partial struct CODECAPI_AVEncInputVideoSystem : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncInputVideoSystem;
}
