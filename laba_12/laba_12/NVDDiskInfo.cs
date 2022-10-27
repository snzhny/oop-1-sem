using System.Text;
namespace laba_12;

public class NVDDiskInfo
{
    public static event Action<string> OnUpdate;

    public static void ShowFreeSpace(string driveName)
    {
        var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driveName);
        Console.WriteLine($"Free space on the disk {currentDrive.Name} - {currentDrive.AvailableFreeSpace} bytes ");
        OnUpdate($"Free space on the disk {currentDrive.Name} - {currentDrive.AvailableFreeSpace} bytes ");
    }

    public static void ShowFileSystemInfo(string driveName)
    {
        var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driveName);
        Console.WriteLine($"File system type and drive format of  {driveName} : {currentDrive.DriveType}, {currentDrive.DriveFormat}");
        OnUpdate($"File system type and drive format of  {driveName} : {currentDrive.DriveType}, {currentDrive.DriveFormat}");
    }

    public static void ShowAllDrivesInfo()
    {
        var message = new StringBuilder("All drives information : \n");
        Console.WriteLine("[");
        message.AppendFormat("[\n");
        foreach (var currentDrive in DriveInfo.GetDrives())
        {
            if (currentDrive.IsReady == false)
                continue;

            Console.WriteLine(
                $"Name - {currentDrive.Name},Total size - {currentDrive.TotalSize},Free space - {currentDrive.AvailableFreeSpace} , Volume label - {currentDrive.VolumeLabel}");

            message.AppendFormat(
                $"Name - {currentDrive.Name},Total size - {currentDrive.TotalSize},Free space - {currentDrive.AvailableFreeSpace} , Volume label - {currentDrive.VolumeLabel}]\n");
        }

        Console.WriteLine("]");
        message.AppendFormat("]\n");
        OnUpdate(message.ToString());
    }
}