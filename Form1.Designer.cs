namespace Laboratory2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Search = new System.Windows.Forms.Button();
            this.Transform = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.CheckBox();
            this.BandName = new System.Windows.Forms.CheckBox();
            this.Album = new System.Windows.Forms.CheckBox();
            this.SongName = new System.Windows.Forms.CheckBox();
            this.Duration = new System.Windows.Forms.CheckBox();
            this.ReleaseYear = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 399);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 39);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Transform
            // 
            this.Transform.Location = new System.Drawing.Point(120, 399);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(104, 39);
            this.Transform.TabIndex = 1;
            this.Transform.Text = "Transform";
            this.Transform.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(248, 399);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 39);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(29, 34);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(70, 24);
            this.Genre.TabIndex = 3;
            this.Genre.Text = "Genre";
            this.Genre.UseVisualStyleBackColor = true;
            this.Genre.CheckedChanged += new System.EventHandler(this.Genre_CheckedChanged);
            // 
            // BandName
            // 
            this.BandName.AutoSize = true;
            this.BandName.Location = new System.Drawing.Point(29, 81);
            this.BandName.Name = "BandName";
            this.BandName.Size = new System.Drawing.Size(109, 24);
            this.BandName.TabIndex = 4;
            this.BandName.Text = "Band Name";
            this.BandName.UseVisualStyleBackColor = true;
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(29, 130);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(75, 24);
            this.Album.TabIndex = 5;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Location = new System.Drawing.Point(29, 177);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(109, 24);
            this.SongName.TabIndex = 6;
            this.SongName.Text = "Song Name";
            this.SongName.UseVisualStyleBackColor = true;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(29, 226);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(89, 24);
            this.Duration.TabIndex = 7;
            this.Duration.Text = "Duration";
            this.Duration.UseVisualStyleBackColor = true;
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.AutoSize = true;
            this.ReleaseYear.Location = new System.Drawing.Point(29, 272);
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.Size = new System.Drawing.Size(114, 24);
            this.ReleaseYear.TabIndex = 8;
            this.ReleaseYear.Text = "Release Year";
            this.ReleaseYear.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 28);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(155, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 28);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(155, 175);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 28);
            this.comboBox4.TabIndex = 12;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(155, 226);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(172, 28);
            this.comboBox5.TabIndex = 13;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(155, 272);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(172, 28);
            this.comboBox6.TabIndex = 14;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(12, 340);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(57, 24);
            this.SAX.TabIndex = 15;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(120, 340);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(65, 24);
            this.DOM.TabIndex = 16;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(234, 340);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(63, 24);
            this.LINQ.TabIndex = 17;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 430);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ReleaseYear);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.BandName);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Transform;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox Genre;
        private System.Windows.Forms.CheckBox BandName;
        private System.Windows.Forms.CheckBox Album;
        private System.Windows.Forms.CheckBox SongName;
        private System.Windows.Forms.CheckBox Duration;
        private System.Windows.Forms.CheckBox ReleaseYear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

