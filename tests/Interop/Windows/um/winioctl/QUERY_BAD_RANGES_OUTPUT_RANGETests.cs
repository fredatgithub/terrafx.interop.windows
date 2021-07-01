// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="QUERY_BAD_RANGES_OUTPUT_RANGE" /> struct.</summary>
    public static unsafe class QUERY_BAD_RANGES_OUTPUT_RANGETests
    {
        /// <summary>Validates that the <see cref="QUERY_BAD_RANGES_OUTPUT_RANGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<QUERY_BAD_RANGES_OUTPUT_RANGE>(), Is.EqualTo(sizeof(QUERY_BAD_RANGES_OUTPUT_RANGE)));
        }

        /// <summary>Validates that the <see cref="QUERY_BAD_RANGES_OUTPUT_RANGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(QUERY_BAD_RANGES_OUTPUT_RANGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="QUERY_BAD_RANGES_OUTPUT_RANGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(QUERY_BAD_RANGES_OUTPUT_RANGE), Is.EqualTo(24));
        }
    }
}
