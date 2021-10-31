// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IP_ADAPTER_INFO
    {
        [NativeTypeName("struct _IP_ADAPTER_INFO *")]
        public IP_ADAPTER_INFO* Next;

        [NativeTypeName("DWORD")]
        public uint ComboIndex;

        [NativeTypeName("char [260]")]
        public fixed sbyte AdapterName[260];

        [NativeTypeName("char [132]")]
        public fixed sbyte Description[132];

        public uint AddressLength;

        [NativeTypeName("BYTE [8]")]
        public fixed byte Address[8];

        [NativeTypeName("DWORD")]
        public uint Index;

        public uint Type;

        public uint DhcpEnabled;

        [NativeTypeName("PIP_ADDR_STRING")]
        public IP_ADDR_STRING* CurrentIpAddress;

        public IP_ADDR_STRING IpAddressList;

        public IP_ADDR_STRING GatewayList;

        public IP_ADDR_STRING DhcpServer;

        public BOOL HaveWins;

        public IP_ADDR_STRING PrimaryWinsServer;

        public IP_ADDR_STRING SecondaryWinsServer;

        [NativeTypeName("time_t")]
        public long LeaseObtained;

        [NativeTypeName("time_t")]
        public long LeaseExpires;
    }
}
