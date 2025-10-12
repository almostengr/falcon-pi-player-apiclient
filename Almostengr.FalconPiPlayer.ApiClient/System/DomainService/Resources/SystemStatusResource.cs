using System.Text.Json.Serialization;

namespace Almostengr.FalconPiPlayer.ApiClient.System.DomainService.Resources;

public class SystemStatusResource
{
    public SystemMqtt Mqtt { get; set; }

    [JsonPropertyName("current_playlist")]
    public SystemCurrentPlaylist CurrentPlaylist { get; set; }

    [JsonPropertyName("curent_sequence")]
    public string CurrentSequence { get; set; }

    [JsonPropertyName("current_song")]
    public string CurrentSong { get; set; }

    public string Fppd { get; set; }
    public int Mode { get; set; }

    [JsonPropertyName("mode_name")]
    public string ModeName { get; set; }

    [JsonPropertyName("next_playlist")]
    public SystemNextPlaylist NextPlaylist { get; set; }

    [JsonPropertyName("repeat_mode")]
    public int RepeatMode { get; set; }

    public SystemScheduler Scheduler { get; set; }

    [JsonPropertyName("seconds_elapsed")]
    public string SecondsElapsed { get; set; }

    [JsonPropertyName("seconds_played")]
    public string SecondsPlayed { get; set; }

    [JsonPropertyName("seconds_remaining")]
    public string SecondsRemaining { get; set; }

    public int Status { get; set; }

    [JsonPropertyName("status_name")]
    public string StatusName { get; set; }

    public string Time { get; set; }

    [JsonPropertyName("time_elapsed")]
    public string TimeElapsed { get; set; }

    [JsonPropertyName("time_remaining")]
    public string TimeRemaining { get; set; }

    public string Uptime { get; set; }

    public decimal UptimeDays { get; set; }
    public decimal UptimeHours { get; set; }
    public decimal UptimeMinutes { get; set; }
    public int UptimeSeconds { get; set; }
    public string UptimeStr { get; set; }
    public int UptimeTotalSeconds { get; set; }
    public int Volume { get; set; }
    public IEnumerable<string> Wifi { get; set; } // todo 
    public SystemInterfaces Interfaces { get; set; }
    public SystemAdvancedView AdvancedView { get; set; }

    public class SystemAdvancedView
    {
        public string HostName { get; set; }
        public string HostDescription { get; set; }
        public string Platform { get; set; }
        public string Variant { get; set; }
        public string MOde { get; set; }
        public string Version { get; set; }
        public string OsVersion { get; set; }
        public string OsRelease { get; set; }
        public string ChannelRanges { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public int TypeId { get; set; }
        public ViewUtilization Utilization { get; set; }
        public string Kernel { get; set; }
        public string LocalGitVersion { get; set; }
        public string RemoteGitVersion { get; set; }
        public string UpgradeSource { get; set; }
        public IEnumerable<string> Ips { get; set; }

        public class ViewUtilization
        {
            public decimal Cpu { get; set; }
            public decimal Memory { get; set; }
            public string Uptime { get; set; }
        }
    }

    public class SystemInterfaces
    {
        public int IfIndex { get; set; }
        public string IfName { get; set; }
        public IEnumerable<string> Flags { get; set; }
        public int Mtu { get; set; }
        public string QDisc { get; set; }
        public string OperState { get; set; }
        public string Group { get; set; }
        public int TxQLen { get; set; }
        public InterfaceAddrInfo AddrInfo { get; set; }

        public class InterfaceAddrInfo
        {
            public string Family { get; set; }
            public string Local { get; set; }
            public int PrefixLen { get; set; }
            public string Scope { get; set; }
            public string Label { get; set; }

            [JsonPropertyName("valid_life_time")]
            public int ValidLifeTime { get; set; }

            [JsonPropertyName("preferred_life_time")]
            public int PreferredLifeTime { get; set; }
        }
    }

    public class SystemScheduler
    {
        public SystemSchedulerCurrentPlaylist CurrentPlaylist { get; set; }
        public int Enabled { get; set; }
        public SystemSchedulerNextPlaylist NextPlaylist { get; set; }
        public string Status { get; set; }

        public class SystemSchedulerNextPlaylist
        {
            public string PlaylistName { get; set; }
            public int ScheduledStartTime { get; set; }
            public string ScheduledStartTimeStr { get; set; }
        }

        public class SystemSchedulerCurrentPlaylist
        {
            public int ActualEndTime { get; set; }
            public string ActualEndTimeStr { get; set; }
            public int ActualStartTime { get; set; }
            public string ActualStartTimeStr { get; set; }
            public int CurrentTime { get; set; }
            public string CurrentTimeStr { get; set; }
            public string PlaylistName { get; set; }
            public int ScheduledEndTime { get; set; }
            public string ScheduledEndTimeStr { get; set; }
            public int ScheduledStartTime { get; set; }
            public string ScheduledStartTimeStr { get; set; }
            public int SecondsRemaining { get; set; }
            public int StopType { get; set; }
            public string StopTypeStr { get; set; }
        }
    }

    public class SystemNextPlaylist
    {
        public string Playlist { get; set; }

        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }

    public class SystemMqtt
    {
        public bool Configured { get; set; }
        public bool Connected { get; set; }
    }

    public class SystemCurrentPlaylist
    {
        public string Count { get; set; }
        public string Description { get; set; }
        public string Index { get; set; }
        public string Playlist { get; set; }
        public string Type { get; set; }
    }
}
