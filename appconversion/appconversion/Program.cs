using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appconversion;

namespace appconversion
{
    internal class Programd
    {
        static void Main(string[] args)
        {
            List<Student> stentry = new List<Student>();
            List<Admin> adentry = new List<Admin>();
            string filename = "studentdata.txt";
            string loginfile = "Logindata.txt";
          //  ReadStuFile(filename, stentry);
          //  ReadFileSignIn(loginfile, adentry);
            while (true)
            {

                int option = firstmenu();
                if (option == 1)
                {
                    signin(adentry, stentry);
                }
                else if (option == 2)
                {
                    signup(adentry, stentry);
                }
            }
           // WriteStuFile(filename, stentry);
           // WriteFile(loginfile,adentry);
        }



        static int firstmenu()
        {
            int option;
            Console.WriteLine("1.Sign In");
            Console.WriteLine("2.Sign up");
            Console.WriteLine("3.Exit");
            Console.WriteLine("");
            Console.Write("Enter your option...   ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void signup(List<Admin> adentry, List<Student> stentry)

        {
            string personrole;
            Console.WriteLine("Enter your role(student/admin");
            personrole = Console.ReadLine();


            if (personrole == "admin")
            {
                Admin s = new Admin();

                Console.WriteLine("Enter your name: ");
                s.name = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                s.password = Console.ReadLine();

                adentry.Add(s);
            }
            else if (personrole == "student")
            {
                Student t = new Student();
                Console.WriteLine("Enter your name: ");
                t.name = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                t.password = Console.ReadLine();
                stentry.Add(t);
            }


            Console.WriteLine("You have successfully signed up;");
        }
        static void signin(List<Admin> adentry, List<Student> stentry)

        {
            int ACprice = 0, Bedprice = 0, Dcprice = 0, Winterprice = 0, messfee = 0, messservice = 0, Aprice = 0, Bprice = 0, Cprice = 0, Dprice = 0, Messfee = 0, Messservice = 0;
            string personrole;
            Console.WriteLine("Are you a student  or admin?: ");
            personrole = Console.ReadLine();
            if (personrole == "student")
            {
                string username;
                Console.WriteLine("Enter your name: ");
                username = Console.ReadLine();
                for (int i = 0; i < stentry.Count; i++)
                {
                    if (stentry[i].name == username)
                    {
                        string passcode;
                        Console.WriteLine("Enter your password: ");
                        passcode = Console.ReadLine();
                        for (int j = 0; j < stentry.Count; j++)
                        {
                            if (stentry[i].password == passcode)
                            {
                                Console.WriteLine("You have successfully signed in;");
                                //  studentmenu(courses, username);
                                menuhostelit(stentry, ref username, ACprice, Bedprice, Dcprice, Winterprice, messfee, messservice, Aprice, Bprice, Cprice, Dprice);
                                Console.Read();
                            }
                        }
                    }
                }
            }
            if (personrole == "admin")
            {
                string username;
                Console.WriteLine("Enter your name: ");
                username = Console.ReadLine();
                for (int i = 0; i < adentry.Count; i++)
                {
                    //  Console.Write("a");
                    if (adentry[i].name == username)
                    {
                        string passcode;
                        Console.WriteLine("Enter your password: ");
                        passcode = Console.ReadLine();
                        for (int j = 0; j < adentry.Count; j++)
                        {
                            if (adentry[i].password == passcode)
                            {
                                //teachermenu(courses);
                                AdminMenu(adentry, stentry, ref username, ref Aprice, ref Bprice, ref Cprice, ref Dprice, ref Messfee, ref Messservice, ref ACprice, ref Bedprice, ref Dcprice, ref Winterprice);

                                Console.Read();
                            }
                        }
                    }
                }
            }

            Console.WriteLine("You have successfully signed in;");

        }
        static void Studentdetails(List<Student> stentry, string username)
        {
            int stuindex = 0;
            for (int i = 0; i < stentry.Count; i++)
            {
                if (username == stentry[i].name)
                {
                    stuindex = i;
                }
            }
            Console.Write("Enter your name: ");
            stentry[stuindex].stname = Console.ReadLine();
            Console.Write("Enter your father name: ");
            stentry[stuindex].fathern = Console.ReadLine();
            Console.Write("Enter your phone numeber: ");
            stentry[stuindex].phone = Console.ReadLine();
            Console.Write("Enter your cnic: ");
            stentry[stuindex].cnic = Console.ReadLine();

        }
        static void roomcat(List<Student> stentry, int Aprice, int Bprice, int Cprice, int Dprice, string username)
        {

            int stuindex = 0;
            for (int i = 0; i < stentry.Count; i++)
            {
                if (username == stentry[i].name)
                {
                    stuindex = i;
                }
            }

            Console.WriteLine("categories     students in room");

            Console.WriteLine($"1.A            one student      Rs.{Aprice}/-");

            Console.WriteLine($"2.B            two students      Rs.{Bprice}/-");

            Console.WriteLine($"3.C            three students    Rs.{Cprice}/-");

            Console.WriteLine($"4.D            four students     Rs.{Dprice}/-");

            char category;
            Console.WriteLine("Enter your room category:");
            category = Console.ReadLine()[0];
            if (category == 'A')
            {
                stentry[stuindex].roomrent = Aprice;
                stentry[stuindex].category = "A";
            }
            else if (category == 'B')
            {
                stentry[stuindex].roomrent = Bprice;
                stentry[stuindex].category = "B";
            }
            else if (category == 'C')
            {
                stentry[stuindex].roomrent = Cprice;
                stentry[stuindex].category = "B";
            }
            else if (category == 'D')
            {
                stentry[stuindex].roomrent = Dprice;
                stentry[stuindex].category = "D";
            }
        }
        static void messinfo(List<Student> stentry, int messfee, int messservice, string username)
        {

            int stuindex = 0;
            for (int i = 0; i < stentry.Count; i++)
            {
                if (username == stentry[i].name)
                {
                    stuindex = i;
                }
            }

            Console.WriteLine("The management provides the mess two times a day");

            Console.WriteLine($"Mess fee per month: Rs.{messfee}");

            Console.WriteLine($"The mess service which is {messservice} rupees in addition to the mess fee.");

            // If you want to read a string input from the user:
            Console.WriteLine("Do you want the mess service? ");
            string userInput = Console.ReadLine();
            if (userInput == "Yes" || userInput == "yes")
            {
                stentry[stuindex].messfee = messfee + messservice;
            }
            else
            {
                stentry[stuindex].messfee = 0;
            }


        }
        static void premium(List<Student> stentry, int ACprice, int Bedprice, int Dcprice, int Winterprice, string username)
        {
            int stuindex = 0;
            for (int i = 0; i < stentry.Count; i++)
            {
                if (username == stentry[i].name)
                {
                    stuindex = i;
                }
            }

            Console.WriteLine($"1. Air Conditioner                       Rs.{ACprice}/- per month");

            Console.WriteLine($"2. Double Bed.                           Rs.{Bedprice}/- per month");

            Console.WriteLine($"3. Get your clothes dry cleaned.         Rs.{Dcprice}/- per month");

            Console.WriteLine($"4. Room Heater and warm water in winter. Rs.{Winterprice}/- per month");
            string ACans, Bedans, Dcans, Winterans;
            Console.WriteLine("Do you want AC service?(Yes/No)");
            ACans = Console.ReadLine();
            Console.WriteLine("Do you want Double bed service?(Yes/No)");
            Bedans = Console.ReadLine();
            Console.WriteLine("Do you want dry cleaning service?(Yes/No)");
            Dcans = Console.ReadLine();
            Console.WriteLine("Do you want Winter facilities service?(Yes/No)");
            Winterans = Console.ReadLine();
            if (ACans != "Yes")
            {
                ACprice = 0;
            }
            if (Bedans != "Yes")
            {
                Bedprice = 0;
            }
            if (Dcans != "Yes")
            {
                Dcprice = 0;
            }
            if (Winterans != "Yes")
            {
                Winterprice = 0;
            }
            stentry[stuindex].premium = ACprice + Bedprice + Winterprice + Dcprice;

        }
        static void receipt(List<Student> stentry, string username)
        {
            int stuindex = 0;
            for (int i = 0; i < stentry.Count; i++)
            {
                if (username == stentry[i].name)
                {
                    stuindex = i;
                }
            }
            stentry[stuindex].roomno = stuindex;
            Console.WriteLine($"Name\t\t\t{stentry[stuindex].name}");

            Console.WriteLine($"Category\t\t\t{stentry[stuindex].category}");

            Console.WriteLine($"Room no.\t\t\t{stentry[stuindex].roomno}");

            Console.WriteLine($"Room Rent\t\t\tRs.{stentry[stuindex].roomrent}");

            Console.WriteLine($"Mess Fee\t\t\tRs.{stentry[stuindex].messfee}");

            Console.WriteLine($"Premium facilities\t\t\tRs.{stentry[stuindex].premium}");

            stentry[stuindex].totalex = stentry[stuindex].roomrent + stentry[stuindex].messfee + stentry[stuindex].premium;

            Console.WriteLine($"         Total Dues\t\t\tRs.{stentry[stuindex].totalex}");
            Console.WriteLine($"         Payment status\t\t\t{stentry[stuindex].paymentstatus}");

        }
        static void changeuserPass(List<Student> stentry, ref string username)
        {
            int stuindex = 0;
            for (int i = 0; i < stentry.Count; i++)
            {
                if (username == stentry[i].name)
                {
                    stuindex = i;
                }
            }
            Console.Write("What do you want to change? Username or password type:(User/Pass): ");
            string change = Console.ReadLine();

            if (change == "User" || change == "Pass")
            {
                if (change == "User")
                {

                    Console.Write("Enter password to make change in username: ");
                    string passcode = Console.ReadLine();

                    if (passcode == stentry[stuindex].password)
                    {
                        Console.Write("Enter the new username: ");
                        stentry[stuindex].name = Console.ReadLine();
                        username = stentry[stuindex].name;
                    }
                    else
                    {
                        Console.Write("Wrong password.");
                    }
                }
                else if (change == "Pass")
                {

                    Console.Write("Enter the old password: ");
                    string passcode = Console.ReadLine();

                    if (passcode == stentry[stuindex].password)
                    {


                        Console.Write("Enter the new Password: ");
                        stentry[stuindex].password = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Wrong password.");
                    }
                }
            }
            else
            {
                Console.Write("Entered input is incorrect.");
            }


        }
        static void menuhostelit(List<Student> stentry, ref string username, int ACprice, int Bedprice, int Dcprice, int Winterprice, int messfee, int messservice, int Aprice, int Bprice, int Cprice, int Dprice)
        {
            while (true)
            {
                string option;
                Console.WriteLine("Complete the following steps....");

                Console.WriteLine("1.Student Details/Bio Data:");

                Console.WriteLine("2.Room categories/Selecting Room");

                Console.WriteLine("3.Mess Info/Avail Mess Facility");

                Console.WriteLine("5.Dues section/Dues to Pay");

                Console.WriteLine("6.Change username/password");

                Console.WriteLine("7.Logout");
                Console.Write("Enter your option . . ");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Studentdetails(stentry, username);
                }
                else if (option == "2")
                {
                    roomcat(stentry, Aprice, Bprice, Cprice, Dprice, username);
                }
                else if (option == "3")
                {
                    messinfo(stentry, messfee, messservice, username);
                }
                else if (option == "4")
                {
                    premium(stentry, ACprice, Bedprice, Dcprice, Winterprice, username);
                }
                else if (option == "5")
                {
                    receipt(stentry, username);
                }
                else if (option == "6")
                {
                    changeuserPass(stentry, ref username);
                }
                else
                {
                    break;
                }

            }


        }
        static void ViewStudents(List<Student> stentry)
        {

            Console.WriteLine("The list of Registered students is:");

            Console.WriteLine("Name\t\t\tFather name");
            if (stentry.Count > 0)
            {
                for (int j = 0; j < stentry.Count; j++)
                {
                    Console.WriteLine($"{j + 1}.{stentry[j].name}\t\t\t{stentry[j].fathern}");
                }
            }
            else
            {
                Console.WriteLine("No registered students!");
            }
        }
        static void messupdate(List<Admin> adentry, string username)
        {
            int adindex = 0;
            for (int i = 0; i < adentry.Count; i++)
            {
                if (username == adentry[i].name)
                {
                    adindex = i;
                }
            }
            if (adentry[adindex].mess.Count > 0)
            {
                for (int i = 0; i < adentry[adindex].mess.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{adentry[adindex].mess[i]}");
                }
            }
            Console.WriteLine("Do you want you make any changes in the menu?(yes/No)");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                Console.WriteLine("What do you want to do(Add/Remove)Dish? ");
                string ans2 = Console.ReadLine();
                if (ans2 == "Add")
                {
                    adentry[adindex].mess.Add(Console.ReadLine());
                }
                else if (ans2 == "Remove")
                {
                    adentry[adindex].mess.Remove(Console.ReadLine());
                }

            }
        }
        static void UpdatePrice(ref int Aprice, ref int Bprice, ref int Cprice, ref int Dprice, ref int Messfee, ref int Messservice, ref int ACprice, ref int Bedprice, ref int Dcprice, ref int Winterprice)
        {
            Console.WriteLine($"1.Category A :Rs{Aprice}");
            Console.WriteLine($"2.Category B :Rs{Bprice}");

            Console.WriteLine($"3.Category C :Rs{Cprice}");

            Console.WriteLine($"4.Category D :Rs{Dprice}");

            Console.WriteLine($"5.Mess fee :Rs{Messfee}");

            Console.WriteLine($"6.Mess Service :Rs{Messservice}");

            Console.WriteLine($"7.Air Conditioner :Rs{ACprice}");

            Console.WriteLine($"8.Bed :Rs{Bedprice}");

            Console.WriteLine($"9.Dry Cleaning: Rs{Dcprice}");

            Console.WriteLine($"10.Winter facilities :Rs{Winterprice}");

            int[] elements = { Aprice, Bprice, Cprice, Dprice, Messfee, Messservice, ACprice, Bedprice, Dcprice, Winterprice };


            Console.Write("Do you want to update the price?(Y/N): ");
            char ans = Console.ReadKey().KeyChar;

            if (ans == 'Y' || ans == 'y')
            {
                Console.Write("Enter the option number to update: ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new price");
                int newprice = int.Parse(Console.ReadLine());
                string str = "";
                if (option == 1)
                {
                    newprice = Aprice;
                    str = "Prices are Updated";
                }
                else if (option == 2)
                {
                    newprice = Bprice;
                    str = "Prices are Updated";
                }
                else if (option == 3)
                {
                    newprice = Cprice;
                    str = "Prices are Updated";
                }
                else if (option == 4)
                {
                    newprice = Dprice;
                    str = "Prices are Updated";
                }
                else if (option == 5)
                {
                    newprice = Messfee;
                    str = "Prices are Updated";
                }
                else if (option == 6)
                {
                    newprice = Messservice;
                    str = "Prices are Updated";
                }
                else if (option == 7)
                {
                    newprice = ACprice;
                    str = "Prices are Updated";
                }
                else if (option == 8)
                {
                    newprice = Bedprice;
                    str = "Prices are Updated";
                }
                else if (option == 9)
                {
                    newprice = Dcprice;
                    str = "Prices are Updated";
                }
                else if (option == 10)
                {
                    newprice = Winterprice;
                    str = "Prices are Updated";
                }
                else
                {
                    str = "No changes made!";
                }
                Console.Write(str);

            }

        }
        static void DuesAdmin(List<Student> stentry)
        {

            Console.WriteLine("Name\t\t\t          Dues");



            for (int i = 0; i < stentry.Count; i++)
            {


                Console.WriteLine($"{i + 1}. {stentry[i].stname} {stentry[i].totalex} {stentry[i].paymentstatus}");


            }
            Console.Write("Do you want to Pay the charges(Y/N)?");
            char ans = Console.ReadKey().KeyChar;

            string result;

            if (ans == 'Y' || ans == 'y')
            {
                bool rule = false;
                Console.Write("Which user?(enter the name)?");
                string answer = Console.ReadLine();

                for (int k = 0; k < stentry.Count; k++)
                {
                    if (answer == stentry[k].stname)
                    {
                        stentry[k].paymentstatus = "paid";
                        rule = true;
                    }
                }

                if (rule)
                {
                    result = "Changes made!";
                }
                else
                {
                    result = "User did not match";
                }
            }
            else
            {
                result = "No Changes Made!";
            }

            Console.Write(result);
        }
        static void UserAccounts(List<Student> stentry)
        {
            // int i = 0;
            // WriteFile(filename, username, password, role);
            // ReadFileSignIn(filename, username, password, role, i);

            //  Console.SetCursorPosition(64, 15);
            Console.WriteLine("Users account are the following: ");



            for (int j = 0; j < stentry.Count; j++)
            {

                //Console.SetCursorPosition(64, x);
                Console.WriteLine($"{j + 1}. {stentry[j].name}\t\t\t{stentry[j].password}");
            }

            //  Console.SetCursorPosition(64, 20);
            Console.Write("Do you want to delete account?(Y/N)");
            char ans = Console.ReadKey().KeyChar;

            string result = "";

            if (ans == 'y' || ans == 'Y')
            {
                //Console.SetCursorPosition(64, 21);
                Console.Write("Enter the username of the account which you want to delete: ");
                string userDel = Console.ReadLine();

                bool rule = false;

                for (int j = 0; j < stentry.Count; j++)
                {
                    if (stentry[j].name == userDel)
                    {
                        stentry.Remove(stentry[j]);
                        rule = true;
                        result = "User account deleted!";
                        break;
                    }
                }

                if (!rule)
                {
                    result = "Invalid input";
                }
            }
            else
            {
                //Console.SetCursorPosition(64, 21);
                Console.WriteLine("Invalid input!");
                result = "No changes made!";
            }

            Console.Write(result);
        }
        static void changeadminPass(List<Admin> adentry, ref string username)
        {
            int adindex = 0;
            for (int i = 0; i < adentry.Count; i++)
            {
                if (username == adentry[i].name)
                {
                    adindex = i;
                }
            }
            Console.Write("What do you want to change? Username or password type:(User/Pass): ");
            string change = Console.ReadLine();

            if (change == "User" || change == "Pass")
            {
                if (change == "User")
                {

                    Console.Write("Enter password to make change in username: ");
                    string passcode = Console.ReadLine();

                    if (passcode == adentry[adindex].password)
                    {
                        Console.Write("Enter the new username: ");
                        adentry[adindex].name = Console.ReadLine();
                        username = adentry[adindex].name;
                    }
                    else
                    {
                        Console.Write("Wrong password.");
                    }
                }
                else if (change == "Pass")
                {

                    Console.Write("Enter the old password: ");
                    string passcode = Console.ReadLine();

                    if (passcode == adentry[adindex].password)
                    {


                        Console.Write("Enter the new Password: ");
                        adentry[adindex].password = Console.ReadLine();

                    }
                    else
                    {
                        Console.Write("Wrong password.");
                    }
                }
            }
            else
            {
                Console.Write("Entered input is incorrect.");
            }


        }
        static void AdminMenu(List<Admin> adentry, List<Student> stentry, ref string username, ref int Aprice, ref int Bprice, ref int Cprice, ref int Dprice, ref int Messfee, ref int Messservice, ref int ACprice, ref int Bedprice, ref int Dcprice, ref int Winterprice)
        {
            while (true)
            {
                Console.WriteLine("1. View Registered Students");
                Console.WriteLine("2. Update Mess");
                Console.WriteLine("3. Update the prices/charges");
                Console.WriteLine("4. Dues Management");
                Console.WriteLine("5. Check/Delete users accounts");
                Console.WriteLine("6. Change Username/Password");
                Console.WriteLine("7. Logout");
                Console.Write("Enter your option: ");

                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    ViewStudents(stentry);
                }
                else if (option == 2)
                {
                    messupdate(adentry, username);
                }
                else if (option == 3)
                {
                    UpdatePrice(ref Aprice, ref Bprice, ref Cprice, ref Dprice, ref Messfee, ref Messservice, ref ACprice, ref Bedprice, ref Dcprice, ref Winterprice);
                }
                else if (option == 4)
                {
                    DuesAdmin(stentry);
                }
                else if (option == 5)
                {
                    UserAccounts(stentry);
                }
                else if (option == 6)
                {
                    changeadminPass(adentry, ref username);
                }
                else
                {
                    break;
                }
            }
        }
        static void WriteStuFile(string filename, List<Student> stentry)
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                for (int i = 0; i < stentry.Count; i++)
                {

                    file.WriteLine($"{stentry[i].name},{stentry[i].password},{stentry[i].stname},{stentry[i].fathern},{stentry[i].phone},{stentry[i].cnic},{stentry[i].roomrent},{stentry[i].messfee},{stentry[i].premium},{stentry[i].totalex},{stentry[i].paymentstatus},{stentry[i].category},{stentry[i].roomno}");

                }
            }
        }
        static void ReadStuFile(string filename, List<Student> stentry)
        {
            if (File.Exists(filename)) { }
            using (StreamReader file = new StreamReader(filename))
            {
                int i = 0;
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        stentry[i].name = GetField(line, 1);
                        stentry[i].password = GetField(line, 2);
                        stentry[i].stname = GetField(line, 3);
                        stentry[i].fathern = GetField(line, 4);
                        stentry[i].phone = GetField(line, 5);
                        stentry[i].cnic = GetField(line, 6);
                        stentry[i].roomrent = int.Parse(GetField(line, 7));
                        stentry[i].messfee = int.Parse(GetField(line, 8));
                        stentry[i].premium = int.Parse(GetField(line, 9));
                        stentry[i].totalex = int.Parse(GetField(line, 10));
                        stentry[i].paymentstatus = GetField(line, 11);
                        stentry[i].category = GetField(line, 12);
                        stentry[i].roomno = int.Parse(GetField(line, 13));
                        i++;
                    }
                }
            }
        }
        }
        static string GetField(string record, int field)
        {
            int commaCount = 1;
            string item = string.Empty;

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
        static void WriteFile(string filename, List<Admin> adentry)
        {
            using (StreamWriter file = new StreamWriter(filename))

                for (int i = 0; i < adentry.Count; i++)
                {
                    file.Write($"{adentry[i].name},{adentry[i].password}");

                }
        }

    static void ReadFileSignIn(string filename, List<Admin> adminList)
    {
        if (File.Exists(filename))
        {
            using (StreamReader file = new StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        adminList.Add(new Admin
                        {
                            name = GetField(line, 1),
                            password = GetField(line, 2)
                        });
                    }
                }
            }
        }




    }

    }
}
          
