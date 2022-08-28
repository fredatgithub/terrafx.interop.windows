// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SpTextSelectionInformation" /> struct.</summary>
public static unsafe partial class SpTextSelectionInformationTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SpTextSelectionInformation" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SpTextSelectionInformation).GUID, Is.EqualTo(IID_SpTextSelectionInformation));
    }

    /// <summary>Validates that the <see cref="SpTextSelectionInformation" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpTextSelectionInformation>(), Is.EqualTo(sizeof(SpTextSelectionInformation)));
    }

    /// <summary>Validates that the <see cref="SpTextSelectionInformation" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpTextSelectionInformation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SpTextSelectionInformation" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpTextSelectionInformation), Is.EqualTo(1));
    }
}
