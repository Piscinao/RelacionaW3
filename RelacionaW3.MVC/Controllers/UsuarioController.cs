using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RelacionaW3.MVC.Controllers
{
    [Route("Usuario")]
    public class UsuarioController : Controller
    {
        [Route("{view=Index}")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}