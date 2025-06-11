using CodeAcademyShope.model;

namespace CodeAcademyShope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationException _context = new ApplicationException();
            var pro1 = new Product
            {
                Name = "Ali",
                Description = "db",
                categoryId = 1,
            };

            _context.products.Add(pro1);
        }
    }
}
