using Microsoft.EntityFrameworkCore;
using MvcCryptographyBBDD.Models;

namespace MvcCryptographyBBDD.Data
{
    public class UsuariosContext : DbContext
    {

        public UsuariosContext(DbContextOptions<UsuariosContext> options)
            : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
