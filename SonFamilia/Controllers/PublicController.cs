using Microsoft.AspNetCore.Mvc;
using SonFamilia.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Controllers
{
    public class PublicController : Controller
    {
        private readonly SfContext db;
        public PublicController(SfContext cnn)
        {
            this.db = cnn;
        }
        public IActionResult Index()
        {
            var publicaciones = db.Posts.ToList();
            return View(publicaciones);
        }
    }
}
