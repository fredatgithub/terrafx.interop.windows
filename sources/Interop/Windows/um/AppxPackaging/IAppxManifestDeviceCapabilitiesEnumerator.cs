// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30204541-427B-4A1C-BACF-655BF463A540")]
    [NativeTypeName("struct IAppxManifestDeviceCapabilitiesEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestDeviceCapabilitiesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("LPWSTR *")] ushort** deviceCapability)
        {
            return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, ushort**, int>)(lpVtbl[3]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), deviceCapability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
