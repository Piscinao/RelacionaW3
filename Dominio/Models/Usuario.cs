using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace RelacionaW3.Dominio.Models
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }
   
        public ICollection<Evento> Eventos {get; set;}

        public ICollection<AreaResponsavel> Areas { get; set; }


     

    }
}