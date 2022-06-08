// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpNotifyTranslator.xml' path='doc/member[@name="SpNotifyTranslator"]/*' />
[Guid("E2AE5372-5D40-11D2-960E-00C04F8EE628")]
public partial struct SpNotifyTranslator : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpNotifyTranslator;
}
