// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TA_TRANSFORM_2D" /> struct.</summary>
    public static unsafe class TA_TRANSFORM_2DTests
    {
        /// <summary>Validates that the <see cref="TA_TRANSFORM_2D" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TA_TRANSFORM_2D>(), Is.EqualTo(sizeof(TA_TRANSFORM_2D)));
        }

        /// <summary>Validates that the <see cref="TA_TRANSFORM_2D" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TA_TRANSFORM_2D).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TA_TRANSFORM_2D" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TA_TRANSFORM_2D), Is.EqualTo(44));
        }
    }
}
