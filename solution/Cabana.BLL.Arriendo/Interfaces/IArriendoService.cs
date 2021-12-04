using Cabana.BLL.Arriendo.DataTransferObject;
using Cabana.BLL.Comun.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabana.BLL.Arriendo.Interfaces
{
    public interface IArriendoService
    {
        ListResponse<ResultadoArriendoDto> ResultadoArriendo(DateTime fecInicio, DateTime fecFin);
    }
}
