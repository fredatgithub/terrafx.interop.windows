// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TRANSACTION_LIST_ENTRY" /> struct.</summary>
public static unsafe partial class TRANSACTION_LIST_ENTRYTests
{
    /// <summary>Validates that the <see cref="TRANSACTION_LIST_ENTRY" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRANSACTION_LIST_ENTRY>(), Is.EqualTo(sizeof(TRANSACTION_LIST_ENTRY)));
    }

    /// <summary>Validates that the <see cref="TRANSACTION_LIST_ENTRY" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRANSACTION_LIST_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TRANSACTION_LIST_ENTRY" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TRANSACTION_LIST_ENTRY), Is.EqualTo(16));
    }
}
