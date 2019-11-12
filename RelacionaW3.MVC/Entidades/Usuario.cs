
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Entidades
{
    public class Usuario
    {
        [Key]
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
