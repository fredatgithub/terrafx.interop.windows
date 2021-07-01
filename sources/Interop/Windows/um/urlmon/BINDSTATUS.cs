// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum BINDSTATUS
    {
        BINDSTATUS_FINDINGRESOURCE = 1,
        BINDSTATUS_CONNECTING = (BINDSTATUS_FINDINGRESOURCE + 1),
        BINDSTATUS_REDIRECTING = (BINDSTATUS_CONNECTING + 1),
        BINDSTATUS_BEGINDOWNLOADDATA = (BINDSTATUS_REDIRECTING + 1),
        BINDSTATUS_DOWNLOADINGDATA = (BINDSTATUS_BEGINDOWNLOADDATA + 1),
        BINDSTATUS_ENDDOWNLOADDATA = (BINDSTATUS_DOWNLOADINGDATA + 1),
        BINDSTATUS_BEGINDOWNLOADCOMPONENTS = (BINDSTATUS_ENDDOWNLOADDATA + 1),
        BINDSTATUS_INSTALLINGCOMPONENTS = (BINDSTATUS_BEGINDOWNLOADCOMPONENTS + 1),
        BINDSTATUS_ENDDOWNLOADCOMPONENTS = (BINDSTATUS_INSTALLINGCOMPONENTS + 1),
        BINDSTATUS_USINGCACHEDCOPY = (BINDSTATUS_ENDDOWNLOADCOMPONENTS + 1),
        BINDSTATUS_SENDINGREQUEST = (BINDSTATUS_USINGCACHEDCOPY + 1),
        BINDSTATUS_CLASSIDAVAILABLE = (BINDSTATUS_SENDINGREQUEST + 1),
        BINDSTATUS_MIMETYPEAVAILABLE = (BINDSTATUS_CLASSIDAVAILABLE + 1),
        BINDSTATUS_CACHEFILENAMEAVAILABLE = (BINDSTATUS_MIMETYPEAVAILABLE + 1),
        BINDSTATUS_BEGINSYNCOPERATION = (BINDSTATUS_CACHEFILENAMEAVAILABLE + 1),
        BINDSTATUS_ENDSYNCOPERATION = (BINDSTATUS_BEGINSYNCOPERATION + 1),
        BINDSTATUS_BEGINUPLOADDATA = (BINDSTATUS_ENDSYNCOPERATION + 1),
        BINDSTATUS_UPLOADINGDATA = (BINDSTATUS_BEGINUPLOADDATA + 1),
        BINDSTATUS_ENDUPLOADDATA = (BINDSTATUS_UPLOADINGDATA + 1),
        BINDSTATUS_PROTOCOLCLASSID = (BINDSTATUS_ENDUPLOADDATA + 1),
        BINDSTATUS_ENCODING = (BINDSTATUS_PROTOCOLCLASSID + 1),
        BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE = (BINDSTATUS_ENCODING + 1),
        BINDSTATUS_CLASSINSTALLLOCATION = (BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE + 1),
        BINDSTATUS_DECODING = (BINDSTATUS_CLASSINSTALLLOCATION + 1),
        BINDSTATUS_LOADINGMIMEHANDLER = (BINDSTATUS_DECODING + 1),
        BINDSTATUS_CONTENTDISPOSITIONATTACH = (BINDSTATUS_LOADINGMIMEHANDLER + 1),
        BINDSTATUS_FILTERREPORTMIMETYPE = (BINDSTATUS_CONTENTDISPOSITIONATTACH + 1),
        BINDSTATUS_CLSIDCANINSTANTIATE = (BINDSTATUS_FILTERREPORTMIMETYPE + 1),
        BINDSTATUS_IUNKNOWNAVAILABLE = (BINDSTATUS_CLSIDCANINSTANTIATE + 1),
        BINDSTATUS_DIRECTBIND = (BINDSTATUS_IUNKNOWNAVAILABLE + 1),
        BINDSTATUS_RAWMIMETYPE = (BINDSTATUS_DIRECTBIND + 1),
        BINDSTATUS_PROXYDETECTING = (BINDSTATUS_RAWMIMETYPE + 1),
        BINDSTATUS_ACCEPTRANGES = (BINDSTATUS_PROXYDETECTING + 1),
        BINDSTATUS_COOKIE_SENT = (BINDSTATUS_ACCEPTRANGES + 1),
        BINDSTATUS_COMPACT_POLICY_RECEIVED = (BINDSTATUS_COOKIE_SENT + 1),
        BINDSTATUS_COOKIE_SUPPRESSED = (BINDSTATUS_COMPACT_POLICY_RECEIVED + 1),
        BINDSTATUS_COOKIE_STATE_UNKNOWN = (BINDSTATUS_COOKIE_SUPPRESSED + 1),
        BINDSTATUS_COOKIE_STATE_ACCEPT = (BINDSTATUS_COOKIE_STATE_UNKNOWN + 1),
        BINDSTATUS_COOKIE_STATE_REJECT = (BINDSTATUS_COOKIE_STATE_ACCEPT + 1),
        BINDSTATUS_COOKIE_STATE_PROMPT = (BINDSTATUS_COOKIE_STATE_REJECT + 1),
        BINDSTATUS_COOKIE_STATE_LEASH = (BINDSTATUS_COOKIE_STATE_PROMPT + 1),
        BINDSTATUS_COOKIE_STATE_DOWNGRADE = (BINDSTATUS_COOKIE_STATE_LEASH + 1),
        BINDSTATUS_POLICY_HREF = (BINDSTATUS_COOKIE_STATE_DOWNGRADE + 1),
        BINDSTATUS_P3P_HEADER = (BINDSTATUS_POLICY_HREF + 1),
        BINDSTATUS_SESSION_COOKIE_RECEIVED = (BINDSTATUS_P3P_HEADER + 1),
        BINDSTATUS_PERSISTENT_COOKIE_RECEIVED = (BINDSTATUS_SESSION_COOKIE_RECEIVED + 1),
        BINDSTATUS_SESSION_COOKIES_ALLOWED = (BINDSTATUS_PERSISTENT_COOKIE_RECEIVED + 1),
        BINDSTATUS_CACHECONTROL = (BINDSTATUS_SESSION_COOKIES_ALLOWED + 1),
        BINDSTATUS_CONTENTDISPOSITIONFILENAME = (BINDSTATUS_CACHECONTROL + 1),
        BINDSTATUS_MIMETEXTPLAINMISMATCH = (BINDSTATUS_CONTENTDISPOSITIONFILENAME + 1),
        BINDSTATUS_PUBLISHERAVAILABLE = (BINDSTATUS_MIMETEXTPLAINMISMATCH + 1),
        BINDSTATUS_DISPLAYNAMEAVAILABLE = (BINDSTATUS_PUBLISHERAVAILABLE + 1),
        BINDSTATUS_SSLUX_NAVBLOCKED = (BINDSTATUS_DISPLAYNAMEAVAILABLE + 1),
        BINDSTATUS_SERVER_MIMETYPEAVAILABLE = (BINDSTATUS_SSLUX_NAVBLOCKED + 1),
        BINDSTATUS_SNIFFED_CLASSIDAVAILABLE = (BINDSTATUS_SERVER_MIMETYPEAVAILABLE + 1),
        BINDSTATUS_64BIT_PROGRESS = (BINDSTATUS_SNIFFED_CLASSIDAVAILABLE + 1),
        BINDSTATUS_LAST = BINDSTATUS_64BIT_PROGRESS,
        BINDSTATUS_RESERVED_0 = (BINDSTATUS_LAST + 1),
        BINDSTATUS_RESERVED_1 = (BINDSTATUS_RESERVED_0 + 1),
        BINDSTATUS_RESERVED_2 = (BINDSTATUS_RESERVED_1 + 1),
        BINDSTATUS_RESERVED_3 = (BINDSTATUS_RESERVED_2 + 1),
        BINDSTATUS_RESERVED_4 = (BINDSTATUS_RESERVED_3 + 1),
        BINDSTATUS_RESERVED_5 = (BINDSTATUS_RESERVED_4 + 1),
        BINDSTATUS_RESERVED_6 = (BINDSTATUS_RESERVED_5 + 1),
        BINDSTATUS_RESERVED_7 = (BINDSTATUS_RESERVED_6 + 1),
        BINDSTATUS_RESERVED_8 = (BINDSTATUS_RESERVED_7 + 1),
        BINDSTATUS_RESERVED_9 = (BINDSTATUS_RESERVED_8 + 1),
        BINDSTATUS_RESERVED_A = (BINDSTATUS_RESERVED_9 + 1),
        BINDSTATUS_RESERVED_B = (BINDSTATUS_RESERVED_A + 1),
        BINDSTATUS_RESERVED_C = (BINDSTATUS_RESERVED_B + 1),
        BINDSTATUS_RESERVED_D = (BINDSTATUS_RESERVED_C + 1),
        BINDSTATUS_RESERVED_E = (BINDSTATUS_RESERVED_D + 1),
        BINDSTATUS_RESERVED_F = (BINDSTATUS_RESERVED_E + 1),
        BINDSTATUS_RESERVED_10 = (BINDSTATUS_RESERVED_F + 1),
        BINDSTATUS_RESERVED_11 = (BINDSTATUS_RESERVED_10 + 1),
        BINDSTATUS_RESERVED_12 = (BINDSTATUS_RESERVED_11 + 1),
        BINDSTATUS_RESERVED_13 = (BINDSTATUS_RESERVED_12 + 1),
        BINDSTATUS_LAST_PRIVATE = BINDSTATUS_RESERVED_13,
    }
}
