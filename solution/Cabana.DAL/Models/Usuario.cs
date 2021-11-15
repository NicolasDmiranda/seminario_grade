using System;
using System.Collections.Generic;

namespace Cabana.DAL.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Arriendos = new HashSet<Arriendo>();
        }

        public int UsuarioId { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<Arriendo> Arriendos { get; set; }
    }
}
