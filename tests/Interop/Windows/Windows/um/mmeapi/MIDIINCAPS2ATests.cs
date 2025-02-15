// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MIDIINCAPS2A" /> struct.</summary>
public static unsafe partial class MIDIINCAPS2ATests
{
    /// <summary>Validates that the <see cref="MIDIINCAPS2A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIDIINCAPS2A>(), Is.EqualTo(sizeof(MIDIINCAPS2A)));
    }

    /// <summary>Validates that the <see cref="MIDIINCAPS2A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIDIINCAPS2A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MIDIINCAPS2A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIDIINCAPS2A), Is.EqualTo(92));
    }
}
