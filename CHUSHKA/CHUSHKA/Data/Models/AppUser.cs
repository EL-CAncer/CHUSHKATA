using Microsoft.AspNetCore.Identity;

namespace CHUSHKA.Data.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
