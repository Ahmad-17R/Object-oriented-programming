using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Exercise
    {
        private string Name;
        private List<Set> sets=new List<Set>();

        public void Addset()
        {
            Set newset = new Set();
            newset.setName();
            newset.setweight();
            newset.setreps();
            sets.Add(newset);
        }

        public void Removeset(Set set)
        {
           
            sets.Remove(set);
        }

        public void viewlist()
        {
            foreach (Set set in sets)
            {
                set.viewset();
            }
            Console.Read();
        }

        public void setname()
        {
            Console.WriteLine("Enter the name of the exercise: ");
            Name=Console.ReadLine();
        }

        public string getname()
        {
            return Name;
        }

    }
}
