// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AB9D8661-F7E8-4EF4-9861-89F334F94E74")]
    [NativeTypeName("struct IMFTimecodeTranslate : IUnknown")]
    public unsafe partial struct IMFTimecodeTranslate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, uint>)(lpVtbl[1]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, uint>)(lpVtbl[2]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginConvertTimecodeToHNS([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVarTimecode, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, PROPVARIANT*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pPropVarTimecode, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndConvertTimecodeToHNS(IMFAsyncResult* pResult, [NativeTypeName("MFTIME *")] long* phnsTime)
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, IMFAsyncResult*, long*, int>)(lpVtbl[4]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pResult, phnsTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginConvertHNSToTimecode([NativeTypeName("MFTIME")] long hnsTime, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, long, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), hnsTime, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndConvertHNSToTimecode(IMFAsyncResult* pResult, PROPVARIANT* pPropVarTimecode)
        {
            return ((delegate* unmanaged<IMFTimecodeTranslate*, IMFAsyncResult*, PROPVARIANT*, int>)(lpVtbl[6]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pResult, pPropVarTimecode);
        }
    }
}
