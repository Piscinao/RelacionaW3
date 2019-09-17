using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace RelacionaW3.Dominio.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles {get; set; }
        
    }
}