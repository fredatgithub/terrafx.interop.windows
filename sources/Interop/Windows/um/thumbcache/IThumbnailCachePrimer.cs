// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0F03F8FE-2B26-46F0-965A-212AA8D66B76")]
    [NativeTypeName("struct IThumbnailCachePrimer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IThumbnailCachePrimer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailCachePrimer*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailCachePrimer*, uint>)(lpVtbl[1]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailCachePrimer*, uint>)(lpVtbl[2]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT PageInThumbnail(IShellItem* psi, WTS_FLAGS wtsFlags, uint cxyRequestedThumbSize)
        {
            return ((delegate* unmanaged<IThumbnailCachePrimer*, IShellItem*, WTS_FLAGS, uint, int>)(lpVtbl[3]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this), psi, wtsFlags, cxyRequestedThumbSize);
        }
    }
}
