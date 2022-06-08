// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncEnableVideoProcessing.xml' path='doc/member[@name="CODECAPI_AVEncEnableVideoProcessing"]/*' />
[Guid("006F4BF6-0EA3-4D42-8702-B5D8BE0F7A92")]
public partial struct CODECAPI_AVEncEnableVideoProcessing : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncEnableVideoProcessing;
}
