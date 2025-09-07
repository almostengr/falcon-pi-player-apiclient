using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdLogResource : FppStatusMessageResource
{
    public FppdLog Log { get; set; }

    public class FppdLog
    {
        public string ChannelData { get; set; }
        public string ChannelOut { get; set; }
        public string Command { get; set; }
        public string Control { get; set; }
        public string E131Bridge { get; set; }
        public string Effect { get; set; }
        public string Event { get; set; }
        public string GPIO { get; set; }
        public string General { get; set; }
        public string HTTP { get; set; }
        public string MediaOut { get; set; }
        public string Playlist { get; set; }
        public string Plugin { get; set; }
        public string Schedule{ get; set; }
        public string Sequence{ get; set; }
        public string Settings { get; set; }
        public string Sync { get; set; }
    }
}
