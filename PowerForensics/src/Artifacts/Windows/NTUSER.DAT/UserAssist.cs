﻿using System;
using System.Collections.Generic;
using PowerForensics.Registry;
using PowerForensics.Utilities;

namespace PowerForensics.Artifacts
{
    #region UserAssistClass

    public class UserAssist
    {
        #region Enums

        private static string Decode(string Path)
        {
            Path = Rot13.Transform(Path);

            Path = Path.Replace("{de61d971-5ebc-4f02-a3a9-6c82895e5c04}", @"Add or Remove Programs (Control Panel)");
            Path = Path.Replace("{F38BF404-1D43-42F2-9305-67DE0B28FC23}", @"%windir%");
            Path = Path.Replace("{9E3995AB-1F9C-4F13-B827-48B24B6C7174}", @"%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned");
            Path = Path.Replace("{724EF170-A42D-4FEF-9F26-B60E846FBA4F}", @"%APPDATA%\Microsoft\Windows\Start Menu\Programs\Administrative Tools");
            Path = Path.Replace("{a305ce99-f527-492b-8b1a-7e76fa98d6e4}", @"Installed Updates");
            Path = Path.Replace("{9E52AB10-F80D-49DF-ACB8-4330F5687855}", @"%LOCALAPPDATA%\Microsoft\Windows\Burn\Burn");
            Path = Path.Replace("{df7266ac-9274-4867-8d55-3bd661de872d}", @"Programs and Features");
            Path = Path.Replace("{D0384E7D-BAC3-4797-8F14-CBA229B392B5}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Administrative Tools");
            Path = Path.Replace("{C1BAE2D0-10DF-4334-BEDD-7AA20B227A9D}", @"%ALLUSERSPROFILE%\OEM Links");
            Path = Path.Replace("{0139D44E-6AFE-49F2-8690-3DAFCAE6FFB8}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs");
            Path = Path.Replace("{A4115719-D62E-491D-AA7C-E74B8BE3B067}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu");
            Path = Path.Replace("{82A5EA35-D9CD-47C5-9629-E15D2F714E6E}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\StartUp");
            Path = Path.Replace("{B94237E7-57AC-4347-9151-B08C6C32D1F7}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Templates");
            Path = Path.Replace("{0AC0837C-BBF8-452A-850D-79D08E667CA7}", @"(My) Computer");
            Path = Path.Replace("{4bfefb45-347d-4006-a5be-ac0cb0567192}", @"Conflicts");
            Path = Path.Replace("{6F0CD92B-2E97-45D1-88FF-B0D186B8DEDD}", @"Network Connections");
            Path = Path.Replace("{56784854-C6CB-462b-8169-88E350ACB882}", @"%USERPROFILE%\Contacts");
            Path = Path.Replace("{82A74AEB-AEB4-465C-A014-D097EE346D63}", @"Control Panel");
            Path = Path.Replace("{2B0F765D-C0E9-4171-908E-08A611B84FF6}", @"%APPDATA%\Microsoft\Windows\Cookies");
            Path = Path.Replace("{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", @"Desktop");
            Path = Path.Replace("{5CE4A5E9-E4EB-479D-B89F-130C02886155}", @"%ALLUSERSPROFILE%\Microsoft\Windows\DeviceMetadataStore");
            Path = Path.Replace("{7B0DB17D-9CD2-4A93-9733-46CC89022E7C}", @"%APPDATA%\Microsoft\Windows\Libraries\Documents.library-ms");
            Path = Path.Replace("{374DE290-123F-4565-9164-39C4925E467B}", @"%USERPROFILE%\Downloads");
            Path = Path.Replace("{1777F761-68AD-4D8A-87BD-30B759FA33DD}", @"%USERPROFILE%\Favorites");
            Path = Path.Replace("{FD228CB7-AE11-4AE3-864C-16F3910AB8FE}", @"%windir%\Fonts");
            Path = Path.Replace("{CAC52C1A-B53D-4edc-92D7-6B2E8AC19434}", @"Games");
            Path = Path.Replace("{054FAE61-4DD8-4787-80B6-090220C4B700}", @"GameExplorer");
            Path = Path.Replace("{D9DC8A3B-B784-432E-A781-5A1130A75963}", @"%LOCALAPPDATA%\Microsoft\Windows\History");
            Path = Path.Replace("{52528A6B-B9E3-4ADD-B60D-588C2DBA842D}", @"Homegroup");
            Path = Path.Replace("{BCB5256F-79F6-4CEE-B725-DC34E402FD46}", @"%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned\ImplicitAppShortcuts");
            Path = Path.Replace("{352481E8-33BE-4251-BA85-6007CAEDCF9D}", @"%LOCALAPPDATA%\Microsoft\Windows\Temporary Internet Files");
            Path = Path.Replace("{4D9F7874-4E0C-4904-967B-40B0D20C3E4B}", @"The Internet");
            Path = Path.Replace("{1B3EA5DC-B587-4786-B4EF-BD1DC332AEAE}", @"%APPDATA%\Microsoft\Windows\Libraries");
            Path = Path.Replace("{bfb9d5e0-c6a9-404c-b2b2-ae6db6af4968}", @"%USERPROFILE%\Links");
            Path = Path.Replace("{F1B32785-6FBA-4FCF-9D55-7B8E7F157091}", @"%LOCALAPPDATA% (%USERPROFILE%\AppData\Local)");
            Path = Path.Replace("{A520A1A4-1780-4FF6-BD18-167343C5AF16}", @"%USERPROFILE%\AppData\LocalLow");
            Path = Path.Replace("{2A00375E-224C-49DE-B8D1-440DF7EF3DDC}", @"%windir%\resources\0409 (code page)");
            Path = Path.Replace("{4BD8D571-6D19-48D3-BE97-422220080E43}", @"%USERPROFILE%\Music");
            Path = Path.Replace("{2112AB0A-C86A-4FFE-A368-0DE96E47012E}", @"%APPDATA%\Microsoft\Windows\Libraries\Music.library-ms");
            Path = Path.Replace("{C5ABBF53-E17F-4121-8900-86626FC2C973}", @"%APPDATA%\Microsoft\Windows\Network Shortcuts");
            Path = Path.Replace("{D20BEEC4-5CA8-4905-AE3B-BF251EA09B53}", @"Network");
            Path = Path.Replace("{2C36C0AA-5812-4b87-BFD0-4CD0DFB19B39}", @"%LOCALAPPDATA%\Microsoft\Windows Photo Gallery\Original Images");
            Path = Path.Replace("{69D2CF90-FC33-4FB7-9A0C-EBB0F0FCB43C}", @"%USERPROFILE%\Pictures\Slide Shows");
            Path = Path.Replace("{A990AE9F-A03B-4E80-94BC-9912D7504104}", @"%APPDATA%\Microsoft\Windows\Libraries\Pictures.library-ms");
            Path = Path.Replace("{33E28130-4E1E-4676-835A-98395C3BC3BB}", @"%USERPROFILE%\Pictures");
            Path = Path.Replace("{DE92C1C7-837F-4F69-A3BB-86E631204A23}", @"%USERPROFILE%\Music\Playlists");
            Path = Path.Replace("{76FC4E2D-D6AD-4519-A663-37BD56068185}", @"Printers");
            Path = Path.Replace("{9274BD8D-CFD1-41C3-B35E-B13F55A758F4}", @"%APPDATA%\Microsoft\Windows\Printer Shortcuts");
            Path = Path.Replace("{5E6C858F-0E22-4760-9AFE-EA3317B67173}", @"%USERPROFILE% (%SystemDrive%\Users\%USERNAME%)");
            Path = Path.Replace("{62AB5D82-FDC1-4DC3-A9DD-070D1D495D97}", @"%ALLUSERSPROFILE% (%ProgramData%, %SystemDrive%\ProgramData)");
            Path = Path.Replace("{905e63b6-c1bf-494e-b29c-65b732d3d21a}", @"%ProgramFiles%");
            Path = Path.Replace("{6D809377-6AF0-444b-8957-A3773F02200E}", @"%ProgramFiles%");
            Path = Path.Replace("{7C5A40EF-A0FB-4BFC-874A-C0F2E0B9FA8E}", @"%ProgramFiles%");
            Path = Path.Replace("{F7F1ED05-9F6D-47A2-AAAE-29D317C6F066}", @"%ProgramFiles%\Common Files");
            Path = Path.Replace("{6365D5A7-0F0D-45E5-87F6-0DA56B6A4F7D}", @"%ProgramFiles%\Common Files");
            Path = Path.Replace("{DE974D24-D9C6-4D3E-BF91-F4455120B917}", @"%ProgramFiles%\Common Files");
            Path = Path.Replace("{A77F5D77-2E2B-44C3-A6A2-ABA601054A51}", @"%APPDATA%\Microsoft\Windows\Start Menu\Programs");
            Path = Path.Replace("{DFDF76A2-C82A-4D63-906A-5644AC457385}", @"%PUBLIC% (%SystemDrive%\Users\Public)");
            Path = Path.Replace("{C4AA340D-F20F-4863-AFEF-F87EF2E6BA25}", @"%PUBLIC%\Desktop");
            Path = Path.Replace("{ED4824AF-DCE4-45A8-81E2-FC7965083634}", @"%PUBLIC%\Documents");
            Path = Path.Replace("{3D644C9B-1FB8-4f30-9B45-F670235F79C0}", @"%PUBLIC%\Downloads");
            Path = Path.Replace("{DEBF2536-E1A8-4c59-B6A2-414586476AEA}", @"%ALLUSERSPROFILE%\Microsoft\Windows\GameExplorer");
            Path = Path.Replace("{48DAF80B-E6CF-4F4E-B800-0E69D84EE384}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Libraries");
            Path = Path.Replace("{3214FAB5-9757-4298-BB61-92A9DEAA44FF}", @"%PUBLIC%\Music");
            Path = Path.Replace("{B6EBFB86-6907-413C-9AF7-4FC2ABF07CC5}", @"%PUBLIC%\Pictures");
            Path = Path.Replace("{E555AB60-153B-4D17-9F04-A5FE99FC15EC}", @"%ALLUSERSPROFILE%\Microsoft\Windows\Ringtones");
            Path = Path.Replace("{2400183A-6185-49FB-A2D8-4A392A602BA3}", @"%PUBLIC%\Videos");
            Path = Path.Replace("{52a4f021-7b75-48a9-9f6b-4b87a210bc8f}", @"%APPDATA%\Microsoft\Internet Explorer\Quick Launch");
            Path = Path.Replace("{AE50C081-EBD2-438A-8655-8A092E34987A}", @"%APPDATA%\Microsoft\Windows\Recent");
            Path = Path.Replace("{1A6FDBA2-F42D-4358-A798-B74D745926C5}", @"%PUBLIC%\RecordedTV.library-ms");
            Path = Path.Replace("{B7534046-3ECB-4C18-BE4E-64CD4CB7D6AC}", @"Recycle Bin");
            Path = Path.Replace("{8AD10C31-2ADB-4296-A8F7-E4701232C972}", @"%windir%\Resources");
            Path = Path.Replace("{C870044B-F49E-4126-A9C3-B52A1FF411E8}", @"%LOCALAPPDATA%\Microsoft\Windows\Ringtones");
            Path = Path.Replace("{3EB685DB-65F9-4CF6-A03A-E3EF65729F3D}", @"%APPDATA% (%USERPROFILE%\AppData\Roaming)");
            Path = Path.Replace("{B250C668-F57D-4EE1-A63C-290EE7D1AA1F}", @"%PUBLIC%\Music\Sample Music");
            Path = Path.Replace("{C4900540-2379-4C75-844B-64E6FAF8716B}", @"%PUBLIC%\Pictures\Sample Pictures");
            Path = Path.Replace("{15CA69B3-30EE-49C1-ACE1-6B5EC372AFB5}", @"%PUBLIC%\Music\Sample Playlists");
            Path = Path.Replace("{859EAD94-2E85-48AD-A71A-0969CB56A6CD}", @"%PUBLIC%\Videos\Sample Videos");
            Path = Path.Replace("{4C5C32FF-BB9D-43b0-B5B4-2D72E54EAAA4}", @"%USERPROFILE%\Saved Games");
            Path = Path.Replace("{7d1d3a04-debb-4115-95cf-2f29da2920da}", @"%USERPROFILE%\Searches");
            Path = Path.Replace("{ee32e446-31ca-4aba-814f-a5ebd2fd6d5e}", @"Offline Files");
            Path = Path.Replace("{98ec0e18-2098-4d44-8644-66979315a281}", @"Microsoft Office Outlook");
            Path = Path.Replace("{190337d1-b8ca-4121-a639-6d472d16972a}", @"Search Results");
            Path = Path.Replace("{8983036C-27C0-404B-8F08-102D10DCFD74}", @"%APPDATA%\Microsoft\Windows\SendTo");
            Path = Path.Replace("{7B396E54-9EC5-4300-BE0A-2482EBAE1A26}", @"%ProgramFiles%\Windows Sidebar\Gadgets");
            Path = Path.Replace("{A75D362E-50FC-4fb7-AC2C-A8BEAA314493}", @"%LOCALAPPDATA%\Microsoft\Windows Sidebar\Gadgets");
            Path = Path.Replace("{625B53C3-AB48-4EC1-BA1F-A1EF4146FC19}", @"%APPDATA%\Microsoft\Windows\Start Menu");
            Path = Path.Replace("{B97D20BB-F46A-4C97-BA10-5E3608430854}", @"%APPDATA%\Microsoft\Windows\Start Menu\Programs\StartUp");
            Path = Path.Replace("{43668BF8-C14E-49B2-97C9-747784D784B7}", @"Sync Center");
            Path = Path.Replace("{289a9a43-be44-4057-a41b-587a76d7e7f9}", @"Sync Results");
            Path = Path.Replace("{0F214138-B1D3-4a90-BBA9-27CBC0C5389A}", @"Sync Setup");
            Path = Path.Replace("{1AC14E77-02E7-4E5D-B744-2EB1AE5198B7}", @"%windir%\system32");
            Path = Path.Replace("{D65231B0-B2F1-4857-A4CE-A8E7C6EA7D27}", @"%windir%\system32");
            Path = Path.Replace("{A63293E8-664E-48DB-A079-DF759E0509F7}", @"%APPDATA%\Microsoft\Windows\Templates");
            Path = Path.Replace("{0762D272-C50A-4BB0-A382-697DCD729B80}", @"%SystemDrive%\Users");
            Path = Path.Replace("{5CD7AEE2-2219-4A67-B85D-6C9CE15660CB}", @"%LOCALAPPDATA%\Programs");
            Path = Path.Replace("{BCBD3057-CA5C-4622-B42D-BC56DB0AE516}", @"%LOCALAPPDATA%\Programs\Common");
            Path = Path.Replace("{f3ce0f7c-4901-4acc-8648-d5d44b04ef8f}", @"The user's full name");
            Path = Path.Replace("{A302545D-DEFF-464b-ABE8-61C8648D939B}", @"Libraries");
            Path = Path.Replace("{18989B1D-99B5-455B-841C-AB7C74E4DDFC}", @"%USERPROFILE%\Videos");
            Path = Path.Replace("{491E922F-5643-4AF4-A7EB-4E7A138D8174}", @"%APPDATA%\Microsoft\Windows\Libraries\Videos.library-ms");
            return Path;
        }

