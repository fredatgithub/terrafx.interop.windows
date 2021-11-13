// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msiltcfg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [DllImport("msiltcfg", ExactSpelling = true)]
        public static extern uint ShutdownMsi([NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("msiltcfg", ExactSpelling = true)]
        public static extern uint RestartMsi([NativeTypeName("DWORD")] uint dwReserved);
    }
}
