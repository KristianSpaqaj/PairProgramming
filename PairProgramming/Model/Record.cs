using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Model
{
    public class Record
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Record()
        {

        }

        public Record(string title, string artist, int duration, DateTime releaseDate)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            ReleaseDate = releaseDate;
        }
    }
}
