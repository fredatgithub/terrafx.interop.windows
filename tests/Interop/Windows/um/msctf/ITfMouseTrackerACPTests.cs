// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfMouseTrackerACP" /> struct.</summary>
    public static unsafe class ITfMouseTrackerACPTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfMouseTrackerACP" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfMouseTrackerACP).GUID, Is.EqualTo(IID_ITfMouseTrackerACP));
        }

        /// <summary>Validates that the <see cref="ITfMouseTrackerACP" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfMouseTrackerACP>(), Is.EqualTo(sizeof(ITfMouseTrackerACP)));
        }

        /// <summary>Validates that the <see cref="ITfMouseTrackerACP" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfMouseTrackerACP).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfMouseTrackerACP" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfMouseTrackerACP), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfMouseTrackerACP), Is.EqualTo(4));
            }
        }
    }
}
