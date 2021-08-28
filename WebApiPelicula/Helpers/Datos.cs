using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPelicula.Models;

namespace WebApiPelicula.Helpers
{
    public class Datos : DbContext
    {
        public DbSet<Peliculas> Pelicula { get; set; } //Tabla categoria de la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Conexion = @"Server = localhost;
                                    Database = dbRentaPeliculas; 
                                    User = sa; 
                                    Password =luis1598*;";
             optionsBuilder.UseSqlServer(Conexion);
        }
    }
}
