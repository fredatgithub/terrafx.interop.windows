// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SP_INF_SIGNER_INFO64_V2_W" /> struct.</summary>
public static unsafe partial class SP_INF_SIGNER_INFO64_V2_WTests
{
    /// <summary>Validates that the <see cref="SP_INF_SIGNER_INFO64_V2_W" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SP_INF_SIGNER_INFO64_V2_W>(), Is.EqualTo(sizeof(SP_INF_SIGNER_INFO64_V2_W)));
    }

    /// <summary>Validates that the <see cref="SP_INF_SIGNER_INFO64_V2_W" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_INF_SIGNER_INFO64_V2_W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SP_INF_SIGNER_INFO64_V2_W" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SP_INF_SIGNER_INFO64_V2_W), Is.EqualTo(1568));
    }
}
