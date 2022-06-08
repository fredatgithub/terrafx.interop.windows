// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ShellDispatchInproc.xml' path='doc/member[@name="ShellDispatchInproc"]/*' />
[Guid("0A89A860-D7B1-11CE-8350-444553540000")]
public partial struct ShellDispatchInproc : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ShellDispatchInproc;
}
