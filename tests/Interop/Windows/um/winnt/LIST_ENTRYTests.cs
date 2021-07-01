// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="LIST_ENTRY" /> struct.</summary>
    public static unsafe class LIST_ENTRYTests
    {
        /// <summary>Validates that the <see cref="LIST_ENTRY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<LIST_ENTRY>(), Is.EqualTo(sizeof(LIST_ENTRY)));
        }

        /// <summary>Validates that the <see cref="LIST_ENTRY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(LIST_ENTRY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="LIST_ENTRY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(LIST_ENTRY), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(LIST_ENTRY), Is.EqualTo(8));
            }
        }
    }
}
