using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Order_System__Medium_
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product()
        {
            Name = "";
            Price = 0;
            Quantity = 0;
        }

        public Product(string n, double p, int q)
        {
            Name = n;
            Price = p;
            Quantity = q;
        }

        public double CalculateTotal()
        {
            double total = Price * Quantity;
            return total;
        }

        public double CalculateTotal(double customPrice, int customQuantity)
        {
            double total = customPrice * customQuantity;
            return total;
        }
    }
}

