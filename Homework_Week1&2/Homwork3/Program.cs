
namespace Homwork3
{
    class Program
    {
        static List<Product> products = new List<Product>();
        static int totalSales = 0;
        static double totalRevenue = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            if (username != "admin" || password != "adminpass")
            {
                Console.WriteLine("Authentication failed. Exiting...");
                return;
            }

            Console.WriteLine($"Authentication successful! Welcome, {username}!");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nOptions:\n1. Add a new product\n2. Update product quantity\n3. Display product list\n4. Record sale\n5. Generate product report\n6. Generate sales report\n7. Exit");
                Console.Write("Select an operation (1-7): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddNewProduct(); 
                        break;
                    case "2": UpdateProductQuantity(); 
                        break;
                    case "3": DisplayProductList(); 
                        break;
                    case "4": RecordSale(); 
                        break;
                    case "5": GenerateProductReport(); 
                        break;
                    case "6": GenerateSalesReport(); 
                        break;
                    case "7":
                        Console.WriteLine($"Thank you for using the Inventory Management System, {username}!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        break;
                }
            }
        }

        static void AddNewProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product cost price: ");
            double costPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter product selling price: ");
            double sellPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter initial quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Product newProduct = new Product(name, costPrice, sellPrice, quantity);
            products.Add(newProduct);
            Console.WriteLine("Product added successfully!");
        }

        static void UpdateProductQuantity()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Product product = FindProduct(name);

            if (product != null)
            {
                Console.Write("Enter new quantity to add: ");
                int addQty = Convert.ToInt32(Console.ReadLine());
                product.Quantity += addQty;
                Console.WriteLine("Quantity updated successfully!");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void DisplayProductList()
        {
            Console.WriteLine("Product List:");
            int i = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{i++}. {product.Name} - Price: ${product.SellPrice}, Quantity: {product.Quantity}");
            }
        }

        static void RecordSale()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Product product = FindProduct(name);

            if (product != null)
            {
                Console.Write("Enter quantity sold: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                if (qty <= product.Quantity)
                {
                    product.Quantity -= qty;
                    totalSales += qty;
                    totalRevenue += qty * product.SellPrice;
                    Console.WriteLine("Sale recorded successfully!");
                }
                else
                {
                    Console.WriteLine("Not enough stock available.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void GenerateProductReport()
        {
            Console.WriteLine("Product Report:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - Quantity: {product.Quantity}");
            }
        }

        static void GenerateSalesReport()
        {
            Console.WriteLine($"Sales Report:\nTotal Sales: {totalSales}\nTotal Revenue: ${totalRevenue}");
        }

        static Product FindProduct(string name)
        {
            foreach (Product p in products)
            {
                if (p.Name.ToLower() == name.ToLower())
                {
                    return p;
                }
            }
            return null; 
        }

    }


    class Product
    {
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SellPrice { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double cost, double price, int qty)
        {
            Name = name;
            CostPrice = cost;
            SellPrice = price;
            Quantity = qty;
        }

        public double GetProfitPerUnit()
        {
            return SellPrice - CostPrice;
        }
    }
}
