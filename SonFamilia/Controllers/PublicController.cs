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
using System.Threading.Tasks;

namespace SonFamilia.Controllers
{
    public class PublicController : Controller
    {
        private readonly SfContext con;
        private IHostingEnvironment ihostingEnvironment;
        public PublicController(SfContext cnn, IHostingEnvironment _hostingEnvironment)
        {
            this.con = cnn;
            ihostingEnvironment = _hostingEnvironment;
        }
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
            }

            var publicaciones = con.Posts.Include(a => a.Usuario).Where(a=>a.Estado==1).ToList();
            return View(publicaciones);
        }

        public IActionResult Crear()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Crear(Post post, IFormFile photos)
        {
            if (ModelState.IsValid)
            {
                Usuario user = LoggedUser();
                con.Posts.Add(post);
                var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", photos.FileName);
                var stream = new FileStream(path, FileMode.Create);
                photos.CopyToAsync(stream);
                post.Imagen = photos.FileName;
                post.FechaRegistro = DateTime.Now;
                post.IdUsuario = user.Id;
                con.SaveChanges();
                return RedirectToAction("", "public");
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

        public IActionResult Detalle(int id)
        {
            var post = con.Posts.Include(a => a.Usuario).Where(a => a.Id == id).FirstOrDefault();
            return View(post);
        } 
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var posteliminar = con.Posts.Where(a=>a.Id==id).FirstOrDefault();
            if (posteliminar!=null)
            {
                posteliminar.Estado = 0;
            }
            con.SaveChanges();
            return RedirectToAction("","public");
        }
    }
}
