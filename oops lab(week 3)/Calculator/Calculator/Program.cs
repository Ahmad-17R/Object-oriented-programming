using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            calculate.num1 = 20;
            calculate.num2 = 10;

            calculate.add();
            calculate.subtract();
            calculate.multiply();
            calculate.divide();
            Console.Read();
        }
    }
}
