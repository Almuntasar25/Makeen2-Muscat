namespace online_shopping.Models
{
    public class Category
    {
        public int id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Products> Products { get; set; }
    }
}
        