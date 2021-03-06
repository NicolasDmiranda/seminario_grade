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

        public ListResponse<ResultadoArriendoDto> FiltrarArriendos(FiltroArriendoDto filter)
        {
            var response = new ListResponse<ResultadoArriendoDto>
            {
                IsValid = true
            };

            response.ResultList = new List<ResultadoArriendoDto>
            {
                new ResultadoArriendoDto
                {
                    Banos = 1,
                    CabanaIdList = new List<int>{1,2,3},
                    Capacidad= 4,
                    Descripcion= "Gran capacidad para una familia de 4 personas.",
                    Dormitorios=2,
                    Estacionamiento= true,
                    Modelo = "Modelo 1",
                    Valor= 50000,
                    Wifi = true
                },
                new ResultadoArriendoDto
                {
                    Banos = 2,
                    CabanaIdList = new List<int>{1,2,3},
                    Capacidad= 6,
                    Descripcion= "Gran capacidad para una familia de 6 personas.",
                    Dormitorios=4,
                    Estacionamiento= true,
                    Modelo = "Modelo 2",
                    Valor= 100000,
                    Wifi = true
                }
            };

            return response;
            
        }
    }
    
}

