using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiRentas.Models
{
    public class Rentas
    {
        [Key]
        public int RentaId { get; set; }
        public string Cliente { get; set; }
        public string FechaRenta { get; set; }
        public string FechaDevolucion { get; set; }

        [ForeignKey("PeliculaId")]
        public string PeliculaId { get; set; }
    }
}
