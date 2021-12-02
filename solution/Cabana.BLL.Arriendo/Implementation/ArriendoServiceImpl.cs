using Cabana.BLL.Arriendo.Interfaces;
using Cabana.DAL.Interfaces;


namespace Cabana.BLL.Arriendo.Implementation
{
    public class ArriendoServiceImpl : IArriendoService
    {
        private readonly IGenericRepository<DAL.Models.Arriendo> _arriendoDao;

        public ArriendoServiceImpl()
        {
            _arriendoDao = new IGenericRepository<DAL.Models.Arriendo>();
        }
    }
    
}

