// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CMC_TAGGED_OTHER_MSG" /> struct.</summary>
public static unsafe partial class CMC_TAGGED_OTHER_MSGTests
{
    /// <summary>Validates that the <see cref="CMC_TAGGED_OTHER_MSG" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CMC_TAGGED_OTHER_MSG>(), Is.EqualTo(sizeof(CMC_TAGGED_OTHER_MSG)));
    }

    /// <summary>Validates that the <see cref="CMC_TAGGED_OTHER_MSG" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CMC_TAGGED_OTHER_MSG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CMC_TAGGED_OTHER_MSG" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CMC_TAGGED_OTHER_MSG), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CMC_TAGGED_OTHER_MSG), Is.EqualTo(16));
        }
    }
}
