using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Song
    {
        private string SongName;
        private string WriterName;
        private string Singer;

        public void SetsongName()
        {
            Console.WriteLine("Enter the name of the song");
            SongName= Console.ReadLine();
        }

        public void SetWriterName()
        {
            Console.WriteLine("Enter the name of the writer: ");
            WriterName= Console.ReadLine();
        }

        public void  GetSingerName() {

            Console.WriteLine("Enter the name of the singer: ");
            Singer= Console.ReadLine();
        }

        public void Displaydetails()
        {
            Console.WriteLine($"Name: {SongName}");
            Console.WriteLine($"Written by: {WriterName}");
            Console.WriteLine($"Artist Name: {Singer}");
            Console.Read();
        }
    }
}
