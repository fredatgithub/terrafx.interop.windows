// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDCompositionDeviceDebug.xml' path='doc/member[@name="IDCompositionDeviceDebug"]/*' />
[Guid("A1A3C64A-224F-4A81-9773-4F03A89D3C6C")]
[NativeTypeName("struct IDCompositionDeviceDebug : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDCompositionDeviceDebug : IDCompositionDeviceDebug.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDeviceDebug));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionDeviceDebug*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionDeviceDebug*, uint>)(lpVtbl[1]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionDeviceDebug*, uint>)(lpVtbl[2]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDeviceDebug.xml' path='doc/member[@name="IDCompositionDeviceDebug.EnableDebugCounters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableDebugCounters()
    {
        return ((delegate* unmanaged<IDCompositionDeviceDebug*, int>)(lpVtbl[3]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDeviceDebug.xml' path='doc/member[@name="IDCompositionDeviceDebug.DisableDebugCounters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableDebugCounters()
    {
        return ((delegate* unmanaged<IDCompositionDeviceDebug*, int>)(lpVtbl[4]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnableDebugCounters();

        [VtblIndex(4)]
        HRESULT DisableDebugCounters();
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EnableDebugCounters;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisableDebugCounters;
    }
}
