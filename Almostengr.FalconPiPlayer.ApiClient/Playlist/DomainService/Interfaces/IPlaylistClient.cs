using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;
using Almostengr.FalconPiPlayer.ApiClient.Media.DomainService.Interfaces;

namespace Almostengr.FalconPiPlayer.ApiClient.Playlist.DomainService.Interfaces;

public interface IPlaylistClient
{
    Task<PlaylistResource> GetByNameAsync(string name);
    Task<FppStatusMessageResource> UpsertByNameAsync(PlaylistResource resource);
    Task<FppStatusMessageResource> DeleteByNameAsync(string name);
    Task<string> StartByNameAsync(string name);
    Task<IEnumerable<string>> GetListAsync();
    Task<string> PauseAsync();
    Task<IEnumerable<string>> GetPlayableAsync();
    Task<string> ResumeAsync();
    Task<string> StopAsync();
    Task<string> StopGracefullyAsync();
    Task<string> StopGracefullyAfterLoopAsync();
}
