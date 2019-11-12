
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RelacionaW3.MVC.Entidades
{
    public class NiveisAcesso: IdentityRole
    {
        public string Descricao { get; set; }

    }
}
