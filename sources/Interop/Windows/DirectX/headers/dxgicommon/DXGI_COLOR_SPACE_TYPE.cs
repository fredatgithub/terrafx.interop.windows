// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum DXGI_COLOR_SPACE_TYPE
{
    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709"]/*' />
    DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709 = 0,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709"]/*' />
    DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709 = 1,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709"]/*' />
    DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709 = 2,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020"]/*' />
    DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020 = 3,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RESERVED"]/*' />
    DXGI_COLOR_SPACE_RESERVED = 4,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601"]/*' />
    DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601 = 5,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601 = 6,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601"]/*' />
    DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601 = 7,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709 = 8,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709"]/*' />
    DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709 = 9,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020 = 10,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020 = 11,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020"]/*' />
    DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020 = 12,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020 = 13,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020"]/*' />
    DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020 = 14,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020 = 15,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020 = 16,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020"]/*' />
    DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020 = 17,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020 = 18,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020 = 19,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709"]/*' />
    DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709 = 20,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020"]/*' />
    DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020 = 21,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709 = 22,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020 = 23,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020"]/*' />
    DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020 = 24,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_CUSTOM"]/*' />
    DXGI_COLOR_SPACE_CUSTOM = unchecked((int)(0xFFFFFFFF)),
}
