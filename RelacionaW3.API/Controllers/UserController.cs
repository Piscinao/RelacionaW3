using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RelacionaW3.API.Dtos;
using RelacionaW3.Dominio.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace RelacionaW3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserController(IConfiguration config,
                                UserManager<User> userManager,
                                SignInManager<User> signInManager,
                                IMapper mapper)
        //parametros passados por injeção de dependencia
        {   
            _signInManager = signInManager;
            _mapper = mapper;
            _config = config;
            _userManager = userManager;
        }


        [HttpGet("GetUser")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUser()
        {
            return Ok(new UserDto());
            
        }

        
        // public async Task<IActionResult> GetUser(UserDto userDto)
        // {
        //     return Ok(userDto);
            
        // }

        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserDto userDto)
        {
           try
           {    // recebe o json e preenche alguns campos do user
               var user = _mapper.Map<User>(userDto);
               // pega o user e registra no banco
               var result = await _userManager.CreateAsync(user, userDto.Password);

               var userToReturn = _mapper.Map<UserDto>(user);

               if(result.Succeeded)
               {    
                   return Created("GetUser", userToReturn);
               }

               return BadRequest(result.Errors);

           }

           catch(System.Exception ex)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");
           }
            
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginDto userLogin)
        {
            try
            {
                // verifica se tem algum usuario com o nome passado 
                var user = await _userManager.FindByNameAsync(userLogin.UserName);
                // verifica o password do usuario
                var result  = await _signInManager.CheckPasswordSignInAsync(user, userLogin.Password, false);
                //retorna o usuario que foi especificado
                if(result.Succeeded)
                {
                    var appUser = await _userManager.Users
                        .FirstOrDefaultAsync(u => u.NormalizedUserName == userLogin.UserName.ToUpper());

                    var userToReturn = _mapper.Map<UserLoginDto>(appUser);

                    return Ok(new {
                        //metodo que gera o token
                        token = GenerateJWToken(appUser).Result,
                        //usuario que foi mapeado pelo Dto
                        user = userToReturn,

                    });
                }

                return Unauthorized();
                
            }

            catch(System.Exception ex)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");
           }
            
        }

        // private async Task<string> GenerateJWToken(User user)
        // {
        //     var key = new SymmetricSecurityKey(Encoding.ASCII
        //                      .GetBytes(_config.GetSection("AppSettings:Token").Value));
        // }

         private async Task<string> GenerateJWToken(User user)
    
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName)
        };

        // controle de acesso via roles
        var roles = await _userManager.GetRolesAsync(user);

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        var key = new SymmetricSecurityKey(Encoding.ASCII
            .GetBytes(_config.GetSection("AppSettings:Token").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(1),
            SigningCredentials = creds
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
  }
}
