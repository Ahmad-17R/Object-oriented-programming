using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();
            playlist.setPlaylistname();
            
            playlist.Addsong();
            playlist.DisplaySongs();
        }
    }
}
