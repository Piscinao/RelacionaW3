using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Entidades
{
    public class Evento
    {
        [Key]
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public decimal Valor { get; set; }

        [ForeignKey("Area")]
        public int IdArea { get; set; }
        public Area Area { get; set; }

        public ICollection<RespostaEventos> Respostas { get; set; }
    }
}
