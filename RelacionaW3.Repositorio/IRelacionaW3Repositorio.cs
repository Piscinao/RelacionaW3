using System.Threading.Tasks;
using RelacionaW3.Dominio;
using RelacionaW3.Dominio.Identity;

namespace RelacionaW3.Repositorio
{
    public interface IRelacionaW3Repositorio
    {
        //Geral
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(T[] entity) where T : class;



        Task<bool> SaveChangeAsync();

        //Users

        Task<User[]> GetAllUserAsync(bool includeAspNetUsers);

        Task<User> GetUserAsyncById(int UserId, bool includeAspNetUsers);

        //Evento
        Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);

        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);

        Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

        Task<Area[]> GetAllAreaAsyncByNome(string nome, bool includeAreas);

        Task<Area[]> GetAllAreaAsync(bool includeAreas);

        Task<Area> GetAreaAsyncById(int AreaId, bool includeAreas);

    

        Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includeEventos);

        Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos);
  
    }
}