using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RelacionaW3.Dominio;

namespace RelacionaW3.API.Dtos {
    public class EventoDto {
        public int Id { get; set; }

        [Required(ErrorMessage="Campo Obrigatório")]
        [StringLength(100, MinimumLength=3, ErrorMessage="Nome é entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        public string DataEvento { get; set; }

        [Required(ErrorMessage="Tema deve ser preenchido")]
        public string Tema { get; set; }

        // [Range(2, 120000, ErrorMessage="Quantidade de pessoas é entre 2 e 120000")]
          [Required(ErrorMessage="Meio de contato deve ser selecionado")]
        public string MeioDeContato { get; set; }

        public string RespostaPadrao {get; set; }
        public string Fonte{ get; set; }

        public string Classificacao { get; set; }

        public string Caracteristica {get; set; }

        public string AreaEnvolvida {get; set;}

        public string AreaResponsavel {get; set;}

        // public int AreaId { get; set; }
        
        // [ForeignKey("AreaId")]
        // public Area Area { get; set; }
       
        public string ImagemURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        public string Celular { get; set; }
        //Validação back-end
        //Data annotation validação para o post 
        [EmailAddress]
        public string Email { get; set; }

        public string Lote { get; set; }

        public List<LoteDto> Lotes { get; set; }

        public List<RedeSocialDto> RedesSociais { get; set; }

        public List<PalestranteDto> Palestrantes { get; set; }
    }
}