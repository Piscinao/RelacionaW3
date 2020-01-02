using Microsoft.AspNetCore.Identity;

namespace RelacionaW3.Dominio.Models
{
    public class NivelAcesso: IdentityRole
    {
        public string Descricao { get; set; }

    }
}
