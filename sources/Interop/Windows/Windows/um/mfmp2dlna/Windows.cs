// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MPEG2DLNASink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xE7, 0x5F, 0xFA,
                    0x1D, 0x6A,
                    0x11, 0x4B,
                    0xB4,
                    0x1F,
                    0xF9,
                    0x59,
                    0xD6,
                    0xC7,
                    0x65,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MP2DLNA_USE_MMCSS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xE2, 0xF3, 0x54,
                    0xA2, 0xA2,
                    0x7D, 0x49,
                    0x98,
                    0x34,
                    0x97,
                    0x3A,
                    0xFD,
                    0xE5,
                    0x21,
                    0xEB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MP2DLNA_VIDEO_BIT_RATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0x48, 0x85, 0xE8,
                    0xB4, 0x73,
                    0xD7, 0x42,
                    0x9C,
                    0x75,
                    0xAD,
                    0xFA,
                    0x0A,
                    0x2A,
                    0x6E,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MP2DLNA_AUDIO_BIT_RATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0x07, 0x1C, 0x2D,
                    0x5F, 0x2B,
                    0xB3, 0x4A,
                    0xA7,
                    0xE6,
                    0x8D,
                    0x94,
                    0x3B,
                    0xA8,
                    0xD0,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MP2DLNA_ENCODE_QUALITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0x79, 0x23, 0xB5,
                    0x46, 0x1D,
                    0xB6, 0x4F,
                    0xA3,
                    0x17,
                    0xA4,
                    0xA5,
                    0xF6,
                    0x09,
                    0x59,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MP2DLNA_STATISTICS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x88, 0xE4, 0x75,
                    0xAD, 0xD5,
                    0x98, 0x48,
                    0x85,
                    0xE0,
                    0xBC,
                    0xCE,
                    0x24,
                    0xA7,
                    0x22,
                    0xD7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFDLNASinkInit
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0x27, 0x01, 0x0C,
                    0x61, 0x1B,
                    0x10, 0x4C,
                    0xBD,
                    0xA9,
                    0x04,
                    0x44,
                    0x5B,
                    0xE5,
                    0xF5,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
