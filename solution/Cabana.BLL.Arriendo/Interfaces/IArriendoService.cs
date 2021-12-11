using Cabana.BLL.Arriendo.DataTransferObject;
using Cabana.BLL.Comun.DataTransferObject;

namespace Cabana.BLL.Arriendo.Interfaces
{
    public interface IArriendoService
    {
        ListResponse<ResultadoArriendoDto> FiltrarArriendos(FiltroArriendoDto filter);
    }
}