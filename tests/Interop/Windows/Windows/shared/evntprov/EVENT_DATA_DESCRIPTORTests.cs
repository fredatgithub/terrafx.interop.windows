// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="EVENT_DATA_DESCRIPTOR" /> struct.</summary>
public static unsafe partial class EVENT_DATA_DESCRIPTORTests
{
    /// <summary>Validates that the <see cref="EVENT_DATA_DESCRIPTOR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EVENT_DATA_DESCRIPTOR>(), Is.EqualTo(sizeof(EVENT_DATA_DESCRIPTOR)));
    }

    /// <summary>Validates that the <see cref="EVENT_DATA_DESCRIPTOR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EVENT_DATA_DESCRIPTOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="EVENT_DATA_DESCRIPTOR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EVENT_DATA_DESCRIPTOR), Is.EqualTo(16));
    }
}
