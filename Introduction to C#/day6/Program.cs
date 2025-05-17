namespace day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 o1 = new Class1();
            //o1.FName = "Test";
            //o1.lName = "Test1";
            //o1.worcedHouers = 3;
            //o1.price = 10;
            //o1.salary = 10;

            //o1.sayHi("Ali"); //Argument

            //int h = o1.totalH();

            //    Console.WriteLine(h);
            ////____________________________________
            //int a = 5;
            //o1.doubelValue(ref a); // colling bay refrens

            //o1.doubelValue(a); // colling bay value

            //Console.WriteLine(a);// colling Re
            //________________________________________________

            //int age = 18;
            //string name = "A";
            //o1.StudentInformaion(age,name);




            //________________________________
            // banke acoent!!


            //Class2 O2 = new Class2();

            //while (true)
            //{
            //    Console.WriteLine("select servis 1 - 3 : and q to go aout");
            //    string servis = Console.ReadLine();
            //    if (servis == "1")
            //    {
            //        O2.CheckAmout();

            //    }
            //    else if (servis == "2")
            //    {
            //        Console.WriteLine("price");
            //        int price = Convert.ToInt32(Console.ReadLine());
            //        O2.WethirDro(price);
            //        O2.CheckAmout();
            //    }
            //    else if (servis == "3")
            //    {
            //        Console.WriteLine("price");
            //        int price = Convert.ToInt32(Console.ReadLine());
            //        O2.Transform(price);
            //        O2.CheckAmout();
            //    }
            //    else if (servis == "q")
            //    {
            //        break;
            //    }
            //________________________________________________


            //Class2 O3 = new Class2();
            //int[] num = {1,2,3,4,5,6,7,8,9,10};
            //O3.EvenNumbers(num);


            //____________________________________________
            
            Class2 p1 = new Class2("a" , " b" , "s");

            p1.FerstName = "";


            }


        


    }
    }


namespace day6
{

    internal class Class2
    {
        //public int totaleAmout = 200;
        //public void CheckAmout()
        //{
        //   Console.WriteLine($"Ther are {totaleAmout} O.R in your account");

        //}

        //public int WethirDro(int price)
        //{
        //    totaleAmout = totaleAmout - price;
        //    return totaleAmout;
        //}

        //public int Transform(int price)
        //{
        //    totaleAmout = totaleAmout + price;
        //    return totaleAmout;
        //}


        public bool isEven(int a)
        {
            return (a % 2 == 0);
        }


        public void EvenNum(int[] a)
        {
            foreach (int i in a)
            {
                if (isEven(i))
                {
                    Console.WriteLine(i + " ");

                }
            }
        }

        public void EvenNumbers(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public int add(int x, int y)
        {
            return x + y;

        }

        public string FerstName;
        public string LastName;
        public string Adrees;

        public Class2(string fierst ,  string last , string adrees)
        {
            FerstName = fierst;
            LastName = last;
            Adrees = adrees;
        }






    }




}

        
        internal class Class1
        {

            public string FName;
            public string lName;
            public int worcedHouers;
            public double price;
            public double salary;
            public static double TAX = 0.03;

            //public void GetSalary()
            //{
            //    double neTAX = Convert.ToDouble(Console.ReadLine());
            //    TAX = neTAX;
            //    double mainSalary =
            //    double salary = (emp.worcedHouers * emp.price) - (emp.worcedHouers * emp.price * Class1.TAX);
            //    Console.WriteLine($"{emp.FName} {emp.lName} worked for {emp.worcedHouers}", "and totall" + $"salary is {emp.salary}");
            //}

            public void sayHi()
            {
                Console.WriteLine("hello" + FName);
            }

            //public int totalH()
            //{
            //    int x = 6;
            //    int w = 7;
            //    int h = x * w;
            //    return h;
            //}
            //public int totalH() => worcedHouers;//=> 1 statment


            public void sayHi(string s) // parameters
            {
                Console.WriteLine("hello" + " " + s);
            }

            public int totalH()
            {
                return worcedHouers;
            }

            //public void doubelValue(ref int a) //
            //{
            //   a= a * a;
            //    Console.WriteLine(a);
            //}
            public void doubelValue(int a) //cooleng value
            {
                Console.WriteLine(a);
            }

            public void StudentInformaion(int a, string name = "User")
            {
                Console.WriteLine($"Hello {name} are you {a} old");
            }










        }
