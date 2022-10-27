using System.IO.Compression;

namespace laba_12;

public class NVDFileManager
{
     public static event Action<string> OnUpdate;

        public static void InspectDrive(string driveName)
        {
            Directory.CreateDirectory(@"D:\unik\oop\laba_12\laba_12\NVDInspect");

            var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driveName);
            OnUpdate($"File manager has inspected {currentDrive.Name}");

            File.Create(@"D:\unik\oop\laba_12\laba_12\NVDInspect\NVDdirinfo.txt").Close();

            using (var streamWriter = new StreamWriter(@"D:\unik\oop\laba_12\laba_12\NVDInspect\NVDdirinfo.txt"))
            {
                streamWriter.WriteLine("|Directories| [");
                foreach (var directoryInfo in currentDrive.RootDirectory.GetDirectories()) streamWriter.WriteLine(directoryInfo.Name);
                streamWriter.WriteLine("]");

                streamWriter.WriteLine("|Files| [");
                foreach (var fileInfo in currentDrive.RootDirectory.GetFiles()) streamWriter.WriteLine(fileInfo.Name);
                streamWriter.WriteLine("]");
            }

            File.Copy(@"D:\unik\oop\laba_12\laba_12\NVDInspect\NVDdirinfo.txt",
                @"D:\unik\oop\laba_12\laba_12\NVDInspect\NVDdirinfoCopy.txt", true);
            File.Delete(@"D:\unik\oop\laba_12\laba_12\NVDInspect\NVDdirinfo.txt");
        }

        public static void CopyFiles(string path, string extension)
        {
            OnUpdate($"File manager has copied {extension} files from {path}");

            var directory = new DirectoryInfo(path);
            Directory.CreateDirectory(@"D:\unik\oop\laba_12\laba_12\NVDFiles");

            foreach (var file in directory.GetFiles())
                if (file.Extension == extension)
                    file.CopyTo($@"D:\unik\oop\laba_12\laba_12\NVDFiles\{file.Name}", true);
            Directory.Delete(@"D:\unik\oop\laba_12\laba_12\NVDFiles\", true);
                Directory.Move(@"D:\unik\oop\laba_12\laba_12\NVDFiles\",
                    @"D:\unik\oop\laba_12\laba_12\NVDInspect\");
        }

        public static void Archive(string pathFrom, string pathTo)
        {
            OnUpdate($"File manager has archived files from {pathFrom} and unarchived");

            Directory.Delete(@"D:\unik\oop\laba_12\laba_12\UnarchiveTest\", true);

            if (!File.Exists($@"{pathFrom}.zip"))
                ZipFile.CreateFromDirectory(pathFrom, $@"{pathFrom}.zip");

            ZipFile.ExtractToDirectory($@"{pathFrom}.zip", pathTo);
        }
}