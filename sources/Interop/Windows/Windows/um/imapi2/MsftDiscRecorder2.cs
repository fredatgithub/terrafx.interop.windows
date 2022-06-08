// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='MsftDiscRecorder2.xml' path='doc/member[@name="MsftDiscRecorder2"]/*' />
[Guid("2735412D-7F64-5B0F-8F00-5D77AFBE261E")]
public partial struct MsftDiscRecorder2 : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_MsftDiscRecorder2;
}
