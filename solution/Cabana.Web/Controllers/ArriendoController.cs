using Cabana.BLL.Arriendo.BusinessImplement;
using Cabana.BLL.Arriendo.BusinessInteface;
using Cabana.BLL.Arriendo.DataTransferObject;
using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Controllers
{
    public class ArriendoController : Controller
    {
        private readonly ICabanaService _cabanaService;
        public ArriendoController()
        {
            _cabanaService = new CabanaServiceImpl();
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
       /* public IActionResult Arrendar(IFormCollection collection)
        {
            var cabanaDto = new CabanaDto
            {
                CabanaId = collection[""],
                ModeloCabanaId=collection[""],
                NumeroCabana=collection[""],
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = "admin"
            };
        }*/
    }
}
