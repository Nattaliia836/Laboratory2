using System;
using System.Collections.Generic;
using System.Xml.Xsl;
using System.Text;
using System.Xml;
//using System.Xml.Linq;
using System.Linq;
using System.Xml.Linq;

namespace Laboratory2
{
    class LINQStrategy : InSearch
    {
        /*
            Genre = "";
            BandName = "";
            Album = "";
            SongName = "";
            Duration = "";
            ReleaseYear = "";
        */

        public List<Song> Search(Song song)
        {
            List<Song> resultSongs = new List<Song>();
            var doc = XDocument.Load(@"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Songs.xml");
            var result = from obj in doc.Descendants("song")
                         where
                         (
                         (obj.Attribute("Genre").Value.Equals(song.Genre) || song.Genre.Equals(String.Empty)) &&
                         (obj.Attribute("BandName").Value.Equals(song.BandName) || song.BandName.Equals(String.Empty)) &&
                         (obj.Attribute("Album").Value.Equals(song.Album) || song.Album.Equals(String.Empty)) &&
                         (obj.Attribute("SongName").Value.Equals(song.SongName) || song.SongName.Equals(String.Empty)) &&
                         (obj.Attribute("Duration").Value.Equals(song.Duration) || song.Duration.Equals(String.Empty)) &&
                         (obj.Attribute("ReleaseYear").Value.Equals(song.ReleaseYear) || song.ReleaseYear.Equals(String.Empty))
                         )
                         select new
                         {
                            genre = obj.Attribute("Genre"),
                            bandName = obj.Attribute("BandName"),
                            album = obj.Attribute("Album"),
                            songName = obj.Attribute("SongName"),
                            duration = obj.Attribute("Duration"),
                            releaseYear = obj.Attribute("ReleaseYear")
                         };


            foreach (var n in result)
            {
                Song newSong = new Song();
                newSong.Genre = (string)n.genre;
                newSong.BandName = (string)n.bandName;
                newSong.Album = (string)n.album;
                newSong.SongName = (string)n.songName;
                newSong.Duration = (string)n.duration;
                newSong.ReleaseYear = (string)n.releaseYear;
                resultSongs.Add(newSong);
            }

            return resultSongs;
        }
    }
}
