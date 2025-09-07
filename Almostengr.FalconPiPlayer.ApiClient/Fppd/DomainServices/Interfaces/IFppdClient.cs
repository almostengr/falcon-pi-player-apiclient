using Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Interfaces;

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
