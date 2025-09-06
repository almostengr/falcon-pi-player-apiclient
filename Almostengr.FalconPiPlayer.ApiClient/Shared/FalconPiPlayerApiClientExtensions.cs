using Almostengr.FalconPiPlayer.ApiClient.DomainServices.Interfaces;
using Almostengr.FalconPiPlayer.ApiClient.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Almostengr.FalconPiPlayer.ApiClient.Shared;

public static class FalconPiPlayerApiClientExtensions
{
    public static void AddFalconPiPlayerApiClientServices(this IServiceCollection services, IConfigurationManager configuration)
    {
        // services.AddHttpClient();
        // services.AddTransient(services.Configure<FppApiClientSettings>(configuration.GetSection(nameof(FppApiClientSettings))));
        services.AddTransient<IFppdClient, FppdClient>();
    }
}