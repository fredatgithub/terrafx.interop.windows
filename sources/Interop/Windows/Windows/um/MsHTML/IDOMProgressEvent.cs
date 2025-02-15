// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDOMProgressEvent.xml' path='doc/member[@name="IDOMProgressEvent"]/*' />
[Guid("3051071E-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMProgressEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMProgressEvent : IDOMProgressEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMProgressEvent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, uint>)(lpVtbl[1]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, uint>)(lpVtbl[2]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, uint*, int>)(lpVtbl[3]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMProgressEvent.xml' path='doc/member[@name="IDOMProgressEvent.get_lengthComputable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_lengthComputable([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, short*, int>)(lpVtbl[7]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMProgressEvent.xml' path='doc/member[@name="IDOMProgressEvent.get_loaded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_loaded([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, ulong*, int>)(lpVtbl[8]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMProgressEvent.xml' path='doc/member[@name="IDOMProgressEvent.get_total"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_total([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, ulong*, int>)(lpVtbl[9]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMProgressEvent.xml' path='doc/member[@name="IDOMProgressEvent.initProgressEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT initProgressEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, [NativeTypeName("VARIANT_BOOL")] short lengthComputableArg, [NativeTypeName("ULONGLONG")] ulong loadedArg, [NativeTypeName("ULONGLONG")] ulong totalArg)
    {
        return ((delegate* unmanaged<IDOMProgressEvent*, ushort*, short, short, short, ulong, ulong, int>)(lpVtbl[10]))((IDOMProgressEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, lengthComputableArg, loadedArg, totalArg);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_lengthComputable([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(8)]
        HRESULT get_loaded([NativeTypeName("ULONGLONG *")] ulong* p);

        [VtblIndex(9)]
        HRESULT get_total([NativeTypeName("ULONGLONG *")] ulong* p);

        [VtblIndex(10)]
        HRESULT initProgressEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, [NativeTypeName("VARIANT_BOOL")] short lengthComputableArg, [NativeTypeName("ULONGLONG")] ulong loadedArg, [NativeTypeName("ULONGLONG")] ulong totalArg);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_lengthComputable;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_loaded;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_total;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL, ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, short, ulong, ulong, int> initProgressEvent;
    }
}
