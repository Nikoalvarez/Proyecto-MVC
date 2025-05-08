using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;





namespace MvcMovie.Controllers
{
    [Authorize]
    public class PostLogin : Controller
    {
        public IActionResult Bienvenida()
        {
            ViewBag.Mensaje = "!BIENVENIDO A MI SISTEMA¡";
            return View();
        }
    }
}
