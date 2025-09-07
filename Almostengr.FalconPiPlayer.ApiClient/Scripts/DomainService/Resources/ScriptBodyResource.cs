using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Scripts.DomainService.Resources;

public class ScriptBodyResource : FppStatusResource
{
    public string ScriptName { get; set; }
    public string ScriptBody { get; set; }
}