// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DWriteEngine2Events" /> struct.</summary>
public static unsafe partial class DWriteEngine2EventsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DWriteEngine2Events" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DWriteEngine2Events).GUID, Is.EqualTo(IID_DWriteEngine2Events));
    }

    /// <summary>Validates that the <see cref="DWriteEngine2Events" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWriteEngine2Events>(), Is.EqualTo(sizeof(DWriteEngine2Events)));
    }

    /// <summary>Validates that the <see cref="DWriteEngine2Events" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWriteEngine2Events).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DWriteEngine2Events" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DWriteEngine2Events), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DWriteEngine2Events), Is.EqualTo(4));
        }
    }
}
