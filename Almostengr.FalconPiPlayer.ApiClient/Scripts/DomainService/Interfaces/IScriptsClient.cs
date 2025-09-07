using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;
using Almostengr.FalconPiPlayer.ApiClient.Scripts.DomainService.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Scripts.DomainService.Interfaces;

public interface IScriptsClient
{
    Task<IEnumerable<string>> GetListAsync();
    Task<ScriptBodyResource> GetByNameAsync(string name);
    Task<string> RunByNameAsync(string name);
    Task<FppStatusResource> InstallRemoteAsync(RemoteScriptResource resource);
    Task<string> ViewRemoteAsync(RemoteScriptResource resource);
}
