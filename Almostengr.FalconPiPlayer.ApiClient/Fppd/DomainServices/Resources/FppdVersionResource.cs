using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdVersionResource : FppStatusResponseResource
{
    public string Branch { get; set; }
    public string FppdApi { get; set; }
    public string MajorVersion { get; set; }
    public string MinorVersion { get; set; }
    public string Version { get; set; }
}
