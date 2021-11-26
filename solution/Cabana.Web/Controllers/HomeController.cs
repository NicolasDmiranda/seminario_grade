using Cabana.BLL.Usuario.BusinessImplement;
using Cabana.BLL.Usuario.BusinessInteface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cabana.Web.Controllers
{
    //[Authorize]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsuarioService _usuarioService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _usuarioService = new UsuarioServiceImpl();
        }

        public IActionResult Index()
        {
            SetFullName();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Arriendo()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}