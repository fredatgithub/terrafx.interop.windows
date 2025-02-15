// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLDOMConstructor.xml' path='doc/member[@name="IHTMLDOMConstructor"]/*' />
[Guid("3051049B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMConstructor : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMConstructor : IHTMLDOMConstructor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMConstructor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, uint>)(lpVtbl[1]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, uint>)(lpVtbl[2]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, uint*, int>)(lpVtbl[3]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDOMConstructor.xml' path='doc/member[@name="IHTMLDOMConstructor.get_constructor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_constructor(IDispatch** p)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, IDispatch**, int>)(lpVtbl[7]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDOMConstructor.xml' path='doc/member[@name="IHTMLDOMConstructor.LookupGetter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LookupGetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* ppDispHandler)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), propname, ppDispHandler);
    }

    /// <include file='IHTMLDOMConstructor.xml' path='doc/member[@name="IHTMLDOMConstructor.LookupSetter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LookupSetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* ppDispHandler)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, ushort*, VARIANT*, int>)(lpVtbl[9]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), propname, ppDispHandler);
    }

    /// <include file='IHTMLDOMConstructor.xml' path='doc/member[@name="IHTMLDOMConstructor.DefineGetter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DefineGetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* pdispHandler)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), propname, pdispHandler);
    }

    /// <include file='IHTMLDOMConstructor.xml' path='doc/member[@name="IHTMLDOMConstructor.DefineSetter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DefineSetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* pdispHandler)
    {
        return ((delegate* unmanaged<IHTMLDOMConstructor*, ushort*, VARIANT*, int>)(lpVtbl[11]))((IHTMLDOMConstructor*)Unsafe.AsPointer(ref this), propname, pdispHandler);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_constructor(IDispatch** p);

        [VtblIndex(8)]
        HRESULT LookupGetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* ppDispHandler);

        [VtblIndex(9)]
        HRESULT LookupSetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* ppDispHandler);

        [VtblIndex(10)]
        HRESULT DefineGetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* pdispHandler);

        [VtblIndex(11)]
        HRESULT DefineSetter([NativeTypeName("BSTR")] ushort* propname, VARIANT* pdispHandler);
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_constructor;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> LookupGetter;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> LookupSetter;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> DefineGetter;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> DefineSetter;
    }
}
