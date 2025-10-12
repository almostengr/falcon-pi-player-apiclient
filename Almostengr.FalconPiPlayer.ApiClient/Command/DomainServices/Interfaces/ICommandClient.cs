using Almostengr.FalconPiPlayer.ApiClient.Command.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Command.DomainServices.Interfaces;

public interface ICommandClient
{
    Task<string> GetCommandAsync(CommandResource resource);
    Task<string> PostCommandAsync(CommandResource resource);
}
