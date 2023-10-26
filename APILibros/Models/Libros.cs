using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APILibros.Models
{
    public class Libros
    {
        [Key]
        public int IdLibro { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Autor { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Precio { get; set; }



    }

}
