using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Entidades
{ 
    public class Pessoa
    {
        [Key]
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ_CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public ICollection<Resposta> Respostas { get; set; }
    }
}
