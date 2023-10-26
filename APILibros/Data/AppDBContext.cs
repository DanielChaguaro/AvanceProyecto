using APILibros.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;

namespace APILibros.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(
            DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Libros> libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libros>().HasData(



                new Libros
                {
                    IdLibro = 1,
                    Nombre = "Harry Potter",
                    Autor = "J.K.Rowling",
                    Cantidad = 20,
                    Precio = 5
                },


                new Libros
                {
                    IdLibro = 2,
                    Nombre = "El alquimista",
                    Autor = "Paulo Coelho",
                    Cantidad = 43,
                    Precio = 7
                });



        }
    }
}