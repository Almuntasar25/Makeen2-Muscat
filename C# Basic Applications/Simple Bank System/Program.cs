using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: Simple Bank System 

            bool i = true;
            while (i)
            {
                Console.WriteLine("Enter user name:"); // USER or user
                string UserName = Console.ReadLine();

                if (UserName == "USER" || UserName == "user")
                {
                    string[] User = UserName.Split(' ');
                    break;
                }
                else
                {
                    Console.WriteLine("user is not fond");
                }
            }
                bool x = true;
            while (x)
            {
                Console.WriteLine("Enter password:"); //1234
                string password = Console.ReadLine();

                if (password == "1234") 
                {
                    string[] UserPassword = password.Split(' ');
                    break;
                }
                else
                {
                    Console.WriteLine("password wronge");
                }

            }
            double[] UserBalances = new double[1];
            UserBalances[0] = 400; 


        Point:
            Console.WriteLine("selec posetion 1 - 5 :\r\n1-> Check Balance \r\n2 -> Deposit \r\n3-> Withdraw \r\n4 -> Transfer" +
                " \r\n5 → Exit ");
            string number =Console.ReadLine();

            bool y = true;
            while ( (number !="0") || (y = !true) )
            {
                switch (number)
                {
                    case "1":
                        Console.WriteLine($"Balance {UserBalances[0]}");
                        goto Point;

                    case "2":

                        Console.WriteLine($" Enter Deposit:");
                       double Deposit =double.Parse(Console.ReadLine());
                        double Depo = UserBalances[0] + Deposit;
                        Console.WriteLine($"Balance {Depo}");
                        goto Point;

                    case "3":
                        Console.WriteLine("How many do you Withdraw?:");
                       double Withdraw = double.Parse(Console.ReadLine());
                        if (UserBalances[0] >= Withdraw)
                        {
                            double Withd = UserBalances[0] - Withdraw;
                            Console.WriteLine($"Balance:{Withd}");
                            
                        }
                        else
                        {
                            Console.WriteLine("canot Withdraw");
                        }
                        goto Point;

                    case "4":
                        Console.WriteLine("How many do you Transfer?:");
                        double Transfer = double.Parse(Console.ReadLine());
                        double Trans = UserBalances[0] - Transfer;
                       
                        Console.WriteLine($"Balance = {Trans}");
                        goto Point;

                    case "5":
                       
                        i = false;
                        break;
                }

            }


        }
    }
}
