namespace CHUSHKA.Services.Models
{
    using System;
    using CHUSHKA.Data.Models;
    using CHUSHKA.wwwroot.Mapping;
  

    public class OrderServiceModel : IMapWith<Order>
    {
        public string Id { get; set; }

        public string ProductId { get; set; }

        public ProductServiceModel Product { get; set; }

        public string ClientId { get; set; }

        public CHUSHKAUserServiceModel Client { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
