using Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Interfaces;
using Almostengr.FalconPiPlayer.ApiClient.Fppd.Infrastructure;
using Almostengr.FalconPiPlayer.ApiClient.Media.DomainService.Interfaces;
using Almostengr.FalconPiPlayer.ApiClient.Media.Infrastructure;
using Almostengr.FalconPiPlayer.ApiClient.System.DomainService.Interfaces;
using Almostengr.FalconPiPlayer.ApiClient.System.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Almostengr.FalconPiPlayer.ApiClient.Common.Shared;

public static class FalconPiPlayerApiClientExtensions
{
    public static void AddFalconPiPlayerApiClientServices(this IServiceCollection services, IConfigurationManager configuration)
    {
        // services.AddHttpClient();
        // services.AddTransient(services.Configure<FppApiClientSettings>(configuration.GetSection(nameof(FppApiClientSettings))));
        services.AddTransient<IFppdClient, FppdClient>();
        services.AddTransient<IMediaClient, MediaClient>();
        services.AddTransient<ISystemClient, SystemClient>();
    }
}