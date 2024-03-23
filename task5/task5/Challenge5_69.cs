using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi(true,true,"etron gt","grey",50000000);
            Console.WriteLine(audi.toString());

            BMW bcar = new BMW(true, true, "iB8", "white", 20000000);
            Console.WriteLine(bcar.toString());

            GLI gcar= new GLI(true, true, "Volkswagen Jetta GLI", "Black", 15000000);
            Console.WriteLine(gcar.toString());

            Console.Read();
        }
    }
}
