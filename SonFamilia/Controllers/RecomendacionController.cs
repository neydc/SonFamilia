
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SonFamilia.Database;
using SonFamilia.Models;
using System.Diagnostics;
using System.Linq;

namespace SonFamilia.Controllers
{
    public class RecomendacionController : Controller
    {
        private readonly SfContext context;
        public RecomendacionController(SfContext context)
        {
            this.context = context;
        }
      
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
            }
           
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            if (claim != null)
            {
                var user = context.Usuarios.Where(o => o.Correo == claim.Value).FirstOrDefault();
                return user;
            }
            return null;
        }
    }
}
