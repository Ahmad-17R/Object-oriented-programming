using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge_3;


namespace challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<MUser> userlist = new List<MUser>();
            string path = "Credentials.txt";

            if (readingData(path, userlist))
            {
                Console.WriteLine("Data Loaded");
            }
            else
            {
                Console.WriteLine("Data Not Loaded");
            }
            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                string option = menu();
                if (option == "1")
                {
                    Console.Clear();
                    MUser auser = withoutrole();
                    if (auser != null)
                    {
                        auser = signIn(auser, userlist);
                        if (auser == null)
                        {
                            Console.WriteLine("Invalid Credentials");
                        }
                        else if (auser.checkspell())
                        {
                            Console.WriteLine("Welcome! Admin.");
                        }
                        else
                        {
                            Console.WriteLine("Welcome! User.");
                        }
                    }
                }
                else if (option == "2")
                {
                    Console.Clear();
                    MUser auser = withrole();
                    if (auser != null)
                    {
                        signUp(path, auser);
                        userlist.Add(auser);
                    }

                }
                else if (option == "3")
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
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Your option is .... ");
            string option = Console.ReadLine();

            return option;
        }
        static bool readingData(string path, List<MUser> userlist)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string data;
                while ((data = file.ReadLine()) != null)
                {
                    string username = GetField(data, 1);
                    string password = GetField(data, 2);
                    string role = GetField(data, 3);
                    MUser user = new MUser(username, password, role);
                    userlist.Add(user);
                }
                file.Close();
                return true;
            }
            return false;
        }
        static string GetField(string record, int field)
        {
            int commaCount = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    item += record[x];
                }
            }

            return item;
        }
        static MUser withoutrole()
        {
            Console.Write("Enter username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;
        }
        static MUser signIn(MUser auser, List<MUser> userlist)
        {
            foreach (MUser Auser in userlist)
            {
                if (auser.name == Auser.name && auser.password == Auser.password)
                {
                    return Auser;
                }
            }
            return null;
        }

        static MUser withrole()
        {
            Console.Write("Enter username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;
        }

        static void signUp(string path, MUser auser)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(auser.name + "," + auser.password + "," + auser.role);
            file.Flush();
            file.Close();
        }
    }
}
