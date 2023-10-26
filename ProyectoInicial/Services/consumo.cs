using System.Text;
using ProyectoInicial.Models;
using Newtonsoft.Json;


namespace ProyectoInicial.Services
{
    public class consumo : Iconsumo
    {
        private static string _baseUrl;

        public consumo()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            _baseUrl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }
        public async Task<string> DeleteLibro(int IdLibro)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.DeleteAsync($"api/InventarioLibros/{IdLibro}");
            return "Producto eliminado correctamente";

        }



        public async Task<List<Libros>> GetLibros()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync("api/InventarioLibros/");
            var json_response = await response.Content.ReadAsStringAsync();
            List<Libros> listaLibros = JsonConvert.DeserializeObject<List<Libros>>(json_response);
            return listaLibros;

        }

        public async Task<Libros> GetLibro(int IdLibro)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var response = await httpClient.GetAsync($"api/InventarioLibros/{IdLibro}");
            var json_response = await response.Content.ReadAsStringAsync();
            Libros libro = JsonConvert.DeserializeObject<Libros>(json_response);
            return libro;
        }

        public async Task<Libros> PutLibro(int IdLibro, Libros libro)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var json = JsonConvert.SerializeObject(libro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"api/InventarioLibros/{IdLibro}", content);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            Libros editarLibro = JsonConvert.DeserializeObject<Libros>(jsonResponse);
            return editarLibro;

        }

        public async Task<Libros> PostLibro(Libros Libro)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_baseUrl);
            var json = JsonConvert.SerializeObject(Libro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("api/InventarioLibros", content);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            Libros libroCreado = JsonConvert.DeserializeObject<Libros>(jsonResponse);
            return libroCreado;
        }
    }
}


