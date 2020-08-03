// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIOutput1" /> struct.</summary>
    public static unsafe class IDXGIOutput1Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIOutput1" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGIOutput1).GUID, Is.EqualTo(IID_IDXGIOutput1));
        }

        /// <summary>Validates that the <see cref="IDXGIOutput1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDXGIOutput1>(), Is.EqualTo(sizeof(IDXGIOutput1)));
        }

        /// <summary>Validates that the <see cref="IDXGIOutput1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIOutput1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDXGIOutput1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDXGIOutput1), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDXGIOutput1), Is.EqualTo(4));
            }
        }
    }
}
