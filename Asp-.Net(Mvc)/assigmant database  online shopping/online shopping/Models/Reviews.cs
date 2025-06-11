using System.ComponentModel.DataAnnotations.Schema;

namespace online_shopping.Models
{
    public class Reviews
    {
        public int id { get; set; }


        public int Rating { get; set; }
        public string Comments { get; set; }

        [ForeignKey("Customer_id")]
        public int Customer_id { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Produc_id")]
        public int Produc_id { get; set; }

        public Products products { get; set; }
    }
}
