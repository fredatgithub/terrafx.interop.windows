// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CERT_USAGE_MATCH" /> struct.</summary>
    public static unsafe class CERT_USAGE_MATCHTests
    {
        /// <summary>Validates that the <see cref="CERT_USAGE_MATCH" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CERT_USAGE_MATCH>(), Is.EqualTo(sizeof(CERT_USAGE_MATCH)));
        }

        /// <summary>Validates that the <see cref="CERT_USAGE_MATCH" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CERT_USAGE_MATCH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CERT_USAGE_MATCH" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CERT_USAGE_MATCH), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(CERT_USAGE_MATCH), Is.EqualTo(12));
            }
        }
    }
}
