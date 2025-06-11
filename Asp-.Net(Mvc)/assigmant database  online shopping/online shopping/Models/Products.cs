using System.ComponentModel.DataAnnotations.Schema;

namespace online_shopping.Models
{
    public class Products
    {
        public int id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        [ForeignKey("Category_id")]
        public int Category_id { get; set; }

        public Category Category { get; set; }

        public IEnumerable<OrderItems> OrderItems { get; set; }
        public IEnumerable<Reviews> Reviews { get; set; }
    }
}
