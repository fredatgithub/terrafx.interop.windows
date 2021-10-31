// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87BE986C-10BE-4943-BF48-4B54CE1983A2")]
    [NativeTypeName("struct IMFContentDecryptionModule : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFContentDecryptionModule
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, uint>)(lpVtbl[1]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, uint>)(lpVtbl[2]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetContentEnabler(IMFContentEnabler* contentEnabler, IMFAsyncResult* result)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, IMFContentEnabler*, IMFAsyncResult*, int>)(lpVtbl[3]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), contentEnabler, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSuspendNotify(IMFCdmSuspendNotify** notify)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, IMFCdmSuspendNotify**, int>)(lpVtbl[4]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), notify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPMPHostApp(IMFPMPHostApp* pmpHostApp)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, IMFPMPHostApp*, int>)(lpVtbl[5]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), pmpHostApp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateSession(MF_MEDIAKEYSESSION_TYPE sessionType, IMFContentDecryptionModuleSessionCallbacks* callbacks, IMFContentDecryptionModuleSession** session)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, MF_MEDIAKEYSESSION_TYPE, IMFContentDecryptionModuleSessionCallbacks*, IMFContentDecryptionModuleSession**, int>)(lpVtbl[6]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), sessionType, callbacks, session);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetServerCertificate([NativeTypeName("const BYTE *")] byte* certificate, [NativeTypeName("DWORD")] uint certificateSize)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, byte*, uint, int>)(lpVtbl[7]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), certificate, certificateSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateTrustedInput([NativeTypeName("const BYTE *")] byte* contentInitData, [NativeTypeName("DWORD")] uint contentInitDataSize, IMFTrustedInput** trustedInput)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, byte*, uint, IMFTrustedInput**, int>)(lpVtbl[8]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), contentInitData, contentInitDataSize, trustedInput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetProtectionSystemIds(Guid** systemIds, [NativeTypeName("DWORD *")] uint* count)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModule*, Guid**, uint*, int>)(lpVtbl[9]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), systemIds, count);
        }
    }
}
