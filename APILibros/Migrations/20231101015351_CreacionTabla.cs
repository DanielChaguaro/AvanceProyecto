using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APILibros.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.IdLibro);
                });

            migrationBuilder.CreateTable(
                name: "prestamos",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.IdPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "IdLibro", "Autor", "Cantidad", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "J.K.Rowling", 20, "Harry Potter", 5 },
                    { 2, "Paulo Coelho", 43, "El alquimista", 7 }
                });

            migrationBuilder.InsertData(
                table: "prestamos",
                columns: new[] { "IdPrestamo", "Cantidad", "IdProducto", "PrecioUnitario", "Total" },
                values: new object[,]
                {
                    { 1, 5, 1, 5, 25 },
                    { 2, 3, 1, 5, 15 }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "IdUsuario", "Apellido", "Contrasena", "Nombre", "Perfil", "UsuarioP" },
                values: new object[,]
                {
                    { 1, "Chaguaro", "hola", "Daniel", "usuario", "Daniel" },
                    { 2, "Chaguaro", "hola", "Juan", "cliente", "Daniel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libros");

            migrationBuilder.DropTable(
                name: "prestamos");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
