using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.Models
{
    public class RegistroViewModel
    {
        // [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        // [Required(ErrorMessage = "Campo Obrigatório")]
        public string CPF { get; set; }

        // [Required(ErrorMessage = "Campo Obrigatório")]
        public string Telefone { get; set; }

        // [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        public string NomeUsuario { get; set; }

        // [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        // [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
