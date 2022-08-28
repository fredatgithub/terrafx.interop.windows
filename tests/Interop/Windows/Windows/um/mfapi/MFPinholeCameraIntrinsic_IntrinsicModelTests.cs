// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MFPinholeCameraIntrinsic_IntrinsicModel" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MFPinholeCameraIntrinsic_IntrinsicModelTests
{
    /// <summary>Validates that the <see cref="MFPinholeCameraIntrinsic_IntrinsicModel" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFPinholeCameraIntrinsic_IntrinsicModel>(), Is.EqualTo(sizeof(MFPinholeCameraIntrinsic_IntrinsicModel)));
    }

    /// <summary>Validates that the <see cref="MFPinholeCameraIntrinsic_IntrinsicModel" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFPinholeCameraIntrinsic_IntrinsicModel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MFPinholeCameraIntrinsic_IntrinsicModel" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFPinholeCameraIntrinsic_IntrinsicModel), Is.EqualTo(44));
    }
}
