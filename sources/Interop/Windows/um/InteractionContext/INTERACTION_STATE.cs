// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum INTERACTION_STATE
    {
        INTERACTION_STATE_IDLE = 0x00000000,
        INTERACTION_STATE_IN_INTERACTION = 0x00000001,
        INTERACTION_STATE_POSSIBLE_DOUBLE_TAP = 0x00000002,
        INTERACTION_STATE_MAX = unchecked((int)(0xffffffff)),
    }
}
