
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RelacionaW3.MVC.Entidades
{
    public class UsuarioTeste: IdentityUser
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

    }
}
