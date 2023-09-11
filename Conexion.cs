using System.Configuration;
using MongoDB.Driver;

namespace BibliotecaTEC
{
    public class Conexion
    {
        private IMongoClient _mongoClient;
        private IMongoDatabase _mongoDatabase;

        public Conexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDBConnection"].ToString();
            _mongoClient = new MongoClient(connectionString);

            // Reemplaza "nombre_de_tu_base_de_datos" con el nombre real de tu base de datos.
            _mongoDatabase = _mongoClient.GetDatabase("BiblioTEC");
        }

        public IMongoCollection<Estudiante> EstudiantesCollection
        {
            get
            {
                // Reemplaza "nombre_de_tu_coleccion" con el nombre real de tu colección de estudiantes.
                return _mongoDatabase.GetCollection<Estudiante>("Estudiantes");
            }
        }

        public IMongoCollection<Libro> LibrosCollection
        {
            get
            {
                // Reemplaza "nombre_de_tu_coleccion" con el nombre real de tu colección de estudiantes.
                return _mongoDatabase.GetCollection<Libro>("Libros");
            }
        }

        public IMongoCollection<Libros> LibrosCollection2
        {
            get
            {
                // Reemplaza "nombre_de_tu_coleccion" con el nombre real de tu colección de estudiantes.
                return _mongoDatabase.GetCollection<Libros>("Libros");
            }
        }

        public IMongoCollection<Alquiler> AlquilerCollection
        {
            get
            {
                // Reemplaza "nombre_de_tu_coleccion" con el nombre real de tu colección de estudiantes.
                return _mongoDatabase.GetCollection<Alquiler>("Alquileres");
            }
        }

        public IMongoCollection<Morosidades> MorosidadesCollection
        {
            get
            {
                // Reemplaza "nombre_de_tu_coleccion" con el nombre real de tu colección de estudiantes.
                return _mongoDatabase.GetCollection<Morosidades>("Morosidades");
            }
        }

        public IMongoCollection<Extravios> ExtraviosCollection
        {
            get
            {
                // Reemplaza "nombre_de_tu_coleccion" con el nombre real de tu colección de estudiantes.
                return _mongoDatabase.GetCollection<Extravios>("Extravios");
            }
        }
    }
}
