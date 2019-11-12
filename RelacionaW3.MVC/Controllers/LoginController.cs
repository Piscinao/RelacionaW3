using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.Helpers;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    public class LoginController : Controller
    {
        protected IHttpContextAccessor HttpContextAcessor;
        readonly IServicoAplicacaoUsuario ServicoAplicacaoUsuario;

        public LoginController(IServicoAplicacaoUsuario servicoAplicacaoUsuario, IHttpContextAccessor httpContext)
        {
            ServicoAplicacaoUsuario = servicoAplicacaoUsuario;
            HttpContextAcessor = httpContext;
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    HttpContextAcessor.HttpContext.Session.Clear();
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            ViewData["ErroLogin"] = string.Empty;

            if (ModelState.IsValid)
            {
                var Senha = Criptografia.GetMd5Hash(model.Senha);
                bool login = ServicoAplicacaoUsuario.ValidarLogin(model.Email, Senha);
                var usuario = ServicoAplicacaoUsuario.RetornarDadosUsuario(model.Email, Senha);

                if (login)
                {
                    //colocar os dados do usúario na sessão
                    HttpContextAcessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, usuario.Nome);
                    HttpContextAcessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, usuario.Email);
                    HttpContextAcessor.HttpContext.Session.SetInt32(Sessao.ID_USUARIO, (int)usuario.Id);
                    HttpContextAcessor.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["ErroLogin"] = "O Email ou Senha informado não existe no sistema!";
                    return View(model);
                }                                
            }
            else
            {
                return View(model);
            }            
        }
    }
}