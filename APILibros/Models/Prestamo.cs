using System.ComponentModel.DataAnnotations;

namespace APILibros.Models
{
    public class Prestamo
    {
        [Key]
        public int IdPrestamo { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int PrecioUnitario { get; set; }
        [Required]
        public int Total { get; set; }
        
    }
}
