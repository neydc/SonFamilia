using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SonFamilia.Database;
using SonFamilia.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Controllers
{
    public class RegistrarController : Controller
    {
        private readonly SfContext con;
        [Obsolete]
        private IHostingEnvironment ihostingEnvironment;

        [Obsolete]
        public RegistrarController(SfContext context, IHostingEnvironment _hostingEnvironment)
        {
            con = context;
            ihostingEnvironment = _hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registro( Usuario user, IFormFile photos)
        {
            if (ModelState.IsValid)
            {
                con.Usuarios.Add(user);
                var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", photos.FileName);
                var stream = new FileStream(path, FileMode.Create);
                photos.CopyToAsync(stream);
                user.Imagen = photos.FileName;
                con.SaveChanges();
                return RedirectToAction("","Login");
            }
            return View();
        }
    }
}
