using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRentas.Models;

namespace WebApiRentas.Helpers
{
    public class Datos : DbContext
    {
        public DbSet<Rentas> Renta { get; set; } //Tabla Rentas de la base de datos

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
