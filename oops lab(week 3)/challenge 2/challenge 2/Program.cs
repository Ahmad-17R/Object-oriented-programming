using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge_2;

namespace challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shop> products = new List<Shop>();

            while (true)
            {
                Console.Clear();
                string option = menu();
                Console.Clear();

                if (option == "1")
                {
                    addp(products);
                    Console.Read();
                }
                else if (option == "2")
                {
                    show(products);
                    Console.Read();
                }
                else if (option == "3")
                {
                    worth(products);
                    Console.Read();
                }
                else if (option == "4")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Option!!!");
                }

            }
        }
        static string menu()
        {

            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit\n");

            Console.Write("Your option is .... ");
            string option = Console.ReadLine();

            return option;
        }
        static void addp(List<Shop> products)
        {

            Shop pro = new Shop();
            Console.Write("Enter Product Name: ");
            pro.name = Console.ReadLine();
            Console.Write("Enter ID: ");
            pro.id = Console.ReadLine();
            Console.Write("Enter Price: ");
            pro.price = float.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            pro.category = Console.ReadLine();
            Console.Write("Enter Brand Name: ");
            pro.brand = Console.ReadLine();
            Console.Write("Enter Country: ");
            pro.country = Console.ReadLine();

            products.Add(pro);
        }
        static void show(List<Shop> products)
        {

            if (products.Count == 0)
            {
                Console.WriteLine( "No current Products");
                Console.Read();
            }
            else
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{products[i].name}\t\t{products[i].price}");
                }
                Console.WriteLine( "These are the current products.");
                Console.Read();
                
            }
            
        }
            static void worth(List<Shop> products)
            {
            if (products.Count == 0)
            {
                Console.WriteLine("Total Store Worth = 0.0");
            }
            else
            {
                float sum = 0;

                for (int x = 0; x < products.Count; x++)
                {
                    sum += products[x].price;
                }
                Console.WriteLine($"Total Store Worth: {sum}");
                Console.WriteLine();
                Console.Read();
                
            }
        }

    }
}
