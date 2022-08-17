using Microsoft.EntityFrameworkCore;
using PeliculaAPI.Models;

namespace PeliculaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
    }
}
