using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Models
{
    public class AreaResponsavel
    {
        [Key]
        public int IdArea { get; set; }
        public string IdUsuario { get; set; }
        public Area Area { get; set; }
        public Usuario Usuario { get; set; }
    }
}
