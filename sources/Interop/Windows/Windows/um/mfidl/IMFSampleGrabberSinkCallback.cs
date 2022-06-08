// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFSampleGrabberSinkCallback.xml' path='doc/member[@name="IMFSampleGrabberSinkCallback"]/*' />
[Guid("8C7B80BF-EE42-4B59-B1DF-55668E1BDCA8")]
[NativeTypeName("struct IMFSampleGrabberSinkCallback : IMFClockStateSink")]
[NativeInheritance("IMFClockStateSink")]
public unsafe partial struct IMFSampleGrabberSinkCallback : IMFSampleGrabberSinkCallback.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IMFSampleGrabberSinkCallback;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, uint>)(lpVtbl[1]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, uint>)(lpVtbl[2]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFClockStateSink.OnClockStart" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, long, long, int>)(lpVtbl[3]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
    }

    /// <inheritdoc cref="IMFClockStateSink.OnClockStop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, long, int>)(lpVtbl[4]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime);
    }

    /// <inheritdoc cref="IMFClockStateSink.OnClockPause" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, long, int>)(lpVtbl[5]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime);
    }

    /// <inheritdoc cref="IMFClockStateSink.OnClockRestart" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, long, int>)(lpVtbl[6]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime);
    }

    /// <inheritdoc cref="IMFClockStateSink.OnClockSetRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, long, float, int>)(lpVtbl[7]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
    }

    /// <include file='IMFSampleGrabberSinkCallback.xml' path='doc/member[@name="IMFSampleGrabberSinkCallback.OnSetPresentationClock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnSetPresentationClock(IMFPresentationClock* pPresentationClock)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, IMFPresentationClock*, int>)(lpVtbl[8]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), pPresentationClock);
    }

    /// <include file='IMFSampleGrabberSinkCallback.xml' path='doc/member[@name="IMFSampleGrabberSinkCallback.OnProcessSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnProcessSample([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, Guid*, uint, long, long, byte*, uint, int>)(lpVtbl[9]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), guidMajorMediaType, dwSampleFlags, llSampleTime, llSampleDuration, pSampleBuffer, dwSampleSize);
    }

    /// <include file='IMFSampleGrabberSinkCallback.xml' path='doc/member[@name="IMFSampleGrabberSinkCallback.OnShutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnShutdown()
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback*, int>)(lpVtbl[10]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFClockStateSink.Interface
    {
        [VtblIndex(8)]
        HRESULT OnSetPresentationClock(IMFPresentationClock* pPresentationClock);

        [VtblIndex(9)]
        HRESULT OnProcessSample([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize);

        [VtblIndex(10)]
        HRESULT OnShutdown();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (MFTIME, LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, long, int> OnClockStart;

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockStop;

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockPause;

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockRestart;

        [NativeTypeName("HRESULT (MFTIME, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, float, int> OnClockSetRate;

        [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock*, int> OnSetPresentationClock;

        [NativeTypeName("HRESULT (const GUID &, DWORD, LONGLONG, LONGLONG, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, long, long, byte*, uint, int> OnProcessSample;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnShutdown;
    }
}
