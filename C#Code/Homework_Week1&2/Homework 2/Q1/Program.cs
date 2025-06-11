using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee castomer1 = new Coffee();
            castomer1.Display();
            castomer1.place_order();
            castomer1.calculate_cost();
            Console.WriteLine(castomer1.display_order_summary()); 
        }
    }

    public class Coffee
    {
        public string selected_coffee;
        public int Customizations;
        public string size;
        public string sugar;
        public string milk;
        public string total_cost;

        public void Display()
        {
            Console.WriteLine("Welcome to the Coffee Shop!");
            Console.WriteLine("Menu: \r\n1. Americano - $2.50 \r\n2. Latte - $3.00 \r\n3. Cappuccino - $3.50\n");
        }

        public string place_order()
        {
            Console.WriteLine("Select a Coffee (1-3):");
            // Read the user's coffee choice
            int Menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customizations: \r\n1. Small \r\n2. Medium \r\n3. Large\n");

            Console.WriteLine("Select a size (1-3):");
            int Customizations = Convert.ToInt32(Console.ReadLine());

            // Ask the user about sugar

            Console.WriteLine("Do you want sugar? (yes/no):");
            sugar = Console.ReadLine();

            // Ask the user about milk
            Console.WriteLine("Do you want milk? (yes/no): ");
            milk = Console.ReadLine();

                if (Menu == 1)
                {
                    selected_coffee = "Americano";
                }
                else if (Menu == 2)
                {
                    selected_coffee = "Latte";
                }
                else if (Menu == 3)
                {
                    selected_coffee = "Cappuccino";
                }

                if (Customizations == 1)
                {
                    size = "Small";
                }
                else if (Customizations == 2)
                {
                    size = "Medium";
                }
                else if (Customizations == 3)
                {
                    size = "Large";
                }
                else { return "Enter 1-3"; }
                // Set sugar preference
                if (sugar == "yes")
                {
                    sugar = "with sugar";
                }
                else if (sugar == "no")
                {
                    sugar = "without sugar";
                }
                else { return "Enter Yes/No"; }
                // Set milk preference
                if (milk == "yes")
                {
                    return milk = "and milk";
                }
                else if (milk == "no")
                {
                    return milk = "without milk";
                }
                else { return "Enter Yes/No"; }
            }
        
        public string calculate_cost()
        {
            if (selected_coffee == "Americano" || size == "Small" || size == "Medium" || size == "Large")
            {
                return total_cost = "2.50";
            }
            else if (selected_coffee == "Latte" || size == "Small" || size == "Medium" || size == "Large")
            {
                return total_cost = "3.00";
            }
            else if (selected_coffee == "Cappuccino" || size == "Small" || size == "Medium" || size == "Large")
            {
                return total_cost = "3.50";
            }
            else { return ""; }
        }
        public string display_order_summary()
        {
            return $"Your Order Summary: {selected_coffee} ({size}) {sugar} {milk} \r\n Total Cost: {total_cost} \r\n Thank you for ordering!";
        }
    }

}

    
