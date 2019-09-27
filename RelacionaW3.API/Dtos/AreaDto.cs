using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelacionaW3.API.Dtos {
    //6 Propriedads
    public class AreaDto
    {

         public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

      
    }
}