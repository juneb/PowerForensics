﻿using System;
using System.Text;
using System.Collections.Generic;
using PowerForensics.Registry;

namespace PowerForensics.Artifacts
{
    #region ShimcacheClass

    public class Shimcache
    {
        #region Constants

        internal const uint WINXP_MAGIC = 0xDEADBEEF;
        internal const uint NT5dot2_MAGIC = 0xBADC0FFE;
        internal const uint NT6dot1_MAGIC = 0xBADC0FEE;
        //internal const uint WIN8_MAGIC = ;
        internal const uint WIN8dot1_MAGIC = 0x00000080;
        internal const uint WIN10_MAGIC = 0x00000030;

        #endregion Constants

        #region Properties

        public readonly string Path;
        public readonly DateTime LastModifiedTime;
        public readonly ulong FileSize;
        public readonly DateTime LastUpdateTime;

        #endregion Properties

        #region Constructors

        internal Shimcache(string path, DateTime lastModTime, ulong size, DateTime lastUpTime)
        {
            Path = path;
            LastModifiedTime = lastModTime;
            FileSize = size;
            LastUpdateTime = lastUpTime;
        }

        #endregion Constructors

        #region StaticMethods

        public static Shimcache[] GetInstances(string volume)
        {
            return Shimcache.GetInstancesByPath(Util.GetVolumeLetter(volume) + @"\Windows\system32\config\SYSTEM");
        }

        public static Shimcache[] GetInstancesByPath(string hivePath)
        {
            if (RegistryHeader.Get(hivePath).HivePath.Contains("SYSTEM"))
            {
                string Key = @"ControlSet001\Control\Session Manager\AppCompatCache";
                ValueKey vk = null;

                try
                {
                    vk = ValueKey.Get(hivePath, Key, "AppCompatCache");
                }
                catch
                {
                    try
                    {
                        Key = @"ControlSet001\Control\Session Manager\AppCompatibility";
                        vk = ValueKey.Get(hivePath, Key, "AppCompatCache");
                    }
                    catch
                    {
                        throw new Exception("Error finding AppCompatCache registry value");
                    }
                }
                
                byte[] bytes = vk.GetData();

                string arch = Encoding.Unicode.GetString(ValueKey.Get(hivePath, @"ControlSet001\Control\Session Manager\Environment", "PROCESSOR_ARCHITECTURE").GetData()).TrimEnd('\0');

                switch (BitConverter.ToUInt32(bytes, 0x00))
                {
                    // Windows XP
                    case WINXP_MAGIC:
                        return GetDEADBEEF(bytes);
                    // Server 2003, Windows Vista, Server 2008
                    case NT5dot2_MAGIC:
                        return GetBADC0FFE(bytes, arch);
                    // Windows 7 and Server 2008 R2
                    case NT6dot1_MAGIC:
                        return GetBADC0FEE(bytes, arch);
                    // Windows 8 
                    // Windows 8.1
                    case WIN8dot1_MAGIC:
                        return Get00000080(bytes);
                    // Windows 10
                    case WIN10_MAGIC:
                        return Get00000030(bytes);
                    default:
                        return null;
                }
            }
            else
            {
                throw new Exception("Invalid SYSTEM hive provided to -HivePath parameter.");
            }
        }

