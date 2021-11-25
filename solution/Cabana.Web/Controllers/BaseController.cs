using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cabana.Web.Controllers
{
    public class BaseController : Controller
    {
        public void SetFullName()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;

            ViewBag.FullName = identity?.Claims.FirstOrDefault(o => o.Type == "FullName")?.Value;
        }

        public string GetCurrerntUserName()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;

            return identity?.Claims.FirstOrDefault(o => o.Type == ClaimTypes.Name)?.Value;
        }
    }
}
