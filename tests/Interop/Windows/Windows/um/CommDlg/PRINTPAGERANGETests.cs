// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PRINTPAGERANGE" /> struct.</summary>
public static unsafe partial class PRINTPAGERANGETests
{
    /// <summary>Validates that the <see cref="PRINTPAGERANGE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PRINTPAGERANGE>(), Is.EqualTo(sizeof(PRINTPAGERANGE)));
    }

    /// <summary>Validates that the <see cref="PRINTPAGERANGE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PRINTPAGERANGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PRINTPAGERANGE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PRINTPAGERANGE), Is.EqualTo(8));
    }
}
