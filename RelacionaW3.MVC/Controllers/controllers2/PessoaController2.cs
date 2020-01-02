﻿// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Aplicacao.Servico.Interfaces;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using RelacionaW3.MVC.Models;

// namespace RelacionaW3.Controllers
// {
//     [Authorize]
//     public class PessoaController : Controller
//     {
//         readonly IServicoAplicacaoPessoa ServicoAplicacaoPessoa;

//         public PessoaController(IServicoAplicacaoPessoa servicoAplicacaoPessoa)
//         {
//             ServicoAplicacaoPessoa = servicoAplicacaoPessoa;
//         }

//         public IActionResult Index()
//         {           
//             return View(ServicoAplicacaoPessoa.Listagem());
//         }

//         public IActionResult Details(int? id)
//         {
//             PessoaViewModel viewModel = new PessoaViewModel();

//             if (id != null)
//             {
//                 viewModel = ServicoAplicacaoPessoa.CarregarRegistro((int)id);
//             }
//             return View(viewModel);
//         }

//         [HttpGet]
//         public IActionResult Create(int? id)
//         {
//             PessoaViewModel viewModel = new PessoaViewModel();

//             if (id != null)
//             {
               
//                 viewModel = ServicoAplicacaoPessoa.CarregarRegistro((int)id);
//             }
//              else
//             {
//                 // TempData["msgError"] = "Erro";
//                 return View(viewModel);
//             }
//             return View(viewModel);
//         }

//         [HttpPost]
//         public IActionResult Create(PessoaViewModel entidade)
//         {
//             if (ModelState.IsValid)
//             {
//                 ServicoAplicacaoPessoa.Create(entidade);
//                 TempData["msgSuccess"] = "Registrar";
//                 // return Json(new { success = true, message = "Add new data success." });
//             }
//             else
//             {
//                 TempData["msgError"] = "Erro";
//                 return View(entidade);
//             }

//             return RedirectToAction("Index");
//         }

//         [HttpGet]
//         public IActionResult Excluir(int id)
//         {
//             ServicoAplicacaoPessoa.Excluir(id);
//             return RedirectToAction("Index");
//         }
//     }
// }