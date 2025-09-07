using Almostengr.FalconPiPlayer.ApiClient.Common.Shared;
using Microsoft.Extensions.Options;

namespace Almostengr.FalconPiPlayer.ApiClient.Scripts.DomainService.Interfaces;

public abstract class BaseFppClient
{
    protected readonly FppApiClientSettings _settings;
    protected readonly HttpClient _httpClient;

    public BaseFppClient(
        HttpClient httpClient,
        IOptions<FppApiClientSettings> options
    )
    {
        _settings = options.Value;
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(_settings.HostUrl);
        _httpClient.Timeout = TimeSpan.FromSeconds(_settings.Timeout);
    }
}
