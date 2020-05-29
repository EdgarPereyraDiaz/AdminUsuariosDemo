using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdministradorUsuarios.Models
{
    /// <summary>
    /// Modelo para inicio de sesión
    /// </summary>
    public class IniciarSesion
    {
        [EmailAddress(ErrorMessage = "E-mail no válido.")]
        [Required(ErrorMessage = "Campo obligatorio.")]
        [DisplayName("E-mail: ")]
        public string Correo { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo obligatorio.")]
        [DisplayName("Contraseña: ")]
        public string Contraseña { get; set; }
        public string ReturnUrl { get; set; }
    }
}
