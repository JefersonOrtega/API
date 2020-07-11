using APIPrestamos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPrestamos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= C:\BasesDeDatosAp2\APIPrestamos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>().HasData(new
            {
                PersonaId = 10,
                Nombre = "Juan Pineda",
                Telefono = "829-666-6000",
                Cedula = "058-6669531-4",
                Direccion = "C/27 de Febrero Esq.Castillo",
                FechaNacimiento = DateTime.Now,
                Balance = 0.00
            });
        }
    }
}
