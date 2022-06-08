// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='PINLogonCredentialProvider.xml' path='doc/member[@name="PINLogonCredentialProvider"]/*' />
[Guid("CB82EA12-9F71-446D-89E1-8D0924E1256E")]
public partial struct PINLogonCredentialProvider : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_PINLogonCredentialProvider;
}
