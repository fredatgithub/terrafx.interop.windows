// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="SYMBOL_INFO_PACKAGE" /> struct.</summary>
    public static unsafe partial class SYMBOL_INFO_PACKAGETests
    {
        /// <summary>Validates that the <see cref="SYMBOL_INFO_PACKAGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SYMBOL_INFO_PACKAGE>(), Is.EqualTo(sizeof(SYMBOL_INFO_PACKAGE)));
        }

        /// <summary>Validates that the <see cref="SYMBOL_INFO_PACKAGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SYMBOL_INFO_PACKAGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SYMBOL_INFO_PACKAGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SYMBOL_INFO_PACKAGE), Is.EqualTo(2096));
        }
    }
}
