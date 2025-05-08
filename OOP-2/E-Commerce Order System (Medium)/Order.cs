using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Order_System__Medium_
{
    internal class Order
    {

        private List<Product> productList;

        public Order()
        {
            productList = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            productList.Add(p);
        }

        public double CalculateOrderTotal()
        {
            double sum = 0;
            for (int i = 0; i < productList.Count; i++)
            {
                sum = sum + productList[i].CalculateTotal();
            }
            return sum;
        }
    }
}

