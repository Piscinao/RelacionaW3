// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
// using RelacionaW3.Dominio.Models;
// using RelacionaW3.Repositorio.Mapeamentos;

// namespace RelacionaW3.Repositorio
// {
//     public class IdentityContext : IdentityDbContext <Usuario, NivelAcesso, string>
//     {
//         public DbSet<Usuario> Usuario { get; set; }
//         public DbSet<NivelAcesso> NivelAcesso { get; set; }
//         public IdentityContext(DbContextOptions<IdentityContext> opcoes) : base(opcoes)
//         {

//         }
//          protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             base.OnModelCreating(modelBuilder);
            
//             modelBuilder.ApplyConfiguration(new UsuarioMap());
//             modelBuilder.ApplyConfiguration(new NivelAcessoMap()); 
//         }
//     }
// }
