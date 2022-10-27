using System;
using System.IO;
using System.Text;
using laba_12;

namespace Laba12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            NVDDiskInfo.OnUpdate += NVDLog.WriteInTXT;
            NVDFileInfo.OnUpdate += NVDLog.WriteInTXT;
            NVDDirInfo.OnUpdate += NVDLog.WriteInTXT;
            NVDFileManager.OnUpdate += NVDLog.WriteInTXT;
            
            NVDDiskInfo.ShowFreeSpace(@"D:\");
            NVDDiskInfo.ShowFileSystemInfo(@"C:\");
            NVDDiskInfo.ShowAllDrivesInfo();
            
            NVDFileInfo.ShowFullPath(@"D:\unik\oop\laba_12\laba_12\NVDlogfile.txt");
            NVDFileInfo.ShowFileInfo(@"D:\unik\oop\laba_12\laba_12\NVDlogfile.txt");
            NVDFileInfo.ShowFileDates(@"D:\unik\oop\laba_12\laba_12\NVDlogfile.txt");
            
            NVDDirInfo.ShowCreationTime(@"D:\Torrents");
            NVDDirInfo.ShowNumberOfFiles(@"D:\Torrents");
            NVDDirInfo.ShowNumberOfSubdirectories(@"D:\Torrents");
            NVDDirInfo.ShowParentDirectory(@"D:\Torrents");
            
            NVDFileManager.InspectDrive(@"D:\");
            NVDFileManager.CopyFiles(@"D:\unik\oop\laba_12\laba_12\", ".cs");
            NVDFileManager.Archive(@"D:\unik\oop\laba_12\laba_12\Archivetest",
                @"D:\unik\oop\laba_12\laba_12\UnarchiveTest");
            FindInfo();
        }

        public static void FindInfo()
        {
            var output = new StringBuilder();

            using (var stream = new StreamReader(@"D:\unik\oop\laba_12\laba_12\NVDlogfile.txt"))
            {
                var textline = "";
                var isActual = false;
                while (stream.EndOfStream == false)
                {
                    isActual = false;
                    textline = stream.ReadLine();
                    if (textline != "" && DateTime.Parse(textline).Day == DateTime.Now.Day)
                    {
                        isActual = true;
                        textline += "\n";
                        output.AppendFormat(textline);
                    }

                    textline = stream.ReadLine();
                    while (textline != "------------------------------")
                    {
                        if (isActual)
                        {
                            textline += "\n";
                            output.AppendFormat(textline);
                        }

                        textline = stream.ReadLine();
                    }

                    if (isActual) output.AppendFormat("------------------------------\n");
                }
            }

            using (var stream = new StreamWriter(@"D:\unik\oop\laba_12\laba_12\NVDlogfile.txt"))
            {
                stream.WriteLine(output.ToString());
            }
        }
    }
}