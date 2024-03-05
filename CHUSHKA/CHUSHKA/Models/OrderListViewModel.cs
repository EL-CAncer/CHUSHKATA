namespace CHUSHKA.Models
{
    using CHUSHKA.wwwroot.Mapping;
    using CHUSHKA.Services.Models;
    using AutoMapper;

    public class OrderListViewModel : IHaveCustomMapping
    {
        public string Id { get; set; }

        public string Customer { get; set; }

        public string Product { get; set; }

        public string OrderedOn { get; set; }
        
        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<OrderServiceModel, OrderListViewModel>()
                .ForMember(dest => dest.Customer, opt =>
                    opt.MapFrom(src => src.Client.FullName))
                .ForMember(dest => dest.Product, opt =>
                    opt.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.OrderedOn, opt =>
                    opt.MapFrom(src => src.OrderedOn.ToString("hh:mm dd/MM/yyyy")));
        }
    }
}