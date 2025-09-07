using Almostengr.FalconPiPlayer.ApiClient.Media.DomainService.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Media.DomainService.Interfaces;

public interface IMediaClient
{
    Task<IEnumerable<string>> GetListAsync();
    // Task<MediaDurationResource> GetDurationAsync(MediaNameResource resource);
    Task<MediaMetaResource> GetMetaAsync(MediaNameResource resource);
}
