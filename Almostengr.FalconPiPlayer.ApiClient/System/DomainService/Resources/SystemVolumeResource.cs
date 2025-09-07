using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.System.DomainService.Resources;

public class SystemVolumeResource : FppStatusResource
{
    public int Volume { get; set; }
    public string Method { get; set; }
}