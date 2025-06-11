using System.Drawing;

namespace day7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Real r = new Real(1);
            Console.WriteLine(r.Amount);


            Rectangle r1 = new Rectangle(3, 3, "blue");
            Rectangle r2 = new Rectangle(-3, 3, "red");
            Rectangle r3 = new Rectangle(4, 6, "blue");

            // ***********************************************************
            // 1- 
            Employee emp1 = new Employee(1, "User", 600);


            //2- 
            Employee emp2 = new Employee(2, "A", 100);


            //3- 
            Employee emp3 = new Employee(3, "User", 700);

            //4- 
            Employee emp4 = new Employee("b")
            {
                id = 4,
                salary = 800,
            };

            Employee[] empioyees = { emp2, emp3, emp4 };
            foreach (Employee emp in empioyees)
            {
                Console.WriteLine(emp.GetData());
            }
            //***************************************************************


        }
    }
}

