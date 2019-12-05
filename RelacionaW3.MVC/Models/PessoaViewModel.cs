using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Models
{
    public class PessoaViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage="Informe o Nome da Pessoa!")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Informe a Classificação da Pessoa!")]
        public string Classificacao { get; set; }
        public string Empresa { get; set; }

        // [Required(ErrorMessage = "Informe o CPF da pessoa!")]
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        // [Required(ErrorMessage = "Informe o Email do Pessoa!")]
        public string Email { get; set; }

        // [Required(ErrorMessage = "Informe o Celular do Pessoa!")]
        public string Celular { get; set; }
        public string Telefone { get; set; }
    }
}
