// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/knownfolders.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref="FOLDERID_NetworkFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_NetworkFolderTest()
    {
        Assert.That(FOLDERID_NetworkFolder, Is.EqualTo(new Guid(0xD20BEEC4, 0x5CA8, 0x4905, 0xAE, 0x3B, 0xBF, 0x25, 0x1E, 0xA0, 0x9B, 0x53)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ComputerFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ComputerFolderTest()
    {
        Assert.That(FOLDERID_ComputerFolder, Is.EqualTo(new Guid(0x0AC0837C, 0xBBF8, 0x452A, 0x85, 0x0D, 0x79, 0xD0, 0x8E, 0x66, 0x7C, 0xA7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_InternetFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_InternetFolderTest()
    {
        Assert.That(FOLDERID_InternetFolder, Is.EqualTo(new Guid(0x4D9F7874, 0x4E0C, 0x4904, 0x96, 0x7B, 0x40, 0xB0, 0xD2, 0x0C, 0x3E, 0x4B)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ControlPanelFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ControlPanelFolderTest()
    {
        Assert.That(FOLDERID_ControlPanelFolder, Is.EqualTo(new Guid(0x82A74AEB, 0xAEB4, 0x465C, 0xA0, 0x14, 0xD0, 0x97, 0xEE, 0x34, 0x6D, 0x63)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PrintersFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PrintersFolderTest()
    {
        Assert.That(FOLDERID_PrintersFolder, Is.EqualTo(new Guid(0x76FC4E2D, 0xD6AD, 0x4519, 0xA6, 0x63, 0x37, 0xBD, 0x56, 0x06, 0x81, 0x85)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SyncManagerFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SyncManagerFolderTest()
    {
        Assert.That(FOLDERID_SyncManagerFolder, Is.EqualTo(new Guid(0x43668BF8, 0xC14E, 0x49B2, 0x97, 0xC9, 0x74, 0x77, 0x84, 0xD7, 0x84, 0xB7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SyncSetupFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SyncSetupFolderTest()
    {
        Assert.That(FOLDERID_SyncSetupFolder, Is.EqualTo(new Guid(0xf214138, 0xb1d3, 0x4a90, 0xbb, 0xa9, 0x27, 0xcb, 0xc0, 0xc5, 0x38, 0x9a)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ConflictFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ConflictFolderTest()
    {
        Assert.That(FOLDERID_ConflictFolder, Is.EqualTo(new Guid(0x4bfefb45, 0x347d, 0x4006, 0xa5, 0xbe, 0xac, 0x0c, 0xb0, 0x56, 0x71, 0x92)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SyncResultsFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SyncResultsFolderTest()
    {
        Assert.That(FOLDERID_SyncResultsFolder, Is.EqualTo(new Guid(0x289a9a43, 0xbe44, 0x4057, 0xa4, 0x1b, 0x58, 0x7a, 0x76, 0xd7, 0xe7, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RecycleBinFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RecycleBinFolderTest()
    {
        Assert.That(FOLDERID_RecycleBinFolder, Is.EqualTo(new Guid(0xB7534046, 0x3ECB, 0x4C18, 0xBE, 0x4E, 0x64, 0xCD, 0x4C, 0xB7, 0xD6, 0xAC)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ConnectionsFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ConnectionsFolderTest()
    {
        Assert.That(FOLDERID_ConnectionsFolder, Is.EqualTo(new Guid(0x6F0CD92B, 0x2E97, 0x45D1, 0x88, 0xFF, 0xB0, 0xD1, 0x86, 0xB8, 0xDE, 0xDD)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Fonts" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_FontsTest()
    {
        Assert.That(FOLDERID_Fonts, Is.EqualTo(new Guid(0xFD228CB7, 0xAE11, 0x4AE3, 0x86, 0x4C, 0x16, 0xF3, 0x91, 0x0A, 0xB8, 0xFE)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Desktop" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DesktopTest()
    {
        Assert.That(FOLDERID_Desktop, Is.EqualTo(new Guid(0xB4BFCC3A, 0xDB2C, 0x424C, 0xB0, 0x29, 0x7F, 0xE9, 0x9A, 0x87, 0xC6, 0x41)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Startup" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_StartupTest()
    {
        Assert.That(FOLDERID_Startup, Is.EqualTo(new Guid(0xB97D20BB, 0xF46A, 0x4C97, 0xBA, 0x10, 0x5E, 0x36, 0x08, 0x43, 0x08, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Programs" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramsTest()
    {
        Assert.That(FOLDERID_Programs, Is.EqualTo(new Guid(0xA77F5D77, 0x2E2B, 0x44C3, 0xA6, 0xA2, 0xAB, 0xA6, 0x01, 0x05, 0x4A, 0x51)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_StartMenu" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_StartMenuTest()
    {
        Assert.That(FOLDERID_StartMenu, Is.EqualTo(new Guid(0x625B53C3, 0xAB48, 0x4EC1, 0xBA, 0x1F, 0xA1, 0xEF, 0x41, 0x46, 0xFC, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Recent" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RecentTest()
    {
        Assert.That(FOLDERID_Recent, Is.EqualTo(new Guid(0xAE50C081, 0xEBD2, 0x438A, 0x86, 0x55, 0x8A, 0x09, 0x2E, 0x34, 0x98, 0x7A)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SendTo" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SendToTest()
    {
        Assert.That(FOLDERID_SendTo, Is.EqualTo(new Guid(0x8983036C, 0x27C0, 0x404B, 0x8F, 0x08, 0x10, 0x2D, 0x10, 0xDC, 0xFD, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Documents" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DocumentsTest()
    {
        Assert.That(FOLDERID_Documents, Is.EqualTo(new Guid(0xFDD39AD0, 0x238F, 0x46AF, 0xAD, 0xB4, 0x6C, 0x85, 0x48, 0x03, 0x69, 0xC7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Favorites" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_FavoritesTest()
    {
        Assert.That(FOLDERID_Favorites, Is.EqualTo(new Guid(0x1777F761, 0x68AD, 0x4D8A, 0x87, 0xBD, 0x30, 0xB7, 0x59, 0xFA, 0x33, 0xDD)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_NetHood" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_NetHoodTest()
    {
        Assert.That(FOLDERID_NetHood, Is.EqualTo(new Guid(0xC5ABBF53, 0xE17F, 0x4121, 0x89, 0x00, 0x86, 0x62, 0x6F, 0xC2, 0xC9, 0x73)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PrintHood" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PrintHoodTest()
    {
        Assert.That(FOLDERID_PrintHood, Is.EqualTo(new Guid(0x9274BD8D, 0xCFD1, 0x41C3, 0xB3, 0x5E, 0xB1, 0x3F, 0x55, 0xA7, 0x58, 0xF4)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Templates" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_TemplatesTest()
    {
        Assert.That(FOLDERID_Templates, Is.EqualTo(new Guid(0xA63293E8, 0x664E, 0x48DB, 0xA0, 0x79, 0xDF, 0x75, 0x9E, 0x05, 0x09, 0xF7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonStartup" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonStartupTest()
    {
        Assert.That(FOLDERID_CommonStartup, Is.EqualTo(new Guid(0x82A5EA35, 0xD9CD, 0x47C5, 0x96, 0x29, 0xE1, 0x5D, 0x2F, 0x71, 0x4E, 0x6E)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonPrograms" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonProgramsTest()
    {
        Assert.That(FOLDERID_CommonPrograms, Is.EqualTo(new Guid(0x0139D44E, 0x6AFE, 0x49F2, 0x86, 0x90, 0x3D, 0xAF, 0xCA, 0xE6, 0xFF, 0xB8)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonStartMenu" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonStartMenuTest()
    {
        Assert.That(FOLDERID_CommonStartMenu, Is.EqualTo(new Guid(0xA4115719, 0xD62E, 0x491D, 0xAA, 0x7C, 0xE7, 0x4B, 0x8B, 0xE3, 0xB0, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicDesktop" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicDesktopTest()
    {
        Assert.That(FOLDERID_PublicDesktop, Is.EqualTo(new Guid(0xC4AA340D, 0xF20F, 0x4863, 0xAF, 0xEF, 0xF8, 0x7E, 0xF2, 0xE6, 0xBA, 0x25)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramData" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramDataTest()
    {
        Assert.That(FOLDERID_ProgramData, Is.EqualTo(new Guid(0x62AB5D82, 0xFDC1, 0x4DC3, 0xA9, 0xDD, 0x07, 0x0D, 0x1D, 0x49, 0x5D, 0x97)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonTemplates" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonTemplatesTest()
    {
        Assert.That(FOLDERID_CommonTemplates, Is.EqualTo(new Guid(0xB94237E7, 0x57AC, 0x4347, 0x91, 0x51, 0xB0, 0x8C, 0x6C, 0x32, 0xD1, 0xF7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicDocuments" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicDocumentsTest()
    {
        Assert.That(FOLDERID_PublicDocuments, Is.EqualTo(new Guid(0xED4824AF, 0xDCE4, 0x45A8, 0x81, 0xE2, 0xFC, 0x79, 0x65, 0x08, 0x36, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RoamingAppData" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RoamingAppDataTest()
    {
        Assert.That(FOLDERID_RoamingAppData, Is.EqualTo(new Guid(0x3EB685DB, 0x65F9, 0x4CF6, 0xA0, 0x3A, 0xE3, 0xEF, 0x65, 0x72, 0x9F, 0x3D)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalAppData" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalAppDataTest()
    {
        Assert.That(FOLDERID_LocalAppData, Is.EqualTo(new Guid(0xF1B32785, 0x6FBA, 0x4FCF, 0x9D, 0x55, 0x7B, 0x8E, 0x7F, 0x15, 0x70, 0x91)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalAppDataLow" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalAppDataLowTest()
    {
        Assert.That(FOLDERID_LocalAppDataLow, Is.EqualTo(new Guid(0xA520A1A4, 0x1780, 0x4FF6, 0xBD, 0x18, 0x16, 0x73, 0x43, 0xC5, 0xAF, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_InternetCache" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_InternetCacheTest()
    {
        Assert.That(FOLDERID_InternetCache, Is.EqualTo(new Guid(0x352481E8, 0x33BE, 0x4251, 0xBA, 0x85, 0x60, 0x07, 0xCA, 0xED, 0xCF, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Cookies" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CookiesTest()
    {
        Assert.That(FOLDERID_Cookies, Is.EqualTo(new Guid(0x2B0F765D, 0xC0E9, 0x4171, 0x90, 0x8E, 0x08, 0xA6, 0x11, 0xB8, 0x4F, 0xF6)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_History" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_HistoryTest()
    {
        Assert.That(FOLDERID_History, Is.EqualTo(new Guid(0xD9DC8A3B, 0xB784, 0x432E, 0xA7, 0x81, 0x5A, 0x11, 0x30, 0xA7, 0x59, 0x63)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_System" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SystemTest()
    {
        Assert.That(FOLDERID_System, Is.EqualTo(new Guid(0x1AC14E77, 0x02E7, 0x4E5D, 0xB7, 0x44, 0x2E, 0xB1, 0xAE, 0x51, 0x98, 0xB7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SystemX86" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SystemX86Test()
    {
        Assert.That(FOLDERID_SystemX86, Is.EqualTo(new Guid(0xD65231B0, 0xB2F1, 0x4857, 0xA4, 0xCE, 0xA8, 0xE7, 0xC6, 0xEA, 0x7D, 0x27)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Windows" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_WindowsTest()
    {
        Assert.That(FOLDERID_Windows, Is.EqualTo(new Guid(0xF38BF404, 0x1D43, 0x42F2, 0x93, 0x05, 0x67, 0xDE, 0x0B, 0x28, 0xFC, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Profile" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProfileTest()
    {
        Assert.That(FOLDERID_Profile, Is.EqualTo(new Guid(0x5E6C858F, 0x0E22, 0x4760, 0x9A, 0xFE, 0xEA, 0x33, 0x17, 0xB6, 0x71, 0x73)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Pictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PicturesTest()
    {
        Assert.That(FOLDERID_Pictures, Is.EqualTo(new Guid(0x33E28130, 0x4E1E, 0x4676, 0x83, 0x5A, 0x98, 0x39, 0x5C, 0x3B, 0xC3, 0xBB)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramFilesX86" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramFilesX86Test()
    {
        Assert.That(FOLDERID_ProgramFilesX86, Is.EqualTo(new Guid(0x7C5A40EF, 0xA0FB, 0x4BFC, 0x87, 0x4A, 0xC0, 0xF2, 0xE0, 0xB9, 0xFA, 0x8E)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramFilesCommonX86" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramFilesCommonX86Test()
    {
        Assert.That(FOLDERID_ProgramFilesCommonX86, Is.EqualTo(new Guid(0xDE974D24, 0xD9C6, 0x4D3E, 0xBF, 0x91, 0xF4, 0x45, 0x51, 0x20, 0xB9, 0x17)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramFilesX64" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramFilesX64Test()
    {
        Assert.That(FOLDERID_ProgramFilesX64, Is.EqualTo(new Guid(0x6d809377, 0x6af0, 0x444b, 0x89, 0x57, 0xa3, 0x77, 0x3f, 0x02, 0x20, 0x0e)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramFilesCommonX64" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramFilesCommonX64Test()
    {
        Assert.That(FOLDERID_ProgramFilesCommonX64, Is.EqualTo(new Guid(0x6365d5a7, 0xf0d, 0x45e5, 0x87, 0xf6, 0xd, 0xa5, 0x6b, 0x6a, 0x4f, 0x7d)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramFiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramFilesTest()
    {
        Assert.That(FOLDERID_ProgramFiles, Is.EqualTo(new Guid(0x905e63b6, 0xc1bf, 0x494e, 0xb2, 0x9c, 0x65, 0xb7, 0x32, 0xd3, 0xd2, 0x1a)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ProgramFilesCommon" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ProgramFilesCommonTest()
    {
        Assert.That(FOLDERID_ProgramFilesCommon, Is.EqualTo(new Guid(0xF7F1ED05, 0x9F6D, 0x47A2, 0xAA, 0xAE, 0x29, 0xD3, 0x17, 0xC6, 0xF0, 0x66)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_UserProgramFiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_UserProgramFilesTest()
    {
        Assert.That(FOLDERID_UserProgramFiles, Is.EqualTo(new Guid(0x5cd7aee2, 0x2219, 0x4a67, 0xb8, 0x5d, 0x6c, 0x9c, 0xe1, 0x56, 0x60, 0xcb)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_UserProgramFilesCommon" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_UserProgramFilesCommonTest()
    {
        Assert.That(FOLDERID_UserProgramFilesCommon, Is.EqualTo(new Guid(0xbcbd3057, 0xca5c, 0x4622, 0xb4, 0x2d, 0xbc, 0x56, 0xdb, 0x0a, 0xe5, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AdminTools" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AdminToolsTest()
    {
        Assert.That(FOLDERID_AdminTools, Is.EqualTo(new Guid(0x724EF170, 0xA42D, 0x4FEF, 0x9F, 0x26, 0xB6, 0x0E, 0x84, 0x6F, 0xBA, 0x4F)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonAdminTools" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonAdminToolsTest()
    {
        Assert.That(FOLDERID_CommonAdminTools, Is.EqualTo(new Guid(0xD0384E7D, 0xBAC3, 0x4797, 0x8F, 0x14, 0xCB, 0xA2, 0x29, 0xB3, 0x92, 0xB5)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Music" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_MusicTest()
    {
        Assert.That(FOLDERID_Music, Is.EqualTo(new Guid(0x4BD8D571, 0x6D19, 0x48D3, 0xBE, 0x97, 0x42, 0x22, 0x20, 0x08, 0x0E, 0x43)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Videos" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_VideosTest()
    {
        Assert.That(FOLDERID_Videos, Is.EqualTo(new Guid(0x18989B1D, 0x99B5, 0x455B, 0x84, 0x1C, 0xAB, 0x7C, 0x74, 0xE4, 0xDD, 0xFC)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Ringtones" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RingtonesTest()
    {
        Assert.That(FOLDERID_Ringtones, Is.EqualTo(new Guid(0xC870044B, 0xF49E, 0x4126, 0xA9, 0xC3, 0xB5, 0x2A, 0x1F, 0xF4, 0x11, 0xE8)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicPictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicPicturesTest()
    {
        Assert.That(FOLDERID_PublicPictures, Is.EqualTo(new Guid(0xB6EBFB86, 0x6907, 0x413C, 0x9A, 0xF7, 0x4F, 0xC2, 0xAB, 0xF0, 0x7C, 0xC5)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicMusic" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicMusicTest()
    {
        Assert.That(FOLDERID_PublicMusic, Is.EqualTo(new Guid(0x3214FAB5, 0x9757, 0x4298, 0xBB, 0x61, 0x92, 0xA9, 0xDE, 0xAA, 0x44, 0xFF)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicVideos" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicVideosTest()
    {
        Assert.That(FOLDERID_PublicVideos, Is.EqualTo(new Guid(0x2400183A, 0x6185, 0x49FB, 0xA2, 0xD8, 0x4A, 0x39, 0x2A, 0x60, 0x2B, 0xA3)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicRingtones" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicRingtonesTest()
    {
        Assert.That(FOLDERID_PublicRingtones, Is.EqualTo(new Guid(0xE555AB60, 0x153B, 0x4D17, 0x9F, 0x04, 0xA5, 0xFE, 0x99, 0xFC, 0x15, 0xEC)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ResourceDir" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ResourceDirTest()
    {
        Assert.That(FOLDERID_ResourceDir, Is.EqualTo(new Guid(0x8AD10C31, 0x2ADB, 0x4296, 0xA8, 0xF7, 0xE4, 0x70, 0x12, 0x32, 0xC9, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalizedResourcesDir" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalizedResourcesDirTest()
    {
        Assert.That(FOLDERID_LocalizedResourcesDir, Is.EqualTo(new Guid(0x2A00375E, 0x224C, 0x49DE, 0xB8, 0xD1, 0x44, 0x0D, 0xF7, 0xEF, 0x3D, 0xDC)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonOEMLinks" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonOEMLinksTest()
    {
        Assert.That(FOLDERID_CommonOEMLinks, Is.EqualTo(new Guid(0xC1BAE2D0, 0x10DF, 0x4334, 0xBE, 0xDD, 0x7A, 0xA2, 0x0B, 0x22, 0x7A, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CDBurning" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CDBurningTest()
    {
        Assert.That(FOLDERID_CDBurning, Is.EqualTo(new Guid(0x9E52AB10, 0xF80D, 0x49DF, 0xAC, 0xB8, 0x43, 0x30, 0xF5, 0x68, 0x78, 0x55)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_UserProfiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_UserProfilesTest()
    {
        Assert.That(FOLDERID_UserProfiles, Is.EqualTo(new Guid(0x0762D272, 0xC50A, 0x4BB0, 0xA3, 0x82, 0x69, 0x7D, 0xCD, 0x72, 0x9B, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Playlists" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PlaylistsTest()
    {
        Assert.That(FOLDERID_Playlists, Is.EqualTo(new Guid(0xDE92C1C7, 0x837F, 0x4F69, 0xA3, 0xBB, 0x86, 0xE6, 0x31, 0x20, 0x4A, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SamplePlaylists" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SamplePlaylistsTest()
    {
        Assert.That(FOLDERID_SamplePlaylists, Is.EqualTo(new Guid(0x15CA69B3, 0x30EE, 0x49C1, 0xAC, 0xE1, 0x6B, 0x5E, 0xC3, 0x72, 0xAF, 0xB5)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SampleMusic" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SampleMusicTest()
    {
        Assert.That(FOLDERID_SampleMusic, Is.EqualTo(new Guid(0xB250C668, 0xF57D, 0x4EE1, 0xA6, 0x3C, 0x29, 0x0E, 0xE7, 0xD1, 0xAA, 0x1F)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SamplePictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SamplePicturesTest()
    {
        Assert.That(FOLDERID_SamplePictures, Is.EqualTo(new Guid(0xC4900540, 0x2379, 0x4C75, 0x84, 0x4B, 0x64, 0xE6, 0xFA, 0xF8, 0x71, 0x6B)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SampleVideos" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SampleVideosTest()
    {
        Assert.That(FOLDERID_SampleVideos, Is.EqualTo(new Guid(0x859EAD94, 0x2E85, 0x48AD, 0xA7, 0x1A, 0x09, 0x69, 0xCB, 0x56, 0xA6, 0xCD)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PhotoAlbums" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PhotoAlbumsTest()
    {
        Assert.That(FOLDERID_PhotoAlbums, Is.EqualTo(new Guid(0x69D2CF90, 0xFC33, 0x4FB7, 0x9A, 0x0C, 0xEB, 0xB0, 0xF0, 0xFC, 0xB4, 0x3C)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Public" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicTest()
    {
        Assert.That(FOLDERID_Public, Is.EqualTo(new Guid(0xDFDF76A2, 0xC82A, 0x4D63, 0x90, 0x6A, 0x56, 0x44, 0xAC, 0x45, 0x73, 0x85)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ChangeRemovePrograms" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ChangeRemoveProgramsTest()
    {
        Assert.That(FOLDERID_ChangeRemovePrograms, Is.EqualTo(new Guid(0xdf7266ac, 0x9274, 0x4867, 0x8d, 0x55, 0x3b, 0xd6, 0x61, 0xde, 0x87, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppUpdates" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppUpdatesTest()
    {
        Assert.That(FOLDERID_AppUpdates, Is.EqualTo(new Guid(0xa305ce99, 0xf527, 0x492b, 0x8b, 0x1a, 0x7e, 0x76, 0xfa, 0x98, 0xd6, 0xe4)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AddNewPrograms" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AddNewProgramsTest()
    {
        Assert.That(FOLDERID_AddNewPrograms, Is.EqualTo(new Guid(0xde61d971, 0x5ebc, 0x4f02, 0xa3, 0xa9, 0x6c, 0x82, 0x89, 0x5e, 0x5c, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Downloads" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DownloadsTest()
    {
        Assert.That(FOLDERID_Downloads, Is.EqualTo(new Guid(0x374de290, 0x123f, 0x4565, 0x91, 0x64, 0x39, 0xc4, 0x92, 0x5e, 0x46, 0x7b)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicDownloads" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicDownloadsTest()
    {
        Assert.That(FOLDERID_PublicDownloads, Is.EqualTo(new Guid(0x3d644c9b, 0x1fb8, 0x4f30, 0x9b, 0x45, 0xf6, 0x70, 0x23, 0x5f, 0x79, 0xc0)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SavedSearches" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SavedSearchesTest()
    {
        Assert.That(FOLDERID_SavedSearches, Is.EqualTo(new Guid(0x7d1d3a04, 0xdebb, 0x4115, 0x95, 0xcf, 0x2f, 0x29, 0xda, 0x29, 0x20, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_QuickLaunch" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_QuickLaunchTest()
    {
        Assert.That(FOLDERID_QuickLaunch, Is.EqualTo(new Guid(0x52a4f021, 0x7b75, 0x48a9, 0x9f, 0x6b, 0x4b, 0x87, 0xa2, 0x10, 0xbc, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Contacts" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ContactsTest()
    {
        Assert.That(FOLDERID_Contacts, Is.EqualTo(new Guid(0x56784854, 0xc6cb, 0x462b, 0x81, 0x69, 0x88, 0xe3, 0x50, 0xac, 0xb8, 0x82)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SidebarParts" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SidebarPartsTest()
    {
        Assert.That(FOLDERID_SidebarParts, Is.EqualTo(new Guid(0xa75d362e, 0x50fc, 0x4fb7, 0xac, 0x2c, 0xa8, 0xbe, 0xaa, 0x31, 0x44, 0x93)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SidebarDefaultParts" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SidebarDefaultPartsTest()
    {
        Assert.That(FOLDERID_SidebarDefaultParts, Is.EqualTo(new Guid(0x7b396e54, 0x9ec5, 0x4300, 0xbe, 0xa, 0x24, 0x82, 0xeb, 0xae, 0x1a, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicGameTasks" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicGameTasksTest()
    {
        Assert.That(FOLDERID_PublicGameTasks, Is.EqualTo(new Guid(0xdebf2536, 0xe1a8, 0x4c59, 0xb6, 0xa2, 0x41, 0x45, 0x86, 0x47, 0x6a, 0xea)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_GameTasks" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_GameTasksTest()
    {
        Assert.That(FOLDERID_GameTasks, Is.EqualTo(new Guid(0x54fae61, 0x4dd8, 0x4787, 0x80, 0xb6, 0x9, 0x2, 0x20, 0xc4, 0xb7, 0x0)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SavedGames" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SavedGamesTest()
    {
        Assert.That(FOLDERID_SavedGames, Is.EqualTo(new Guid(0x4c5c32ff, 0xbb9d, 0x43b0, 0xb5, 0xb4, 0x2d, 0x72, 0xe5, 0x4e, 0xaa, 0xa4)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Games" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_GamesTest()
    {
        Assert.That(FOLDERID_Games, Is.EqualTo(new Guid(0xcac52c1a, 0xb53d, 0x4edc, 0x92, 0xd7, 0x6b, 0x2e, 0x8a, 0xc1, 0x94, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SEARCH_MAPI" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SEARCH_MAPITest()
    {
        Assert.That(FOLDERID_SEARCH_MAPI, Is.EqualTo(new Guid(0x98ec0e18, 0x2098, 0x4d44, 0x86, 0x44, 0x66, 0x97, 0x93, 0x15, 0xa2, 0x81)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SEARCH_CSC" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SEARCH_CSCTest()
    {
        Assert.That(FOLDERID_SEARCH_CSC, Is.EqualTo(new Guid(0xee32e446, 0x31ca, 0x4aba, 0x81, 0x4f, 0xa5, 0xeb, 0xd2, 0xfd, 0x6d, 0x5e)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Links" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LinksTest()
    {
        Assert.That(FOLDERID_Links, Is.EqualTo(new Guid(0xbfb9d5e0, 0xc6a9, 0x404c, 0xb2, 0xb2, 0xae, 0x6d, 0xb6, 0xaf, 0x49, 0x68)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_UsersFiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_UsersFilesTest()
    {
        Assert.That(FOLDERID_UsersFiles, Is.EqualTo(new Guid(0xf3ce0f7c, 0x4901, 0x4acc, 0x86, 0x48, 0xd5, 0xd4, 0x4b, 0x04, 0xef, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_UsersLibraries" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_UsersLibrariesTest()
    {
        Assert.That(FOLDERID_UsersLibraries, Is.EqualTo(new Guid(0xa302545d, 0xdeff, 0x464b, 0xab, 0xe8, 0x61, 0xc8, 0x64, 0x8d, 0x93, 0x9b)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SearchHome" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SearchHomeTest()
    {
        Assert.That(FOLDERID_SearchHome, Is.EqualTo(new Guid(0x190337d1, 0xb8ca, 0x4121, 0xa6, 0x39, 0x6d, 0x47, 0x2d, 0x16, 0x97, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_OriginalImages" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_OriginalImagesTest()
    {
        Assert.That(FOLDERID_OriginalImages, Is.EqualTo(new Guid(0x2C36C0AA, 0x5812, 0x4b87, 0xbf, 0xd0, 0x4c, 0xd0, 0xdf, 0xb1, 0x9b, 0x39)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_DocumentsLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DocumentsLibraryTest()
    {
        Assert.That(FOLDERID_DocumentsLibrary, Is.EqualTo(new Guid(0x7b0db17d, 0x9cd2, 0x4a93, 0x97, 0x33, 0x46, 0xcc, 0x89, 0x02, 0x2e, 0x7c)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_MusicLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_MusicLibraryTest()
    {
        Assert.That(FOLDERID_MusicLibrary, Is.EqualTo(new Guid(0x2112ab0a, 0xc86a, 0x4ffe, 0xa3, 0x68, 0xd, 0xe9, 0x6e, 0x47, 0x1, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PicturesLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PicturesLibraryTest()
    {
        Assert.That(FOLDERID_PicturesLibrary, Is.EqualTo(new Guid(0xa990ae9f, 0xa03b, 0x4e80, 0x94, 0xbc, 0x99, 0x12, 0xd7, 0x50, 0x41, 0x4)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_VideosLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_VideosLibraryTest()
    {
        Assert.That(FOLDERID_VideosLibrary, Is.EqualTo(new Guid(0x491e922f, 0x5643, 0x4af4, 0xa7, 0xeb, 0x4e, 0x7a, 0x13, 0x8d, 0x81, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RecordedTVLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RecordedTVLibraryTest()
    {
        Assert.That(FOLDERID_RecordedTVLibrary, Is.EqualTo(new Guid(0x1a6fdba2, 0xf42d, 0x4358, 0xa7, 0x98, 0xb7, 0x4d, 0x74, 0x59, 0x26, 0xc5)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_HomeGroup" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_HomeGroupTest()
    {
        Assert.That(FOLDERID_HomeGroup, Is.EqualTo(new Guid(0x52528a6b, 0xb9e3, 0x4add, 0xb6, 0xd, 0x58, 0x8c, 0x2d, 0xba, 0x84, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_HomeGroupCurrentUser" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_HomeGroupCurrentUserTest()
    {
        Assert.That(FOLDERID_HomeGroupCurrentUser, Is.EqualTo(new Guid(0x9b74b6a3, 0xdfd, 0x4f11, 0x9e, 0x78, 0x5f, 0x78, 0x0, 0xf2, 0xe7, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_DeviceMetadataStore" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DeviceMetadataStoreTest()
    {
        Assert.That(FOLDERID_DeviceMetadataStore, Is.EqualTo(new Guid(0x5ce4a5e9, 0xe4eb, 0x479d, 0xb8, 0x9f, 0x13, 0x0c, 0x02, 0x88, 0x61, 0x55)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Libraries" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LibrariesTest()
    {
        Assert.That(FOLDERID_Libraries, Is.EqualTo(new Guid(0x1b3ea5dc, 0xb587, 0x4786, 0xb4, 0xef, 0xbd, 0x1d, 0xc3, 0x32, 0xae, 0xae)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicLibraries" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicLibrariesTest()
    {
        Assert.That(FOLDERID_PublicLibraries, Is.EqualTo(new Guid(0x48daf80b, 0xe6cf, 0x4f4e, 0xb8, 0x00, 0x0e, 0x69, 0xd8, 0x4e, 0xe3, 0x84)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_UserPinned" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_UserPinnedTest()
    {
        Assert.That(FOLDERID_UserPinned, Is.EqualTo(new Guid(0x9e3995ab, 0x1f9c, 0x4f13, 0xb8, 0x27, 0x48, 0xb2, 0x4b, 0x6c, 0x71, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ImplicitAppShortcuts" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ImplicitAppShortcutsTest()
    {
        Assert.That(FOLDERID_ImplicitAppShortcuts, Is.EqualTo(new Guid(0xbcb5256f, 0x79f6, 0x4cee, 0xb7, 0x25, 0xdc, 0x34, 0xe4, 0x2, 0xfd, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AccountPictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AccountPicturesTest()
    {
        Assert.That(FOLDERID_AccountPictures, Is.EqualTo(new Guid(0x008ca0b1, 0x55b4, 0x4c56, 0xb8, 0xa8, 0x4d, 0xe4, 0xb2, 0x99, 0xd3, 0xbe)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_PublicUserTiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_PublicUserTilesTest()
    {
        Assert.That(FOLDERID_PublicUserTiles, Is.EqualTo(new Guid(0x0482af6c, 0x08f1, 0x4c34, 0x8c, 0x90, 0xe1, 0x7e, 0xc9, 0x8b, 0x1e, 0x17)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppsFolder" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppsFolderTest()
    {
        Assert.That(FOLDERID_AppsFolder, Is.EqualTo(new Guid(0x1e87508d, 0x89c2, 0x42f0, 0x8a, 0x7e, 0x64, 0x5a, 0x0f, 0x50, 0xca, 0x58)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_StartMenuAllPrograms" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_StartMenuAllProgramsTest()
    {
        Assert.That(FOLDERID_StartMenuAllPrograms, Is.EqualTo(new Guid(0xf26305ef, 0x6948, 0x40b9, 0xb2, 0x55, 0x81, 0x45, 0x3d, 0x9, 0xc7, 0x85)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CommonStartMenuPlaces" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CommonStartMenuPlacesTest()
    {
        Assert.That(FOLDERID_CommonStartMenuPlaces, Is.EqualTo(new Guid(0xa440879f, 0x87a0, 0x4f7d, 0xb7, 0x0, 0x2, 0x7, 0xb9, 0x66, 0x19, 0x4a)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_ApplicationShortcuts" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ApplicationShortcutsTest()
    {
        Assert.That(FOLDERID_ApplicationShortcuts, Is.EqualTo(new Guid(0xa3918781, 0xe5f2, 0x4890, 0xb3, 0xd9, 0xa7, 0xe5, 0x43, 0x32, 0x32, 0x8c)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RoamingTiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RoamingTilesTest()
    {
        Assert.That(FOLDERID_RoamingTiles, Is.EqualTo(new Guid(0xbcfc5a, 0xed94, 0x4e48, 0x96, 0xa1, 0x3f, 0x62, 0x17, 0xf2, 0x19, 0x90)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RoamedTileImages" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RoamedTileImagesTest()
    {
        Assert.That(FOLDERID_RoamedTileImages, Is.EqualTo(new Guid(0xaaa8d5a5, 0xf1d6, 0x4259, 0xba, 0xa8, 0x78, 0xe7, 0xef, 0x60, 0x83, 0x5e)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Screenshots" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_ScreenshotsTest()
    {
        Assert.That(FOLDERID_Screenshots, Is.EqualTo(new Guid(0xb7bede81, 0xdf94, 0x4682, 0xa7, 0xd8, 0x57, 0xa5, 0x26, 0x20, 0xb8, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CameraRoll" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CameraRollTest()
    {
        Assert.That(FOLDERID_CameraRoll, Is.EqualTo(new Guid(0xab5fb87b, 0x7ce2, 0x4f83, 0x91, 0x5d, 0x55, 0x8, 0x46, 0xc9, 0x53, 0x7b)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SkyDrive" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SkyDriveTest()
    {
        Assert.That(FOLDERID_SkyDrive, Is.EqualTo(new Guid(0xa52bba46, 0xe9e1, 0x435f, 0xb3, 0xd9, 0x28, 0xda, 0xa6, 0x48, 0xc0, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_OneDrive" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_OneDriveTest()
    {
        Assert.That(FOLDERID_OneDrive, Is.EqualTo(new Guid(0xa52bba46, 0xe9e1, 0x435f, 0xb3, 0xd9, 0x28, 0xda, 0xa6, 0x48, 0xc0, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SkyDriveDocuments" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SkyDriveDocumentsTest()
    {
        Assert.That(FOLDERID_SkyDriveDocuments, Is.EqualTo(new Guid(0x24d89e24, 0x2f19, 0x4534, 0x9d, 0xde, 0x6a, 0x66, 0x71, 0xfb, 0xb8, 0xfe)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SkyDrivePictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SkyDrivePicturesTest()
    {
        Assert.That(FOLDERID_SkyDrivePictures, Is.EqualTo(new Guid(0x339719b5, 0x8c47, 0x4894, 0x94, 0xc2, 0xd8, 0xf7, 0x7a, 0xdd, 0x44, 0xa6)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SkyDriveMusic" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SkyDriveMusicTest()
    {
        Assert.That(FOLDERID_SkyDriveMusic, Is.EqualTo(new Guid(0xc3f2459e, 0x80d6, 0x45dc, 0xbf, 0xef, 0x1f, 0x76, 0x9f, 0x2b, 0xe7, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SkyDriveCameraRoll" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SkyDriveCameraRollTest()
    {
        Assert.That(FOLDERID_SkyDriveCameraRoll, Is.EqualTo(new Guid(0x767e6811, 0x49cb, 0x4273, 0x87, 0xc2, 0x20, 0xf3, 0x55, 0xe1, 0x08, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SearchHistory" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SearchHistoryTest()
    {
        Assert.That(FOLDERID_SearchHistory, Is.EqualTo(new Guid(0x0d4c3db6, 0x03a3, 0x462f, 0xa0, 0xe6, 0x08, 0x92, 0x4c, 0x41, 0xb5, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SearchTemplates" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SearchTemplatesTest()
    {
        Assert.That(FOLDERID_SearchTemplates, Is.EqualTo(new Guid(0x7e636bfe, 0xdfa9, 0x4d5e, 0xb4, 0x56, 0xd7, 0xb3, 0x98, 0x51, 0xd8, 0xa9)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CameraRollLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CameraRollLibraryTest()
    {
        Assert.That(FOLDERID_CameraRollLibrary, Is.EqualTo(new Guid(0x2b20df75, 0x1eda, 0x4039, 0x80, 0x97, 0x38, 0x79, 0x82, 0x27, 0xd5, 0xb7)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SavedPictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SavedPicturesTest()
    {
        Assert.That(FOLDERID_SavedPictures, Is.EqualTo(new Guid(0x3b193882, 0xd3ad, 0x4eab, 0x96, 0x5a, 0x69, 0x82, 0x9d, 0x1f, 0xb5, 0x9f)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_SavedPicturesLibrary" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_SavedPicturesLibraryTest()
    {
        Assert.That(FOLDERID_SavedPicturesLibrary, Is.EqualTo(new Guid(0xe25b5812, 0xbe88, 0x4bd9, 0x94, 0xb0, 0x29, 0x23, 0x34, 0x77, 0xb6, 0xc3)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RetailDemo" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RetailDemoTest()
    {
        Assert.That(FOLDERID_RetailDemo, Is.EqualTo(new Guid(0x12d4c69e, 0x24ad, 0x4923, 0xbe, 0x19, 0x31, 0x32, 0x1c, 0x43, 0xa7, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Device" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DeviceTest()
    {
        Assert.That(FOLDERID_Device, Is.EqualTo(new Guid(0x1C2AC1DC, 0x4358, 0x4B6C, 0x97, 0x33, 0xAF, 0x21, 0x15, 0x65, 0x76, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_DevelopmentFiles" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_DevelopmentFilesTest()
    {
        Assert.That(FOLDERID_DevelopmentFiles, Is.EqualTo(new Guid(0xdbe8e08e, 0x3053, 0x4bbc, 0xb1, 0x83, 0x2a, 0x7b, 0x2b, 0x19, 0x1e, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_Objects3D" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_Objects3DTest()
    {
        Assert.That(FOLDERID_Objects3D, Is.EqualTo(new Guid(0x31c0dd25, 0x9439, 0x4f12, 0xbf, 0x41, 0x7f, 0xf4, 0xed, 0xa3, 0x87, 0x22)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppCaptures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppCapturesTest()
    {
        Assert.That(FOLDERID_AppCaptures, Is.EqualTo(new Guid(0xedc0fe71, 0x98d8, 0x4f4a, 0xb9, 0x20, 0xc8, 0xdc, 0x13, 0x3c, 0xb1, 0x65)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalDocuments" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalDocumentsTest()
    {
        Assert.That(FOLDERID_LocalDocuments, Is.EqualTo(new Guid(0xf42ee2d3, 0x909f, 0x4907, 0x88, 0x71, 0x4c, 0x22, 0xfc, 0x0b, 0xf7, 0x56)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalPictures" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalPicturesTest()
    {
        Assert.That(FOLDERID_LocalPictures, Is.EqualTo(new Guid(0x0ddd015d, 0xb06c, 0x45d5, 0x8c, 0x4c, 0xf5, 0x97, 0x13, 0x85, 0x46, 0x39)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalVideos" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalVideosTest()
    {
        Assert.That(FOLDERID_LocalVideos, Is.EqualTo(new Guid(0x35286a68, 0x3c57, 0x41a1, 0xbb, 0xb1, 0x0e, 0xae, 0x73, 0xd7, 0x6c, 0x95)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalMusic" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalMusicTest()
    {
        Assert.That(FOLDERID_LocalMusic, Is.EqualTo(new Guid(0xa0c69a99, 0x21c8, 0x4671, 0x87, 0x03, 0x79, 0x34, 0x16, 0x2f, 0xcf, 0x1d)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalDownloads" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalDownloadsTest()
    {
        Assert.That(FOLDERID_LocalDownloads, Is.EqualTo(new Guid(0x7d83ee9b, 0x2244, 0x4e70, 0xb1, 0xf5, 0x53, 0x93, 0x04, 0x2a, 0xf1, 0xe4)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_RecordedCalls" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_RecordedCallsTest()
    {
        Assert.That(FOLDERID_RecordedCalls, Is.EqualTo(new Guid(0x2f8b40c2, 0x83ed, 0x48ee, 0xb3, 0x83, 0xa1, 0xf1, 0x57, 0xec, 0x6f, 0x9a)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AllAppMods" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AllAppModsTest()
    {
        Assert.That(FOLDERID_AllAppMods, Is.EqualTo(new Guid(0x7ad67899, 0x66af, 0x43ba, 0x91, 0x56, 0x6a, 0xad, 0x42, 0xe6, 0xc5, 0x96)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_CurrentAppMods" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_CurrentAppModsTest()
    {
        Assert.That(FOLDERID_CurrentAppMods, Is.EqualTo(new Guid(0x3db40b20, 0x2a30, 0x4dbe, 0x91, 0x7e, 0x77, 0x1d, 0xd2, 0x1d, 0xd0, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppDataDesktop" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppDataDesktopTest()
    {
        Assert.That(FOLDERID_AppDataDesktop, Is.EqualTo(new Guid(0xb2c5e279, 0x7add, 0x439f, 0xb2, 0x8c, 0xc4, 0x1f, 0xe1, 0xbb, 0xf6, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppDataDocuments" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppDataDocumentsTest()
    {
        Assert.That(FOLDERID_AppDataDocuments, Is.EqualTo(new Guid(0x7be16610, 0x1f7f, 0x44ac, 0xbf, 0xf0, 0x83, 0xe1, 0x5f, 0x2f, 0xfc, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppDataFavorites" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppDataFavoritesTest()
    {
        Assert.That(FOLDERID_AppDataFavorites, Is.EqualTo(new Guid(0x7cfbefbc, 0xde1f, 0x45aa, 0xb8, 0x43, 0xa5, 0x42, 0xac, 0x53, 0x6c, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_AppDataProgramData" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_AppDataProgramDataTest()
    {
        Assert.That(FOLDERID_AppDataProgramData, Is.EqualTo(new Guid(0x559d40a3, 0xa036, 0x40fa, 0xaf, 0x61, 0x84, 0xcb, 0x43, 0xa, 0x4d, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref="FOLDERID_LocalStorage" /> property is correct.</summary>
    [Test]
    public static void FOLDERID_LocalStorageTest()
    {
        Assert.That(FOLDERID_LocalStorage, Is.EqualTo(new Guid(0xB3EB08D3, 0xA1F3, 0x496B, 0x86, 0x5A, 0x42, 0xB5, 0x36, 0xCD, 0xA0, 0xEC)));
    }
}
