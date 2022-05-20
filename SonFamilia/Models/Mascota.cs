using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Models
{
    public class Mascota
    {
        public int Id{ get; set; }
        public string Nombre{ get; set; }
        public string Descripcion{ get; set; }
        public string Estado{ get; set; }
        public string Imagen{ get; set; }
    }
}
