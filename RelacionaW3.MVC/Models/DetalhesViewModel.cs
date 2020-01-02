using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.MVC.Models
{
    public class DetalhesViewModel
    {

 
 
       [ForeignKey("Area")]
        public int IdArea { get; set; }
        public Area Area { get; set; }
        public string DescricaoArea { get; set; }

        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomePessoa { get; set; }
       
    }
}
