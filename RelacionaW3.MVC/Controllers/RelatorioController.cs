using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.MVC.Models;
using RelacionaW3.Repositorio.Interfaces;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class RelatorioController : Controller
    {
        private readonly IEventoRepositorio _eventoRepositorio;

        public RelatorioController(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public IActionResult Grafico(int IdArea, int IdEvento)
        {
            var lista = _eventoRepositorio.ListaGrafico(IdArea, IdEvento).ToList();

            string valores = string.Empty;
            string labels = string.Empty; 
            string cores = string.Empty;

            var random = new Random();

            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].TotalEvento.ToString() + ",";
                labels += "'" + lista[i].Descricao.ToString() + "',";
                cores += "'" + String.Format("#{0:X6}", random.Next(0x1000000)) + "',";
            }

            ViewBag.Valores = valores;
            ViewBag.Labels = labels;
            ViewBag.Cores = cores;

            return View();
        }
    }
}