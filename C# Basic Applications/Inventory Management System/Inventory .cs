namespace ConsoleApp1
{
    internal class Inventory
    {
        //Assignment 3 Inventory Management System

        static void Main(string[] args)
        {
           
            string[] products = { "Apple", "Orange", "Milk" };
            int[] quantities = { 10, 20, 15 };

            while (true)
            {
               
                Console.WriteLine("Menu ::");
                Console.WriteLine("1 . View All Products");
                Console.WriteLine("2 . Add Stock");
                Console.WriteLine("3 . Sell Product");
                Console.WriteLine("4 . Check Product Quantity");
                Console.WriteLine("5 . Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        Console.WriteLine("List:");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"{products[i]}: {quantities[i]} items");
                        }
                        break;

                    case "2":  
                        Console.Write("Enter product name: ");
                        string AddName = Console.ReadLine();
                        bool FoundAddQty = false;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].ToLower() == AddName.ToLower())
                            {
                                Console.Write("Enter quantity to add: ");
                                int AQty = int.Parse(Console.ReadLine());
                                quantities[i] = quantities[i] + AQty;
                                Console.WriteLine($"{AQty} added to {products[i]}.");
                                FoundAddQty = true;
                                break;
                            }
                        }
                        if (!FoundAddQty)
                            Console.WriteLine("Product not found!");
                        break;

                    case "3": 
                        Console.Write("Enter product name to sell: ");
                        string Sell_Name = Console.ReadLine();
                        bool Found_Sell = false;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].ToLower() == Sell_Name.ToLower())
                            {
                                Console.Write("Enter quantity to sell: ");
                                int Sell_Qty = int.Parse(Console.ReadLine());
                                if (Sell_Qty <= quantities[i])
                                {
                                    quantities[i] = quantities[i] - Sell_Qty;
                                    Console.WriteLine($"{Sell_Qty} sold from {products[i]}.");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough stock to sell!");
                                }
                                Found_Sell = true;
                                break;
                            }
                        }
                        if (!Found_Sell)
                            Console.WriteLine("Product not found!");
                        break;

                    case "4":    
                        Console.Write("Enter product name to check: ");
                        string Check_Name = Console.ReadLine();
                        bool Found_Check = false;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].ToLower() == Check_Name.ToLower())
                            {
                                Console.WriteLine($"{products[i]} has {quantities[i]} in stock.");
                                Found_Check = true;
                                break;
                            }
                        }
                        if (!Found_Check)
                            Console.WriteLine("Product not found!");
                        break;

                    case "5":  
                        Console.WriteLine("Exiting program!");
                        return;

                    default:
                        Console.WriteLine("Please select between 1 - 5.");
                        break;
                }
            }
        }
    }

}