        #endregion Enums

        #region Properties

        public readonly string Path;
        public readonly uint RunCount;
        public readonly uint FocusTime;
        public readonly DateTime LastExecutionTimeUtc;

        #endregion Properties

        #region Constructors

        internal UserAssist(ValueKey vk, byte[] bytes)
        {
            Path = Decode(vk.Name);

            byte[] data = vk.GetData(bytes);

            RunCount = BitConverter.ToUInt32(data, 0x04);
            FocusTime = BitConverter.ToUInt32(data, 0x0C);            
            LastExecutionTimeUtc = DateTime.FromFileTimeUtc(BitConverter.ToInt64(data, 0x03C));
        }

        #endregion Constructors

        #region StaticMethods

        public static UserAssist[] GetInstances(string hivePath)
        {
            if (RegistryHeader.Get(hivePath).HivePath.ToUpper().Contains("NTUSER.DAT"))
            {
                List<UserAssist> uaList = new List<UserAssist>();

                string Key = @"Software\Microsoft\Windows\CurrentVersion\Explorer\UserAssist";

                byte[] bytes = Registry.Helper.GetHiveBytes(hivePath);

                NamedKey[] FileSubKey = NamedKey.GetInstances(bytes, hivePath, Key);

                foreach (NamedKey key in FileSubKey)
                {
                    foreach (NamedKey nk in key.GetSubKeys(bytes, key.FullName))
                    {
                        if (nk.NumberOfValues != 0)
                        {
                            foreach (ValueKey vk in nk.GetValues(bytes))
                            {
                                uaList.Add(new UserAssist(vk, bytes));
                            }
                        }
                    }
                }
                return uaList.ToArray();
            }
            else
            {
                throw new Exception("Invalid NTUSER.DAT hive provided to -HivePath parameter.");
            }
        }

        #endregion StaticMethods

        public override string ToString()
        {
            return String.Format("[PROGRAM EXECUTION] {0} run {1} times", this.Path, this.RunCount);
        }
    }

    #endregion UserAssistClass
}
