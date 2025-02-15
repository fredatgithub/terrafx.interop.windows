// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage"]/*' />
[Guid("9D416F9C-E184-45B2-A4F0-CE517F719E9B")]
[NativeTypeName("struct IDiaPropertyStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaPropertyStorage : IDiaPropertyStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaPropertyStorage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, Guid*, void**, int>)(lpVtbl[0]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint>)(lpVtbl[1]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint>)(lpVtbl[2]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadMultiple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC *")] PROPSPEC* rgpspec, PROPVARIANT* rgvar)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, int>)(lpVtbl[3]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgvar);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadPropertyNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID *")] uint* rgpropid, [NativeTypeName("BSTR *")] ushort** rglpwstrName)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, uint*, ushort**, int>)(lpVtbl[4]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.Enum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Enum(IEnumSTATPROPSTG** ppenum)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, IEnumSTATPROPSTG**, int>)(lpVtbl[5]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadDWORD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadDWORD([NativeTypeName("PROPID")] uint id, [NativeTypeName("DWORD *")] uint* pValue)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, uint*, int>)(lpVtbl[6]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadLONG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReadLONG([NativeTypeName("PROPID")] uint id, [NativeTypeName("LONG *")] int* pValue)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, int*, int>)(lpVtbl[7]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadBOOL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReadBOOL([NativeTypeName("PROPID")] uint id, BOOL* pValue)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, BOOL*, int>)(lpVtbl[8]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadULONGLONG"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadULONGLONG([NativeTypeName("PROPID")] uint id, [NativeTypeName("ULONGLONG *")] ulong* pValue)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, ulong*, int>)(lpVtbl[9]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
    }

    /// <include file='IDiaPropertyStorage.xml' path='doc/member[@name="IDiaPropertyStorage.ReadBSTR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadBSTR([NativeTypeName("PROPID")] uint id, [NativeTypeName("BSTR *")] ushort** pValue)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage*, uint, ushort**, int>)(lpVtbl[10]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC *")] PROPSPEC* rgpspec, PROPVARIANT* rgvar);

        [VtblIndex(4)]
        HRESULT ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID *")] uint* rgpropid, [NativeTypeName("BSTR *")] ushort** rglpwstrName);

        [VtblIndex(5)]
        HRESULT Enum(IEnumSTATPROPSTG** ppenum);

        [VtblIndex(6)]
        HRESULT ReadDWORD([NativeTypeName("PROPID")] uint id, [NativeTypeName("DWORD *")] uint* pValue);

        [VtblIndex(7)]
        HRESULT ReadLONG([NativeTypeName("PROPID")] uint id, [NativeTypeName("LONG *")] int* pValue);

        [VtblIndex(8)]
        HRESULT ReadBOOL([NativeTypeName("PROPID")] uint id, BOOL* pValue);

        [VtblIndex(9)]
        HRESULT ReadULONGLONG([NativeTypeName("PROPID")] uint id, [NativeTypeName("ULONGLONG *")] ulong* pValue);

        [VtblIndex(10)]
        HRESULT ReadBSTR([NativeTypeName("PROPID")] uint id, [NativeTypeName("BSTR *")] ushort** pValue);
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

        [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPSPEC*, PROPVARIANT*, int> ReadMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPID *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, ushort**, int> ReadPropertyNames;

        [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATPROPSTG**, int> Enum;

        [NativeTypeName("HRESULT (PROPID, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> ReadDWORD;

        [NativeTypeName("HRESULT (PROPID, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> ReadLONG;

        [NativeTypeName("HRESULT (PROPID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> ReadBOOL;

        [NativeTypeName("HRESULT (PROPID, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong*, int> ReadULONGLONG;

        [NativeTypeName("HRESULT (PROPID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> ReadBSTR;
    }
}
