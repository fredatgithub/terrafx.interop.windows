// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='IsolatedAppLauncher.xml' path='doc/member[@name="IsolatedAppLauncher"]/*' />
[Guid("BC812430-E75E-4FD1-9641-1F9F1E2D9A1F")]
public partial struct IsolatedAppLauncher : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_IsolatedAppLauncher;
}
