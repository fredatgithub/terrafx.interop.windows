// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IHTMLStyleSheetRule" /> struct.</summary>
public static unsafe partial class IHTMLStyleSheetRuleTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLStyleSheetRule" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLStyleSheetRule).GUID, Is.EqualTo(IID_IHTMLStyleSheetRule));
    }

    /// <summary>Validates that the <see cref="IHTMLStyleSheetRule" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLStyleSheetRule>(), Is.EqualTo(sizeof(IHTMLStyleSheetRule)));
    }

    /// <summary>Validates that the <see cref="IHTMLStyleSheetRule" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLStyleSheetRule).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IHTMLStyleSheetRule" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLStyleSheetRule), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLStyleSheetRule), Is.EqualTo(4));
        }
    }
}
