// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6CCB7BE0-6807-11D0-B810-00C04FD706EC")]
    [NativeTypeName("struct IShellTaskScheduler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellTaskScheduler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, Guid*, void**, int>)(lpVtbl[0]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, uint>)(lpVtbl[1]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, uint>)(lpVtbl[2]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddTask(IRunnableTask* prt, [NativeTypeName("const TASKOWNERID &")] Guid* rtoid, [NativeTypeName("DWORD_PTR")] nuint lParam, [NativeTypeName("DWORD")] uint dwPriority)
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, IRunnableTask*, Guid*, nuint, uint, int>)(lpVtbl[3]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), prt, rtoid, lParam, dwPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveTasks([NativeTypeName("const TASKOWNERID &")] Guid* rtoid, [NativeTypeName("DWORD_PTR")] nuint lParam, [NativeTypeName("BOOL")] int bWaitIfRunning)
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, Guid*, nuint, int, int>)(lpVtbl[4]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), rtoid, lParam, bWaitIfRunning);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("UINT")]
        public uint CountTasks([NativeTypeName("const TASKOWNERID &")] Guid* rtoid)
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, Guid*, uint>)(lpVtbl[5]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), rtoid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Status([NativeTypeName("DWORD")] uint dwReleaseStatus, [NativeTypeName("DWORD")] uint dwThreadTimeout)
        {
            return ((delegate* unmanaged<IShellTaskScheduler*, uint, uint, int>)(lpVtbl[6]))((IShellTaskScheduler*)Unsafe.AsPointer(ref this), dwReleaseStatus, dwThreadTimeout);
        }
    }
}
