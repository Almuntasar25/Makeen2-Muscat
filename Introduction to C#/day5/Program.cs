using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] number = { };

            //Console.WriteLine("enter number:");
            //int sum = 0;

            //int num =Convert.ToInt32(Console.ReadLine());
            //while (num != 0) {
            //    //
            //    int digit = num % 10;
            //    sum += digit;
            //    num /= 10;
            //}
            //Console.WriteLine(sum);


            //Console.WriteLine("number");
            //int number=Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= number; i++) {
            //    result *= i;
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine(result);


            //int[,] matrix =
            //{
            //    {1,2,3,},
            //    {4,5,6,}
            //};
            //for (int r = 0; r < matrix.Length; r++)
            //{

            //    for (int c = 0; c < matrix.GetLength(0); c++)
            //    {
            //        Console.WriteLine($"{matrix[r,c]}");
            //    }
            //}

            // foreach read all type!
            //String s = "hello";
            //foreach (char c in s)
            //{
            //    Console.WriteLine(c);
            //}


            //1
            //12
            //123
            //1234
            //int num = 4;
            //for (int i = 1; i <= num; i++) {

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j+" ");
            //        Console.WriteLine();
            //    }

            //}
            // go to point***************
            //int x = 5;

            //Point:
            //    Console.WriteLine("go to");
            //    if (x <= 7 )
            //    {
            //        Console.WriteLine("smaller");
            //    x = 8;
            //    goto Point;

            //    }
            //}


            //string s1 = "5";
            //string s2 = "2";
            //Console.WriteLine(int.Parse(s1)+int.Parse(s2)); // Casteng to int but canot casting "null"!!
            //Console.WriteLine(Convert.ToInt32(s1) + Convert.ToInt32(s2)); //  Casteng to int

            //Console.WriteLine("enter marke");
            //string[] stodent_marke = Console.ReadLine().Split(" ");
            //string score = "";

            //for (int i = 0; i < stodent_marke.Length; i++)
            //{
            //    int marke = Convert.ToInt32(stodent_marke[i]);
            //    if (marke <= 100 && marke >= 90)
            //    {
            //        score += " "+"A";
            //    }
            //    else if (marke <= 89 && marke >= 80)
            //    {
            //        score += "  "+"B";
            //    }
            //    else if (marke <= 79 && marke >= 70)
            //    {
            //        score += "  "+ "C";
            //    }
            //    else if (marke <= 69 && marke >= 60)
            //    {
            //        score += "  " + "D";
            //    }
            //    else {
            //        score += "  "+ "F";
            //    }
            //}
            //Console.WriteLine(score);


            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            //Array.Sort(num);
            //Array.Reverse(num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i] + " ");
            //}

            //int[] num = { 30 ,10 , 40 ,5, 1 }; //source
            //int[] num2 =new int [3]{ 1,4,6 }; //destnetion
            //Array.Copy(num , 0 , num2,1 ,2);
            //Array.Sort(num);
            //Array.Reverse(num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num2[i] + " ");
            //}
            //Console.WriteLine("name");
            //string FName = Console.ReadLine();
            //Console.WriteLine("last name");

            //string lName = Console.ReadLine();
            //Console.WriteLine("worced Houers:");

            //int worcedHouers =int.Parse(Console.ReadLine());
            //Console.WriteLine("price:");

            //double price = double.Parse(Console.ReadLine());
            //const double TAX = 0.03;
            //double salary = (worcedHouers * price) - (worcedHouers * price * TAX);
            //Console.WriteLine($"{FName} {lName} worked for {worcedHouers}" , "and totall" + $"salary is {salary}");

            Class1 o1 = new Class1();
            o1.FName = "Test";
            o1.lName = "Test1";
            o1.worcedHouers = 3;
            o1.price = 10;
            o1.salary = 10;

            Class1 o2 = new Class1();
            o2.FName = "Test";
            o2.lName = "Test1";
            o2.worcedHouers = 3;
            o2.price = 10;
            o2.salary = 10;

            Class1 o3 = new Class1();

            Class1[] employy= { o1, o2 };

            foreach (Class1 emp in employy)
            {
                double salary = (emp.worcedHouers * emp.price) - (emp.worcedHouers * emp.price * Class1.TAX);
                Console.WriteLine($"{emp.FName} {emp.lName} worked for {emp.worcedHouers}", "and totall" + $"salary is {emp.salary}");



            }





        }
    }
}
