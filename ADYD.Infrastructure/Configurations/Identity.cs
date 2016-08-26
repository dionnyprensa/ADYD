using Microsoft.AspNet.Identity.EntityFramework;

namespace ADYD.Infrastructure.Configurations
{
    public class CustomUserClaim : IdentityUserClaim<int> { }

    public class CustomUserLogin : IdentityUserLogin<int> { }
}