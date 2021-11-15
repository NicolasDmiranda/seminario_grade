using System;
using System.Collections.Generic;

namespace Cabana.DAL.Models
{
    public partial class Cabana
    {
        public Cabana()
        {
            Arriendos = new HashSet<Arriendo>();
        }

        public int CabanaId { get; set; }
        public int ModeloCabanaId { get; set; }
        public int NumeroCabana { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ModeloCabana ModeloCabana { get; set; } = null!;
        public virtual ICollection<Arriendo> Arriendos { get; set; }
    }
}
