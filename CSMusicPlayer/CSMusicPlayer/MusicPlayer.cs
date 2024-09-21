using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMusicPlayer
{
    public partial class MusicPlayer : Form
    {
        List<Song> _songs;
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void InitializingAReferenceToSongNull ()
        {
            if (_songs == null)
                _songs = new List<Song>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
                AddSongToList(dialog.SafeFileNames.ToList(), dialog.FileNames.ToList());
        }
        
        private void AddSongToList(List<string> names, List<string> paths)
        {
            InitializingAReferenceToSongNull();

            foreach (var name in names)
            {
                if(!ExistOnlist(name))
                    _songs.Add(new Song(name, GetPath(name, paths)));
            }

            RefreshList();
        }

        private bool ExistOnlist (string song)
        {
            bool exists = false;
            
            foreach(var songName in _songs)
            {
                if (songName.Name == song)
                    exists = true;
            }

            return exists;
        }

        private string GetPath(string fileName, List<string> songsPaths = null)
        {
            string actualPath = string.Empty;

            if (songsPaths == null)
                foreach (var song in _songs)
                {
                    if (song.Name == fileName)
                        actualPath = song.Path;
                }
            else
            {
                foreach (var path in songsPaths)
                {
                    if (path.Contains(fileName))
                        actualPath = path;
                }
            }
            return actualPath;
        }

        private void SongsList_DoubleClick(object sender, EventArgs e)
        {
            InitializingAReferenceToSongNull();

            axWindowsMediaPlayer1.URL = GetPath(SongsList.Text);
            

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            InitializingAReferenceToSongNull();

            Song songToRemove = null;

            foreach (var song in _songs)
            { 
                if (song.Name == SongsList.Text)
                {
                    songToRemove = song;
                }
            }


            if (songToRemove != null)
                _songs.Remove(songToRemove);
            
            RefreshList();
        }

        private void RefreshList ()
        {
            List<string> songNames = new List<string>();

            foreach (var song in _songs)
                songNames.Add(song.Name);
            
            SongsList.DataSource = null;
            SongsList.DataSource = songNames;
        }

        
    }
}
