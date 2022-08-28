// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IRendezvousApplication.xml' path='doc/member[@name="IRendezvousApplication"]/*' />
[Guid("4F4D070B-A275-49FB-B10D-8EC26387B50D")]
[NativeTypeName("struct IRendezvousApplication : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRendezvousApplication : IRendezvousApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRendezvousApplication));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRendezvousApplication*, Guid*, void**, int>)(lpVtbl[0]))((IRendezvousApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRendezvousApplication*, uint>)(lpVtbl[1]))((IRendezvousApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRendezvousApplication*, uint>)(lpVtbl[2]))((IRendezvousApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRendezvousApplication.xml' path='doc/member[@name="IRendezvousApplication.SetRendezvousSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRendezvousSession(IUnknown* pRendezvousSession)
    {
        return ((delegate* unmanaged<IRendezvousApplication*, IUnknown*, int>)(lpVtbl[3]))((IRendezvousApplication*)Unsafe.AsPointer(ref this), pRendezvousSession);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetRendezvousSession(IUnknown* pRendezvousSession);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetRendezvousSession;
    }
}
