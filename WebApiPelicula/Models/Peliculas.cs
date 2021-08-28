using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPelicula.Models
{
    public class Peliculas
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string FechaLanzamiento { get; set; }
    }
}
