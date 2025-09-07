using System.Text.Json.Serialization;

namespace Almostengr.FalconPiPlayer.ApiClient.Media.DomainService.Resources;

public class MediaMetaResource
{
    public IEnumerable<string> Programs { get; set; }
    public IEnumerable<MediaStream> Streams { get; set; }
    public IEnumerable<string> Chapters { get; set; }
    public MediaFormat Format { get; set; }

    public class MediaStream
    {
        public int Index { get; set; }

        [JsonPropertyName("codec_name")]
        public string CodecName { get; set; }

        [JsonPropertyName("codec_long_name")]
        public string CodecLongName { get; set; }

        public string Profile { get; set; }

        [JsonPropertyName("codec_type")]
        public string CodecType { get; set; }

        [JsonPropertyName("codec_time_base")]
        public string CodecTimeBase { get; set; }

        [JsonPropertyName("codec_tag_string")]
        public string CodecTagString { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        [JsonPropertyName("display_aspect_ratio")]
        public string DisplayAspectRatio { get; set; }

        public string PixFmt { get; set; }
    }

    public class MediaFormat
    {
        public string Filename { get; set; }

        [JsonPropertyName("nb_streams")]
        public int NbStreams { get; set; }

        [JsonPropertyName("nb_programs")]
        public int NbPrograms { get; set; }

        [JsonPropertyName("format_name")]
        public string FormatName { get; set; }

        [JsonPropertyName("format_long_name")]
        public string FormatLongName { get; set; }

        public string StartTime { get; set; }
        public string Duration { get; set; }
        public string Size { get; set; }

        [JsonPropertyName("bit_rate")]
        public string BitRate { get; set; }

        [JsonPropertyName("probe_score")]
        public int ProbeScore{ get; set; }

        public MediaFormatTags Tags { get; set; }

        public class MediaFormatTags
        {
            [JsonPropertyName("major_brand")]
            public string MajorBrand { get; set; }

            [JsonPropertyName("minor_version")]
            public string MinorVersion { get; set; }

            [JsonPropertyName("compatible_brands")]
            public string CompatibleBrands { get; set; }

            [JsonPropertyName("creation_time")]
            public string CreationTime { get; set; }

            public string Title { get; set; }
            public string Artist { get; set; }
            public string Encoder { get; set; }
        }
    }
}
