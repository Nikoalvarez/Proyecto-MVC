using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PostLogin : Controller
    {
        public IActionResult Bienvenida()
        {
            ViewBag.Mensaje = "!BIENVENIDO A MI SISTEMA¡";
            return View();
        }
    }
}
