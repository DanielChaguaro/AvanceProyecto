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
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Prestamo> prestamos { get; set; }

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
            modelBuilder.Entity<Usuario>().HasData(

                new Usuario
                {
                    IdUsuario = 1,
                    Nombre = "Daniel",
                    Apellido = "Chaguaro",
                    Perfil = "usuario",
                    UsuarioP = "Daniel",
                    Contrasena = "hola"
                },


                new Usuario
                {
                    IdUsuario = 2,
                    Nombre = "Juan",
                    Apellido = "Chaguaro",
                    Perfil = "cliente",
                    UsuarioP = "Daniel",
                    Contrasena = "hola"
                });
            modelBuilder.Entity<Prestamo>().HasData(

                new Prestamo
                {
                    IdPrestamo = 1,
                    IdProducto = 1,
                    Cantidad = 5,
                    PrecioUnitario = 5,
                    Total = 25

                },
                new Prestamo
                {
                    IdPrestamo = 2,
                    IdProducto = 1,
                    Cantidad = 3,
                    PrecioUnitario = 5,
                    Total = 15

                });

        }
        }
    }
