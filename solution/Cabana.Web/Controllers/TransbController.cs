using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Controllers
{
    public class TransbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
