// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IAppxManifestQualifiedResourcesEnumerator" /> struct.</summary>
public static unsafe partial class IAppxManifestQualifiedResourcesEnumeratorTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxManifestQualifiedResourcesEnumerator" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxManifestQualifiedResourcesEnumerator).GUID, Is.EqualTo(IID_IAppxManifestQualifiedResourcesEnumerator));
    }

    /// <summary>Validates that the <see cref="IAppxManifestQualifiedResourcesEnumerator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxManifestQualifiedResourcesEnumerator>(), Is.EqualTo(sizeof(IAppxManifestQualifiedResourcesEnumerator)));
    }

    /// <summary>Validates that the <see cref="IAppxManifestQualifiedResourcesEnumerator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxManifestQualifiedResourcesEnumerator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IAppxManifestQualifiedResourcesEnumerator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxManifestQualifiedResourcesEnumerator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxManifestQualifiedResourcesEnumerator), Is.EqualTo(4));
        }
    }
}
