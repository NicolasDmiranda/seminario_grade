using System;
using System.Collections.Generic;

namespace Cabana.DAL.Models
{
    public partial class Arriendo
    {
        public int ArriendoId { get; set; }
        public int CabanaId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int ClienteId { get; set; }
        public int TotalArriendo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Cabana Cabana { get; set; } = null!;
        public virtual Usuario Cliente { get; set; } = null!;
    }
}
