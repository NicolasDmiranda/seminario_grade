using Cabana.BLL.Usuario.BusinessImplement;
using Cabana.BLL.Usuario.BusinessInteface;
using Cabana.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cabana.Web.Controllers
{
    public class HomeController : Controller
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
            var o = _usuarioService.Login(new BLL.Usuario.DataTransferObject.UsuarioDto { Clave = "hola1", NombreUsuario = "hola1" });
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}