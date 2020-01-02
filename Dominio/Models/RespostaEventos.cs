using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Models
{
    public class RespostaEventos
    {
        [Key]
        public int IdResposta { get; set; }
        public int IdEvento { get; set; }
        public Evento Evento { get; set; }
        public Resposta Resposta { get; set; }
    }
}
