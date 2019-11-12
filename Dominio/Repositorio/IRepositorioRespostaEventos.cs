using RelacionaW3.Dominio.DTO;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Repositorio
{
    public interface IRepositorioRespostaEventos
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
