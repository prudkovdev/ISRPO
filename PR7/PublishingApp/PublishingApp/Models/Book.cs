using System;

namespace PublishingApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int ReleaseYear { get; set; }
        public int VolumeOfSheets { get; set; }
        public int Circulation { get; set; }
    }
}
