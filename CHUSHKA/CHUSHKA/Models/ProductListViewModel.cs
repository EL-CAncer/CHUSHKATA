namespace CHUSHKA.Models
{
    using CHUSHKA.wwwroot.Mapping;
    using Services.Models;

    public class ProductListViewModel : IMapWith<ProductServiceModel>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}