

namespace Cabana.BLL.Arriendo.DataTransferObject
{
    public class ResultadoArriendoDto
    {
        public List<int>CabanaIdList;
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public bool Estacionamiento { get; set; }
        public int Banos { get; set; }
        public int Dormitorios { get; set; }
        public int Valor { get; set; }
        public bool Wifi { get; set; }
        public string Descripcion { get; set; }
    }
}
