using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratory2
{
    class Song
    {
        public string Genre { get; set; } = "";
        public string BandName { get; set; } = "";
        public string Album { get; set; } = "";
        public string SongName { get; set; } = "";
        public string Duration { get; set; } = "";
        public string ReleaseYear { get; set; } = "";

        public Song() {}
        /*
        public Song(List<string> info)
        {
            Genre = info.ElementAt(0);
            BandName = info.ElementAt(1);
            Album = info.ElementAt(2);
            Name = info.ElementAt(3);
            Duration = info.ElementAt(4);
            ReleaseYear = info.ElementAt(5);
        }
        
        public Song (IStrategy algo)
        {
            Genre = String.Empty;
            BandName = String.Empty;
            Album = String.Empty;
            Name = String.Empty;
            Duration = String.Empty;
            ReleaseYear = String.Empty;
        }

        public bool Comparing(Song song)
        {
            if ((Genre == song.Genre)
                && (BandName == song.BandName)
                && (Album == song.Album)
                && (Name == song.Name)
                && (Duration == song.Duration)
                && (ReleaseYear == song.ReleaseYear))
            {
                return true;
            }
            else return false;
        }
        public IStraregy Algo { get; set; }
        public List<Song> Algorithm(Song parametrs, string path)
        {
            return Algo.Algorithm(parametrs, path);
        }
        */
    }
}
