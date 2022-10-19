namespace laba_8;

public class Software
{   
    public string Name { get; set; }
    public string Version { get; set; }
    public bool WorkingStatus { get; set; }
    
    public Software(){}
    public Software(string name) { Name = name; }
    public Software(string name, string version, bool workingstatus)
    {
        Name = name;
        Version = version;
        WorkingStatus = workingstatus;
    }

    public void SoftwareInfo()
    {
        Console.WriteLine($"Software INFO: Software name: {this.Name}; Version: {this.Version}; Working status: {this.WorkingStatus}");
    }

    public void KillProcess() { WorkingStatus = false; }

    public void StartProcess() { WorkingStatus = true; }
    
    public void VersionController(string version){ Version = version; }
    
}   