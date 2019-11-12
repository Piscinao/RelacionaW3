using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.Entidades
{
    public class RespostaEventos
    {
        public int IdResposta { get; set; }
        public int IdEvento { get; set; }

        //public double Quantidade { get; set; }
        //public decimal ValorUnitario { get; set; }
        //public decimal ValorTotal { get; set; }
        public Evento Evento { get; set; }
        public Resposta Resposta { get; set; }
    }
}
