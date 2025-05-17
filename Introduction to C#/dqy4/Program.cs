using System.Diagnostics;

namespace dqy4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 3;
            //switch (num)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 9:
            //        console.writeline("odd");
            //        break;
            //    case 2:
            //    case 4:
            //    case 8:
            //    case 10:
            //        console.writeline("even");
            //        break;
            //    default:
            //        console.writeline("number of out of range");
            //        break;

            //}

            //**********************************************************************

            // TYPE SWITCH 1

            //object o = 4.9;
            //switch (o)
            //{
            //    case int or double:
            //        Console.WriteLine((dynamic) o*2);

            //        break;
            //    //case double d:
            //    //    Console.WriteLine(Math.Floor(d));
            //        break;
            //    case string s:
            //        Console.WriteLine(s.ToUpper());
            //        break;
            //    default:
            //        Console.WriteLine("Doun");
            //        break;


            //}


            //TYPE SWITCH 2
            ///
            //bool isbusniess = true;
            //bool hasbit = true;
            //switch (isbusniess)
            //{
            //    case bool j when hasbit == true:
            //        Console.WriteLine("more chages");
            //        break;
            //    case bool j when hasbit == false:
            //        Console.WriteLine("go insaid");
            //        break;

            //}

            // TYPE SWITCH 3

            //int num = 5;
            //string value = num switch
            //{
            //    1 => "card 1",
            //    2 => "card 2",
            //    3 => "card 3",
            //    4 => "card 4",
            //    5 => "card 5",

            //    _ => num.ToString()

            //}; Console.WriteLine(num);

            //Console.WriteLine(value);

            //*************************************
            // iterition diefngtio

            //************************* whil loop

            //int i = 0;
            //while (i <= 10) { 
            //        Console.WriteLine(i);
            //    i += 2;

            //}

            //*************************  do whil loop

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i += 2;

            //}
            //while (i <= 10);


            // ********** exampel for while*************
            //int k = 20;
            //Console.WriteLine("enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool f = true;

            //while (f)
            //{
            //    if (k > num)
            //    {
            //        Console.WriteLine("Up");
            //        Console.WriteLine("enter number agen?");
            //        k = Convert.ToInt32(Console.ReadLine());

            //    }
            //    else if (k < num)
            //    {
            //        Console.WriteLine("dowen");
            //        Console.WriteLine("enter number agen?");
            //        k = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("you win");
            //        f = false;
            //    }
            //}

            int num = Convert.ToInt32(Console.ReadLine());
          

            for (int i = 1; i <= num; i++)
            {
                if (num % i ==0)
                
                Console.WriteLine(i + " ");
            }
        }
    }
}

