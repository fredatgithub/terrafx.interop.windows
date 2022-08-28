// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_SupportedSignatures.xml' path='doc/member[@name="SecPkgContext_SupportedSignatures"]/*' />
public unsafe partial struct SecPkgContext_SupportedSignatures
{
    /// <include file='SecPkgContext_SupportedSignatures.xml' path='doc/member[@name="SecPkgContext_SupportedSignatures.cSignatureAndHashAlgorithms"]/*' />
    [NativeTypeName("WORD")]
    public ushort cSignatureAndHashAlgorithms;

    /// <include file='SecPkgContext_SupportedSignatures.xml' path='doc/member[@name="SecPkgContext_SupportedSignatures.pSignatureAndHashAlgorithms"]/*' />
    [NativeTypeName("WORD *")]
    public ushort* pSignatureAndHashAlgorithms;
}
