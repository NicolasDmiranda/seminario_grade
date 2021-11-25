using Cabana.BLL.Usuario.BusinessImplement;
using Cabana.BLL.Usuario.BusinessInteface;
using Cabana.BLL.Usuario.DataTransferObject;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cabana.Web.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;


        public LoginController()
        {
            _usuarioService = new UsuarioServiceImpl();
        }

        public IActionResult Index()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"]?.ToString();
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection collection)
        {
            var usuarioDto = new UsuarioDto
            {
                Clave = collection["PSW"],
                NombreUsuario = collection["USUARIO"]
            };

            var response = _usuarioService.Login(usuarioDto);

            if (response.IsValid)
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim("FullName", response.Model.NombreCompleto),
                    new Claim(ClaimTypes.Name, response.Model.NombreUsuario)

                });

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity),
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTimeOffset.MaxValue,
                        AllowRefresh = true
                    });

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = response.Mensaje;
                return RedirectToAction("Index");
            }            
        }
    }
}
