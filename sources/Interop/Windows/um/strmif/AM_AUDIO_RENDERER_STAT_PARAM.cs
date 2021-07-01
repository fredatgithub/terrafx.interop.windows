// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AM_AUDIO_RENDERER_STAT_PARAM
    {
        AM_AUDREND_STAT_PARAM_BREAK_COUNT = 1,
        AM_AUDREND_STAT_PARAM_SLAVE_MODE = (AM_AUDREND_STAT_PARAM_BREAK_COUNT + 1),
        AM_AUDREND_STAT_PARAM_SILENCE_DUR = (AM_AUDREND_STAT_PARAM_SLAVE_MODE + 1),
        AM_AUDREND_STAT_PARAM_LAST_BUFFER_DUR = (AM_AUDREND_STAT_PARAM_SILENCE_DUR + 1),
        AM_AUDREND_STAT_PARAM_DISCONTINUITIES = (AM_AUDREND_STAT_PARAM_LAST_BUFFER_DUR + 1),
        AM_AUDREND_STAT_PARAM_SLAVE_RATE = (AM_AUDREND_STAT_PARAM_DISCONTINUITIES + 1),
        AM_AUDREND_STAT_PARAM_SLAVE_DROPWRITE_DUR = (AM_AUDREND_STAT_PARAM_SLAVE_RATE + 1),
        AM_AUDREND_STAT_PARAM_SLAVE_HIGHLOWERROR = (AM_AUDREND_STAT_PARAM_SLAVE_DROPWRITE_DUR + 1),
        AM_AUDREND_STAT_PARAM_SLAVE_LASTHIGHLOWERROR = (AM_AUDREND_STAT_PARAM_SLAVE_HIGHLOWERROR + 1),
        AM_AUDREND_STAT_PARAM_SLAVE_ACCUMERROR = (AM_AUDREND_STAT_PARAM_SLAVE_LASTHIGHLOWERROR + 1),
        AM_AUDREND_STAT_PARAM_BUFFERFULLNESS = (AM_AUDREND_STAT_PARAM_SLAVE_ACCUMERROR + 1),
        AM_AUDREND_STAT_PARAM_JITTER = (AM_AUDREND_STAT_PARAM_BUFFERFULLNESS + 1),
    }
}
