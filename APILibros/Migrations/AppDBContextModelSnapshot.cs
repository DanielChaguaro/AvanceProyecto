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
                .HasAnnotation("ProductVersion", "7.0.12")
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
#pragma warning restore 612, 618
        }
    }
}