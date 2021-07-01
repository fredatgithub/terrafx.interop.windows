// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDirectDraw4" /> struct.</summary>
    public static unsafe class IDirectDraw4Tests
    {
        /// <summary>Validates that the <see cref="IDirectDraw4" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDirectDraw4>(), Is.EqualTo(sizeof(IDirectDraw4)));
        }

        /// <summary>Validates that the <see cref="IDirectDraw4" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDirectDraw4).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDirectDraw4" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDirectDraw4), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDirectDraw4), Is.EqualTo(4));
            }
        }
    }
}
