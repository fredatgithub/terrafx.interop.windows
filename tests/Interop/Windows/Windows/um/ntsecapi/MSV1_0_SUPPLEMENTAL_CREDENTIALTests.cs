// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MSV1_0_SUPPLEMENTAL_CREDENTIAL" /> struct.</summary>
public static unsafe partial class MSV1_0_SUPPLEMENTAL_CREDENTIALTests
{
    /// <summary>Validates that the <see cref="MSV1_0_SUPPLEMENTAL_CREDENTIAL" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MSV1_0_SUPPLEMENTAL_CREDENTIAL>(), Is.EqualTo(sizeof(MSV1_0_SUPPLEMENTAL_CREDENTIAL)));
    }

    /// <summary>Validates that the <see cref="MSV1_0_SUPPLEMENTAL_CREDENTIAL" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MSV1_0_SUPPLEMENTAL_CREDENTIAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MSV1_0_SUPPLEMENTAL_CREDENTIAL" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MSV1_0_SUPPLEMENTAL_CREDENTIAL), Is.EqualTo(40));
    }
}
