using Almostengr.FalconPiPlayer.ApiClient.Command.Shared;

namespace Almostengr.FalconPiPlayer.ApiClient.Command.DomainServices.Resources;

public class CommandResource
{
    public CommandName Command { get; set; }
    public IEnumerable<string> Args { get; set; }
}