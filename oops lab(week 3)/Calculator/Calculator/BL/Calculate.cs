using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculate
    {
        public float num1;
        public float num2;

        public void add()
        {
            Console.WriteLine(num1 + "+" + num2+"="+(num1+num2));
        }
        public void subtract()
        {
            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
        }
        public void multiply()
        {
            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
        }
        public void divide()
        {
            Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
        }
    }
}
