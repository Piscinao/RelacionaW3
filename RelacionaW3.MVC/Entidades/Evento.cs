using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.Entidades
{
    public class Evento
    {
        [Key]
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public string DataEvento { get; set; }
        public string Fonte { get; set; }
        public string Meio { get; set; }
        public string Classificacao { get; set; }
        public string Caracteristica { get; set; }
        public string NotaFiscal { get; set; }
        public string DescricaoMaterial { get; set; }
        public string Evidencias { get; set; }
        public string Produto { get; set; }
        public double Quantidade { get; set; }
        // public DateTime DataEncaminhamento {get; set;}
        // public DateTime Prazo {get; set;} 
        public decimal Valor { get; set; }

        public string Status { get; set;}

        [ForeignKey("Area")]
        public int idArea { get; set; }
        public Area Area { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public ICollection<RespostaEventos> Respostas { get; set; }
    }
}
