using Almostengr.FalconPiPlayer.ApiClient.Common.DomainServices.Resources;

namespace Almostengr.FalconPiPlayer.ApiClient.Fppd.DomainServices.Resources;

public class FppdScheduleResource : FppStatusResponseResource
{
    public ScheduleSchedule Schedule { get; set; }

    public class ScheduleSchedule
    {
        public int Enabled { get; set; }
        public IEnumerable<ScheduleEntry> ScheduleEntries { get; set; }

        public class ScheduleEntry
        {
            public IEnumerable<string> Args { get; set; }
            public int Day { get; set; }
            public string DayStr { get; set; }
            public int Enabled { get; set; }
            public string EndDate { get; set; }
            public string EndTime { get; set; }
            public int Id { get; set; }
            public bool MulitsyncCommand { get; set; }
            public string Mutlisynchosts { get; set; }
            public string Playlist { get; set; }
            public int Priority { get; set; }
            public int Repeat { get; set; }
            public int RepeatInterval { get; set; }
            public string StartDate { get; set; }
            public string StartTime { get; set; }
            public string StartTimeStr { get; set; }
            public int StopType { get; set; }
            public string StopTypeStr { get; set; }
            public string Type { get; set; }
        }
    }
}
