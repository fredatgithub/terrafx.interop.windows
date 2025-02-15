// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="APPLICATIONLAUNCH_SETTING_VALUE" /> struct.</summary>
public static unsafe partial class APPLICATIONLAUNCH_SETTING_VALUETests
{
    /// <summary>Validates that the <see cref="APPLICATIONLAUNCH_SETTING_VALUE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<APPLICATIONLAUNCH_SETTING_VALUE>(), Is.EqualTo(sizeof(APPLICATIONLAUNCH_SETTING_VALUE)));
    }

    /// <summary>Validates that the <see cref="APPLICATIONLAUNCH_SETTING_VALUE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(APPLICATIONLAUNCH_SETTING_VALUE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="APPLICATIONLAUNCH_SETTING_VALUE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(APPLICATIONLAUNCH_SETTING_VALUE), Is.EqualTo(16));
    }
}
