using Microsoft.AspNetCore.Identity;

namespace oeClean.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Selskap;
        public ApplicationUser()
        {
            Selskap = "0";
        }
    }
}
