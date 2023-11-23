using UsuariosTest.Models;
using Microsoft.EntityFrameworkCore;

namespace UsuariosTest.Infrastructure
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options) 
        { 
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

