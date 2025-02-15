// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="OFNOTIFYA" /> struct.</summary>
public static unsafe partial class OFNOTIFYATests
{
    /// <summary>Validates that the <see cref="OFNOTIFYA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OFNOTIFYA>(), Is.EqualTo(sizeof(OFNOTIFYA)));
    }

    /// <summary>Validates that the <see cref="OFNOTIFYA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OFNOTIFYA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="OFNOTIFYA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OFNOTIFYA), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(OFNOTIFYA), Is.EqualTo(20));
        }
    }
}
