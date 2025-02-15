// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WINHTTP_WEB_SOCKET_STATUS" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WINHTTP_WEB_SOCKET_STATUSTests
{
    /// <summary>Validates that the <see cref="WINHTTP_WEB_SOCKET_STATUS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_WEB_SOCKET_STATUS>(), Is.EqualTo(sizeof(WINHTTP_WEB_SOCKET_STATUS)));
    }

    /// <summary>Validates that the <see cref="WINHTTP_WEB_SOCKET_STATUS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_WEB_SOCKET_STATUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WINHTTP_WEB_SOCKET_STATUS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_WEB_SOCKET_STATUS), Is.EqualTo(8));
    }
}
