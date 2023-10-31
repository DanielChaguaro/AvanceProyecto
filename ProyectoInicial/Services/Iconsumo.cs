using ProyectoInicial.Models;

namespace ProyectoInicial.Services
{
    public interface Iconsumo
    {
        Task<List<Libros>> GetLibros();
        Task<Libros> GetLibro(int IdLibro);
        Task<Libros> PostLibro(Libros Libro);

        Task<Libros> PutLibro(int IdLibro, Libros Libro);
        Task<string> DeleteLibro(int IdLibro);
        Task<List<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuario(int IdUsuario);
        Task<Usuario> PostUsuario(Usuario usuario);
        Task<Usuario> PutUsuario(int IdUsuario, Usuario usuario);
        Task<string> DeleteUsuario(int IdUsuario);
        Task<Usuario> LoginUsuario(string UsuarioP, string Contrasena);
    }
}



