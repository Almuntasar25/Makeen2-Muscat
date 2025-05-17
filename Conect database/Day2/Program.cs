using CodeAcademyShope.context;
using CodeAcademyShope.model;

namespace CodeAcademyShope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplecationDbContext();
            var pro1 = new Product
            {
                Name = "Ali",
                price = 100,
                quntity = 20
            };
            _context.Products.Add(pro1);
            _context.SaveChanges();

        }
    }
}
