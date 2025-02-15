// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="AUDIO_STREAM_CONFIG_CAPS" /> struct.</summary>
public static unsafe partial class AUDIO_STREAM_CONFIG_CAPSTests
{
    /// <summary>Validates that the <see cref="AUDIO_STREAM_CONFIG_CAPS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AUDIO_STREAM_CONFIG_CAPS>(), Is.EqualTo(sizeof(AUDIO_STREAM_CONFIG_CAPS)));
    }

    /// <summary>Validates that the <see cref="AUDIO_STREAM_CONFIG_CAPS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AUDIO_STREAM_CONFIG_CAPS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AUDIO_STREAM_CONFIG_CAPS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AUDIO_STREAM_CONFIG_CAPS), Is.EqualTo(52));
    }
}
