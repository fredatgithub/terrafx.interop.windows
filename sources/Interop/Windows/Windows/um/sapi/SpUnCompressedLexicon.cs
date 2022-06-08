// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpUnCompressedLexicon.xml' path='doc/member[@name="SpUnCompressedLexicon"]/*' />
[Guid("C9E37C15-DF92-4727-85D6-72E5EEB6995A")]
public partial struct SpUnCompressedLexicon : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpUnCompressedLexicon;
}
