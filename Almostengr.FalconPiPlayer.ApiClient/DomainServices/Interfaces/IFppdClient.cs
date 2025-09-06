using Almostengr.FalconPiPlayer.ApiClient.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.DomainServices.Interfaces;

public interface IFppdClient
{
    Task<FppdE131StatsResource> GetFppdE131StatsAsync();
    Task<FppdEffectsResource> GetEffectsResourceAsync();
    Task<FppdLogResource> GetLogResourceAsync();
    Task<FppdMultiSyncStatsResource> GetFppdMultiSyncStatsAsync();
    Task<FppdMultiSyncSystemsResource> GetFppdMultiSyncSystemsAsync();
    Task<FppdScheduleResource> GetFppdScheduleAsync();
    Task<FppdTestingResource> GetFppdTestingAsync();
    Task<FppdVersionResource> GetFppdVersionAsync();
    Task<FppdVolumeResource> GetVolumeAsync();
    Task<FppdStatusResource> GetStatusAsync();
}
