// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0DB8851D-2E5B-47EB-9208-D28C325A01D7")]
    [NativeTypeName("struct ICondition2 : ICondition")]
    public unsafe partial struct ICondition2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICondition2*, Guid*, void**, int>)(lpVtbl[0]))((ICondition2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICondition2*, uint>)(lpVtbl[1]))((ICondition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICondition2*, uint>)(lpVtbl[2]))((ICondition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<ICondition2*, Guid*, int>)(lpVtbl[3]))((ICondition2*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<ICondition2*, int>)(lpVtbl[4]))((ICondition2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm)
        {
            return ((delegate* unmanaged<ICondition2*, IStream*, int>)(lpVtbl[5]))((ICondition2*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return ((delegate* unmanaged<ICondition2*, IStream*, int, int>)(lpVtbl[6]))((ICondition2*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged<ICondition2*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ICondition2*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType(CONDITION_TYPE* pNodeType)
        {
            return ((delegate* unmanaged<ICondition2*, CONDITION_TYPE*, int>)(lpVtbl[8]))((ICondition2*)Unsafe.AsPointer(ref this), pNodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ICondition2*, Guid*, void**, int>)(lpVtbl[9]))((ICondition2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComparisonInfo([NativeTypeName("LPWSTR *")] ushort** ppszPropertyName, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<ICondition2*, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int>)(lpVtbl[10]))((ICondition2*)Unsafe.AsPointer(ref this), ppszPropertyName, pcop, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName)
        {
            return ((delegate* unmanaged<ICondition2*, ushort**, int>)(lpVtbl[11]))((ICondition2*)Unsafe.AsPointer(ref this), ppszValueTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization)
        {
            return ((delegate* unmanaged<ICondition2*, ushort**, int>)(lpVtbl[12]))((ICondition2*)Unsafe.AsPointer(ref this), ppszNormalization);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTerms(IRichChunk** ppPropertyTerm, IRichChunk** ppOperationTerm, IRichChunk** ppValueTerm)
        {
            return ((delegate* unmanaged<ICondition2*, IRichChunk**, IRichChunk**, IRichChunk**, int>)(lpVtbl[13]))((ICondition2*)Unsafe.AsPointer(ref this), ppPropertyTerm, ppOperationTerm, ppValueTerm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ICondition** ppc)
        {
            return ((delegate* unmanaged<ICondition2*, ICondition**, int>)(lpVtbl[14]))((ICondition2*)Unsafe.AsPointer(ref this), ppc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocale([NativeTypeName("LPWSTR *")] ushort** ppszLocaleName)
        {
            return ((delegate* unmanaged<ICondition2*, ushort**, int>)(lpVtbl[15]))((ICondition2*)Unsafe.AsPointer(ref this), ppszLocaleName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLeafConditionInfo(PROPERTYKEY* ppropkey, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<ICondition2*, PROPERTYKEY*, CONDITION_OPERATION*, PROPVARIANT*, int>)(lpVtbl[16]))((ICondition2*)Unsafe.AsPointer(ref this), ppropkey, pcop, ppropvar);
        }
    }
}
