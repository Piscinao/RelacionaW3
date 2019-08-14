using Microsoft.EntityFrameworkCore;
using RelacionaW3.API.Model;

namespace RelacionaW3.API.Data
{
    public class DataContext : DbContext


    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}
        
        public DbSet<Evento> Eventos {get; set;}
    }
}