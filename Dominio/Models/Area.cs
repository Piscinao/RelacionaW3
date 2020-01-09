
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.Dominio.Models
{
    public class Area
    {
        public int? Id {get; set;}

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        public ICollection<AreaResponsavel> Usuarios { get; set; }
    

        // public ICollection<Resposta> Respostas { get; set; }

      
    }
}
