using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Set
    {
        private string Name;
        private int weight;
        private int reps;

        public void setName()
        {
            Console.WriteLine("Enter the name of the set: ");
            Name=Console.ReadLine();

        }
        public void setweight()
        {
            Console.WriteLine("Enter the weight of the set: ");
            weight = int.Parse(Console.ReadLine());

        }
        public void setreps()
        {
            Console.WriteLine("Enter the reps of the set: ");
            reps = int.Parse(Console.ReadLine());

        }

        public void viewset()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Weight :{weight}");
            Console.WriteLine($"Repitions: {reps}");
        }
    }
}
