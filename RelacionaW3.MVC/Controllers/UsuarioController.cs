using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RelacionaW3.Dominio.Models;
using RelacionaW3.MVC.Models;
using RelacionaW3.Repositorio.Interfaces;

namespace RelacionaW3.MVC.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
     
         public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
             _usuarioRepositorio = usuarioRepositorio;

        }

        [AllowAnonymous]
        public IActionResult Create()
        {
            // if (User.Identity.IsAuthenticated)
            //     await _usuarioRepositorio.EfetuarLogOut();

            return View();
        }

        public async Task<IActionResult> Index2()

        {
           
             return View(await _usuarioRepositorio.PegarUsuarioLogado(User));
        }   

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegistroViewModel registro)
        {
            if(ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    UserName = registro.NomeUsuario,
                    Email = registro.Email,
                    CPF = registro.CPF,
                    Telefone = registro.Telefone,
                    Nome = registro.Nome,
                    PasswordHash = registro.Senha
                };
               
                var resultado = await _usuarioRepositorio.SalvarUsuario(usuario, registro.Senha);

                if(resultado.Succeeded)
                {
                  
                    var nivelAcesso = "Administrador";

                    await _usuarioRepositorio.AtribuirNivelAcesso(usuario, nivelAcesso);
                    
                    await _usuarioRepositorio.EfetuarLogin(usuario, false);
                   
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                   
                    foreach (var erro in resultado.Errors)
                        ModelState.AddModelError("", erro.Description.ToString());
                }               

            }
            
            return View(registro);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
                await _usuarioRepositorio.EfetuarLogOut();

           
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if(ModelState.IsValid)
            {
              
                var usuario = await _usuarioRepositorio.PegarUsuarioPeloEmail(login.Email);
                PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();

                if(usuario != null)
                {
                  
                    if(passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, login.Senha) != PasswordVerificationResult.Failed)
                    {
                      
                        await _usuarioRepositorio.EfetuarLogin(usuario, false);

                        return RedirectToAction("Index", "Home");
                    }
                   
                    ModelState.AddModelError("", "Email e/ou senha inválidos");
                }

                ModelState.AddModelError("", "Email e/ou senha inválidos");
            }
          
            return View(login);
        }

        public async Task<IActionResult> LogOut()
        {
            await _usuarioRepositorio.EfetuarLogOut();

            return RedirectToAction("Login", "Usuario");
        }


        [HttpGet]
        public async Task<IActionResult> Atualizar(string UsuarioId)
        {
            
            var usuario = await _usuarioRepositorio.PegarPeloId(UsuarioId);

            var atualizarViewModel = new AtualizarViewModel
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Telefone = usuario.Telefone,
                NomeUsuario = usuario.UserName
            };
            
            return View(atualizarViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atualizar(AtualizarViewModel atualizarViewModel)
        {
            if(ModelState.IsValid)
            {
                var usuario = await _usuarioRepositorio.PegarPeloId(atualizarViewModel.Id);

                usuario.Nome = atualizarViewModel.Nome;
                usuario.CPF = atualizarViewModel.CPF;
                usuario.UserName = atualizarViewModel.NomeUsuario;
                usuario.Email = atualizarViewModel.Email;
                usuario.Telefone = atualizarViewModel.Telefone;

                await _usuarioRepositorio.AtualizarUsuario(usuario); 

                return RedirectToAction("Index", "Usuario");
            }

            return View(atualizarViewModel);
        }
    }
}