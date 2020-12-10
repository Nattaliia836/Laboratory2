using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Laboratory2
{
    public partial class Form1 : Form
    {
        //string path = "Songs.xml";
        private List<Song> resultSongs = new List<Song>(); 
        public Form1()
        {
            InitializeComponent();
        }
       

        private void AddItems (XmlNode n)
        {
            if (!GenreBox.Items.Contains(n.SelectSingleNode("@Genre").Value))
                GenreBox.Items.Add(n.SelectSingleNode("@Genre").Value);

            if (!BandNameBox.Items.Contains(n.SelectSingleNode("@BandName").Value))
                BandNameBox.Items.Add(n.SelectSingleNode("@BandName").Value);

            if (!AlbumBox.Items.Contains(n.SelectSingleNode("@Album").Value))
                AlbumBox.Items.Add(n.SelectSingleNode("@Album").Value);

            if (!SongNameBox.Items.Contains(n.SelectSingleNode("@SongName").Value))
                SongNameBox.Items.Add(n.SelectSingleNode("@SongName").Value);

            if (!DurationBox.Items.Contains(n.SelectSingleNode("@Duration").Value))
                DurationBox.Items.Add(n.SelectSingleNode("@Duration").Value);

            if (!ReleaseYearBox.Items.Contains(n.SelectSingleNode("@ReleaseYear").Value))
                ReleaseYearBox.Items.Add(n.SelectSingleNode("@ReleaseYear").Value);
        }

        public void GetAllSongs()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Songs.xml");
            
            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("song");

            for(int i = 0; i < childNodes.Count; ++i)
            {
                XmlNode n = childNodes.Item(i);
                AddItems(n);
            }
        }

        private void Genre_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void search()
        {
            ResultBox.Text = "";
            Song newSong = new Song();

            /*
            Genre = "";
            BandName = "";
            Album = "";
            SongName = "";
            Duration = "";
            ReleaseYear = "";
        */
            if (GenreCheck.Checked)
                newSong.Genre = GenreBox.SelectedItem.ToString();

            if (BandNameCheck.Checked)
                newSong.BandName = BandNameBox.SelectedItem.ToString();

            if (AlbumCheck.Checked)
                newSong.Album = AlbumBox.SelectedItem.ToString();

            if (SongNameCheck.Checked)
                newSong.SongName = SongNameBox.SelectedItem.ToString();

            if (DurationCheck.Checked)
                newSong.Duration = DurationBox.SelectedItem.ToString();

            if (ReleaseYearCheck.Checked)
                newSong.ReleaseYear = ReleaseYearBox.SelectedItem.ToString();

            InSearch analizator = new DOMStrategy(); // по замовчуванню

            if (DOM.Checked)
                analizator = new DOMStrategy();

            if (SAX.Checked)
                analizator = new SAXStraregy();

            if (LINQ.Checked)
                analizator = new LINQStrategy();

            
            List<Song> results = analizator.Search(newSong);
            
            foreach (Song song_  in results)
            {
                ResultBox.Text += "Genre: " + song_.Genre + '\n';
                ResultBox.Text += "BandName: " + song_.BandName + '\n';
                ResultBox.Text += "Album: " + song_.Album + '\n';
                ResultBox.Text += "SongName: " + song_.SongName + '\n';
                ResultBox.Text += "Duration: " + song_.Duration + '\n';
                ResultBox.Text += "ReleaseYear: " + song_.ReleaseYear + '\n';
                ResultBox.Text += "\n";
            }
            
            
        }

        
        private void Search_Click(object sender, EventArgs e)
        {
            search();
            /*ResultBox.Text = "";
            Song newSong = new Song();

            Search analizator = new DOMStrategy();

            if (DOM.Checked)
            {
                resultSongs = analizator.Search(newSong);
            }
                //analizator = new DOMStrategy();

            if (SAX.Checked)
            {

            }
                //analizator = new SAXStraregy();

            if (LINQ.Checked)
            {

            }
                //analizator = new LINQStrategy();
            */
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
            ResultBox.Text = "";
            GenreBox.Text = null;
            GenreCheck.Checked = false;
            BandNameBox.Text = null;
            BandNameCheck.Checked = false;
            AlbumBox.Text = null;
            AlbumCheck.Checked = false;
            SongNameBox.Text = null;
            SongNameCheck.Checked = false;
            DurationBox.Text = null;
            DurationCheck.Checked = false;
            ReleaseYearBox.Text = null;
            ReleaseYearCheck.Checked = false;
            SAX.Checked = false;
            DOM.Checked = false;
            LINQ.Checked = false;
            
        }

        private void Transform_Click(object sender, EventArgs e)
        {
            
             XslCompiledTransform xct = new XslCompiledTransform();
             xct.Load(@"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Song.xsl");
             string fXML = @"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Songs.xml";
             string fHTML = @"E:\____________Study\OOP\Laboratory\Laboratory2\Laboratory2\Songs.html";
             xct.Transform(fXML, fHTML);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllSongs();
        }
    }
}
