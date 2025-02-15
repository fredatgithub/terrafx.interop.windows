// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PlayToManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IPlayToManagerInterop" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IPlayToManagerInteropTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPlayToManagerInterop" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPlayToManagerInterop).GUID, Is.EqualTo(IID_IPlayToManagerInterop));
    }

    /// <summary>Validates that the <see cref="IPlayToManagerInterop" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPlayToManagerInterop>(), Is.EqualTo(sizeof(IPlayToManagerInterop)));
    }

    /// <summary>Validates that the <see cref="IPlayToManagerInterop" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPlayToManagerInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IPlayToManagerInterop" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPlayToManagerInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPlayToManagerInterop), Is.EqualTo(4));
        }
    }
}
