using System.ComponentModel.DataAnnotations;

namespace APILibros.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Perfil { get; set; }
        [Required]
        public string UsuarioP { get; set; }
        [Required]
        public string Contrasena { get; set; }
    }
}
