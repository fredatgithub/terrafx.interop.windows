// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncMPEG1Audio.xml' path='doc/member[@name="CODECAPI_GUID_AVEncMPEG1Audio"]/*' />
[Guid("D4DD1362-CD4A-4CD6-8138-B94DB4542B04")]
public partial struct CODECAPI_GUID_AVEncMPEG1Audio : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_GUID_AVEncMPEG1Audio;
}
