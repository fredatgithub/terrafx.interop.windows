// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MIB_IPFORWARDTABLE" /> struct.</summary>
public static unsafe partial class MIB_IPFORWARDTABLETests
{
    /// <summary>Validates that the <see cref="MIB_IPFORWARDTABLE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_IPFORWARDTABLE>(), Is.EqualTo(sizeof(MIB_IPFORWARDTABLE)));
    }

    /// <summary>Validates that the <see cref="MIB_IPFORWARDTABLE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_IPFORWARDTABLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MIB_IPFORWARDTABLE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_IPFORWARDTABLE), Is.EqualTo(60));
    }
}
