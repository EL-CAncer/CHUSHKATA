namespace CHUSHKA.Data.Models
{
    public class Order
    {
        public string Id { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public string ClientId { get; set; }

        public AppUser Client { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
