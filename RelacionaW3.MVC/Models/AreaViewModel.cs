using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.MVC.Models
{
    public class AreaViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage="Informe a Descrição da Area!")]
        public string Descricao { get; set; }

        public string JsonUsuarios { get; set; }


    }
}
