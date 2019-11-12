using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio.Entidades
{
    public class EntityBase
    {
        [Key]
        public int? Id { get; set; }
    }
}
