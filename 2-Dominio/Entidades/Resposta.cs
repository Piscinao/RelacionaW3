using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Entidades
{
    public class Resposta
    {
        [Key]
        public int? Id { get; set; }
        public DateTime Data { get; set; }

        [ForeignKey("Pessoa")]
        public int idPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        public decimal Total { get; set; }

        public ICollection<RespostaProdutos> Produtos { get; set; }
    }
}
