// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SyncMgrFolder" /> struct.</summary>
public static unsafe partial class SyncMgrFolderTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SyncMgrFolder" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SyncMgrFolder).GUID, Is.EqualTo(IID_SyncMgrFolder));
    }

    /// <summary>Validates that the <see cref="SyncMgrFolder" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SyncMgrFolder>(), Is.EqualTo(sizeof(SyncMgrFolder)));
    }

    /// <summary>Validates that the <see cref="SyncMgrFolder" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SyncMgrFolder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SyncMgrFolder" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SyncMgrFolder), Is.EqualTo(1));
    }
}
