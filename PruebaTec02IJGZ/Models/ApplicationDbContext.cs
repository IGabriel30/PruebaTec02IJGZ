using Microsoft.EntityFrameworkCore;

namespace PruebaTec02IJGZ.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }
        public DbSet<Cursos> Cursos { get; set; }
    }
}
