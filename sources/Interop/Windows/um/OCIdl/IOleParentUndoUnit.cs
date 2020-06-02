// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A1FAF330-EF97-11CE-9BC9-00AA00608E01")]
    public unsafe partial struct IOleParentUndoUnit
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Do([NativeTypeName("IOleUndoManager *")] IOleUndoManager* pUndoManager)
        {
            return lpVtbl->Do((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return lpVtbl->GetDescription((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
        {
            return lpVtbl->GetUnitType((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnNextAdd()
        {
            return lpVtbl->OnNextAdd((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU)
        {
            return lpVtbl->Open((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return lpVtbl->Close((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return lpVtbl->Add((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindUnit([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return lpVtbl->FindUnit((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return lpVtbl->GetParentState((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pdwState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, uint> Release;

            [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, IOleUndoManager*, int> Do;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, ushort**, int> GetDescription;

            [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, Guid*, int*, int> GetUnitType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, int> OnNextAdd;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, IOleParentUndoUnit*, int> Open;

            [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, IOleParentUndoUnit*, int, int> Close;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, IOleUndoUnit*, int> Add;

            [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, IOleUndoUnit*, int> FindUnit;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleParentUndoUnit*, uint*, int> GetParentState;
        }
    }
}
