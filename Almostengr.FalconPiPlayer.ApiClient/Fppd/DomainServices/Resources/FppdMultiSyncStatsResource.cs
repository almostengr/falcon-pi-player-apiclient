using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdMultiSyncStatsResource : FppStatusMessageResource
{
    public string MasterHostname { get; set; }
    public string MasterIp { get; set; }
    public StatSystems Systems { get; set; }

    public class StatSystems
    {
        public string HostName { get; set; }
        public string LastReceiveTime { get; set; }
        public int PktBlank { get; set; }
        public int PktCommand { get; set; }
        public int PktError { get; set; }
        public int PktFppCommand { get; set; }
        public int PktPing { get; set; }
        public int PktPlugin { get; set; }
        public int PktSyncMedOpen { get; set; }
        public int PktSyncMedStart { get; set; }
        public int PktSyncMedStop { get; set; }
        public int PktSyncMedSync { get; set; }
        public int PktSyncSeqOpen { get; set; }
        public int PktSyncSeqStart { get; set; }
        public int PktSyncSeqStop { get; set; }
        public int PktSyncSeqSync { get; set; }
        public string SourceIp { get; set; }
    }
}
