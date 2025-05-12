using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork3
{
    internal class Inventory
    {
        public string name;
        public double price;
        public int quantity;

        public Inventory ()
        {
            
        }

        public string AddNewProdect()
        {
            Console.WriteLine("Product added successfully!");
            return $"{name} {price} {quantity}"; 
        }

        public int UpdateQuantity(int quantity)
        {
           quantity=this.quantity;

            return quantity;
        }

        public string DisplayList()
        {
            return $"Product List: \r\n 1. {name} - Price: ${price}, Quantity: {quantity} ";
        }

        public int RecordSales()
        {
            Console.WriteLine("Enter product name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter quantity sold:");
            quantity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sale recorded successfully! ");

            return UpdateQuantity(quantity);
            ;
        }







    }


}
