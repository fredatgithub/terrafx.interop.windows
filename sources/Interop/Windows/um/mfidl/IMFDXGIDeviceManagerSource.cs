// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("20BC074B-7A8D-4609-8C3B-64A0A3B5D7CE")]
    [NativeTypeName("struct IMFDXGIDeviceManagerSource : IUnknown")]
    public unsafe partial struct IMFDXGIDeviceManagerSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint>)(lpVtbl[1]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint>)(lpVtbl[2]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetManager(IMFDXGIDeviceManager** ppManager)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, IMFDXGIDeviceManager**, int>)(lpVtbl[3]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this), ppManager);
        }
    }
}
