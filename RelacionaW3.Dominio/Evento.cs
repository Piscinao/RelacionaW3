using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelacionaW3.Dominio
{
    //6 Propriedads
    public class Evento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataEvento { get; set; }

        public string Tema { get; set; }

        public string MeioDeContato{ get; set; }

        public string RespostaPadrao {get; set; }

        public string Fonte{ get; set; }

        public string Classificacao { get; set; }

        public string Caracteristica {get; set;}

        public string AreaEnvolvida {get; set;}

        public string AreaResponsavel {get; set;}

        public string ImagemURL {get; set;}

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string Lote { get; set; }


//ALTERNATIVA TENTATIVA CHAVE ESTRANGEIRA
        public int? AreaId { get; set; }

        public virtual Area Area { get; set; }

        public List<Area> Areas { get; set; }


        // public int AreaId { get; set; }
        // [ForeignKey("AreaId")]
        // public Area Area { get; }
        // public string Area { get; set; }
        public List<Lote> Lotes { get; set; }
        public List<RedeSocial> RedesSociais { get; set; }
        public List<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}