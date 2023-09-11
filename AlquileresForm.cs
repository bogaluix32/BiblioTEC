using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTEC
{
    public partial class AlquileresForm : Form
    {
        private readonly Conexion _mongoDBConnection;
        public AlquileresForm()
        {
            InitializeComponent();
            _mongoDBConnection = new Conexion();
        }

        private void AlquileresForm_Load(object sender, EventArgs e)
        {
            ListarAlquileres();
        }

        private void ListarAlquileres()
        {
            IMongoCollection<Alquiler> AlquileresCollection = _mongoDBConnection.AlquilerCollection;

            // Define la proyección para incluir solo los campos 'carne' y 'fullname'.
            var projection = Builders<Alquiler>.Projection
                .Include(alquiler => alquiler.CarneEstudiante)
                .Include(alquiler => alquiler.CarreraEstudiante)
                .Include(alquiler => alquiler.CampusEstudiante)
                .Include(alquiler => alquiler.NombreLibro)
                .Include(alquiler => alquiler.FechaAlquiler)
                .Include(alquiler => alquiler.FechaVencimiento)
                .Include(alquiler => alquiler.FechaDevolucion)
                .Include(alquiler => alquiler.Estado)
                .Include(alquiler => alquiler.LateFees);

            // Realiza la consulta con la proyección y obtén los resultados en una lista.
            List<Alquiler> alquileres = AlquileresCollection.Find(_ => true)
                .Project<Alquiler>(projection)
                .ToList();

            // Limpia el DataGridView antes de agregar nuevos datos.
            dgvData.Rows.Clear();

            // Agrega los estudiantes al DataGridView.
            foreach (var alquiler in alquileres)
            {
                DateTime.TryParse(alquiler.FechaVencimiento, out DateTime fechaVencimiento);
                DateTime.TryParse(alquiler.FechaDevolucion, out DateTime fechaDevolucion);

                TimeSpan diferencia = fechaDevolucion - fechaVencimiento;
                int morosidad = DefinirMorosidad(diferencia.Days, alquiler.LateFees);

                if (morosidad != 0)
                {
                    Morosidades objMorosidades = new Morosidades()
                    {
                        CarneEstudiante = alquiler.CarneEstudiante,
                        Morosidad = morosidad,
                        CampusEstudiante = alquiler.CampusEstudiante,
                        FechaVecimiento = fechaVencimiento.ToString("dd/MM/yyyy"),
                        NombreLibro = alquiler.NombreLibro,
                    };

                    var filtro = Builders<Morosidades>.Filter.Eq(x => x.NombreLibro, alquiler.NombreLibro);
                    IMongoCollection<Morosidades> MorosidadesCollection = _mongoDBConnection.MorosidadesCollection;
                    var existeRegistro = MorosidadesCollection.Find(filtro).Any();

                    if (existeRegistro)
                    {
                        // Define la actualización con los nuevos valores.
                        var actualizacion = Builders<Morosidades>.Update
                            .Set(x => x.Morosidad, objMorosidades.Morosidad);

                        // Realiza la actualización en la colección.
                        MorosidadesCollection.UpdateOne(filtro, actualizacion);
                    }
                    else
                    {
                        // Inserta el estudiante en la colección.
                        MorosidadesCollection.InsertOne(objMorosidades);
                    }
                }

                dgvData.Rows.Add("",
                    alquiler.CarneEstudiante,
                    alquiler.CarreraEstudiante,
                    alquiler.CampusEstudiante,
                    alquiler.NombreLibro,
                    alquiler.FechaAlquiler,
                    fechaVencimiento.ToString("dd/MM/yyyy"),
                    fechaDevolucion.ToString("dd/MM/yyyy"),
                    alquiler.Estado,
                    alquiler.LateFees
                );
            }
        }

        private int DefinirMorosidad(int numeroDias, double calificacion)
        {
            if(calificacion <= 3.9)
            {
                if (numeroDias <= 6) return 0;
                else if (numeroDias == 7) return 2000;
                else if (numeroDias > 7 && numeroDias <= 14) return 4000;
                else if (numeroDias > 14 && numeroDias <= 21) return 6000;
                else if (numeroDias > 21 && numeroDias <= 28) return 8000;
                else if (numeroDias > 28 && numeroDias <= 35) return 10000;
                else if (numeroDias > 35 && numeroDias <= 42) return 12000;
                else if (numeroDias > 42 && numeroDias <= 49) return 14000;
                else return 16000;
            }
            else
            {
                if (numeroDias <= 6) return 0;
                else if (numeroDias == 7) return 3500;
                else if (numeroDias > 7 && numeroDias <= 14) return 7000;
                else if (numeroDias > 14 && numeroDias <= 21) return 10500;
                else if (numeroDias > 21 && numeroDias <= 28) return 1400;
                else if (numeroDias > 28 && numeroDias <= 35) return 17500;
                else if (numeroDias > 35 && numeroDias <= 42) return 21000;
                else if (numeroDias > 42 && numeroDias <= 49) return 24500;
                else return 28000;
            }
            
        }
        private void ClearForm()
        {
            txtIndex.Text = "-1";
            txtCarneEstudiante.Text = "";
            txtCarerraEstudiante.Text = "";
            txtCampusEstudiante.Text = "";
            txtNombreLibro.Text = "";
            txtFechaAlquiler.Text = "";
            txtFechaVencimiento.Text = "";
            txtFechaDevolucion.Text = "";
            txtEstado.Text = "";
            txtMulta.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;

            Alquiler objAlquiler = new Alquiler()
            {
                CarneEstudiante = txtCarneEstudiante.Text,
                CarreraEstudiante = txtCarerraEstudiante.Text,
                CampusEstudiante = txtCampusEstudiante.Text,
                NombreLibro = txtNombreLibro.Text,
                FechaAlquiler = txtFechaAlquiler.Text,
                FechaVencimiento = txtFechaVencimiento.Text,
                FechaDevolucion = txtFechaDevolucion.Text,
                Estado = txtEstado.Text,
                LateFees = Convert.ToDouble(txtMulta.Text)
            };

            // Obtén la cantidad de libros disponibles para el libro en particular.
            int librosDisponibles = ObtenerCantidadLibrosDisponiblesParaLibro(objAlquiler.NombreLibro);

            if(librosDisponibles > 0)
            {
                if (Convert.ToInt32(txtID.Text) == 0)
                {
                    IMongoCollection<Alquiler> alquilerCollection = _mongoDBConnection.AlquilerCollection;

                    // Inserta el estudiante en la colección.
                    alquilerCollection.InsertOne(objAlquiler);

                    dgvData.Rows.Add(new object[] {"",
                        txtCarneEstudiante.Text,
                        txtCarerraEstudiante.Text,
                        txtCampusEstudiante.Text,
                        txtNombreLibro.Text,
                        txtFechaAlquiler.Text,
                        txtFechaVencimiento.Text,
                        txtFechaDevolucion.Text,
                        txtEstado.Text,
                        txtMulta.Text
                    });

                    // Disminuye la cantidad de libros disponibles en 1.
                    DisminuirCantidadLibrosDisponiblesParaLibro(objAlquiler.NombreLibro, librosDisponibles);

                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("No hay libros disponibles para alquilar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Convert.ToInt32(txtID.Text) != 0)
            {
                IMongoCollection<Alquiler> alquilerCollection = _mongoDBConnection.AlquilerCollection;

                // Define el filtro para identificar al estudiante que deseas actualizar.
                var filtro = Builders<Alquiler>.Filter.Eq(alquiler => alquiler.CarneEstudiante, objAlquiler.CarneEstudiante);

                // Define la actualización con los nuevos valores.
                var actualizacion = Builders<Alquiler>.Update
                    .Set(alquiler => alquiler.CarreraEstudiante, objAlquiler.CarreraEstudiante)
                    .Set(alquiler => alquiler.CampusEstudiante, objAlquiler.CampusEstudiante)
                    .Set(alquiler => alquiler.NombreLibro, objAlquiler.NombreLibro)
                    .Set(alquiler => alquiler.FechaAlquiler, objAlquiler.FechaAlquiler)
                    .Set(alquiler => alquiler.FechaVencimiento, objAlquiler.FechaVencimiento)
                    .Set(alquiler => alquiler.FechaDevolucion, objAlquiler.FechaDevolucion)
                    .Set(alquiler => alquiler.Estado, objAlquiler.Estado)
                    .Set(alquiler => alquiler.LateFees, objAlquiler.LateFees);

                // Realiza la actualización en la colección.
                alquilerCollection.UpdateOne(filtro, actualizacion);

                if (objAlquiler.Estado == "Cancelado")
                {
                    // Obtén la cantidad de libros disponibles para el libro en particular.
                    int librosDisponibles2 = ObtenerCantidadLibrosDisponiblesParaLibro(objAlquiler.NombreLibro);
                    AumentarCantidadLibrosDisponiblesParaLibro(objAlquiler.NombreLibro, librosDisponibles2);
                }
                ClearForm();
                ListarAlquileres();
            }
        }

        private int ObtenerCantidadLibrosDisponiblesParaLibro(string nombreLibro)
        {
            IMongoCollection<Libros> librosCollection = _mongoDBConnection.LibrosCollection2;

            // Define la proyección para incluir solo los campos 'carne' y 'fullname'.
            var projection = Builders<Libros>.Projection
                .Include(libro => libro.Name)
                .Include(libro => libro.Quantity);

            // Realiza la consulta con la proyección y obtén los resultados en una lista.
            List<Libros> libros = librosCollection.Find(_ => true)
                .Project<Libros>(projection)
                .ToList();

            foreach (var libro in libros)
            {
                if (nombreLibro == libro.Name) return libro.Quantity;
                else return 0;
            }
            return 0;
        }

        private void DisminuirCantidadLibrosDisponiblesParaLibro(string nombreLibro, int cantidadActual)
        {   
            int nuevaCantidad = cantidadActual - 1;
            IMongoCollection<Libros> librosCollection = _mongoDBConnection.LibrosCollection2;

            // Define el filtro para identificar al libro que deseas actualizar.
            var filtro = Builders<Libros>.Filter.Eq(libro => libro.Name, nombreLibro);

            // Define la actualización con los nuevos valores.
            var actualizacion = Builders<Libros>.Update
                .Set(libro => libro.Quantity, nuevaCantidad);

            // Realiza la actualización en la colección.
            librosCollection.UpdateOne(filtro, actualizacion);
        }

        private void AumentarCantidadLibrosDisponiblesParaLibro(string nombreLibro, int cantidadActual)
        {
            int nuevaCantidad = cantidadActual + 1;
            IMongoCollection<Libros> librosCollection = _mongoDBConnection.LibrosCollection2;

            // Define el filtro para identificar al libro que deseas actualizar.
            var filtro = Builders<Libros>.Filter.Eq(libro => libro.Name, nombreLibro);

            // Define la actualización con los nuevos valores.
            var actualizacion = Builders<Libros>.Update
                .Set(libro => libro.Quantity, nuevaCantidad);

            // Realiza la actualización en la colección.
            librosCollection.UpdateOne(filtro, actualizacion);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                int i = e.RowIndex;

                if (i >= 0)
                {
                    txtIndex.Text = i.ToString();
                    txtID.Text = i.ToString();
                    txtCarneEstudiante.Text = dgvData.Rows[i].Cells["carne"].Value.ToString();
                    txtCarerraEstudiante.Text = dgvData.Rows[i].Cells["carrera"].Value.ToString();
                    txtCampusEstudiante.Text = dgvData.Rows[i].Cells["campus"].Value.ToString();
                    txtNombreLibro.Text = dgvData.Rows[i].Cells["libro"].Value.ToString();
                    txtFechaAlquiler.Text = dgvData.Rows[i].Cells["alquiler"].Value.ToString();
                    txtFechaVencimiento.Text = dgvData.Rows[i].Cells["vencimiento"].Value.ToString();
                    txtFechaDevolucion.Text = dgvData.Rows[i].Cells["devolucion"].Value.ToString();
                    txtEstado.Text = dgvData.Rows[i].Cells["estado"].Value.ToString();
                    txtMulta.Text = dgvData.Rows[i].Cells["multa"].Value.ToString();
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el alquiler?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string message = string.Empty;

                    Alquiler objAlquiler = new Alquiler()
                    {
                        CarneEstudiante = txtCarneEstudiante.Text,
                    };

                    IMongoCollection<Alquiler> alquilerCollection = _mongoDBConnection.AlquilerCollection;

                    // Define el filtro para identificar al estudiante que deseas eliminar por su número de carné.
                    var filtro = Builders<Alquiler>.Filter.Eq(alquiler => alquiler.CarneEstudiante, objAlquiler.CarneEstudiante);

                    var result = alquilerCollection.DeleteOne(filtro);

                    if (result.DeletedCount > 0)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndex.Text));
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show(message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
    
    public class Alquiler
    {
        public ObjectId _id { get; set; }
        public string CarneEstudiante { get; set; }
        public string CarreraEstudiante { get; set; }
        public string CampusEstudiante { get; set; }
        public string NombreLibro { get; set; }
        public string FechaAlquiler { get; set; }
        public string FechaVencimiento { get; set; }
        public string FechaDevolucion { get; set; }
        public string Estado { get; set; }
        public double LateFees { get; set; }
    }

    public class Libros
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double UserRating { get; set; }
        public int Reviews { get; set; }

        public int Price { get; set; }

        public int Year { get; set; }
        public string Genre { get; set; }
        public int Quantity { get; set; }

    }

    public class Morosidades
    {
        public ObjectId _id { get; set; }
        public string CarneEstudiante { get; set; }
        public int Morosidad { get; set; }
        public string CampusEstudiante { get; set; }
        public string FechaVecimiento { get; set; }

        public string NombreLibro { get; set; }
    }
}
