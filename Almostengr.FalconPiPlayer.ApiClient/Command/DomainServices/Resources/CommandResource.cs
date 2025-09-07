using System.Text.Json.Serialization;
using Almostengr.FalconPiPlayer.ApiClient.Command.Shared;

namespace Almostengr.FalconPiPlayer.ApiClient.Command.DomainServices.Resources;

public class CommandResource
{
    public CommandName Command { get; set; }

    [JsonPropertyName("args")]
    public IEnumerable<string> Arguments { get; set; }
}