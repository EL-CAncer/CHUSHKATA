using CHUSHKA.wwwroot.Mapping;
using AutoMapper;

namespace CHUSHKA.wwwroot.Mapping
{
    

    public interface IHaveCustomMapping
    {
        void ConfigureMapping(Profile mapper);
    }
}
