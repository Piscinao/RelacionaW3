
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Repositorio;
using RelacionaW3.Repositorio.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.MVC.ViewComponents
{
    public class EventoAreaViewComponent : ViewComponent
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly Context _context;

        private readonly IAreaResponsavelRepositorio _areaResponsavelRepositorio;

        public EventoAreaViewComponent(Context contexto, IUsuarioRepositorio usuarioRepositorio, IAreaResponsavelRepositorio areaResponsavelRepositorio)
        {
            _context = contexto;
            _usuarioRepositorio = usuarioRepositorio;
            _areaResponsavelRepositorio = areaResponsavelRepositorio;
        }

       

        // public async Task<IViewComponentResult> InvokeAsync()
        // {
        //     var usuario = await _usuarioRepositorio.PegarUsuarioLogado(HttpContext.User);
        //     var areaResponsavel = await _usuarioRepositorio.PegarUsuarioLogado(HttpContext.User);

        //     return View(await _context.Evento.Include(e => e.Area).Include(e=> e.AreaResponsavel).Include(e=> e.Pessoa)
        //     .Where(e => e.IdArea == IdArea == usuario.Id).ToListAsync());
         
        // }

        public async Task<IViewComponentResult> InvokeAsync(int IdArea, string IdUsuario)
        {
            var usuarioLogado = await _usuarioRepositorio.PegarUsuarioLogado(HttpContext.User);
    
            var areaUsuario = await _areaResponsavelRepositorio.GetAreaById(IdArea, IdUsuario);
            
            return View(await _context.Evento.Include(e => e.Area).Include(e=> e.AreaResponsavel).Include(e=> e.Pessoa).Include(e=>e.Usuario)
            .Where(a => a.IdArea == areaUsuario.IdArea && usuarioLogado.Id == areaUsuario.IdUsuario).ToListAsync());
        }

        //  Evento IdArea == AreareponsavelIdArea e UsuarioLogado == AreaReponsavelIdUsuario

          
    }
}
