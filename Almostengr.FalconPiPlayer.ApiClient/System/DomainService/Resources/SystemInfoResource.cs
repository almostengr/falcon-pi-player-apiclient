namespace Almostengr.FalconPiPlayer.ApiClient.System.DomainService.Resources;

public class SystemInfoResource
{
    public string Hostname { get; set; }
    public string HostDescription { get; set; }
    public string Platform { get; set; }
    public string Variant { get; set; }
    public string Mode { get; set; }
    public string Version { get; set; }
    public string Branch { get; set; }
    public string OsVersion { get; set; }
    public string OsRelease { get; set; }
    public string ChannelRanges { get; set; }
    public int MajorVersion { get; set; }
    public int MinorVersion { get; set; }
    public int TypeId { get; set; }
    public SystemUtilization Utilization { get; set; }
    public string Kernel { get; set; }
    public string LocalGitVersion { get; set; }
    public string RemoteGetVersion { get; set; }
    public string UpgradeSource { get; set; }
    public IEnumerable<string> Ips { get; set; }

    public class SystemUtilization
    {
        public decimal Cpu { get; set; }
        public decimal Memory { get; set; }
        public string UpTime { get; set; }
    }
}
