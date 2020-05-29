using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdministradorUsuarios.Models
{
    /// <summary>
    /// Modelo heredado de IdentityDbContext para migración
    /// </summary>
    public class UsuariosDbContext : IdentityDbContext<AppUsuarios>
    {
        public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options) : base(options)
        {
        }
        public DbSet<AppUsuarios> Usuarios { get; set; }
    }
}
