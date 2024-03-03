using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Playlist
    {
        private string playlistname;
        private List<Song> songs=new List<Song>();

        public void Addsong()
        {
            Song song = new Song();
            song.SetsongName();
            song.SetWriterName();
            song.GetSingerName();
            songs.Add(song);
        }

        public void DisplaySongs()
        {
            foreach(Song s in songs) {
                s.Displaydetails();
            }
            Console.Read();
        }

        public void setPlaylistname()
        {
            Console.WriteLine("Enter the name of the playlist: ");
            playlistname= Console.ReadLine();
        }
    }
}
