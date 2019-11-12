using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Entidades
{
    public class Area : EntityBase
    {
        public string Descricao { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }
}
