// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SOURCE_MEDIA64_A" /> struct.</summary>
public static unsafe partial class SOURCE_MEDIA64_ATests
{
    /// <summary>Validates that the <see cref="SOURCE_MEDIA64_A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOURCE_MEDIA64_A>(), Is.EqualTo(sizeof(SOURCE_MEDIA64_A)));
    }

    /// <summary>Validates that the <see cref="SOURCE_MEDIA64_A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOURCE_MEDIA64_A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SOURCE_MEDIA64_A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SOURCE_MEDIA64_A), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(SOURCE_MEDIA64_A), Is.EqualTo(24));
        }
    }
}
