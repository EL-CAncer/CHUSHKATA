namespace CHUSHKA.Services.Models
{
    using System.Collections.Generic;
   
    using CHUSHKA.wwwroot.Mapping;
    using CHUSHKA.Data.Models;

    public class ProductServiceModel : IMapWith<Product>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; }

        public ICollection<OrderServiceModel> Orders { get; set; }

        public bool IsDeleted { get; set; }
    }
}
