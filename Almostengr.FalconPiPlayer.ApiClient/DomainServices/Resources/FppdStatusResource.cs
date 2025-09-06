namespace Almostengr.FalconPiPlayer.ApiClient.DomainServices.Resources;

public sealed class FppdStatusResource
{
    public Mqtt Mqtt { get; set; }
    public bool Bridging { get; set; }
    public CurrentPlaylist CurrentPlaylist { get; set; }
    public string CurrentSequence { get; set; }
    public string CurrentSong { get; set; }
    public string DateStr { get; set; }
    public string Fppd { get; set; }
    public int Mode { get; set; }
    public string ModeName { get; set; }
    public bool Multisync { get; set; }
    public NextPlaylist NextPlaylist { get; set; }
    public int RepeatMode { get; set; }
    public Scheduler Scheduler { get; set; }
    public string SecondsElaspsed { get; set; }
    public string SecondsPlayed { get; set; }
    public string SecondsRemaining { get; set; }
    public int Status { get; set; }
    public string Time { get; set; }
    public string TimeStr { get; set; }
    public string TimeStrFull { get; set; }
    public string TimeElapsed { get; set; }
    public string TimeRemaining { get; set; }
    public string Uptime { get; set; }
    public decimal UptimeDays { get; set; }
    public decimal UptimeHours { get; set; }
    public decimal UptimeMinutes { get; set; }
    public int UptimeSeconds { get; set; }
    public string UptimeString { get; set; }
    public int UptimeTotalSeconds { get; set; }
    public string Uuid { get; set; }
    public int Volume { get; set; }

    public class Mqtt
    {
        public bool Configured { get; set; }
        public bool Connected { get; set; }
    }

    public class CurrentPlaylist
    {
        public int Count { get; set; }
        public string Description { get; set; }
        public string Index { get; set; }
        public string Playlist { get; set; }
        public string Type { get; set; }
    }

    public class NextPlaylist
    {
        public string Playlist { get; set; }
        public string StartTime { get; set; }
    }

    public class Scheduler
    {
        public SchedulerCurrentPlaylist CurrentPlaylist { get; set; }
        public int Enabled { get; set; }
        public SchedulerNextPlaylist NextPlaylist { get; set; }
        public string Status { get; set; }

        public class SchedulerNextPlaylist
        {
            public string PlaylistName { get; set; }
            public int ScheduledStartTime { get; set; }
            public string ScheduledStartTimeStr { get; set; }
        }

        public class SchedulerCurrentPlaylist
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
}
