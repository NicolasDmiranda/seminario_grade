using System;
using System.Collections.Generic;

namespace Cabana.DAL.Models
{
    public partial class ModeloCabana
    {
        public ModeloCabana()
        {
            Cabanas = new HashSet<Cabana>();
        }

        public int ModeloCabanaId { get; set; }
        public string Modelo { get; set; } = null!;
        public int Capacidad { get; set; }
        public bool Estacionamiento { get; set; }
        public int Banos { get; set; }
        public int Dormitorio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int ValorDia { get; set; }
        public bool Wifi { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Cabana> Cabanas { get; set; }
    }
}
