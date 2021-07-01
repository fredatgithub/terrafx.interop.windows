// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_SVG_PATH_COMMAND : uint
    {
        D2D1_SVG_PATH_COMMAND_CLOSE_PATH = 0,
        D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE = 1,
        D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE = 2,
        D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE = 3,
        D2D1_SVG_PATH_COMMAND_LINE_RELATIVE = 4,
        D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE = 5,
        D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE = 6,
        D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE = 7,
        D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE = 8,
        D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE = 9,
        D2D1_SVG_PATH_COMMAND_ARC_RELATIVE = 10,
        D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE = 11,
        D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE = 12,
        D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE = 13,
        D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE = 14,
        D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE = 15,
        D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE = 16,
        D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE = 17,
        D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE = 18,
        D2D1_SVG_PATH_COMMAND_FORCE_DWORD = 0xffffffff,
    }
}
