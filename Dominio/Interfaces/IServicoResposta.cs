using RelacionaW3.Dominio.DTO;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IServicoResposta : IServicoCRUD<Resposta>
    {
        IEnumerable<GraficoViewModel> ListaGrafico();
    }
}
