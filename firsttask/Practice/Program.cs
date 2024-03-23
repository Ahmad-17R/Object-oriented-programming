using Practice.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayScholar std = new DayScholar();
            std.Name = "Ahmad";
            std.BusNO = 1;
            Console.WriteLine($"{std.Name} is Allocated Bus {std.BusNO}");

            Hostellite hostellite = new Hostellite();
            hostellite.Name = "Ali";
            hostellite.RoomNO = 1;
            Console.WriteLine($"{hostellite.Name} is Allocated Room {hostellite.RoomNO}");

            Console.ReadKey();
        }
    }
}
