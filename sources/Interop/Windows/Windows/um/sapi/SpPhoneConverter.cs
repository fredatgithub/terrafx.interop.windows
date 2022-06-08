// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpPhoneConverter.xml' path='doc/member[@name="SpPhoneConverter"]/*' />
[Guid("9185F743-1143-4C28-86B5-BFF14F20E5C8")]
public partial struct SpPhoneConverter : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpPhoneConverter;
}
