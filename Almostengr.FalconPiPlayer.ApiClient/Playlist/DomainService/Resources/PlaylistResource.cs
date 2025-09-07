using System.Text.Json.Serialization;

namespace Almostengr.FalconPiPlayer.ApiClient.Media.DomainService.Interfaces;

public class PlaylistResource
{
    public string Name { get; set; }
    public IEnumerable<MainPlaylistItem> MainPlaylist { get; set; }
    public PlaylistInfoDetail PlaylistInfo { get; set; }
    public class MainPlaylistItem
    {
        public string Type { get; set; }
        public int Enabled { get; set; }
        public int PlayOnce { get; set; }
        public int Duration { get; set; }
    }

    public class PlaylistInfoDetail
    {
        [JsonPropertyName("total_duration")]
        public int TotalDuration { get; set; }

        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }
    }
}