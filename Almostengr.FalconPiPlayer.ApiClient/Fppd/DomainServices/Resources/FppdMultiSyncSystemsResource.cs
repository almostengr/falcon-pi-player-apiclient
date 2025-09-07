using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdMultiSyncSystemsResource : FppStatusResponseResource
{
    public IEnumerable<SyncSystems> Systems { get; set; }

    public class SyncSystems
    {
        public string Address { get; set; }
        public string ChannelRanges { get; set; }
        public string FppMode { get; set; }
        public string FppModeString { get; set; }
        public string HostName { get; set; }
        public int LastSeen { get; set; }
        public string LastSeenStr { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
    }
}
