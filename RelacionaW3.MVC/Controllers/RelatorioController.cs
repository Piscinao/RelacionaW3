using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class RelatorioController : Controller
    {
        readonly IServicoAplicacaoResposta ServicoResposta;

        public RelatorioController(IServicoAplicacaoResposta servicoResposta)
        {
            ServicoResposta = servicoResposta;
        }

        public IActionResult Grafico()
        {
            var lista = ServicoResposta.ListaGrafico().ToList();

            string valores = string.Empty;
            string labels = string.Empty;
            string cores = string.Empty;

            var random = new Random();

            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].TotalVendido.ToString() + ",";
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