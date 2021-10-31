// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct s_RIFFWAVE_inst
    {
        public byte bUnshiftedNote;

        [NativeTypeName("char")]
        public sbyte chFineTune;

        [NativeTypeName("char")]
        public sbyte chGain;

        public byte bLowNote;

        public byte bHighNote;

        public byte bLowVelocity;

        public byte bHighVelocity;
    }
}
