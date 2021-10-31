// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106EB-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCSSMediaRule : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCSSMediaRule
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, uint>)(lpVtbl[1]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, uint>)(lpVtbl[2]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, uint*, int>)(lpVtbl[3]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_media(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, VARIANT, int>)(lpVtbl[7]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_media(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, VARIANT*, int>)(lpVtbl[8]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_cssRules(IHTMLStyleSheetRulesCollection** p)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, IHTMLStyleSheetRulesCollection**, int>)(lpVtbl[9]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT insertRule([NativeTypeName("BSTR")] ushort* bstrRule, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plNewIndex)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, ushort*, int, int*, int>)(lpVtbl[10]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), bstrRule, lIndex, plNewIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT deleteRule([NativeTypeName("long")] int lIndex = -1)
        {
            return ((delegate* unmanaged<IHTMLCSSMediaRule*, int, int>)(lpVtbl[11]))((IHTMLCSSMediaRule*)Unsafe.AsPointer(ref this), lIndex);
        }
    }
}
