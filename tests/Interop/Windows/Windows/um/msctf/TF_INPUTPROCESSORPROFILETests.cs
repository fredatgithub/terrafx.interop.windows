// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TF_INPUTPROCESSORPROFILE" /> struct.</summary>
public static unsafe partial class TF_INPUTPROCESSORPROFILETests
{
    /// <summary>Validates that the <see cref="TF_INPUTPROCESSORPROFILE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TF_INPUTPROCESSORPROFILE>(), Is.EqualTo(sizeof(TF_INPUTPROCESSORPROFILE)));
    }

    /// <summary>Validates that the <see cref="TF_INPUTPROCESSORPROFILE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TF_INPUTPROCESSORPROFILE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TF_INPUTPROCESSORPROFILE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TF_INPUTPROCESSORPROFILE), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(TF_INPUTPROCESSORPROFILE), Is.EqualTo(72));
        }
    }
}
