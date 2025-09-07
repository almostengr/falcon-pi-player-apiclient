using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdTestingResource : FppStatusResponseResource
{
    public Configuration Config { get; set; }

    public class Configuration
    {
        public int Enabled { get; set; }
        public string ChannelSet { get; set; }
        public string ChannelSetType { get; set; }
        public string ColorPattern { get; set; }
        public int CycleMs { get; set; }
        public string Mode { get; set; }
        public string SubMode { get; set; }
    }
}
