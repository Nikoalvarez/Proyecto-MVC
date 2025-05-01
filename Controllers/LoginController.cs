using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.DataBaseFake;

namespace MvcMovie.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string Password)
        {
            var user = DataBaseLogin.Usuarios.FirstOrDefault(u => u.User == User && u.Password == Password);

            if (user != null)
            {

                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, User)
                };


                HttpContext.Session.SetString("user", user.User);
                var identity = new ClaimsIdentity(claims, "cookies");
                var principal = new ClaimsPrincipal(identity);


                HttpContext.SignInAsync("cookies", principal);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.Error = "Credenciales Invalidas";
            }

                return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("cookies");

            return RedirectToAction("Login");
        }
    }
}
