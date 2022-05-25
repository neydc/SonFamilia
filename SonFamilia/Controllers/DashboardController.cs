using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonFamilia.Database;
using SonFamilia.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SonFamilia.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly SfContext con;
        [Obsolete]
        private IHostingEnvironment ihostingEnvironment;

        [Obsolete]
        public DashboardController(SfContext context, IHostingEnvironment _hostingEnvironment)
        {
            con = context;
            ihostingEnvironment = _hostingEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
                var obtenerPost = con.Posts.Where(a => a.IdUsuario == user.Id).Where(a=>a.Estado==1).ToList();
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
        [HttpGet]
        public IActionResult Editar(int id)
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
            }
            var post = con.Posts.Where(a => a.Id == id).FirstOrDefault();
            return View(post);
        }
        [HttpPost]
        public IActionResult Editar(Post post, IFormFile photos,int id)
        {
            var obtnerPost = con.Posts.Where(a=>a.Id==id).FirstOrDefault();
            if (obtnerPost!=null)
            {
                obtnerPost.Titulo =post.Titulo;
                obtnerPost.Descripcion =post.Descripcion;
                obtnerPost.Estado =1;
                if (photos!=null)
                {
                    if (obtnerPost.Imagen != photos.FileName)
                    {
                        var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", photos.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        photos.CopyToAsync(stream);
                        obtnerPost.Imagen = photos.FileName;
                    }
                }
                con.SaveChanges();
                return RedirectToAction("", "dashboard");
            }
            return View();
        }

            [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var posteliminar = con.Posts.Where(a => a.Id == id).FirstOrDefault();
            if (posteliminar != null)
            {
                posteliminar.Estado = 0;
            }
            con.SaveChanges();
            return RedirectToAction("", "dashboard");
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
