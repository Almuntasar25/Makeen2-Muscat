namespace online_shopping.Models
{
    public class Customer
    {
        public int id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<ShippingAddress> ShippingAddresses { get; set; }
        public ICollection<Payment_Information> PaymentInformations { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
    }
}
