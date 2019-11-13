using System;
using System.Collections.Generic;

namespace RelacionaW3.Dominio
{
    //6 Propriedads
    public class Evento
    {
        public int Id { get; set; }

        public string Local { get; set; }

        public string Local2 { get; set; }

        public string Local3 { get; set; }

        public DateTime DataEvento { get; set; }

        public string Tema { get; set; }

        public int QtdPessoas { get; set; }

        public string ImagemURL {get; set;}

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Lote { get; set; }

        public List<Lote> Lotes { get; set; }

        public List<RedeSocial> RedesSociais { get; set; }

        public List<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}