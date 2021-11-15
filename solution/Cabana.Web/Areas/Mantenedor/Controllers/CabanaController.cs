using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Areas.Mantenedor.Controllers
{
    [Area("Mantenedor")]
    public class CabanaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
