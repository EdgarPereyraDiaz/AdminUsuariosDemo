using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdministradorUsuarios.Models
{
    /// <summary>
    /// Modelo para usuarios
    /// </summary>
    public class Usuarios
    {
        [Required(ErrorMessage = "Nombre de usuario es obligatorio")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Nombre de Usuario solo con letras y sin espacios")]
        [DisplayName("Nombre de Usuario: ")]
        public string NombreUsuario { get; set; }
        [EmailAddress(ErrorMessage = "E-mail no válido.")]
        [Required(ErrorMessage = "E-mail es obligatorio")]      
        [DisplayName("E-mail: ")]
        public string Correo { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Contraseña es obligatoria")]
        [DisplayName("Contraseña: ")]
        public string Contraseña { get; set; }
    }
}
