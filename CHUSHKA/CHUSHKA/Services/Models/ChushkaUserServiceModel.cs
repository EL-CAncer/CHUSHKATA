namespace CHUSHKA.Services.Models
{
    using System.Collections.Generic;
    using CHUSHKA.Data.Models;
    using CHUSHKA.wwwroot.Mapping;
    using Microsoft.AspNetCore.Identity;

    public class CHUSHKAUserServiceModel : IdentityUser, IMapWith<AppUser>
    {
        public string FullName { get; set; }
        
        public ICollection<OrderServiceModel> Orders { get; set; }
    }
}
