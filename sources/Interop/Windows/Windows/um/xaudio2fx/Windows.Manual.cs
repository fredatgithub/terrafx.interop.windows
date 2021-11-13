// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0xF0, 0xD8, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x80, 0x3F,
                    0x00, 0x00, 0x00, 0x3F,
                    0xF0, 0xD8, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0xF0, 0xD8, 0xFF, 0xFF,
                    0x0A, 0xD7, 0x23, 0x3D,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_GENERIC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x9C, 0xFF, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0xE1, 0x7A, 0x54, 0x3F,
                    0xD6, 0xF5, 0xFF, 0xFF,
                    0x42, 0x60, 0xE5, 0x3B,
                    0xC8, 0x00, 0x00, 0x00,
                    0x58, 0x39, 0x34, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PADDEDCELL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x90, 0xE8, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x7B, 0x14, 0x2E, 0x3E,
                    0xCD, 0xCC, 0xCC, 0x3D,
                    0x4C, 0xFB, 0xFF, 0xFF,
                    0x6F, 0x12, 0x83, 0x3A,
                    0xCF, 0x00, 0x00, 0x00,
                    0x6F, 0x12, 0x03, 0x3B,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_ROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x3A, 0xFE, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0xCD, 0xCC, 0xCC, 0x3E,
                    0xE1, 0x7A, 0x54, 0x3F,
                    0x92, 0xF9, 0xFF, 0xFF,
                    0x6F, 0x12, 0x03, 0x3B,
                    0x35, 0x00, 0x00, 0x00,
                    0xA6, 0x9B, 0x44, 0x3B,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_BATHROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x50, 0xFB, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0x71, 0x3D, 0x0A, 0x3F,
                    0x8E, 0xFE, 0xFF, 0xFF,
                    0x42, 0x60, 0xE5, 0x3B,
                    0x06, 0x04, 0x00, 0x00,
                    0x58, 0x39, 0x34, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0x70, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_LIVINGROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x90, 0xE8, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x3F,
                    0xCD, 0xCC, 0xCC, 0x3D,
                    0xA0, 0xFA, 0xFF, 0xFF,
                    0xA6, 0x9B, 0x44, 0x3B,
                    0xB0, 0xFB, 0xFF, 0xFF,
                    0x6F, 0x12, 0x83, 0x3B,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_STONEROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xD4, 0xFE, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x0A, 0xD7, 0x13, 0x40,
                    0x0A, 0xD7, 0x23, 0x3F,
                    0x39, 0xFD, 0xFF, 0xFF,
                    0xA6, 0x9B, 0x44, 0x3C,
                    0x53, 0x00, 0x00, 0x00,
                    0x96, 0x43, 0x8B, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_AUDITORIUM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x24, 0xFE, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x71, 0x3D, 0x8A, 0x40,
                    0x3D, 0x0A, 0x17, 0x3F,
                    0xEB, 0xFC, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0xDF, 0xFE, 0xFF, 0xFF,
                    0x8F, 0xC2, 0xF5, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CONCERTHALL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x0C, 0xFE, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x48, 0xE1, 0x7A, 0x40,
                    0x33, 0x33, 0x33, 0x3F,
                    0x32, 0xFB, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0xFE, 0xFF, 0xFF, 0xFF,
                    0x68, 0x91, 0xED, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CAVE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x71, 0x3D, 0x3A, 0x40,
                    0x66, 0x66, 0xA6, 0x3F,
                    0xA6, 0xFD, 0xFF, 0xFF,
                    0x8F, 0xC2, 0x75, 0x3C,
                    0xD2, 0xFE, 0xFF, 0xFF,
                    0x58, 0x39, 0xB4, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_ARENA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x46, 0xFD, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x14, 0xAE, 0xE7, 0x40,
                    0xC3, 0xF5, 0xA8, 0x3E,
                    0x72, 0xFB, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0x10, 0x00, 0x00, 0x00,
                    0x8F, 0xC2, 0xF5, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_HANGAR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0xCD, 0xCC, 0x20, 0x41,
                    0x1F, 0x85, 0x6B, 0x3E,
                    0xA6, 0xFD, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0xC6, 0x00, 0x00, 0x00,
                    0x8F, 0xC2, 0xF5, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CARPETEDHALLWAY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x60, 0xF0, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x9A, 0x99, 0x99, 0x3E,
                    0xCD, 0xCC, 0xCC, 0x3D,
                    0xD9, 0xF8, 0xFF, 0xFF,
                    0x6F, 0x12, 0x03, 0x3B,
                    0xA2, 0xF9, 0xFF, 0xFF,
                    0x8F, 0xC2, 0xF5, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_HALLWAY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xD4, 0xFE, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0x3D, 0x0A, 0x17, 0x3F,
                    0x3D, 0xFB, 0xFF, 0xFF,
                    0x42, 0x60, 0xE5, 0x3B,
                    0xB9, 0x01, 0x00, 0x00,
                    0x58, 0x39, 0x34, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_STONECORRIDOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x13, 0xFF, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0xCD, 0xCC, 0x2C, 0x40,
                    0x71, 0x3D, 0x4A, 0x3F,
                    0x42, 0xFB, 0xFF, 0xFF,
                    0xF4, 0xFD, 0x54, 0x3C,
                    0x8B, 0x01, 0x00, 0x00,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_ALLEY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xF2, 0xFE, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0xF6, 0x28, 0x5C, 0x3F,
                    0x4C, 0xFB, 0xFF, 0xFF,
                    0x42, 0x60, 0xE5, 0x3B,
                    0xFC, 0xFF, 0xFF, 0xFF,
                    0x58, 0x39, 0x34, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_FOREST
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x1C, 0xF3, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0x71, 0x3D, 0x0A, 0x3F,
                    0x00, 0xF6, 0xFF, 0xFF,
                    0x54, 0xE3, 0x25, 0x3E,
                    0x9B, 0xFD, 0xFF, 0xFF,
                    0x58, 0x39, 0xB4, 0x3D,
                    0x00, 0x00, 0x9E, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xE0, 0xFC, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0x1F, 0x85, 0x2B, 0x3F,
                    0x1F, 0xF7, 0xFF, 0xFF,
                    0x42, 0x60, 0xE5, 0x3B,
                    0x57, 0xF7, 0xFF, 0xFF,
                    0x58, 0x39, 0x34, 0x3C,
                    0x00, 0x00, 0x48, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_MOUNTAINS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x3C, 0xF6, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0x3D, 0x0A, 0x57, 0x3E,
                    0x24, 0xF5, 0xFF, 0xFF,
                    0x9A, 0x99, 0x99, 0x3E,
                    0x22, 0xF8, 0xFF, 0xFF,
                    0xCD, 0xCC, 0xCC, 0x3D,
                    0x00, 0x00, 0xD8, 0x41,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_QUARRY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0xE1, 0x7A, 0x54, 0x3F,
                    0xF0, 0xD8, 0xFF, 0xFF,
                    0x23, 0xDB, 0x79, 0x3D,
                    0xF4, 0x01, 0x00, 0x00,
                    0xCD, 0xCC, 0xCC, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PLAIN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x30, 0xF8, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0x00, 0x00, 0x00, 0x3F,
                    0x5E, 0xF6, 0xFF, 0xFF,
                    0xC7, 0x4B, 0x37, 0x3E,
                    0x2E, 0xF6, 0xFF, 0xFF,
                    0xCD, 0xCC, 0xCC, 0x3D,
                    0x00, 0x00, 0xA8, 0x41,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PARKINGLOT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x33, 0x33, 0xD3, 0x3F,
                    0x00, 0x00, 0xC0, 0x3F,
                    0xAD, 0xFA, 0xFF, 0xFF,
                    0x6F, 0x12, 0x03, 0x3C,
                    0x7F, 0xFB, 0xFF, 0xFF,
                    0xA6, 0x9B, 0x44, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_SEWERPIPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x0A, 0xD7, 0x33, 0x40,
                    0x29, 0x5C, 0x0F, 0x3E,
                    0xAD, 0x01, 0x00, 0x00,
                    0x42, 0x60, 0x65, 0x3C,
                    0x88, 0x02, 0x00, 0x00,
                    0x31, 0x08, 0xAC, 0x3C,
                    0x00, 0x00, 0xA0, 0x42,
                    0x00, 0x00, 0x70, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_UNDERWATER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x60, 0xF0, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x52, 0xB8, 0xBE, 0x3F,
                    0xCD, 0xCC, 0xCC, 0x3D,
                    0x3F, 0xFE, 0xFF, 0xFF,
                    0x42, 0x60, 0xE5, 0x3B,
                    0xA4, 0x06, 0x00, 0x00,
                    0x58, 0x39, 0x34, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_SMALLROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xA8, 0xFD, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0xCD, 0xCC, 0x8C, 0x3F,
                    0xE1, 0x7A, 0x54, 0x3F,
                    0x70, 0xFE, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3B,
                    0xF4, 0x01, 0x00, 0x00,
                    0x0A, 0xD7, 0x23, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_MEDIUMROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xA8, 0xFD, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x66, 0x66, 0xA6, 0x3F,
                    0xE1, 0x7A, 0x54, 0x3F,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x0A, 0xD7, 0x23, 0x3C,
                    0x38, 0xFF, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_LARGEROOM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xA8, 0xFD, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0xC0, 0x3F,
                    0xE1, 0x7A, 0x54, 0x3F,
                    0xC0, 0xF9, 0xFF, 0xFF,
                    0x0A, 0xD7, 0xA3, 0x3C,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x0A, 0xD7, 0x23, 0x3D,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_MEDIUMHALL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xA8, 0xFD, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x66, 0x66, 0xE6, 0x3F,
                    0x33, 0x33, 0x33, 0x3F,
                    0xEC, 0xFA, 0xFF, 0xFF,
                    0x8F, 0xC2, 0x75, 0x3C,
                    0xE0, 0xFC, 0xFF, 0xFF,
                    0x8F, 0xC2, 0xF5, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_LARGEHALL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0xA8, 0xFD, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x66, 0x66, 0xE6, 0x3F,
                    0x33, 0x33, 0x33, 0x3F,
                    0x30, 0xF8, 0xFF, 0xFF,
                    0x8F, 0xC2, 0xF5, 0x3C,
                    0x88, 0xFA, 0xFF, 0xFF,
                    0x8F, 0xC2, 0x75, 0x3D,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PLATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0xC8, 0x42,
                    0x18, 0xFC, 0xFF, 0xFF,
                    0x38, 0xFF, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00,
                    0x66, 0x66, 0xA6, 0x3F,
                    0x66, 0x66, 0x66, 0x3F,
                    0x00, 0x00, 0x00, 0x00,
                    0x6F, 0x12, 0x03, 0x3B,
                    0x00, 0x00, 0x00, 0x00,
                    0x0A, 0xD7, 0x23, 0x3C,
                    0x00, 0x00, 0xC8, 0x42,
                    0x00, 0x00, 0x96, 0x42,
                    0x00, 0x40, 0x9C, 0x45
                };

                return ref Unsafe.As<byte, XAUDIO2FX_REVERB_I3DL2_PARAMETERS>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static HRESULT XAudio2CreateVolumeMeter([NativeTypeName("IUnknown **")] IUnknown** ppApo, [NativeTypeName("UINT32")] uint Flags = 0)
        {
            return CreateAudioVolumeMeter(ppApo);
        }

        public static HRESULT XAudio2CreateReverb([NativeTypeName("IUnknown **")] IUnknown** ppApo, [NativeTypeName("UINT32")] uint Flags = 0)
        {
            return CreateAudioReverb(ppApo);
        }

        public static void ReverbConvertI3DL2ToNative([NativeTypeName("const XAUDIO2FX_REVERB_I3DL2_PARAMETERS *")] XAUDIO2FX_REVERB_I3DL2_PARAMETERS* pI3DL2, [NativeTypeName("XAUDIO2FX_REVERB_PARAMETERS *")] XAUDIO2FX_REVERB_PARAMETERS* pNative, [Optional, DefaultParameterValue(1)] BOOL sevenDotOneReverb)
        {
            float reflectionsDelay;
            float reverbDelay;

            if (sevenDotOneReverb != 0)
            {
                pNative->RearDelay = 20;
            }
            else
            {
                pNative->RearDelay = 5;
            }

            pNative->SideDelay = 5;
            pNative->PositionLeft = 6;
            pNative->PositionRight = 6;
            pNative->PositionMatrixLeft = 27;
            pNative->PositionMatrixRight = 27;
            pNative->RoomSize = 100.0f;
            pNative->LowEQCutoff = 4;
            pNative->HighEQCutoff = 6;
            pNative->RoomFilterMain = (float)pI3DL2->Room / 100.0f;
            pNative->RoomFilterHF = (float)pI3DL2->RoomHF / 100.0f;

            if (pI3DL2->DecayHFRatio >= 1.0f)
            {
                int index = (int)(-4.0 * Math.Log10(pI3DL2->DecayHFRatio));

                if (index < -8)
                {
                    index = -8;
                }

                pNative->LowEQGain = (byte)((index < 0) ? index + 8 : 8);
                pNative->HighEQGain = 8;
                pNative->DecayTime = pI3DL2->DecayTime * pI3DL2->DecayHFRatio;
            }
            else
            {
                int index = (int)(4.0 * Math.Log10(pI3DL2->DecayHFRatio));

                if (index < -8)
                {
                    index = -8;
                }

                pNative->LowEQGain = 8;
                pNative->HighEQGain = (byte)((index < 0) ? index + 8 : 8);
                pNative->DecayTime = pI3DL2->DecayTime;
            }

            reflectionsDelay = pI3DL2->ReflectionsDelay * 1000.0f;
            if (reflectionsDelay >= 300)
            {
                reflectionsDelay = (float)(300 - 1);
            }
            else if (reflectionsDelay <= 1)
            {
                reflectionsDelay = 1;
            }

            pNative->ReflectionsDelay = (uint)reflectionsDelay;
            reverbDelay = pI3DL2->ReverbDelay * 1000.0f;
            if (reverbDelay >= 85)
            {
                reverbDelay = (float)(85 - 1);
            }

            pNative->ReverbDelay = (byte)reverbDelay;
            pNative->ReflectionsGain = pI3DL2->Reflections / 100.0f;
            pNative->ReverbGain = pI3DL2->Reverb / 100.0f;
            pNative->EarlyDiffusion = (byte)(15.0f * pI3DL2->Diffusion / 100.0f);
            pNative->LateDiffusion = pNative->EarlyDiffusion;
            pNative->Density = pI3DL2->Density;
            pNative->RoomFilterFreq = pI3DL2->HFReference;
            pNative->WetDryMix = pI3DL2->WetDryMix;
            pNative->DisableLateField = 0;
        }
    }
}
