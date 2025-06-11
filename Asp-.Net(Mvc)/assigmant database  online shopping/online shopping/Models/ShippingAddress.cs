using System.ComponentModel.DataAnnotations.Schema;

namespace online_shopping.Models
{
    public class ShippingAddress
    {
        public int id { get; set; }


        public string Street_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postal_Code { get; set; }

        [ForeignKey("Customer_id")]
        public int Custome_id { get; set; }

        public Customer Customer { get; set; }
    }
}
