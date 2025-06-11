namespace Vehicle_Hierarchy_System__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", 2020, 4);
            Truck truck1 = new Truck("Volvo", "FH16", 2018, 18.0);

            car1.DisplayInfo();
            Console.WriteLine();
            truck1.DisplayInfo();
        }
    }
}
    

