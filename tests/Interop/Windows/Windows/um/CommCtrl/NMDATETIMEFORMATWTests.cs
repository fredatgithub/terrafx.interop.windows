// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="NMDATETIMEFORMATW" /> struct.</summary>
public static unsafe partial class NMDATETIMEFORMATWTests
{
    /// <summary>Validates that the <see cref="NMDATETIMEFORMATW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMDATETIMEFORMATW>(), Is.EqualTo(sizeof(NMDATETIMEFORMATW)));
    }

    /// <summary>Validates that the <see cref="NMDATETIMEFORMATW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMDATETIMEFORMATW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="NMDATETIMEFORMATW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMDATETIMEFORMATW), Is.EqualTo(184));
        }
        else
        {
            Assert.That(sizeof(NMDATETIMEFORMATW), Is.EqualTo(164));
        }
    }
}
