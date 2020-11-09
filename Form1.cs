using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class Form1 : Form
    {
        string path = "Songs.xml";
        private List<Song> songs = new List<Song>; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Genre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
