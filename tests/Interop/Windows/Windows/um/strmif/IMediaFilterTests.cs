// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMediaFilter" /> struct.</summary>
public static unsafe partial class IMediaFilterTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMediaFilter" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaFilter).GUID, Is.EqualTo(IID_IMediaFilter));
    }

    /// <summary>Validates that the <see cref="IMediaFilter" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaFilter>(), Is.EqualTo(sizeof(IMediaFilter)));
    }

    /// <summary>Validates that the <see cref="IMediaFilter" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaFilter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMediaFilter" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaFilter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaFilter), Is.EqualTo(4));
        }
    }
}
