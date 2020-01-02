
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Repositorio;
using RelacionaW3.Repositorio.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.ViewComponents
{
    public class EventoViewComponent : ViewComponent
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly Context _context;

        public EventoViewComponent(Context contexto, IUsuarioRepositorio usuarioRepositorio)
        {
            _context = contexto;
            _usuarioRepositorio = usuarioRepositorio;
        }

       

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var usuario = await _usuarioRepositorio.PegarUsuarioLogado(HttpContext.User);
            
            return View(await _context.Evento.Include(e => e.Area).Include(e=> e.Pessoa).Where(e => e.IdUsuario == usuario.Id).ToListAsync());

        }
    }
}
