// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum INTERACTION_CONFIGURATION_FLAGS
    {
        INTERACTION_CONFIGURATION_FLAG_NONE = 0x00000000,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION = 0x00000001,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_TRANSLATION_X = 0x00000002,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_TRANSLATION_Y = 0x00000004,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_ROTATION = 0x00000008,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_SCALING = 0x00000010,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_TRANSLATION_INERTIA = 0x00000020,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_ROTATION_INERTIA = 0x00000040,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_SCALING_INERTIA = 0x00000080,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_RAILS_X = 0x00000100,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_RAILS_Y = 0x00000200,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_EXACT = 0x00000400,
        INTERACTION_CONFIGURATION_FLAG_MANIPULATION_MULTIPLE_FINGER_PANNING = 0x00000800,
        INTERACTION_CONFIGURATION_FLAG_CROSS_SLIDE = 0x00000001,
        INTERACTION_CONFIGURATION_FLAG_CROSS_SLIDE_HORIZONTAL = 0x00000002,
        INTERACTION_CONFIGURATION_FLAG_CROSS_SLIDE_SELECT = 0x00000004,
        INTERACTION_CONFIGURATION_FLAG_CROSS_SLIDE_SPEED_BUMP = 0x00000008,
        INTERACTION_CONFIGURATION_FLAG_CROSS_SLIDE_REARRANGE = 0x00000010,
        INTERACTION_CONFIGURATION_FLAG_CROSS_SLIDE_EXACT = 0x00000020,
        INTERACTION_CONFIGURATION_FLAG_TAP = 0x00000001,
        INTERACTION_CONFIGURATION_FLAG_TAP_DOUBLE = 0x00000002,
        INTERACTION_CONFIGURATION_FLAG_TAP_MULTIPLE_FINGER = 0x00000004,
        INTERACTION_CONFIGURATION_FLAG_SECONDARY_TAP = 0x00000001,
        INTERACTION_CONFIGURATION_FLAG_HOLD = 0x00000001,
        INTERACTION_CONFIGURATION_FLAG_HOLD_MOUSE = 0x00000002,
        INTERACTION_CONFIGURATION_FLAG_HOLD_MULTIPLE_FINGER = 0x00000004,
        INTERACTION_CONFIGURATION_FLAG_DRAG = 0x00000001,
        INTERACTION_CONFIGURATION_FLAG_MAX = unchecked((int)(0xffffffff)),
    }
}
