using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.API.Dtos {

    public class AreaDto
    {

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

      
    }
}