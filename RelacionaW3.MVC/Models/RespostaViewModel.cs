using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Models
{
    public class RespostaViewModel
    {
        public int? Id { get; set; }
        
        // [Required(ErrorMessage = "Informe a Data da Resposta!")]
        public string Data { get; set; }
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a Pessoa!")]
        public int? IdPessoa { get; set; }
        public IEnumerable<SelectListItem> ListaPessoas { get; set; }
        public string NomePessoa { get; set; }

        // public int? IdEvento { get; set; }
        public IEnumerable<SelectListItem> ListaEventos { get; set; }

        // public string DescricaoEvento { get; set; }

        // [Required(ErrorMessage = "Informe a Descrição!")]
        // public string DescricaoEvento { get; set; }
        public string Prazo { get; set; }
        public string VerificaRetorno { get; set; }
        public string Observacoes {get; set; }
        public string JsonEventos { get; set; }
       
    }
}
