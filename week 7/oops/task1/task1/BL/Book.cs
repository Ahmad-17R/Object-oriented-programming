using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Book
    {
        private string Name;
        private Author author;

        public void SetAuthorName()
        {
            author = new Author();
            author.SetName();

        }

        public void bookdetails()
        {
            Console.WriteLine($"The name of the book is {Name}");
            author.ShowName();
        }

        public void setBookname()
        {
            Console.WriteLine("Enter the name of the book: ");
            Name=Console.ReadLine();
        }

    }
}
