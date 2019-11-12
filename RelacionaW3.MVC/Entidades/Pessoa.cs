using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Entidades
{
    public class Pessoa
    {
        [Key]
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Empresa { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public ICollection<Resposta> Respostas { get; set; }
    }
}
