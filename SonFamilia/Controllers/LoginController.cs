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
    public class LoginController : Controller
    {
        private readonly SfContext con;

        public LoginController(SfContext context)
        {
            con = context;
        }
       [HttpGet]
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                return RedirectToAction("","dashboard");
            }
            else { 
            return View();
            }
        }
        [HttpPost]
        public IActionResult SignIn(Usuario user)
        {
            if (user.Contrasenia==null || user.Correo==null)
            {
                if (user.Correo == null)
                {
                    ModelState.AddModelError("Correo", "Ingrese su Correo");
                }
                if (user.Contrasenia == null)
                {
                    ModelState.AddModelError("Contrasenia", "Ingrese su Contraseña");
                }
                ViewBag.Correo = user.Correo;
                ViewBag.Contrasenia = user.Contrasenia;
                return View("Index");
            }
            
            if (user!=null)
            {
                var userv = con.Usuarios.Where(o => o.Correo == user.Correo && o.Contrasenia == user.Contrasenia).FirstOrDefault();
                if (userv != null)
                {
                    var claims = new List<Claim> {
                             new Claim(ClaimTypes.Name, user.Correo)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    HttpContext.SignInAsync(claimsPrincipal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Incorrecto", "Usuario y/o Contraseña incorrecta");
                   
                }
            }
            ViewBag.Correo = user.Correo;
            ViewBag.Contrasenia = user.Contrasenia;
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
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }

}
