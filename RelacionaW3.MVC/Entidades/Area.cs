using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.Entidades
{
    public class Area
    {
        [Key]
        public int? Id { get; set; }
        public string Descricao { get; set; }
        //public ICollection<Evento> Eventos { get; set; }

    }
}
