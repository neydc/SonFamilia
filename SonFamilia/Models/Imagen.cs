using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Models
{
    public class Imagen
    {
        public int Id{ get; set; }
        public string ImagenUrl{ get; set; }
        public int PostId { get; set; }
        public Post Post{ get; set; }
    }
}
