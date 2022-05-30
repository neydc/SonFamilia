using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        //public List<string> Imagen { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaRegistro{ get; set; }
        public int IdUsuario { get; set; }
        public int Estado { get; set; }

        public Usuario Usuario { get; set; }
        public List <Imagen> ListImagenes { get; set; }
    }
}
