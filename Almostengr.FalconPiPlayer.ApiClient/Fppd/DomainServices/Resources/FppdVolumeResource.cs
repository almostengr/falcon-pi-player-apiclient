using System.Text.Json.Serialization;
using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;
using Newtonsoft.Json;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdVolumeResource : FppStatusMessageResource
{
    [JsonPropertyName("volume")]    public int Volume { get; set; }
}
