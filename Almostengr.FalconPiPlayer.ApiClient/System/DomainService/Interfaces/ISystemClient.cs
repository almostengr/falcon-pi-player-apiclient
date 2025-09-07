using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;
using Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;
using Almostengr.FalconPiPlayer.ApiClient.System.DomainService.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.System.DomainService.Interfaces;

public interface ISystemClient
{
    Task<FppStatusResource> RestartFppdAsync();
    Task<FppStatusResource> StartFppdAsync();
    Task<FppStatusResource> StopFppdAsync();
    Task<SystemInfoResource> GetSystemInfoAsync();
    Task<FppStatusResource> RebootSystemAsync();
    Task<FppStatusResource> ShutdownSystemAsync();
    Task<SystemStatusResource> GetSystemStatusAsync();
    Task<SystemVolumeResource> GetSystemVolumeAsync();
    Task<FppStatusResource> UpdateSystemVolumeAsync(SystemVolumeResource resource);
}
