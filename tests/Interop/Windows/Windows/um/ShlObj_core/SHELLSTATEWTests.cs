// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SHELLSTATEW" /> struct.</summary>
public static unsafe partial class SHELLSTATEWTests
{
    /// <summary>Validates that the <see cref="SHELLSTATEW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHELLSTATEW>(), Is.EqualTo(sizeof(SHELLSTATEW)));
    }

    /// <summary>Validates that the <see cref="SHELLSTATEW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHELLSTATEW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SHELLSTATEW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SHELLSTATEW), Is.EqualTo(32));
    }
}
