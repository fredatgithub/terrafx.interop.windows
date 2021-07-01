// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CERT_SELECT_CHAIN_PARA" /> struct.</summary>
    public static unsafe class CERT_SELECT_CHAIN_PARATests
    {
        /// <summary>Validates that the <see cref="CERT_SELECT_CHAIN_PARA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CERT_SELECT_CHAIN_PARA>(), Is.EqualTo(sizeof(CERT_SELECT_CHAIN_PARA)));
        }

        /// <summary>Validates that the <see cref="CERT_SELECT_CHAIN_PARA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CERT_SELECT_CHAIN_PARA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CERT_SELECT_CHAIN_PARA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CERT_SELECT_CHAIN_PARA), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(CERT_SELECT_CHAIN_PARA), Is.EqualTo(20));
            }
        }
    }
}
