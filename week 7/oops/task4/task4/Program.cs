using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Abu Bakr");
            User user2 = new User("Usman");

            Console.WriteLine($"Welcome {user1.GetUsername()}\n");

            user1.AddFollower(user2);
            user1.AddPost();
            user1.AddComment();
            user1.AddLike();

            user1.ViewUser();

            Console.ReadKey();
        }
    }
}
