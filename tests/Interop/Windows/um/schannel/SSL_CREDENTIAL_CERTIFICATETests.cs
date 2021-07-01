// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SSL_CREDENTIAL_CERTIFICATE" /> struct.</summary>
    public static unsafe class SSL_CREDENTIAL_CERTIFICATETests
    {
        /// <summary>Validates that the <see cref="SSL_CREDENTIAL_CERTIFICATE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SSL_CREDENTIAL_CERTIFICATE>(), Is.EqualTo(sizeof(SSL_CREDENTIAL_CERTIFICATE)));
        }

        /// <summary>Validates that the <see cref="SSL_CREDENTIAL_CERTIFICATE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SSL_CREDENTIAL_CERTIFICATE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SSL_CREDENTIAL_CERTIFICATE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SSL_CREDENTIAL_CERTIFICATE), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(SSL_CREDENTIAL_CERTIFICATE), Is.EqualTo(20));
            }
        }
    }
}
