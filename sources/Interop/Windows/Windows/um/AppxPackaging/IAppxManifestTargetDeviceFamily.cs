// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestTargetDeviceFamily.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamily"]/*' />
[Guid("9091B09B-C8D5-4F31-8687-A338259FAEFB")]
[NativeTypeName("struct IAppxManifestTargetDeviceFamily : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxManifestTargetDeviceFamily : IAppxManifestTargetDeviceFamily.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestTargetDeviceFamily));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, uint>)(lpVtbl[1]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, uint>)(lpVtbl[2]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestTargetDeviceFamily.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamily.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, ushort**, int>)(lpVtbl[3]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IAppxManifestTargetDeviceFamily.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamily.GetMinVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, ulong*, int>)(lpVtbl[4]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), minVersion);
    }

    /// <include file='IAppxManifestTargetDeviceFamily.xml' path='doc/member[@name="IAppxManifestTargetDeviceFamily.GetMaxVersionTested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaxVersionTested([NativeTypeName("UINT64 *")] ulong* maxVersionTested)
    {
        return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, ulong*, int>)(lpVtbl[5]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), maxVersionTested);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

        [VtblIndex(4)]
        HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion);

        [VtblIndex(5)]
        HRESULT GetMaxVersionTested([NativeTypeName("UINT64 *")] ulong* maxVersionTested);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMinVersion;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMaxVersionTested;
    }
}
