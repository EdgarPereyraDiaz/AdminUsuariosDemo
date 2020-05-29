using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AdministradorUsuarios.Controllers
{
    /// <summary>
    /// Modelo para edición de roles
    /// </summary>
    public class EditarRoles
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUsuarios> Members { get; set; }
        public IEnumerable<AppUsuarios> NonMembers { get; set; }
    }
}
