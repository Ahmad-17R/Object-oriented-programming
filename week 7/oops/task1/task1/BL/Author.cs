using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Author
    {
        private string Name;

        public void SetName()
        {
            Console.WriteLine("Enter the name of the author: ");
            Name=Console.ReadLine();
        }
        public void ShowName()
        {
            Console.WriteLine($"The Name of the author is {Name}");
            Console.Read();
        }

        public Author()
        {

        }

        public Author(string name)
        {
            Name=name;
        }
    }
}
