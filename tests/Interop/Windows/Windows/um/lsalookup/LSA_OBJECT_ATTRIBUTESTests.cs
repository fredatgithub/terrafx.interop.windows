// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="LSA_OBJECT_ATTRIBUTES" /> struct.</summary>
public static unsafe partial class LSA_OBJECT_ATTRIBUTESTests
{
    /// <summary>Validates that the <see cref="LSA_OBJECT_ATTRIBUTES" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LSA_OBJECT_ATTRIBUTES>(), Is.EqualTo(sizeof(LSA_OBJECT_ATTRIBUTES)));
    }

    /// <summary>Validates that the <see cref="LSA_OBJECT_ATTRIBUTES" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LSA_OBJECT_ATTRIBUTES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="LSA_OBJECT_ATTRIBUTES" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LSA_OBJECT_ATTRIBUTES), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(LSA_OBJECT_ATTRIBUTES), Is.EqualTo(24));
        }
    }
}
