// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMediaSource" /> struct.</summary>
public static unsafe partial class IMFMediaSourceTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaSource" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaSource).GUID, Is.EqualTo(IID_IMFMediaSource));
    }

    /// <summary>Validates that the <see cref="IMFMediaSource" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaSource>(), Is.EqualTo(sizeof(IMFMediaSource)));
    }

    /// <summary>Validates that the <see cref="IMFMediaSource" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaSource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMediaSource" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaSource), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaSource), Is.EqualTo(4));
        }
    }
}
