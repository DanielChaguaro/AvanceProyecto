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
    }
}



