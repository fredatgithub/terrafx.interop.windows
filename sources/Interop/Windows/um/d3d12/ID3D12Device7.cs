// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C014B53-68A1-4B9B-8BD1-DD6046B9358B")]
    [NativeTypeName("struct ID3D12Device7 : ID3D12Device6")]
    [NativeInheritance("ID3D12Device6")]
    public unsafe partial struct ID3D12Device7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Device7*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Device7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint>)(lpVtbl[1]))((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint>)(lpVtbl[2]))((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Device7*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Device7*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12Device7*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Device7*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12Device7*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Device7*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ushort*, int>)(lpVtbl[6]))((ID3D12Device7*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public uint GetNodeCount()
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint>)(lpVtbl[7]))((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandQueue)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandAllocator)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int>)(lpVtbl[9]))((ID3D12Device7*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[11]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateCommandList(uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12Device7*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CheckFeatureSupport(D3D12_FEATURE Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_FEATURE, void*, uint, int>)(lpVtbl[13]))((ID3D12Device7*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[14]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_DESCRIPTOR_HEAP_TYPE, uint>)(lpVtbl[15]))((ID3D12Device7*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppvRootSignature)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)(lpVtbl[16]))((ID3D12Device7*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device7*, D3D12_CONSTANT_BUFFER_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[17]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void CreateShaderResourceView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device7*, ID3D12Resource*, D3D12_SHADER_RESOURCE_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[18]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, D3D12_UNORDERED_ACCESS_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[19]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void CreateRenderTargetView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device7*, ID3D12Resource*, D3D12_RENDER_TARGET_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[20]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void CreateDepthStencilView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device7*, ID3D12Resource*, D3D12_DEPTH_STENCIL_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[21]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device7*, D3D12_SAMPLER_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[22]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            ((delegate* unmanaged<ID3D12Device7*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, D3D12_DESCRIPTOR_HEAP_TYPE, void>)(lpVtbl[23]))((ID3D12Device7*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void CopyDescriptorsSimple(uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
        {
            ((delegate* unmanaged<ID3D12Device7*, uint, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE, void>)(lpVtbl[24]))((ID3D12Device7*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *((delegate* unmanaged<ID3D12Device7*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO*>)(lpVtbl[25]))((ID3D12Device7*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType)
        {
            D3D12_HEAP_PROPERTIES result;
            return *((delegate* unmanaged<ID3D12Device7*, D3D12_HEAP_PROPERTIES*, uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES*>)(lpVtbl[26]))((ID3D12Device7*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[27]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[28]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CreatePlacedResource(ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[29]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int>)(lpVtbl[30]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT CreateSharedHandle(ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, HANDLE* pHandle)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ID3D12DeviceChild*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int>)(lpVtbl[31]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT OpenSharedHandle(HANDLE NTHandle, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return ((delegate* unmanaged<ID3D12Device7*, HANDLE, Guid*, void**, int>)(lpVtbl[32]))((ID3D12Device7*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, HANDLE* pNTHandle)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ushort*, uint, HANDLE*, int>)(lpVtbl[33]))((ID3D12Device7*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint, ID3D12Pageable**, int>)(lpVtbl[34]))((ID3D12Device7*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint, ID3D12Pageable**, int>)(lpVtbl[35]))((ID3D12Device7*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFence)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int>)(lpVtbl[36]))((ID3D12Device7*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D12Device7*, int>)(lpVtbl[37]))((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            ((delegate* unmanaged<ID3D12Device7*, D3D12_RESOURCE_DESC*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void>)(lpVtbl[38]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int>)(lpVtbl[39]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT SetStablePowerState(BOOL Enable)
        {
            return ((delegate* unmanaged<ID3D12Device7*, BOOL, int>)(lpVtbl[40]))((ID3D12Device7*)Unsafe.AsPointer(ref this), Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, void** ppvCommandSignature)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_COMMAND_SIGNATURE_DESC*, ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[41]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, D3D12_PACKED_MIP_INFO* pPackedMipDesc, D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged<ID3D12Device7*, ID3D12Resource*, uint*, D3D12_PACKED_MIP_INFO*, D3D12_TILE_SHAPE*, uint*, uint, D3D12_SUBRESOURCE_TILING*, void>)(lpVtbl[42]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public LUID GetAdapterLuid()
        {
            LUID result;
            return *((delegate* unmanaged<ID3D12Device7*, LUID*, LUID*>)(lpVtbl[43]))((ID3D12Device7*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineLibrary)
        {
            return ((delegate* unmanaged<ID3D12Device7*, void*, nuint, Guid*, void**, int>)(lpVtbl[44]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, HANDLE hEvent)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ID3D12Fence**, ulong*, uint, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE, int>)(lpVtbl[45]))((ID3D12Device7*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT SetResidencyPriority(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint, ID3D12Pageable**, D3D12_RESIDENCY_PRIORITY*, int>)(lpVtbl[46]))((ID3D12Device7*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int>)(lpVtbl[47]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT OpenExistingHeapFromAddress([NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device7*, void*, Guid*, void**, int>)(lpVtbl[48]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pAddress, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT OpenExistingHeapFromFileMapping(HANDLE hFileMapping, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device7*, HANDLE, Guid*, void**, int>)(lpVtbl[49]))((ID3D12Device7*)Unsafe.AsPointer(ref this), hFileMapping, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_RESIDENCY_FLAGS, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)(lpVtbl[50]))((ID3D12Device7*)Unsafe.AsPointer(ref this), Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT CreateCommandList1(uint nodeMask, D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_LIST_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint, D3D12_COMMAND_LIST_TYPE, D3D12_COMMAND_LIST_FLAGS, Guid*, void**, int>)(lpVtbl[51]))((ID3D12Device7*)Unsafe.AsPointer(ref this), nodeMask, type, flags, riid, ppCommandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT CreateProtectedResourceSession([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppSession)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, Guid*, void**, int>)(lpVtbl[52]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT CreateCommittedResource1([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[53]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT CreateHeap1([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[54]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, pProtectedSession, riid, ppvHeap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT CreateReservedResource1([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[55]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs, D3D12_RESOURCE_ALLOCATION_INFO1* pResourceAllocationInfo1)
        {
            D3D12_RESOURCE_ALLOCATION_INFO result;
            return *((delegate* unmanaged<ID3D12Device7*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO1*, D3D12_RESOURCE_ALLOCATION_INFO*>)(lpVtbl[56]))((ID3D12Device7*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppvTracker)
        {
            return ((delegate* unmanaged<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)(lpVtbl[57]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pOwner, riid, ppvTracker);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void RemoveDevice()
        {
            ((delegate* unmanaged<ID3D12Device7*, void>)(lpVtbl[58]))((ID3D12Device7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT EnumerateMetaCommands(uint* pNumMetaCommands, D3D12_META_COMMAND_DESC* pDescs)
        {
            return ((delegate* unmanaged<ID3D12Device7*, uint*, D3D12_META_COMMAND_DESC*, int>)(lpVtbl[59]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pNumMetaCommands, pDescs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT EnumerateMetaCommandParameters([NativeTypeName("const GUID &")] Guid* CommandId, D3D12_META_COMMAND_PARAMETER_STAGE Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, D3D12_META_COMMAND_PARAMETER_DESC* pParameterDescs)
        {
            return ((delegate* unmanaged<ID3D12Device7*, Guid*, D3D12_META_COMMAND_PARAMETER_STAGE, uint*, uint*, D3D12_META_COMMAND_PARAMETER_DESC*, int>)(lpVtbl[60]))((ID3D12Device7*)Unsafe.AsPointer(ref this), CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT CreateMetaCommand([NativeTypeName("const GUID &")] Guid* CommandId, uint NodeMask, [NativeTypeName("const void *")] void* pCreationParametersData, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppMetaCommand)
        {
            return ((delegate* unmanaged<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)(lpVtbl[61]))((ID3D12Device7*)Unsafe.AsPointer(ref this), CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT CreateStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppStateObject)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_STATE_OBJECT_DESC*, Guid*, void**, int>)(lpVtbl[62]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppStateObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public void GetRaytracingAccelerationStructurePrebuildInfo([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS* pDesc, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO* pInfo)
        {
            ((delegate* unmanaged<ID3D12Device7*, D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS*, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO*, void>)(lpVtbl[63]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS CheckDriverMatchingIdentifier(D3D12_SERIALIZED_DATA_TYPE SerializedDataType, [NativeTypeName("const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *")] D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER* pIdentifierToCheck)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_SERIALIZED_DATA_TYPE, D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER*, D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS>)(lpVtbl[64]))((ID3D12Device7*)Unsafe.AsPointer(ref this), SerializedDataType, pIdentifierToCheck);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT SetBackgroundProcessingMode(D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, HANDLE hEventToSignalUponCompletion, BOOL* pbFurtherMeasurementsDesired)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_BACKGROUND_PROCESSING_MODE, D3D12_MEASUREMENTS_ACTION, HANDLE, BOOL*, int>)(lpVtbl[65]))((ID3D12Device7*)Unsafe.AsPointer(ref this), Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT AddToStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, [NativeTypeName("const IID &")] Guid* riid, void** ppNewStateObject)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_STATE_OBJECT_DESC*, ID3D12StateObject*, Guid*, void**, int>)(lpVtbl[66]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT CreateProtectedResourceSession1([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC1 *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC1* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppSession)
        {
            return ((delegate* unmanaged<ID3D12Device7*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*, Guid*, void**, int>)(lpVtbl[67]))((ID3D12Device7*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
        }
    }
}
