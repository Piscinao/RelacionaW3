using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Models
{
    public class PessoaViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage="Informe o Nome do Pessoa!")]
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ/CPF do Pessoa!")]
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Informe o Email do Pessoa!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Celular do Pessoa!")]
        public string Celular { get; set; }
        public string Telefone { get; set; }
    }
}
