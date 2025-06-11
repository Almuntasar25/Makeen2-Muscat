using System.ComponentModel.DataAnnotations.Schema;

namespace online_shopping.Models
{
    public class OrderItems
    {
        public int id { get; set; }
        public decimal Item_Price { get; set; }
        public int quantity { get; set; }


        [ForeignKey("Order_id")]
        public Orders Order { get; set; }

        [ForeignKey("Product_id")]
        public int Product_id { get; set; }

        public Products Product { get; set; }
    }
}
