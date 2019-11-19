// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using Microsoft.Extensions.Logging;

// namespace RelacionaW3.MVC.Models
// {
//     [AllowAnonymous]
//     public class LoginViewModel : PageModel
//     {
//         private readonly SignInManager<IdentityUser> _signInManager;
//         private readonly ILogger<LoginViewModel> _logger;

//         public LoginViewModel(SignInManager<IdentityUser> signInManager, ILogger<LoginViewModel> logger)
//         {
//             _signInManager = signInManager;
//             _logger = logger;
//         }

//         [BindProperty]
//         public InputModel Input { get; set; }

//         public IList<AuthenticationScheme> ExternalLogins { get; set; }

//         public string ReturnUrl { get; set; }

//         [TempData]
//         public string ErrorMessage { get; set; }

//         public class InputModel
//         {
//             [Required]
//             [EmailAddress]
//             public string Email { get; set; }

//             [Required]
//             [DataType(DataType.Password)]
//             public string Password { get; set; }

//             [Display(Name = "Remember me?")]
//             public bool RememberMe { get; set; }
//         }

       
//     }
// }
