using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a simple coffee shop ordering system.
            // It allows the user to select a coffee, choose the size, add sugar/milk, and displays the order summary with the total cost.

            // Display the coffee menu
            Console.WriteLine("Welcome to the Coffee Shop!");
            Console.WriteLine("Menu: \r\n1. Americano - $2.50 \r\n2. Latte - $3.00 \r\n3. Cappuccino - $3.50\n");
            Console.WriteLine("Select a Coffee (1-3):");

            // Read the user's coffee choice
            int Menu = Convert.ToInt32(Console.ReadLine());
            string Coffee = "";
            double price = 0.0;
            int Customizations;
            string size = "";

            // Determine coffee type and price based on user selection
            if (Menu == 1)
            {
                price = 2.50;
                Coffee = "Americano";
            }
            else if (Menu == 2)
            {
                price = 3.00;
                Coffee = "Latte";
            }
            else if (Menu == 3)
            {
                price = 3.50;
                Coffee = "Cappuccino";
            }

            // Ask the user to choose a size
            Console.WriteLine("Customizations: \r\n1. Small \r\n2. Medium \r\n3. Large\n");
            Console.WriteLine("Select a size (1-3):");
            Customizations = Convert.ToInt32(Console.ReadLine());

            // Set the size based on the user's choice
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

            // Ask the user about sugar
            Console.WriteLine("Do you want sugar? (yes/no):");
            string sugar = Console.ReadLine();

            // Set sugar preference
            if (sugar == "yes")
            {
                sugar = "with sugar";
            }
            else if (sugar == "no")
            {
                sugar = "without sugar";
            }
            else
            {
                sugar = "";
            }

            // Ask the user about milk
            Console.WriteLine("Do you want milk? (yes/no): ");
            string milk = Console.ReadLine();

            // Set milk preference
            if (milk == "yes")
            {
                milk = "and milk";
            }
            else if (milk == "no")
            {
                milk = "without milk";
            }
            else
            {
                milk = "";
            }

            // Display the final order summary
            Console.WriteLine($"Your Order Summary: {Coffee} ({size}) {sugar} {milk} \r\nTotal Cost: ${price} \r\nThank you for ordering!");
        }
    } 
}
