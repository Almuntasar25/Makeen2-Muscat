namespace Tesetproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[3] {1,3,5};
            //num[0] = 1;
            //num[1] = 2;
            //num[2] = 3;
            //Console.WriteLine(num[2]);


            //int[,] num1 = new int[0,1];
            //num1[0,0] = 1;
            //num1[0,1] = 2;
            //num1[1,1] = 3;
            //Console.WriteLine(num1[1,1]);
            //Console.WriteLine(num1[0,1]);

            //int[][] avg = new int [][];
            //new int[] { 0, 1, 2, 3,);

            //int[] number = {1,2,3,4,6,5,6};
            //int[] slice1 = number[2..4];
            //int[] slice2 = number[2..];
            //int[] slice3 = number[..5];

            //Console.WriteLine(slice3[3]);



            //string name = Console.ReadLine();
            //if (name == null )
            //{
            //    Console.WriteLine("Name:", name);
            //}
            //else { Console.WriteLine("no name"); }


            //string name = null;
            //string num = name == null ? "null": name;
            //Console.WriteLine(num);

            //Console.WriteLine("Enter number 1 :");
            //int number1 =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter + or - or * or / :");
            //string x = Console.ReadLine();
            //Console.WriteLine("Enter number 2 :");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int rusolt;

            //if (x == "+")
            //{
            //    rusolt = number1 + number2;
            //    Console.WriteLine(number1 + " + " + number2 + " = " + rusolt);
            //}

            //else if (x == "*")
            //{
            //    rusolt = number1 * number2;
            //    Console.WriteLine(number1 + " * " + number2 + " = " + rusolt);
            //}

            //else if (x == "-")
            //{
            //    rusolt = number1 - number2;
            //    Console.WriteLine(number1 + " - " + number2 + " = " + rusolt);
            //}
            //else if (x == "/")
            //{
            //    rusolt = number1 / number2;
            //    Console.WriteLine(number1 + " / " + number2 + " = " + rusolt);
            //}


            //else
            //{
            //    Console.WriteLine("Enter eror ? plenter corect!");
            //}

            //Console.WriteLine("Enter number");
            //int num =Convert.ToInt32( Console.ReadLine());
            //if (num >= 0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("odd");

            //    }
            //}

            //else
            //{
            //    Console.WriteLine("The number is negitev");
            //}

            Console.WriteLine("Enter number");
            string day =Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("sunday");
                    break;
                case "2":
                    Console.WriteLine("MUNDAY");
                    break;
                case "3":
                    Console.WriteLine("tusday");
                    break;
                case "4":
                    Console.WriteLine("wensday");
                    break;
            }

            }
    }
}
