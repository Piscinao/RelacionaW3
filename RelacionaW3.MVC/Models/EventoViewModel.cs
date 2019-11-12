using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Models
{
    public class EventoViewModel
    {
       
        public int? Id { get; set; }

        [Required(ErrorMessage="Informe a Descrição do Evento!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a Data da Resposta!")]
        public DateTime? DataEvento { get; set; }
        public string Fonte { get; set; }
        public string Meio { get; set; }
        public string Classificacao { get; set; }
        public string Caracteristica { get; set; }
        public string NotaFiscal { get; set; }
        public string DescricaoMaterial { get; set; }
        public string Evidencias { get; set; }
        public string Produto { get; set; }
        public double Quantidade { get; set; }
        // public DateTime? DataEncaminhamento {get; set;}
        // public DateTime? Prazo {get; set;} 
        public decimal? Valor { get; set; }

        [Required(ErrorMessage = "Informe a Area do Evento!")]
        public int? IdArea { get; set; }

        [Required(ErrorMessage = "Informe a Pessoa!")]
        public int? IdPessoa { get; set; }

        public string Status { get; set;}
        public IEnumerable<SelectListItem> ListaAreas { get; set; }
        public string DescricaoArea { get; set; }
        public IEnumerable<SelectListItem> ListaPessoas { get; set; }
        public string NomePessoa { get; set; }
    }
}
