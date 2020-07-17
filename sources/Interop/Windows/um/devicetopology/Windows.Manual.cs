// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IAudioAutoGainControl = new Guid(0x85401FD4, 0x6DE4, 0x4B9D, 0x98, 0x69, 0x2D, 0x67, 0x53, 0xA8, 0x2F, 0x3C);

        public static readonly Guid IID_IAudioBass = new Guid(0xA2B1A1D9, 0x4DB3, 0x425D, 0xA2, 0xB2, 0xBD, 0x33, 0x5C, 0xB3, 0xE2, 0xE5);

        public static readonly Guid IID_IAudioChannelConfig = new Guid(0xBB11C46F, 0xEC28, 0x493C, 0xB8, 0x8A, 0x5D, 0xB8, 0x80, 0x62, 0xCE, 0x98);

        public static readonly Guid IID_IAudioInputSelector = new Guid(0x4F03DC02, 0x5E6E, 0x4653, 0x8F, 0x72, 0xA0, 0x30, 0xC1, 0x23, 0xD5, 0x98);
        
        public static readonly Guid IID_IAudioLoudness = new Guid(0x7D8B1437, 0xDD53, 0x4350, 0x9C, 0x1B, 0x1E, 0xE2, 0x89, 0x0B, 0xD9, 0x38);
        
        public static readonly Guid IID_IAudioMidrange = new Guid(0x5E54B6D7, 0xB44B, 0x40D9, 0x9A, 0x9E, 0xE6, 0x91, 0xD9, 0xCE, 0x6E, 0xDF);
        
        public static readonly Guid IID_IAudioMute = new Guid(0xDF45AEEA, 0xB74A, 0x4B6B, 0xAF, 0xAD, 0x23, 0x66, 0xB6, 0xAA, 0x01, 0x2E);
        
        public static readonly Guid IID_IAudioOutputSelector = new Guid(0xBB515F69, 0x94A7, 0x429E, 0x8B, 0x9C, 0x27, 0x1B, 0x3F, 0x11, 0xA3, 0xAB);
        
        public static readonly Guid IID_IAudioPeakMeter = new Guid(0xDD79923C, 0x0599, 0x45E0, 0xB8, 0xB6, 0xC8, 0xDF, 0x7D, 0xB6, 0xE7, 0x96);
        
        public static readonly Guid IID_IAudioTreble = new Guid(0x0A717812, 0x694E, 0x4907, 0xB7, 0x4B, 0xBA, 0xFA, 0x5C, 0xFD, 0xCA, 0x7B);
        
        public static readonly Guid IID_IAudioVolumeLevel = new Guid(0x7FB7B48F, 0x531D, 0x44A2, 0xBC, 0xB3, 0x5A, 0xD5, 0xA1, 0x34, 0xB3, 0xDC);
        
        public static readonly Guid IID_IConnector = new Guid(0x9C2C4058, 0x23F5, 0x41DE, 0x87, 0x7A, 0xDF, 0x3A, 0xF2, 0x36, 0xA0, 0x9E);
        
        public static readonly Guid IID_IControlChangeNotify = new Guid(0xA09513ED, 0xC709, 0x4D21, 0xBD, 0x7B, 0x5F, 0x34, 0xC4, 0x7F, 0x39, 0x47);
        
        public static readonly Guid IID_IControlInterface = new Guid(0x45D37C3F, 0x5140, 0x444A, 0xAE, 0x24, 0x40, 0x07, 0x89, 0xF3, 0xCB, 0xF3);
        
        public static readonly Guid IID_IDeviceSpecificProperty = new Guid(0x3B22BCBF, 0x2586, 0x4AF0, 0x85, 0x83, 0x20, 0x5D, 0x39, 0x1B, 0x80, 0x7C);
        
        public static readonly Guid IID_IDeviceTopology = new Guid(0x2A07407E, 0x6497, 0x4A18, 0x97, 0x87, 0x32, 0xF7, 0x9B, 0xD0, 0xD9, 0x8F);
        
        public static readonly Guid IID_IKsControl = new Guid(0x28F54685, 0x06FD, 0x11D2, 0xB2, 0x7A, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96);
        
        public static readonly Guid IID_IKsFormatSupport = new Guid(0x3CB4A69D, 0xBB6F, 0x4D2B, 0x95, 0xB7, 0x45, 0x2D, 0x2C, 0x15, 0x5D, 0xB5);
        
        public static readonly Guid IID_IKsJackContainerId = new Guid(0xC99AF463, 0xD629, 0x4EC4, 0x8C, 0x00, 0xE5, 0x4D, 0x68, 0x15, 0x42, 0x48);
        
        public static readonly Guid IID_IKsJackDescription = new Guid(0x4509F757, 0x2D46, 0x4637, 0x8E, 0x62, 0xCE, 0x7D, 0xB9, 0x44, 0xF5, 0x7B);
        
        public static readonly Guid IID_IKsJackDescription2 = new Guid(0x478F3A9B, 0xE0C9, 0x4827, 0x92, 0x28, 0x6F, 0x55, 0x05, 0xFF, 0xE7, 0x6A);
        
        public static readonly Guid IID_IKsJackSinkInformation = new Guid(0xD9BD72ED, 0x290F, 0x4581, 0x9F, 0xF3, 0x61, 0x02, 0x7A, 0x8F, 0xE5, 0x32);
        
        public static readonly Guid IID_IPart = new Guid(0xAE2DE0E4, 0x5BCA, 0x4F2D, 0xAA, 0x46, 0x5D, 0x13, 0xF8, 0xFD, 0xB3, 0xA9);
        
        public static readonly Guid IID_IPartsList = new Guid(0x6DAA848C, 0x5EB0, 0x45CC, 0xAE, 0xA5, 0x99, 0x8A, 0x2C, 0xDA, 0x1F, 0xFB);
        
        public static readonly Guid IID_IPerChannelDbLevel = new Guid(0xC2F8E001, 0xF205, 0x4BC9, 0x99, 0xBC, 0xC1, 0x3B, 0x1E, 0x04, 0x8C, 0xCB);
        
        public static readonly Guid IID_ISubunit = new Guid(0x82149A85, 0xDBA6, 0x4487, 0x86, 0xBB, 0xEA, 0x8F, 0x7F, 0xEF, 0xCC, 0x71);
    }
}
