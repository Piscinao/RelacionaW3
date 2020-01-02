// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Aplicacao.Servico.Interfaces;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

// using RelacionaW3.MVC.Models;


// namespace RelacionaW3.MVC.Controllers
// {
//     [Authorize]
//     public class UsuarioController : Controller
//     {
//         private readonly IServicoAplicacaoUsuario ServicoAplicacaoUsuario;
//         private readonly ILogger<UsuarioController> _logger;

//          public UsuarioController(IServicoAplicacaoUsuario servicoAplicacaoUsuario)
//         {
//             ServicoAplicacaoUsuario = servicoAplicacaoUsuario;

//         }

//         [AllowAnonymous]
//         public async Task<IActionResult> Create()
//         {
//             if (User.Identity.IsAuthenticated)
//                 await ServicoAplicacaoUsuario.EfetuarLogOut();

//             // _logger.LogInformation("Entrando na página de registro");
//             return View();
//         }

//         [AllowAnonymous]
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Create(RegistroViewModel registro)
//         {
//             if(ModelState.IsValid)
//             {
//                 var usuario = new UsuarioIdentity
//                 {
//                     UserName = registro.NomeUsuario,
//                     Email = registro.Email,
//                     CPF = registro.CPF,
//                     Telefone = registro.Telefone,
//                     Nome = registro.Nome,
//                     PasswordHash = registro.Senha
//                 };

//                 // _logger.LogInformation("Tentando criar um usuário");
//                 var resultado = await ServicoAplicacaoUsuario.SalvarUsuario(usuario, registro.Senha);

//                 if(resultado.Succeeded)
//                 {
//                     // _logger.LogInformation("Novo usuário criado");
//                     // _logger.LogInformation("Atribuindo nível de acesso ao novo usuário");
//                     var nivelAcesso = "Administrador";

//                     await ServicoAplicacaoUsuario.AtribuirNivelAcesso(usuario, nivelAcesso);
//                     // _logger.LogInformation("Atribuição concluída");

//                     // _logger.LogInformation("Logando o usuário");
//                     await ServicoAplicacaoUsuario.EfetuarLogin(usuario, false);
//                     // _logger.LogInformation("Usuário logado com sucesso");

//                     return RedirectToAction("Index", "Home");
//                 }

//                 else
//                 {
//                     // _logger.LogError("Erro ao criar o usuário");

//                     foreach (var erro in resultado.Errors)
//                         ModelState.AddModelError("", erro.Description.ToString());
//                 }               

//             }
//             // _logger.LogError("Informações de usuário inválidas");
//             return View(registro);
//         }

//         [AllowAnonymous]
//         public async Task<IActionResult> Login()
//         {
//             if (User.Identity.IsAuthenticated)
//                 await ServicoAplicacaoUsuario.EfetuarLogOut();

//             // _logger.LogInformation("Entrando na página de login");
//             return View();
//         }

//         [AllowAnonymous]
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Login(LoginViewModel login)
//         {
//             if(ModelState.IsValid)
//             {
//                 // _logger.LogInformation("Pegando o usuário pelo email");
//                 var usuario = await ServicoAplicacaoUsuario.PegarUsuarioPeloEmail(login.Email);
//                 PasswordHasher<UsuarioIdentity> passwordHasher = new PasswordHasher<UsuarioIdentity>();

//                 if(usuario != null)
//                 {
//                     // _logger.LogInformation("Verificando informações do usuário");
//                     if(passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, login.Senha) != PasswordVerificationResult.Failed)
//                     {
//                         // _logger.LogInformation("Informações corretas. Logando o usuário");
//                         await ServicoAplicacaoUsuario.EfetuarLogin(usuario, false);

//                         return RedirectToAction("Index", "Home");
//                     }

//                     // _logger.LogError("Informações inválidas");
//                     ModelState.AddModelError("", "Email e/ou senha inválidos");
//                 }

//                 // _logger.LogError("Informações inválidas");
//                 ModelState.AddModelError("", "Email e/ou senha inválidos");
//             }
//             return View(login);
//         }

//         public async Task<IActionResult> LogOut()
//         {
//             await ServicoAplicacaoUsuario.EfetuarLogOut();

//             return RedirectToAction("Login", "Usuario");
//         }


//         [HttpGet]
//         public async Task<IActionResult> Atualizar(string UsuarioId)
//         {
//             _logger.LogInformation("Verificando se o usuário existe");
//             var usuario = await ServicoAplicacaoUsuario.PegarPeloId(UsuarioId);

//             var atualizarViewModel = new AtualizarViewModel
//             {
//                 Id = usuario.Id,
//                 Nome = usuario.Nome,
//                 CPF = usuario.CPF,
//                 Email = usuario.Email,
//                 Telefone = usuario.Telefone,
//                 NomeUsuario = usuario.UserName
//             };
//             _logger.LogInformation("Atualizar usuário");
//             return View(atualizarViewModel);
//         }

//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Atualizar(AtualizarViewModel atualizarViewModel)
//         {
//             if(ModelState.IsValid)
//             {
//                 var usuario = await ServicoAplicacaoUsuario.PegarPeloId(atualizarViewModel.Id);

//                 usuario.Nome = atualizarViewModel.Nome;
//                 usuario.CPF = atualizarViewModel.CPF;
//                 usuario.UserName = atualizarViewModel.NomeUsuario;
//                 usuario.Email = atualizarViewModel.Email;
//                 usuario.Telefone = atualizarViewModel.Telefone;

//                 await ServicoAplicacaoUsuario.AtualizarUsuario(usuario);
//                 _logger.LogInformation("Atualizando usuário");

//                 return RedirectToAction("Index", "Usuario");
//             }
//             _logger.LogError("Informações inválidas");

//             return View(atualizarViewModel);
//         }
//     }
// }