using System.Text.Json.Serialization;

namespace Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

public class FppStatusMessageResource : FppStatusResource
{
    public string Message { get; set; }
    
    [JsonPropertyName("respCode")]
    public int RespCode { get; set; }
}