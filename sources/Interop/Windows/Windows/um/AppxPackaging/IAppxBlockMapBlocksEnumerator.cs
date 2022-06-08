// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxBlockMapBlocksEnumerator.xml' path='doc/member[@name="IAppxBlockMapBlocksEnumerator"]/*' />
[Guid("6B429B5B-36EF-479E-B9EB-0C1482B49E16")]
[NativeTypeName("struct IAppxBlockMapBlocksEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IAppxBlockMapBlocksEnumerator : IAppxBlockMapBlocksEnumerator.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IAppxBlockMapBlocksEnumerator;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint>)(lpVtbl[1]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint>)(lpVtbl[2]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBlockMapBlocksEnumerator.xml' path='doc/member[@name="IAppxBlockMapBlocksEnumerator.GetCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxBlockMapBlock** block)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, IAppxBlockMapBlock**, int>)(lpVtbl[3]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), block);
    }

    /// <include file='IAppxBlockMapBlocksEnumerator.xml' path='doc/member[@name="IAppxBlockMapBlocksEnumerator.GetHasCurrent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxBlockMapBlocksEnumerator.xml' path='doc/member[@name="IAppxBlockMapBlocksEnumerator.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxBlockMapBlock** block);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
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

        [NativeTypeName("HRESULT (IAppxBlockMapBlock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBlockMapBlock**, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}