        private static Shimcache[] GetDEADBEEF(byte[] bytes)
        {
            int offset = 0x190;
            int count = BitConverter.ToInt32(bytes, 0x04);
            Shimcache[] shimcacheArray = new Shimcache[count];

            for (int i = 0; i < count; i++)
            {
                string path = Encoding.Unicode.GetString(bytes, offset, 0x210).Split('\0')[0];
                DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, offset + 0x210));
                ulong size = BitConverter.ToUInt64(bytes, offset + 0x218);
                DateTime lastUpTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, offset + 0x220));

                shimcacheArray[i] = new Shimcache(path, lastModifiedTime, size, lastUpTime);

                offset += 0x228;
            }

            return shimcacheArray;
        }

        // Server 2003 has a size property, but I haven't figured out how to differentiate Server 2003 from Vista/2k8
        // Need an example of 2003/Vista/2k8 to test on
        private static Shimcache[] GetBADC0FFE(byte[] bytes, string arch)
        {
            int offset = 0x80;
            int count = BitConverter.ToInt32(bytes, 0x04);
            Shimcache[] shimcacheArray = new Shimcache[count];

            if (arch == "x86")
            {
                for (int i = 0; i < count; i++)
                {
                    string path = Encoding.Unicode.GetString(bytes, BitConverter.ToInt32(bytes, offset + 0x04), BitConverter.ToInt16(bytes, offset));
                    DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, offset + 0x08));

                    shimcacheArray[i] = new Shimcache(path, lastModifiedTime, 0, new DateTime(0));

                    offset += 0x20;
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    string path = Encoding.Unicode.GetString(bytes, BitConverter.ToInt32(bytes, offset + 0x08), BitConverter.ToInt16(bytes, offset));
                    DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, offset + 0x10));

                    shimcacheArray[i] = new Shimcache(path, lastModifiedTime, 0, new DateTime(0));

                    offset += 0x30;
                }
            }
            return shimcacheArray;
        }

        private static Shimcache[] GetBADC0FEE(byte[] bytes, string arch)
        {
            int offset = 0x80;
            int count = BitConverter.ToInt32(bytes, 0x04);
            Shimcache[] shimcacheArray = new Shimcache[count];

            if (arch == "x86")
            {
                for (int i = 0; i < count; i++)
                {
                    string path = Encoding.Unicode.GetString(bytes, BitConverter.ToInt32(bytes, offset + 0x04), BitConverter.ToInt16(bytes, offset));
                    DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, offset + 0x08));

                    shimcacheArray[i] = new Shimcache(path, lastModifiedTime, 0, new DateTime(0));

                    offset += 0x20;
                }
            }
            else
            {
                for(int i = 0; i < count; i++)
                {
                    string path = Encoding.Unicode.GetString(bytes, BitConverter.ToInt32(bytes, offset + 0x08), BitConverter.ToInt16(bytes, offset));
                    DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, offset + 0x10));

                    shimcacheArray[i] = new Shimcache(path, lastModifiedTime, 0, new DateTime(0));

                    offset += 0x30;
                }
            }

            return shimcacheArray;
        }

        private static Shimcache[] Get00000080(byte[] bytes)
        {
            int offset = BitConverter.ToInt32(bytes, 0x00);
            List<Shimcache> shimList = new List<Shimcache>();

            while (offset < bytes.Length)
            {
                if (Encoding.ASCII.GetString(bytes, offset, 0x04) == "10ts")
                {
                    int pathoffset = offset + 0x0E;
                    int pathlength = BitConverter.ToInt16(bytes, offset + 0x0C);
                    string path = Encoding.Unicode.GetString(bytes, pathoffset, pathlength);
                    DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, pathoffset + pathlength + 0x0A));

                    shimList.Add(new Shimcache(path, lastModifiedTime, 0, new DateTime(0)));

                    offset += (BitConverter.ToInt32(bytes, offset + 0x08) + 0x0C);
                }
                else
                {
                    break;
                }
            }

            return shimList.ToArray();
        }

        private static Shimcache[] Get00000030(byte[] bytes)
        {
            int offset = BitConverter.ToInt32(bytes, 0x00);
            List<Shimcache> shimList = new List<Shimcache>();

            while (offset < bytes.Length)
            {
                if (Encoding.ASCII.GetString(bytes, offset, 0x04) == "10ts")
                {
                    int pathoffset = offset + 0x0E;
                    int pathlength = BitConverter.ToInt16(bytes, offset + 0x0C);
                    string path = Encoding.Unicode.GetString(bytes, pathoffset, pathlength);
                    DateTime lastModifiedTime = DateTime.FromFileTimeUtc(BitConverter.ToInt64(bytes, pathoffset + pathlength));

                    shimList.Add(new Shimcache(path, lastModifiedTime, 0, new DateTime(0)));

                    offset += (BitConverter.ToInt32(bytes, offset + 0x08) + 0x0C);
                }
                else
                {
                    break;
                }
            }

            return shimList.ToArray();
        }
        
        #endregion StaticMethods
    }

    #endregion ShimcacheClass
}
