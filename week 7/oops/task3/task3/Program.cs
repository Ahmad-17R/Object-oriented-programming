using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Routine routine = new Routine();
            routine.Setname();
            routine.Addexercise();
            routine.viewexercises();
        }
    }
}
