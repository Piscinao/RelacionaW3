using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Entidades
{
    public class Pessoa : EntityBase
    {
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Empresa { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public ICollection<Evento> Eventos {get; set;}
        public ICollection<Resposta> Respostas { get; set; }
    }
}
