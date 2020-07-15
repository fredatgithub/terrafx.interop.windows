// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "FillConsoleOutputCharacterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("CHAR")] sbyte cCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "FillConsoleOutputCharacterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WCHAR")] ushort cCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "FillConsoleOutputAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WORD")] ushort wAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsWritten);

        [DllImport("kernel32", EntryPoint = "GenerateConsoleCtrlEvent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GenerateConsoleCtrlEvent([NativeTypeName("DWORD")] uint dwCtrlEvent, [NativeTypeName("DWORD")] uint dwProcessGroupId);

        [DllImport("kernel32", EntryPoint = "CreateConsoleScreenBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateConsoleScreenBuffer([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpScreenBufferData);

        [DllImport("kernel32", EntryPoint = "SetConsoleActiveScreenBuffer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleActiveScreenBuffer([NativeTypeName("HANDLE")] IntPtr hConsoleOutput);

        [DllImport("kernel32", EntryPoint = "FlushConsoleInputBuffer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushConsoleInputBuffer([NativeTypeName("HANDLE")] IntPtr hConsoleInput);

        [DllImport("kernel32", EntryPoint = "SetConsoleCP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCP([NativeTypeName("UINT")] uint wCodePageID);

        [DllImport("kernel32", EntryPoint = "SetConsoleOutputCP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleOutputCP([NativeTypeName("UINT")] uint wCodePageID);

        [DllImport("kernel32", EntryPoint = "GetConsoleCursorInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleCursorInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_CURSOR_INFO")] CONSOLE_CURSOR_INFO* lpConsoleCursorInfo);

        [DllImport("kernel32", EntryPoint = "SetConsoleCursorInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCursorInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CONSOLE_CURSOR_INFO *")] CONSOLE_CURSOR_INFO* lpConsoleCursorInfo);

        [DllImport("kernel32", EntryPoint = "GetConsoleScreenBufferInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleScreenBufferInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFO")] CONSOLE_SCREEN_BUFFER_INFO* lpConsoleScreenBufferInfo);

        [DllImport("kernel32", EntryPoint = "GetConsoleScreenBufferInfoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetConsoleScreenBufferInfoEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFOEX")] CONSOLE_SCREEN_BUFFER_INFOEX* lpConsoleScreenBufferInfoEx);

        [DllImport("kernel32", EntryPoint = "SetConsoleScreenBufferInfoEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleScreenBufferInfoEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFOEX")] CONSOLE_SCREEN_BUFFER_INFOEX* lpConsoleScreenBufferInfoEx);

        [DllImport("kernel32", EntryPoint = "SetConsoleScreenBufferSize", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleScreenBufferSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, COORD dwSize);

        [DllImport("kernel32", EntryPoint = "SetConsoleCursorPosition", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleCursorPosition([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, COORD dwCursorPosition);

        [DllImport("kernel32", EntryPoint = "GetLargestConsoleWindowSize", ExactSpelling = true)]
        public static extern COORD GetLargestConsoleWindowSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput);

        [DllImport("kernel32", EntryPoint = "SetConsoleTextAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleTextAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WORD")] ushort wAttributes);

        [DllImport("kernel32", EntryPoint = "SetConsoleWindowInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleWindowInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("BOOL")] int bAbsolute, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpConsoleWindow);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputCharacterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPCSTR")] sbyte* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputCharacterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPCWSTR")] ushort* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const WORD *")] ushort* lpAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsWritten);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputCharacterA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPSTR")] sbyte* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputCharacterW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPWSTR")] ushort* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPWORD")] ushort* lpAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsRead);

        [DllImport("kernel32", EntryPoint = "WriteConsoleInputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("const INPUT_RECORD *")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsWritten);

        [DllImport("kernel32", EntryPoint = "WriteConsoleInputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("const INPUT_RECORD *")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsWritten);

        [DllImport("kernel32", EntryPoint = "ScrollConsoleScreenBufferA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollConsoleScreenBufferA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpScrollRectangle, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpClipRectangle, COORD dwDestinationOrigin, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpFill);

        [DllImport("kernel32", EntryPoint = "ScrollConsoleScreenBufferW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollConsoleScreenBufferW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpScrollRectangle, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpClipRectangle, COORD dwDestinationOrigin, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpFill);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpWriteRegion);

        [DllImport("kernel32", EntryPoint = "WriteConsoleOutputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteConsoleOutputW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpWriteRegion);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCHAR_INFO")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpReadRegion);

        [DllImport("kernel32", EntryPoint = "ReadConsoleOutputW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadConsoleOutputW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCHAR_INFO")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpReadRegion);

        [DllImport("kernel32", EntryPoint = "GetConsoleTitleA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleTitleA([NativeTypeName("LPSTR")] sbyte* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetConsoleTitleW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleTitleW([NativeTypeName("LPWSTR")] ushort* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetConsoleOriginalTitleA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleOriginalTitleA([NativeTypeName("LPSTR")] sbyte* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetConsoleOriginalTitleW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleOriginalTitleW([NativeTypeName("LPWSTR")] ushort* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "SetConsoleTitleA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleTitleA([NativeTypeName("LPCSTR")] sbyte* lpConsoleTitle);

        [DllImport("kernel32", EntryPoint = "SetConsoleTitleW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetConsoleTitleW([NativeTypeName("LPCWSTR")] ushort* lpConsoleTitle);
    }
}
