using Microsoft.AspNetCore.Identity;

namespace RelacionaW3.Dominio.Identity
{
    public class UserRole : IdentityUserRole<int>
     
    {
        public User User { get; set; }
        public Role Role { get; set; }        
    }
}