using System.ComponentModel.DataAnnotations.Schema;

namespace online_shopping.Models
{
    public class Orders
    {
        public int id { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public decimal Total_Price { get; set; }

        [ForeignKey("Customer_id")]
        public int Customer_id { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
