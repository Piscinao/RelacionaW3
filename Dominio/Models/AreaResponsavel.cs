
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.Dominio.Models
{
    public class AreaResponsavel
    {
        [Key]
        public string IdUsuario { get; set; }
        public int IdArea { get; set; }
        public Usuario Usuario { get; set; }
        public Area Area { get; set; }

      
    }
}
