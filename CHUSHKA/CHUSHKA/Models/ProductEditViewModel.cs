namespace CHUSHKA.Models
{
    using System.ComponentModel.DataAnnotations;
    using CHUSHKA.wwwroot.Mapping;
    using Services.Models;

    public class ProductEditViewModel : IMapWith<ProductServiceModel>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
