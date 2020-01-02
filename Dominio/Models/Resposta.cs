
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Models
{
    public class Resposta
    {
        public int? Id { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        // [ForeignKey("Evento")]
        // public int IdEvento { get; set; }
        // public Evento Evento { get; set; }
        public string Prazo { get; set; }
        public string VerificaRetorno { get; set; }
        public string Observacoes {get; set; }
    
        public ICollection<RespostaEventos> Eventos { get; set; }
    }
}
