using Cabana.BLL.Arriendo.BusinessImplement;
using Cabana.BLL.Arriendo.BusinessInteface;
using Cabana.BLL.Arriendo.DataTransferObject;
using Cabana.BLL.Arriendo.Implementation;
using Cabana.BLL.Arriendo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Controllers
{
    public class ArriendoController : Controller
    {
        private readonly ICabanaService _cabanaService;
        private readonly IArriendoService _arriendoService;
        public ArriendoController()
        {
            _cabanaService = new CabanaServiceImpl();
            _arriendoService = new ArriendoServiceImpl();
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult FiltrarArriendos(FiltroArriendoDto filtro)
        {
            var resultado = _arriendoService.FiltrarArriendos(filtro);

            return View("TablaArriendos", resultado.ResultList);
        }
    }
}
