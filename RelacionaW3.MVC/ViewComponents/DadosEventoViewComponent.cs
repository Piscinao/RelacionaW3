
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.ViewComponents
{
    public class DadosEventoViewComponent : ViewComponent
    {
        private readonly IEventoRepositorio _eventoRepositorio;

        public DadosEventoViewComponent(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public async Task<IViewComponentResult> InvokeAsync(int IdEvento)
        {
            return View(await _eventoRepositorio.EventoById(IdEvento));
        }
    }
}
