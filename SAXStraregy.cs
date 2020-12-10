using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Laboratory2
{
    class SAXStraregy : InSearch
    {
        public List<Song> Search(Song song)
        {
            List<Song> result = new List<Song>();
            var xmlReader = new XmlTextReader(@"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Songs.xml");

            string Genre = "";
            string BandName = "";
            string Album = "";
            string SongName = "";
            string Duration = "";
            string ReleaseYear = "";

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        Genre = "";
                        BandName = "";
                        Album = "";
                        SongName = "";
                        Duration = "";
                        ReleaseYear = "";

                        if (xmlReader.Name.Equals("Genre") && (xmlReader.Value.Equals(song.Genre) || song.Genre.Equals(String.Empty)))
                        {
                            Genre = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("BandName") && (xmlReader.Value.Equals(song.BandName) || song.BandName.Equals(String.Empty)))
                            {
                                BandName = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name.Equals("Album") && (xmlReader.Value.Equals(song.Album) || song.Album.Equals(String.Empty)))
                                {
                                    Album = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (xmlReader.Name.Equals("SongName") && (xmlReader.Value.Equals(song.SongName) || song.SongName.Equals(String.Empty)))
                                    {
                                        SongName = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name.Equals("Duration") && (xmlReader.Value.Equals(song.Duration) || song.Duration.Equals(String.Empty)))
                                        {
                                            Duration = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name.Equals("ReleaseYear") && (xmlReader.Value.Equals(song.ReleaseYear) || song.ReleaseYear.Equals(String.Empty)))
                                            {
                                                ReleaseYear = xmlReader.Value;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (Genre != "" && BandName != "" && Album != "" && SongName != "" && Duration != "" && ReleaseYear != "")
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
                }
            }
            xmlReader.Close();
            return result;
        }
    }
}
