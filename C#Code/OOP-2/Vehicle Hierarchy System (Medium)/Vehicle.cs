using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Hierarchy_System__Medium_
{
    internal class Vehicle
    {
        protected string make;
        protected string model;
        protected int year;

        public Vehicle(string m, string mo, int y)
        {
            make = m;
            model = mo;
            year = y;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
        }
    }

    class Car : Vehicle
    {
        private int numberOfDoors;

        public Car(string m, string mo, int y, int doors) : base(m, mo, y)
        {
            numberOfDoors = doors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Number of Doors: " + numberOfDoors);
        }
    }

    class Truck : Vehicle
    {
        private double loadCapacity;

        public Truck(string m, string mo, int y, double capacity) : base(m, mo, y)
        {
            loadCapacity = capacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Truck Information:");
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Load Capacity: " + loadCapacity + " tons");
        }
    }
}

