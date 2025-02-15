// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellExecuteHookW.xml' path='doc/member[@name="IShellExecuteHookW"]/*' />
[Guid("000214FB-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellExecuteHookW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellExecuteHookW : IShellExecuteHookW.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellExecuteHookW));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellExecuteHookW*, Guid*, void**, int>)(lpVtbl[0]))((IShellExecuteHookW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellExecuteHookW*, uint>)(lpVtbl[1]))((IShellExecuteHookW*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellExecuteHookW*, uint>)(lpVtbl[2]))((IShellExecuteHookW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellExecuteHookW.xml' path='doc/member[@name="IShellExecuteHookW.Execute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Execute([NativeTypeName("LPSHELLEXECUTEINFOW")] void* pei)
    {
        return ((delegate* unmanaged<IShellExecuteHookW*, void*, int>)(lpVtbl[3]))((IShellExecuteHookW*)Unsafe.AsPointer(ref this), pei);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Execute([NativeTypeName("LPSHELLEXECUTEINFOW")] void* pei);
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

        [NativeTypeName("HRESULT (LPSHELLEXECUTEINFOW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> Execute;
    }
}
