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

            var publicaciones = con.Posts.Include(a => a.Usuario).Where(a => a.Estado == 1).ToList();
            return View(publicaciones);
        }

        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Crear(Post post, List<IFormFile> photos)
        {
            Usuario user = LoggedUser();
            if (photos!=null)
            {
                var obtenerUltimoId = con.Posts.OrderByDescending(a => a.Id).FirstOrDefault();
                int idIncrementado = obtenerUltimoId.Id;
                post.Id = idIncrementado + 1;
                post.FechaRegistro = DateTime.Now;
                post.IdUsuario = user.Id;
                post.Estado = 1;
                post.Imagen = photos.FirstOrDefault().FileName;
                con.Posts.Add(post);
                con.SaveChanges();
                foreach (var image in photos)
                {
                    var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", image.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    image.CopyToAsync(stream);
                    var agregarImagen = new Imagen
                    {
                        ImagenUrl = image.FileName,
                        PostId = post.Id
                    };
                    con.Imagenes.Add(agregarImagen);
                }
             
                con.SaveChanges();
            }
            //if (ModelState.IsValid)
            //{
            //    Usuario user = LoggedUser();

            //    if (photos != null)
            //    {
            //        foreach (var item in photos.Images)
            //        {
            //            var _productImage = new ProductImage
            //            {
            //                ImageUrl = item.FileName,
            //            };
            //            con.ProductImage.Add(_productImage);
            //        }

            //        //var path = Path.Combine(ihostingEnvironment.WebRootPath, "images", photo.FileName);
            //        //using (var stream = System.IO.File.Create(path))
            //        //{
            //        //    await photo.CopyToAsync(stream);
            //        //}
            //        //var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", photos.FileName);
            //        //        var stream = new FileStream(path, FileMode.Create);
            //        //        photos.CopyToAsync(stream);

            //        //var filePath = Path.GetTempFileName();
            //        //using (var stream = System.IO.File.Create(filePath))
            //        //{
            //        //    await photo.CopyToAsync(stream);
            //        //}
            //        post.FechaRegistro = DateTime.Now;
            //        post.IdUsuario = user.Id;
            //        post.Estado = 1;
            //        con.SaveChanges();
            //    }
            //    return RedirectToAction("", "public");
            //}
            //public IActionResult Crear(Post post, IFormFile photos)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        Usuario user = LoggedUser();
            //        con.Posts.Add(post);
            //        var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", photos.FileName);
            //        var stream = new FileStream(path, FileMode.Create);
            //        photos.CopyToAsync(stream);
            //        post.Imagen = photos.FileName;
            //        post.FechaRegistro = DateTime.Now;
            //        post.IdUsuario = user.Id;
            //        post.Estado = 1;
            //        con.SaveChanges();
            //        return RedirectToAction("", "public");
            //    }
            //    return View();
            //}
            return RedirectToAction("", "public");
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
            var imagenes = con.Imagenes.Where(e=>e.PostId==post.Id).ToList();
            ViewBag.listimagenes = imagenes;
            return View(post);
        } 
    }
}
