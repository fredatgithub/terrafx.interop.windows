// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6AE-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLRenderStyle : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLRenderStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, uint>)(lpVtbl[1]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, uint>)(lpVtbl[2]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, uint*, int>)(lpVtbl[3]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_textLineThroughStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int>)(lpVtbl[7]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_textLineThroughStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int>)(lpVtbl[8]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_textUnderlineStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int>)(lpVtbl[9]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_textUnderlineStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int>)(lpVtbl[10]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_textEffect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int>)(lpVtbl[11]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_textEffect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int>)(lpVtbl[12]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_textColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT, int>)(lpVtbl[13]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_textColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT*, int>)(lpVtbl[14]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_textBackgroundColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT, int>)(lpVtbl[15]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_textBackgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT*, int>)(lpVtbl[16]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_textDecorationColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT, int>)(lpVtbl[17]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_textDecorationColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, VARIANT*, int>)(lpVtbl[18]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_renderingPriority([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, int, int>)(lpVtbl[19]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_renderingPriority([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, int*, int>)(lpVtbl[20]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_defaultTextSelection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int>)(lpVtbl[21]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_defaultTextSelection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int>)(lpVtbl[22]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort*, int>)(lpVtbl[23]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRenderStyle*, ushort**, int>)(lpVtbl[24]))((IHTMLRenderStyle*)Unsafe.AsPointer(ref this), p);
        }
    }
}
