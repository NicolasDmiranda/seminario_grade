using Cabana.BLL.Arriendo.BusinessInteface;
using Cabana.BLL.Arriendo.DataTransferObject;
using Cabana.DAL.Implementation;
using Cabana.DAL.Interfaces;

namespace Cabana.BLL.Arriendo.BusinessImplement
{
    public class CabanaServiceImpl : ICabanaService
    {
        private readonly IGenericRepository<DAL.Models.Cabana> _cabanaDao;

        public CabanaServiceImpl()
        {
            _cabanaDao = new GenericRepository<DAL.Models.Cabana>();
        }

        public List<CabanaDto> Test()
        {
            return _cabanaDao.GetAll().Select(o => new CabanaDto
            {
                CabanaId = o.CabanaId,
                FechaCreacion = o.FechaCreacion,
                ModeloCabanaId = o.ModeloCabanaId,
                NumeroCabana = o.NumeroCabana,
                UsuarioCreacion = o.UsuarioCreacion
            }).ToList();
        }
    }
}