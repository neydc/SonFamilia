using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SonFamilia.Database;
using SonFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SonFamilia.Controllers
{
    public class DashboardController : Controller
    {
        private readonly SfContext con;

        public DashboardController(SfContext context)
        {
            con = context;
        }
       [HttpGet]
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
                var obtenerPost = con.Posts.Where(a => a.IdUsuario == user.Id).ToList();
                if (obtenerPost != null)
                {
                 
                    return View(obtenerPost);
                }
                
            }
            if (user==null)
            {
                return RedirectToAction("", "login");
            }
            return View();
        }
        private Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            if (claim != null)
            {
                var user = con.Usuarios.Where(o => o.Correo == claim.Value).FirstOrDefault();
                return user;
            }
            return null;
        }
    }

}
