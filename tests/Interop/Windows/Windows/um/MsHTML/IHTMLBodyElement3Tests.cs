// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IHTMLBodyElement3" /> struct.</summary>
public static unsafe partial class IHTMLBodyElement3Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLBodyElement3" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLBodyElement3).GUID, Is.EqualTo(IID_IHTMLBodyElement3));
    }

    /// <summary>Validates that the <see cref="IHTMLBodyElement3" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLBodyElement3>(), Is.EqualTo(sizeof(IHTMLBodyElement3)));
    }

    /// <summary>Validates that the <see cref="IHTMLBodyElement3" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLBodyElement3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IHTMLBodyElement3" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLBodyElement3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLBodyElement3), Is.EqualTo(4));
        }
    }
}
