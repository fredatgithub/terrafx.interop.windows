// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IConnectableCredentialProviderCredential" /> struct.</summary>
public static unsafe partial class IConnectableCredentialProviderCredentialTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IConnectableCredentialProviderCredential" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IConnectableCredentialProviderCredential).GUID, Is.EqualTo(IID_IConnectableCredentialProviderCredential));
    }

    /// <summary>Validates that the <see cref="IConnectableCredentialProviderCredential" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IConnectableCredentialProviderCredential>(), Is.EqualTo(sizeof(IConnectableCredentialProviderCredential)));
    }

    /// <summary>Validates that the <see cref="IConnectableCredentialProviderCredential" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IConnectableCredentialProviderCredential).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IConnectableCredentialProviderCredential" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IConnectableCredentialProviderCredential), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IConnectableCredentialProviderCredential), Is.EqualTo(4));
        }
    }
}
