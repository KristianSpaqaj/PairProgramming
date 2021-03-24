using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Model
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Record()
        {

        }

        public Record(int id, string title, string artist, int duration, DateTime releaseDate)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            ReleaseDate = releaseDate;
        }
    }
}
