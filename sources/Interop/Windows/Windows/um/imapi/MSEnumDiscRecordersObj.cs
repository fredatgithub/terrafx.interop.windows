// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='MSEnumDiscRecordersObj.xml' path='doc/member[@name="MSEnumDiscRecordersObj"]/*' />
[Guid("8A03567A-63CB-4BA8-BAF6-52119816D1EF")]
public partial struct MSEnumDiscRecordersObj : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_MSEnumDiscRecordersObj;
}
