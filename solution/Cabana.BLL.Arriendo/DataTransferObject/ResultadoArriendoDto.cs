using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabana.BLL.Arriendo.DataTransferObject
{
    public class ResultadoArriendoDto
    {
        public List<int>CabanaIdList;
        public string Modelo { get; set; }
        public string Capacidad { get; set; }
        public string Estacionamiento { get; set; }
        public string Banos { get; set; }
        public string Dormitorios { get; set; }
        public int Valor { get; set; }
        public string Wifi { get; set; }
        public string Descripcion { get; set; }
    }
}
