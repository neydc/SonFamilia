using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Models
{
    public class Usuario
    {
        public int Id{ get; set; }
        public string Nombre{ get; set; }
        public string Apellidos{ get; set; }
        public string Correo{ get; set; }
        public string Contrasenia{ get; set; }
        public string Tipo{ get; set; }
        public string Imagen{ get; set; }

        public List<Post> Posts{ get; set; }
    }
}
