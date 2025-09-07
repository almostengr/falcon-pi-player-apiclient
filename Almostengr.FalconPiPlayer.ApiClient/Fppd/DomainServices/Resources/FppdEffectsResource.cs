using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdEffectsResource : FppStatusMessageResource
{
    public IEnumerable<RunningEffect> RunningEffects { get; set; }

    public class RunningEffect
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
