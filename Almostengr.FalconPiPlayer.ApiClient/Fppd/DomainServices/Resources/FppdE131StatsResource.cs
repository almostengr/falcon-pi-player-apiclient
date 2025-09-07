using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdE131StatsResource : FppStatusMessageResource
{
    public IEnumerable<StatUniverse> StatUniverses { get; set; }

    public class StatUniverse
    {
        public string BytesReceived { get; set; }
        public string Errors { get; set; }
        public int Id { get; set; }
        public string PacketsReceived { get; set; }
        public int StartChannel { get; set; }
    }
}