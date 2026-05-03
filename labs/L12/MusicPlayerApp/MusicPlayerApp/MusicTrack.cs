using System;

namespace MusicPlayerApp
{
    public class MusicTrack
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public long FileSize { get; set; }
        public DateTime AddedDate { get; set; }
        public int PlayCount { get; set; } = 0;
    }
}
