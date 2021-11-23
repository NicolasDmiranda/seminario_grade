using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Controllers
{
    public class NosotrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
