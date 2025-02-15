// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SVGAnimatedEnumeration" /> struct.</summary>
public static unsafe partial class SVGAnimatedEnumerationTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SVGAnimatedEnumeration" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGAnimatedEnumeration).GUID, Is.EqualTo(IID_SVGAnimatedEnumeration));
    }

    /// <summary>Validates that the <see cref="SVGAnimatedEnumeration" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGAnimatedEnumeration>(), Is.EqualTo(sizeof(SVGAnimatedEnumeration)));
    }

    /// <summary>Validates that the <see cref="SVGAnimatedEnumeration" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGAnimatedEnumeration).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SVGAnimatedEnumeration" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGAnimatedEnumeration), Is.EqualTo(1));
    }
}
