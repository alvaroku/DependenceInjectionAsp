using Microsoft.EntityFrameworkCore;

namespace InyeccionDependencias.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
    }
}
