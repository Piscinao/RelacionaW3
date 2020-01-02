using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.MVC.Models;
using RelacionaW3.Repositorio.Interfaces;

namespace RelacionaW3.MVC.Controllers
{
    [AllowAnonymous]
    public class NivelAcessoController : Controller
    {
        private readonly INivelAcessoRepositorio _nivelAcessoRepositorio;

         public NivelAcessoController(INivelAcessoRepositorio nivelAcessoRepositorio)
        {
            _nivelAcessoRepositorio = nivelAcessoRepositorio;
        }
        // public async Task <IActionResult> Index()
        // {
        //     return View(await ServicoAplicacaoNivelAcesso.PegarTodos().ToListAsync());
        // }
               
        public IActionResult Create()
        {
           
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Name")] NivelAcesso nivelAcesso)
        {
            if (ModelState.IsValid)
            {
                
                bool nivelExiste = await _nivelAcessoRepositorio.NivelAcessoExiste(nivelAcesso.Name);

                if(!nivelExiste)
                {
                    nivelAcesso.NormalizedName = nivelAcesso.Name.ToUpper();
                    await _nivelAcessoRepositorio.Create(nivelAcesso);
                   

                    return RedirectToAction("Index", "NiveisAcessos");
                }                
            }
          
            return View(nivelAcesso);
        }

        public async Task<IActionResult> Edit(string id)
        {
            
            if (id == null)
            {
                
                return NotFound();
            }

            var niveisAcesso = await _nivelAcessoRepositorio.PegarPeloId(id);
            if (niveisAcesso == null)
            {
                return NotFound();
            }
            return View(niveisAcesso);
        }
        
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(string id, [Bind("Descricao,Id,Name,NormalizedName,ConcurrencyStamp")] NiveisAcesso niveisAcesso)
        // {
        //     if (id != niveisAcesso.Id)
        //     {
               
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {

        //         await ServicoAplicacaoNivelAcesso.Atualizar(niveisAcesso);
                
        //         return RedirectToAction("Index", "NiveisAcessos");

        //     }

        //     return View(niveisAcesso);
        // }
       
        // [HttpPost]
        // public async Task<IActionResult> Delete(string id)
        // {
        //     await ServicoAplicacaoNivelAcesso.Excluir(id);
           
        //     return RedirectToAction(nameof(Index));
        // }       
    }
}