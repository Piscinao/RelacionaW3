using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Dominio.Entidades
{
    public class UsuarioTeste : EntityBase
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }
    }
}
