﻿// <auto-generated />
using APILibros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APILibros.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APILibros.Models.Libros", b =>
                {
                    b.Property<int>("IdLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLibro"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IdLibro");

                    b.ToTable("libros");

                    b.HasData(
                        new
                        {
                            IdLibro = 1,
                            Autor = "J.K.Rowling",
                            Cantidad = 20,
                            Nombre = "Harry Potter",
                            Precio = 5
                        },
                        new
                        {
                            IdLibro = 2,
                            Autor = "Paulo Coelho",
                            Cantidad = 43,
                            Nombre = "El alquimista",
                            Precio = 7
                        });
                });

            modelBuilder.Entity("APILibros.Models.Prestamo", b =>
                {
                    b.Property<int>("IdPrestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrestamo"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("PrecioUnitario")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("IdPrestamo");

                    b.ToTable("prestamos");

                    b.HasData(
                        new
                        {
                            IdPrestamo = 1,
                            Cantidad = 5,
                            IdProducto = 1,
                            PrecioUnitario = 5,
                            Total = 25
                        },
                        new
                        {
                            IdPrestamo = 2,
                            Cantidad = 3,
                            IdProducto = 1,
                            PrecioUnitario = 5,
                            Total = 15
                        });
                });

            modelBuilder.Entity("APILibros.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Apellido = "Chaguaro",
                            Contrasena = "hola",
                            Nombre = "Daniel",
                            Perfil = "usuario",
                            UsuarioP = "Daniel"
                        },
                        new
                        {
                            IdUsuario = 2,
                            Apellido = "Chaguaro",
                            Contrasena = "hola",
                            Nombre = "Juan",
                            Perfil = "cliente",
                            UsuarioP = "Daniel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
