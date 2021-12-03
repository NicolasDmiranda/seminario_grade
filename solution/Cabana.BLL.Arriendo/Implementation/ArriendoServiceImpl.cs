using Cabana.BLL.Arriendo.DataTransferObject;
using Cabana.BLL.Arriendo.Interfaces;
using Cabana.BLL.Comun.DataTransferObject;
using Cabana.DAL.Implementation;
using Cabana.DAL.Interfaces;


namespace Cabana.BLL.Arriendo.Implementation
{
    public class ArriendoServiceImpl : IArriendoService
    {
        private readonly IGenericRepository<DAL.Models.Arriendo> _arriendoDao;

        public ArriendoServiceImpl()
        {
            _arriendoDao = new GenericRepository<DAL.Models.Arriendo>();
        }

        public SingleResponse<ResultadoArriendoDto> ResultadoArriendo(ResultadoArriendoDto arriendo)
        {
            List<ResultadoArriendoDto> lista = new List<ResultadoArriendoDto>();

            lista.Add(arriendo);
            
        }
    }
    
}

