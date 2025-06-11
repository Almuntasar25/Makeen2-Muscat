using System.ComponentModel.DataAnnotations.Schema;

namespace online_shopping.Models
{
    public class Payment_Information
    {
        public int id { get; set; }
        public string Payment_Method { get; set; }
        public string Card_Number { get; set; }
        public string Expiration_Date { get; set; }
        public string CVV { get; set; }

        [ForeignKey("Customer_id")]
        public Customer Customer { get; set; }

        public int Customer_id { get; set; }


    }
}
