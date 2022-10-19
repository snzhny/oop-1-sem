namespace laba_8;

public class User
{
    public static event Action<string> OnUpgrade;
    public static event Action WorkStart;
    public static event Action WorkEnd;

    
    public static void StartWorkWithSoftware(Software software)
    {
        WorkStart += software.StartProcess;
        WorkEnd += software.KillProcess;

        WorkStart?.Invoke();
    }

    public static void EndWorkWithSoftware(Software software)
    {
        if (software.WorkingStatus == false)
            throw new ArgumentException("The software is not working now");

        WorkEnd?.Invoke();

        WorkStart -= software.StartProcess;
        WorkEnd -= software.KillProcess;
    }

    public static void Upgrade(Software software, string newVersion)
    {
        OnUpgrade += software.VersionController;

        OnUpgrade?.Invoke(newVersion);

        OnUpgrade -= software.VersionController;
    }
}