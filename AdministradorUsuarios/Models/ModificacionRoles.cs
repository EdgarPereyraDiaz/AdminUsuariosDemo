using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdministradorUsuarios.Models
{
    /// <summary>
    /// Modelo para modificación de roles
    /// </summary>
    public class ModificacionRoles
    {
        [Required(ErrorMessage = "Nombre del Rol es obligatorio")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Nombre del Rol solo con letras y sin espacios")]
        [DisplayName("Nombre del Rol:: ")]
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] AddIds { get; set; }
        public string[] DeleteIds { get; set; }
    }
}
