// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncWMVKeyFrameDistance.xml' path='doc/member[@name="CODECAPI_AVEncWMVKeyFrameDistance"]/*' />
[Guid("5569055E-E268-4771-B83E-9555EA28AED3")]
public unsafe partial struct CODECAPI_AVEncWMVKeyFrameDistance : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncWMVKeyFrameDistance));
}
