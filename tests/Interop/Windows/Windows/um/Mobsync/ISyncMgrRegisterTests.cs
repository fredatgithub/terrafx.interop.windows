// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISyncMgrRegister" /> struct.</summary>
public static unsafe partial class ISyncMgrRegisterTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrRegister" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrRegister).GUID, Is.EqualTo(IID_ISyncMgrRegister));
    }

    /// <summary>Validates that the <see cref="ISyncMgrRegister" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrRegister>(), Is.EqualTo(sizeof(ISyncMgrRegister)));
    }

    /// <summary>Validates that the <see cref="ISyncMgrRegister" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrRegister).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISyncMgrRegister" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrRegister), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrRegister), Is.EqualTo(4));
        }
    }
}
