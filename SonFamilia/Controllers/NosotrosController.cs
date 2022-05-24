using Microsoft.AspNetCore.Mvc;
using SonFamilia.Database;
using SonFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Controllers
{
    public class NosotrosController : Controller
    {
        private readonly SfContext con;

        public NosotrosController(SfContext context)
        {
            con = context;
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
