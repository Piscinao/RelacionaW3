using System.Threading.Tasks;
using RelacionaW3.Dominio;

namespace RelacionaW3.Repositorio
{
    public interface IRelacionaW3Repositorio
    {
        //Geral
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangeAsync();

        //Eventos
        Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);

        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);

        Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

        Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includeEventos);

        Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos);
          
    }
}