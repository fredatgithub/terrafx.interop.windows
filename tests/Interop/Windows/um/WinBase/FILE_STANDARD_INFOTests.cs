// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FILE_STANDARD_INFO" /> struct.</summary>
    public static unsafe class FILE_STANDARD_INFOTests
    {
        /// <summary>Validates that the <see cref="FILE_STANDARD_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FILE_STANDARD_INFO>(), Is.EqualTo(sizeof(FILE_STANDARD_INFO)));
        }

        /// <summary>Validates that the <see cref="FILE_STANDARD_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FILE_STANDARD_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FILE_STANDARD_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FILE_STANDARD_INFO), Is.EqualTo(24));
        }
    }
}
