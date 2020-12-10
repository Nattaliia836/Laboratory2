using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Laboratory2
{
    class DOMStrategy : InSearch
    {
        public List<Song> Search(Song song)
        {
            //Console.WriteLine("DOM1");
            List<Song> result = new List<Song>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Songs.xml");

            XmlNode node = doc.DocumentElement;

            foreach (XmlNode nod in node.ChildNodes)
            {
                string Genre = "";
                string BandName = "";
                string Album = "";
                string SongName = "";
                string Duration = "";
                string ReleaseYear = "";

                //Console.WriteLine("DOM2");

                foreach (XmlAttribute attribute in nod.Attributes)
                {
                    if (attribute.Name.Equals("Genre") && (attribute.Value.Equals(song.Genre) || song.Genre.Equals(String.Empty)))
                    {
                        Genre = attribute.Value;
                       // Console.WriteLine("Genre");
                    }
                       

                    if (attribute.Name.Equals("BandName") && (attribute.Value.Equals(song.BandName) || song.BandName.Equals(String.Empty)))
                    {
                        BandName = attribute.Value;
                        //Console.WriteLine("BandName");
                    }
                       

                    if (attribute.Name.Equals("Album") && (attribute.Value.Equals(song.Album) || song.Album.Equals(String.Empty)))
                    {
                        Album = attribute.Value;
                        //Console.WriteLine("Album");
                    }
                       

                    if (attribute.Name.Equals("SongName") && (attribute.Value.Equals(song.SongName) || song.SongName.Equals(String.Empty)))
                    {
                        SongName = attribute.Value;
                        //Console.WriteLine("SongName");
                    }
                       

                    if (attribute.Name.Equals("Duration") && (attribute.Value.Equals(song.Duration) || song.Duration.Equals(String.Empty)))
                    {
                        Duration = attribute.Value;
                        //Console.WriteLine("Duration");
                    }
                       

                    if (attribute.Name.Equals("ReleaseYear") && (attribute.Value.Equals(song.ReleaseYear) || song.ReleaseYear.Equals(String.Empty)))
                    {
                        ReleaseYear = attribute.Value;
                        //Console.WriteLine("ReleaseYear");
                    }
                        
                }

                if(Genre != "" && BandName != "" && Album != "" && SongName != "" && Duration != "" && ReleaseYear != "")
                {
                    Song newSong = new Song();
                    newSong.Genre = Genre;
                    newSong.BandName = BandName;
                    newSong.Album = Album;
                    newSong.SongName = SongName;
                    newSong.Duration = Duration;
                    newSong.ReleaseYear = ReleaseYear;
                    result.Add(newSong);
                }
            }

            return result;
        }
    }
}
