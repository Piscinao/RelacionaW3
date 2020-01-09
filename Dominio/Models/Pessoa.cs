
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.Dominio.Models
{
    public class Pessoa
    {
        public int? Id {get; set;}

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Empresa { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }

        public ICollection<Evento> Eventos {get; set;}
        // public ICollection<Resposta> Respostas { get; set; }

      
    }
}
