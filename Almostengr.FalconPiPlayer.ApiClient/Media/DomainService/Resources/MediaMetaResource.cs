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
        public string CodecName { get; set; }
        public string CodecLongName { get; set; }
        public string Profile { get; set; }
        public string CodecType { get; set; }
        public string CodecTimebase { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string DisplayAspectRatio { get; set; }
        public string PixFmt { get; set; }
    }

    public class MediaFormat
    {
        public string Filename { get; set; }
        public int NbStreams { get; set; }
        public int NbPrograms { get; set; }
        public string FormatName { get; set; }
        public string FormatLongName { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public string Size { get; set; }
        public string BitRate { get; set; }
        public MediaFormatTags Tags { get; set; }

        public class MediaFormatTags
        {
            public string MajorBrand { get; set; }
            public string MinorVersion { get; set; }
            public string CompatibleBrands { get; set; }
            public string CreationTime { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Encoder { get; set; }
        }
    }
}
