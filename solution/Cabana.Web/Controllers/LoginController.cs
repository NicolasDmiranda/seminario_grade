using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
