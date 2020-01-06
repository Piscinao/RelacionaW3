using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelacionaW3.Dominio.Models
{
    public class Evento
    {
        
        public int? Id {get; set;}

        [Required(ErrorMessage="Informe a descrição do Evento!")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage="Informe a data do Evento!")]
        public string DataEvento { get; set; }

        [Required(ErrorMessage="Informe a fonte!")]
        public string Fonte { get; set; }

        [Required(ErrorMessage="Informe o meio de contato!")]
        public string Meio { get; set; }

        [Required(ErrorMessage="Informe a característica !")]
        public string Caracteristica { get; set; }
        public string DescricaoMaterial { get; set; }
        public string Evidencias { get; set; }
        public string NotaFiscal { get; set; }
        public string Quantidade { get; set; }
        public string Produto { get; set; }
        // public DateTime DataEncaminhamento {get; set;}
        // public DateTime Prazo {get; set;} 
        public decimal Valor { get; set; }
        public string Status { get; set; }

        [ForeignKey("Area")]

        [Required(ErrorMessage="Informe a área envolvida!")]
        public int IdArea { get; set; }
        public Area Area { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        [ForeignKey("Usuario")]
        public string IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<RespostaEventos> Respostas { get; set; }

        public ICollection<AreaResponsavel> AreaResponsavel { get; set; }

        // public AreaResponsavel AreaResponsavel { get; set; }



    }
}