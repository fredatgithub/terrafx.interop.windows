// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiscFormat2.xml' path='doc/member[@name="IDiscFormat2"]/*' />
[Guid("27354152-8F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscFormat2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDiscFormat2 : IDiscFormat2.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDiscFormat2;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscFormat2*, Guid*, void**, int>)(lpVtbl[0]))((IDiscFormat2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscFormat2*, uint>)(lpVtbl[1]))((IDiscFormat2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscFormat2*, uint>)(lpVtbl[2]))((IDiscFormat2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscFormat2*, uint*, int>)(lpVtbl[3]))((IDiscFormat2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDiscFormat2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscFormat2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDiscFormat2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscFormat2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDiscFormat2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscFormat2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDiscFormat2.xml' path='doc/member[@name="IDiscFormat2.IsRecorderSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsRecorderSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2*, IDiscRecorder2*, short*, int>)(lpVtbl[7]))((IDiscFormat2*)Unsafe.AsPointer(ref this), recorder, value);
    }

    /// <include file='IDiscFormat2.xml' path='doc/member[@name="IDiscFormat2.IsCurrentMediaSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsCurrentMediaSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2*, IDiscRecorder2*, short*, int>)(lpVtbl[8]))((IDiscFormat2*)Unsafe.AsPointer(ref this), recorder, value);
    }

    /// <include file='IDiscFormat2.xml' path='doc/member[@name="IDiscFormat2.get_MediaPhysicallyBlank"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2*, short*, int>)(lpVtbl[9]))((IDiscFormat2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2.xml' path='doc/member[@name="IDiscFormat2.get_MediaHeuristicallyBlank"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2*, short*, int>)(lpVtbl[10]))((IDiscFormat2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2.xml' path='doc/member[@name="IDiscFormat2.get_SupportedMediaTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportedMediaTypes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2*, SAFEARRAY**, int>)(lpVtbl[11]))((IDiscFormat2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT IsRecorderSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(8)]
        HRESULT IsCurrentMediaSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(9)]
        HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(10)]
        HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(11)]
        HRESULT get_SupportedMediaTypes(SAFEARRAY** value);
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

        [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, short*, int> IsRecorderSupported;

        [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, short*, int> IsCurrentMediaSupported;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MediaPhysicallyBlank;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MediaHeuristicallyBlank;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedMediaTypes;
    }
}
