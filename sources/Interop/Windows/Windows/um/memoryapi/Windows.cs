// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* VirtualAlloc([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualProtect([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flNewProtect, [NativeTypeName("PDWORD")] uint* lpflOldProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualFree([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint dwFreeType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint VirtualQuery([NativeTypeName("LPCVOID")] void* lpAddress, [NativeTypeName("PMEMORY_BASIC_INFORMATION")] MEMORY_BASIC_INFORMATION* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* VirtualAllocEx(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualProtectEx(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flNewProtect, [NativeTypeName("PDWORD")] uint* lpflOldProtect);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint VirtualQueryEx(HANDLE hProcess, [NativeTypeName("LPCVOID")] void* lpAddress, [NativeTypeName("PMEMORY_BASIC_INFORMATION")] MEMORY_BASIC_INFORMATION* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL ReadProcessMemory(HANDLE hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint nSize, [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteProcessMemory(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint nSize, [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE CreateFileMappingW(HANDLE hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE OpenFileMappingW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFile(HANDLE hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFileEx(HANDLE hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualFreeEx(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint dwFreeType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FlushViewOfFile([NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToFlush);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnmapViewOfFile([NativeTypeName("LPCVOID")] void* lpBaseAddress);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint GetLargePageMinimum();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetProcessWorkingSetSize(HANDLE hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL GetProcessWorkingSetSizeEx(HANDLE hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessWorkingSetSize(HANDLE hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetProcessWorkingSetSizeEx(HANDLE hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualLock([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualUnlock([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern uint GetWriteWatch([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwRegionSize, [NativeTypeName("PVOID *")] void** lpAddresses, [NativeTypeName("ULONG_PTR *")] nuint* lpdwCount, [NativeTypeName("LPDWORD")] uint* lpdwGranularity);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern uint ResetWriteWatch([NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwRegionSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE CreateMemoryResourceNotification(MEMORY_RESOURCE_NOTIFICATION_TYPE NotificationType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL QueryMemoryResourceNotification(HANDLE ResourceNotificationHandle, [NativeTypeName("PBOOL")] BOOL* ResourceState);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetSystemFileCacheSize([NativeTypeName("PSIZE_T")] nuint* lpMinimumFileCacheSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumFileCacheSize, [NativeTypeName("PDWORD")] uint* lpFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetSystemFileCacheSize([NativeTypeName("SIZE_T")] nuint MinimumFileCacheSize, [NativeTypeName("SIZE_T")] nuint MaximumFileCacheSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE CreateFileMappingNumaW(HANDLE hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nndPreferred);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PrefetchVirtualMemory(HANDLE hProcess, [NativeTypeName("ULONG_PTR")] nuint NumberOfEntries, [NativeTypeName("PWIN32_MEMORY_RANGE_ENTRY")] WIN32_MEMORY_RANGE_ENTRY* VirtualAddresses, [NativeTypeName("ULONG")] uint Flags);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE CreateFileMappingFromApp(HANDLE hFile, [NativeTypeName("PSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG64")] ulong MaximumSize, [NativeTypeName("PCWSTR")] ushort* Name);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFileFromApp(HANDLE hFileMappingObject, [NativeTypeName("ULONG")] uint DesiredAccess, [NativeTypeName("ULONG64")] ulong FileOffset, [NativeTypeName("SIZE_T")] nuint NumberOfBytesToMap);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnmapViewOfFileEx([NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG")] uint UnmapFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AllocateUserPhysicalPages(HANDLE hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FreeUserPhysicalPages(HANDLE hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL MapUserPhysicalPages([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("ULONG_PTR")] nuint NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AllocateUserPhysicalPagesNuma(HANDLE hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* VirtualAllocExNuma(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint nndPreferred);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetMemoryErrorHandlingCapabilities([NativeTypeName("PULONG")] uint* Capabilities);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* RegisterBadMemoryNotification([NativeTypeName("PBAD_MEMORY_CALLBACK_ROUTINE")] delegate* unmanaged<void> Callback);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnregisterBadMemoryNotification([NativeTypeName("PVOID")] void* RegistrationHandle);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OfferVirtualMemory([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size, OFFER_PRIORITY Priority);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReclaimVirtualMemory([NativeTypeName("const void *")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DiscardVirtualMemory([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true)]
        public static extern BOOL SetProcessValidCallTargets(HANDLE hProcess, [NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint RegionSize, [NativeTypeName("ULONG")] uint NumberOfOffsets, [NativeTypeName("PCFG_CALL_TARGET_INFO")] CFG_CALL_TARGET_INFO* OffsetInformation);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* VirtualAllocFromApp([NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint Protection);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL VirtualProtectFromApp([NativeTypeName("PVOID")] void* Address, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint NewProtection, [NativeTypeName("PULONG")] uint* OldProtection);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern HANDLE OpenFileMappingFromApp([NativeTypeName("ULONG")] uint DesiredAccess, BOOL InheritHandle, [NativeTypeName("PCWSTR")] ushort* Name);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("api-ms-win-core-memory-l1-1-4", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL QueryVirtualMemoryInformation(HANDLE Process, [NativeTypeName("const void *")] void* VirtualAddress, WIN32_MEMORY_INFORMATION_CLASS MemoryInformationClass, [NativeTypeName("PVOID")] void* MemoryInformation, [NativeTypeName("SIZE_T")] nuint MemoryInformationSize, [NativeTypeName("PSIZE_T")] nuint* ReturnSize);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("api-ms-win-core-memory-l1-1-5", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFileNuma2(HANDLE FileMappingHandle, HANDLE ProcessHandle, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG")] uint PreferredNode);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [return: NativeTypeName("PVOID")]
        public static void* MapViewOfFile2(HANDLE FileMappingHandle, HANDLE ProcessHandle, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection)
        {
            return MapViewOfFileNuma2(FileMappingHandle, ProcessHandle, Offset, BaseAddress, ViewSize, AllocationType, PageProtection, unchecked((uint)(-1)));
        }

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL UnmapViewOfFile2(HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG")] uint UnmapFlags);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* VirtualAlloc2(HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFile3(HANDLE FileMapping, HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* VirtualAlloc2FromApp(HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* MapViewOfFile3FromApp(HANDLE FileMapping, HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [DllImport("kernelbase", ExactSpelling = true)]
        public static extern HANDLE CreateFileMapping2(HANDLE File, SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint DesiredAccess, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG")] uint AllocationAttributes, [NativeTypeName("ULONG64")] ulong MaximumSize, [NativeTypeName("PCWSTR")] ushort* Name, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);

        [NativeTypeName("#define FILE_MAP_WRITE SECTION_MAP_WRITE")]
        public const int FILE_MAP_WRITE = 0x0002;

        [NativeTypeName("#define FILE_MAP_READ SECTION_MAP_READ")]
        public const int FILE_MAP_READ = 0x0004;

        [NativeTypeName("#define FILE_MAP_ALL_ACCESS SECTION_ALL_ACCESS")]
        public const int FILE_MAP_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);

        [NativeTypeName("#define FILE_MAP_EXECUTE SECTION_MAP_EXECUTE_EXPLICIT")]
        public const int FILE_MAP_EXECUTE = 0x0020;

        [NativeTypeName("#define FILE_MAP_COPY 0x00000001")]
        public const int FILE_MAP_COPY = 0x00000001;

        [NativeTypeName("#define FILE_MAP_RESERVE 0x80000000")]
        public const uint FILE_MAP_RESERVE = 0x80000000;

        [NativeTypeName("#define FILE_MAP_TARGETS_INVALID 0x40000000")]
        public const int FILE_MAP_TARGETS_INVALID = 0x40000000;

        [NativeTypeName("#define FILE_MAP_LARGE_PAGES 0x20000000")]
        public const int FILE_MAP_LARGE_PAGES = 0x20000000;

        [NativeTypeName("#define CreateFileMapping CreateFileMappingW")]
        public static delegate*<HANDLE, SECURITY_ATTRIBUTES*, uint, uint, uint, ushort*, HANDLE> CreateFileMapping => &CreateFileMappingW;

        [NativeTypeName("#define OpenFileMapping OpenFileMappingW")]
        public static delegate*<uint, BOOL, ushort*, HANDLE> OpenFileMapping => &OpenFileMappingW;

        [NativeTypeName("#define FILE_CACHE_MAX_HARD_ENABLE 0x00000001")]
        public const int FILE_CACHE_MAX_HARD_ENABLE = 0x00000001;

        [NativeTypeName("#define FILE_CACHE_MAX_HARD_DISABLE 0x00000002")]
        public const int FILE_CACHE_MAX_HARD_DISABLE = 0x00000002;

        [NativeTypeName("#define FILE_CACHE_MIN_HARD_ENABLE 0x00000004")]
        public const int FILE_CACHE_MIN_HARD_ENABLE = 0x00000004;

        [NativeTypeName("#define FILE_CACHE_MIN_HARD_DISABLE 0x00000008")]
        public const int FILE_CACHE_MIN_HARD_DISABLE = 0x00000008;

        [NativeTypeName("#define CreateFileMappingNuma CreateFileMappingNumaW")]
        public static delegate*<HANDLE, SECURITY_ATTRIBUTES*, uint, uint, uint, ushort*, uint, HANDLE> CreateFileMappingNuma => &CreateFileMappingNumaW;

        [NativeTypeName("#define MEHC_PATROL_SCRUBBER_PRESENT 0x1")]
        public const int MEHC_PATROL_SCRUBBER_PRESENT = 0x1;
    }
}
