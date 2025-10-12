using System.Text.Json.Serialization;

namespace Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

public class FppStatusResponseResource : FppStatusMessageResource
{

    [JsonPropertyName("respCode")]
    public int RespCode { get; set; }
}
