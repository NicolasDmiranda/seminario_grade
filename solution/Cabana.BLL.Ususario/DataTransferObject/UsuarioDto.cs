

namespace Cabana.BLL.Usuario.DataTransferObject
{
    public class UsuarioDto
    {
        public int UsuarioId { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
