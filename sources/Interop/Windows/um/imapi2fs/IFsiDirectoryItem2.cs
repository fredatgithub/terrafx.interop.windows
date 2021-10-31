// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F7FB4B9B-6D96-4D7B-9115-201B144811EF")]
    [NativeTypeName("struct IFsiDirectoryItem2 : IFsiDirectoryItem")]
    [NativeInheritance("IFsiDirectoryItem")]
    public unsafe partial struct IFsiDirectoryItem2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, Guid*, void**, int>)(lpVtbl[0]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, uint>)(lpVtbl[1]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, uint>)(lpVtbl[2]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, uint*, int>)(lpVtbl[3]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort**, int>)(lpVtbl[7]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort**, int>)(lpVtbl[8]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_CreationTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, double*, int>)(lpVtbl[9]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_CreationTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, double, int>)(lpVtbl[10]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, double*, int>)(lpVtbl[11]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, double, int>)(lpVtbl[12]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, double*, int>)(lpVtbl[13]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, double, int>)(lpVtbl[14]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, short*, int>)(lpVtbl[15]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, short, int>)(lpVtbl[16]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, FsiFileSystems, ushort**, int>)(lpVtbl[17]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, FsiFileSystems, ushort**, int>)(lpVtbl[18]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get__NewEnum(IEnumVARIANT** NewEnum)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, IEnumVARIANT**, int>)(lpVtbl[19]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_Item([NativeTypeName("BSTR")] ushort* path, IFsiItem** item)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, IFsiItem**, int>)(lpVtbl[20]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* Count)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, int*, int>)(lpVtbl[21]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_EnumFsiItems(IEnumFsiItems** NewEnum)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, IEnumFsiItems**, int>)(lpVtbl[22]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT AddDirectory([NativeTypeName("BSTR")] ushort* path)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, int>)(lpVtbl[23]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT AddFile([NativeTypeName("BSTR")] ushort* path, IStream* fileData)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, IStream*, int>)(lpVtbl[24]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path, fileData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT AddTree([NativeTypeName("BSTR")] ushort* sourceDirectory, [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, short, int>)(lpVtbl[25]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), sourceDirectory, includeBaseDirectory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT Add(IFsiItem* item)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, IFsiItem*, int>)(lpVtbl[26]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT Remove([NativeTypeName("BSTR")] ushort* path)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, int>)(lpVtbl[27]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT RemoveTree([NativeTypeName("BSTR")] ushort* path)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, int>)(lpVtbl[28]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT AddTreeWithNamedStreams([NativeTypeName("BSTR")] ushort* sourceDirectory, [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, short, int>)(lpVtbl[29]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), sourceDirectory, includeBaseDirectory);
        }
    }
}
