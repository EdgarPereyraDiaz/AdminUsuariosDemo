using System;

namespace AdministradorUsuarios.Models
{
    /// <summary>
    /// Modelo para manejo de errores
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}