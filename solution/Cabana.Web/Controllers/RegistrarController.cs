using Cabana.BLL.Usuario.BusinessImplement;
using Cabana.BLL.Usuario.BusinessInteface;
using Cabana.BLL.Usuario.DataTransferObject;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cabana.Web.Controllers
{
    public class RegistrarController : Controller
    {

        private readonly IUsuarioService _usuarioService;

        public RegistrarController()
        {
            _usuarioService = new UsuarioServiceImpl();
        }
        public IActionResult Index()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"]?.ToString();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(IFormCollection collection)
        {
            var usuarioDto = new UsuarioDto
            {
                NombreCompleto = collection["NOMBRE"],
                NombreUsuario = collection["USUARIO"],
                Correo = collection["EMAIL"],
                Clave = collection["PSW"],
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = "admin"

            };

            var response = _usuarioService.Insert(usuarioDto);
            if (response.IsValid)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                TempData["ErrorMessage"] = response.Mensaje;
                return RedirectToAction("Index");
            }
        }
    }
}
