namespace E_Commerce_Order_System__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 1200, 1);
            Product p2 = new Product();
            p2.Name = "Mouse";
            p2.Price = 50;
            p2.Quantity = 2;

            Order order1 = new Order();
            order1.AddProduct(p1);
            order1.AddProduct(p2);

            Console.WriteLine("Product 1 Total: " + p1.CalculateTotal());
            Console.WriteLine("Product 2 Total (custom): " + p2.CalculateTotal(45, 2));
            Console.WriteLine("Order Total: " + order1.CalculateOrderTotal());
        }
    }
    }

