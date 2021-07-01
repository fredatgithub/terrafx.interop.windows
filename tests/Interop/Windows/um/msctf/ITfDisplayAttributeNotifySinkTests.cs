// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfDisplayAttributeNotifySink" /> struct.</summary>
    public static unsafe class ITfDisplayAttributeNotifySinkTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfDisplayAttributeNotifySink" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfDisplayAttributeNotifySink).GUID, Is.EqualTo(IID_ITfDisplayAttributeNotifySink));
        }

        /// <summary>Validates that the <see cref="ITfDisplayAttributeNotifySink" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfDisplayAttributeNotifySink>(), Is.EqualTo(sizeof(ITfDisplayAttributeNotifySink)));
        }

        /// <summary>Validates that the <see cref="ITfDisplayAttributeNotifySink" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfDisplayAttributeNotifySink).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfDisplayAttributeNotifySink" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfDisplayAttributeNotifySink), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfDisplayAttributeNotifySink), Is.EqualTo(4));
            }
        }
    }
}
