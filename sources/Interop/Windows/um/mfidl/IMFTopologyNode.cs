// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83CF873A-F6DA-4BC8-823F-BACFD55DC430")]
    [NativeTypeName("struct IMFTopologyNode : IMFAttributes")]
    [NativeInheritance("IMFAttributes")]
    public unsafe partial struct IMFTopologyNode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint>)(lpVtbl[1]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint>)(lpVtbl[2]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint*, int>)(lpVtbl[7]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, double*, int>)(lpVtbl[9]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint*, int>)(lpVtbl[11]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint*, int>)(lpVtbl[14]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, int>)(lpVtbl[19]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, int>)(lpVtbl[20]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint, int>)(lpVtbl[21]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ulong, int>)(lpVtbl[22]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, double, int>)(lpVtbl[23]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT LockStore()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, int>)(lpVtbl[28]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT UnlockStore()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, int>)(lpVtbl[29]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint*, int>)(lpVtbl[30]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IMFAttributes*, int>)(lpVtbl[32]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetObject(IUnknown* pObject)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IUnknown*, int>)(lpVtbl[33]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetObject(IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IUnknown**, int>)(lpVtbl[34]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetNodeType(MF_TOPOLOGY_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, MF_TOPOLOGY_TYPE*, int>)(lpVtbl[35]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetTopoNodeID([NativeTypeName("TOPOID *")] ulong* pID)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, ulong*, int>)(lpVtbl[36]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetTopoNodeID([NativeTypeName("TOPOID")] ulong ullTopoID)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, ulong, int>)(lpVtbl[37]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), ullTopoID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT GetInputCount([NativeTypeName("DWORD *")] uint* pcInputs)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint*, int>)(lpVtbl[38]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pcInputs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetOutputCount([NativeTypeName("DWORD *")] uint* pcOutputs)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint*, int>)(lpVtbl[39]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pcOutputs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT ConnectOutput([NativeTypeName("DWORD")] uint dwOutputIndex, IMFTopologyNode* pDownstreamNode, [NativeTypeName("DWORD")] uint dwInputIndexOnDownstreamNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFTopologyNode*, uint, int>)(lpVtbl[40]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, pDownstreamNode, dwInputIndexOnDownstreamNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT DisconnectOutput([NativeTypeName("DWORD")] uint dwOutputIndex)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, int>)(lpVtbl[41]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT GetInput([NativeTypeName("DWORD")] uint dwInputIndex, IMFTopologyNode** ppUpstreamNode, [NativeTypeName("DWORD *")] uint* pdwOutputIndexOnUpstreamNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFTopologyNode**, uint*, int>)(lpVtbl[42]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwInputIndex, ppUpstreamNode, pdwOutputIndexOnUpstreamNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT GetOutput([NativeTypeName("DWORD")] uint dwOutputIndex, IMFTopologyNode** ppDownstreamNode, [NativeTypeName("DWORD *")] uint* pdwInputIndexOnDownstreamNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFTopologyNode**, uint*, int>)(lpVtbl[43]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, ppDownstreamNode, pdwInputIndexOnDownstreamNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT SetOutputPrefType([NativeTypeName("DWORD")] uint dwOutputIndex, IMFMediaType* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType*, int>)(lpVtbl[44]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT GetOutputPrefType([NativeTypeName("DWORD")] uint dwOutputIndex, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType**, int>)(lpVtbl[45]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT SetInputPrefType([NativeTypeName("DWORD")] uint dwInputIndex, IMFMediaType* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType*, int>)(lpVtbl[46]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwInputIndex, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT GetInputPrefType([NativeTypeName("DWORD")] uint dwInputIndex, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType**, int>)(lpVtbl[47]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwInputIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT CloneFrom(IMFTopologyNode* pNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IMFTopologyNode*, int>)(lpVtbl[48]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pNode);
        }
    }
}
