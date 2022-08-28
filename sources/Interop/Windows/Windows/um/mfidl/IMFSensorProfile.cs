// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFSensorProfile.xml' path='doc/member[@name="IMFSensorProfile"]/*' />
[Guid("22F765D1-8DAB-4107-846D-56BAF72215E7")]
[NativeTypeName("struct IMFSensorProfile : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.17134.0")]
public unsafe partial struct IMFSensorProfile : IMFSensorProfile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorProfile));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorProfile*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorProfile*, uint>)(lpVtbl[1]))((IMFSensorProfile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorProfile*, uint>)(lpVtbl[2]))((IMFSensorProfile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorProfile.xml' path='doc/member[@name="IMFSensorProfile.GetProfileId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetProfileId(SENSORPROFILEID* pId)
    {
        return ((delegate* unmanaged<IMFSensorProfile*, SENSORPROFILEID*, int>)(lpVtbl[3]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), pId);
    }

    /// <include file='IMFSensorProfile.xml' path='doc/member[@name="IMFSensorProfile.AddProfileFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddProfileFilter([NativeTypeName("UINT32")] uint StreamId, [NativeTypeName("LPCWSTR")] ushort* wzFilterSetString)
    {
        return ((delegate* unmanaged<IMFSensorProfile*, uint, ushort*, int>)(lpVtbl[4]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), StreamId, wzFilterSetString);
    }

    /// <include file='IMFSensorProfile.xml' path='doc/member[@name="IMFSensorProfile.IsMediaTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsMediaTypeSupported([NativeTypeName("UINT32")] uint StreamId, IMFMediaType* pMediaType, BOOL* pfSupported)
    {
        return ((delegate* unmanaged<IMFSensorProfile*, uint, IMFMediaType*, BOOL*, int>)(lpVtbl[5]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), StreamId, pMediaType, pfSupported);
    }

    /// <include file='IMFSensorProfile.xml' path='doc/member[@name="IMFSensorProfile.AddBlockedControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddBlockedControl([NativeTypeName("LPCWSTR")] ushort* wzBlockedControl)
    {
        return ((delegate* unmanaged<IMFSensorProfile*, ushort*, int>)(lpVtbl[6]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), wzBlockedControl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetProfileId(SENSORPROFILEID* pId);

        [VtblIndex(4)]
        HRESULT AddProfileFilter([NativeTypeName("UINT32")] uint StreamId, [NativeTypeName("LPCWSTR")] ushort* wzFilterSetString);

        [VtblIndex(5)]
        HRESULT IsMediaTypeSupported([NativeTypeName("UINT32")] uint StreamId, IMFMediaType* pMediaType, BOOL* pfSupported);

        [VtblIndex(6)]
        HRESULT AddBlockedControl([NativeTypeName("LPCWSTR")] ushort* wzBlockedControl);
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

        [NativeTypeName("HRESULT (SENSORPROFILEID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SENSORPROFILEID*, int> GetProfileId;

        [NativeTypeName("HRESULT (UINT32, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> AddProfileFilter;

        [NativeTypeName("HRESULT (UINT32, IMFMediaType *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, BOOL*, int> IsMediaTypeSupported;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddBlockedControl;
    }
}
