using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio;

namespace RelacionaW3.Repositorio
{
    public class RelacionaW3Repositorio : IRelacionaW3Repositorio
    {
        public RelacionaW3Repositorio(RelacionaW3Context context)
        {
            _context = context;
        }

        public RelacionaW3Context _context ;


//Gerais
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
             _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangeAsync()
        {
           return (await _context.SaveChangesAsync()) > 0 ;
        }
        
    
//Evento
        public async Task<Evento[]> GetAllEventoAsync(bool includePalestrantes = false)
        {                                           //se for passado com parametro true vai no IF
            IQueryable<Evento> query = _context.Eventos
            .Include(c => c.Lotes)
            .Include(c => c.RedesSociais);

            if(includePalestrantes){
                query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking()
            .OrderByDescending(c => c.DataEvento);

            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes)
        {
             IQueryable<Evento> query = _context.Eventos
            .Include(c => c.Lotes)
            .Include(c => c.RedesSociais);

            if(includePalestrantes){
                query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking()
            .OrderByDescending(c => c.DataEvento)
            .Where(c => c.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }
        public async Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(c => c.Lotes)
            .Include(c => c.RedesSociais);

            if(includePalestrantes){
                query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking()
            .OrderByDescending(c => c.DataEvento)
            .Where(c => c.Id == EventoId);

            return await query.FirstOrDefaultAsync();
        }

//Palestrante
       
        public async Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c => c.RedesSociais);

            if(includeEventos){
                query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(e => e.Evento);
            }

            query = query.AsNoTracking()
            .OrderBy(p => p.Nome)
            .Where(p => p.Id == PalestranteId);
              

            return await query.FirstOrDefaultAsync();
        }
         public async Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c => c.RedesSociais);

            if(includeEventos){
                query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(e => e.Evento);
            }

            query = query.AsNoTracking()
            .OrderBy(p => p.Nome)
            .Where(p => p.Nome.ToLower().Contains(name.ToLower()));
              

            return await query.ToArrayAsync();
        }

     

    }  
}