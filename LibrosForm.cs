using MongoDB.Bson;
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
    public partial class LibrosForm : Form
    {
        private readonly Conexion _mongoDBConnection;
        public LibrosForm()
        {
            InitializeComponent();
            _mongoDBConnection = new Conexion();
        }

        private void LibrosForm_Load(object sender, EventArgs e)
        {
            ListarLibros();
        }

        private void ListarLibros()
        {
            IMongoCollection<Libro> librosCollection = _mongoDBConnection.LibrosCollection;

            // Define la proyección para incluir solo los campos 'carne' y 'fullname'.
            var projection = Builders<Libro>.Projection
                .Include(libro => libro.Name)
                .Include(libro => libro.Author)
                .Include(libro => libro.UserRating)
                .Include(libro => libro.Reviews)
                .Include(libro => libro.Price)
                .Include(libro => libro.Year)
                .Include(libro => libro.Genre)
                .Include(libro => libro.Quantity);

            // Realiza la consulta con la proyección y obtén los resultados en una lista.
            List<Libro> libros = librosCollection.Find(_ => true)
                .Project<Libro>(projection)
                .ToList();

            // Limpia el DataGridView antes de agregar nuevos datos.
            dgvData.Rows.Clear();

            // Agrega los estudiantes al DataGridView.
            foreach (var libro in libros)
            {
                dgvData.Rows.Add("",
                    libro.Name,
                    libro.Author,
                    libro.UserRating,
                    libro.Reviews,
                    libro.Price,
                    libro.Year,
                    libro.Genre,
                    libro.Quantity
                );
            }
        }

        private void ClearForm()
        {
            txtIndex.Text = "-1";
            txtNombreLibro.Text = "";
            txtAutor.Text = "";
            txtCalificacion.Text = "";
            txtResenia.Text = "";
            txtPrecio.Text = "";
            txtAnio.Text = "";
            txtGenero.Text = "";
            txtCantidad.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;

            Libro objLibro = new Libro()
            {
                Name = txtNombreLibro.Text,
                Author = txtAutor.Text,
                UserRating = Convert.ToDouble(txtCalificacion.Text),
                Reviews = Convert.ToInt32(txtResenia.Text),
                Price = Convert.ToInt32(txtPrecio.Text),
                Year = Convert.ToInt32(txtAnio.Text),
                Genre = txtGenero.Text,
                Quantity = Convert.ToInt32(txtCantidad.Text)
            };
            if (Convert.ToInt32(txtID.Text) == 0)
            {
                IMongoCollection<Libro> libroCollection = _mongoDBConnection.LibrosCollection;

                // Inserta el estudiante en la colección.
                libroCollection.InsertOne(objLibro);

                dgvData.Rows.Add(new object[] {"",
                       txtNombreLibro.Text,
                       txtAutor.Text,
                       txtCalificacion.Text,
                       txtResenia.Text,
                       txtPrecio.Text,
                       txtAnio.Text,
                       txtGenero.Text,
                       txtCantidad.Text,
            });

                ClearForm();
            }
            else
            {
                IMongoCollection<Libro> librosCollection = _mongoDBConnection.LibrosCollection;

                // Define el filtro para identificar al libro que deseas actualizar.
                var filtro = Builders<Libro>.Filter.Eq(libro => libro.Name, objLibro.Name);

                // Define la actualización con los nuevos valores.
                var actualizacion = Builders<Libro>.Update
                    .Set(libro => libro.Author, objLibro.Author)
                    .Set(libro => libro.UserRating, objLibro.UserRating)
                    .Set(libro => libro.Reviews, objLibro.Reviews)
                    .Set(libro => libro.Price, objLibro.Price)
                    .Set(libro => libro.Year, objLibro.Year)
                    .Set(libro => libro.Genre, objLibro.Genre)
                    .Set(libro => libro.Quantity, objLibro.Quantity);

                // Realiza la actualización en la colección.
                librosCollection.UpdateOne(filtro, actualizacion);

                ClearForm();
                ListarLibros();
            }
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                int i = e.RowIndex;

                if (i >= 0)
                {
                    txtIndex.Text = i.ToString();
                    txtID.Text = i.ToString();
                    txtNombreLibro.Text = dgvData.Rows[i].Cells["nombre"].Value.ToString();
                    txtAutor.Text = dgvData.Rows[i].Cells["autor"].Value.ToString();
                    txtCalificacion.Text = dgvData.Rows[i].Cells["calificacion"].Value.ToString();
                    txtResenia.Text = dgvData.Rows[i].Cells["resenia"].Value.ToString();
                    txtPrecio.Text = dgvData.Rows[i].Cells["precio"].Value.ToString();
                    txtAnio.Text = dgvData.Rows[i].Cells["anio"].Value.ToString();
                    txtGenero.Text = dgvData.Rows[i].Cells["genero"].Value.ToString();
                    txtCantidad.Text = dgvData.Rows[i].Cells["cantidad"].Value.ToString();
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el libro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string message = string.Empty;

                    Libro objLibro = new Libro()
                    {
                        Name = txtNombreLibro.Text,
                    };

                    IMongoCollection<Libro> librosCollection = _mongoDBConnection.LibrosCollection;

                    // Define el filtro para identificar al estudiante que deseas eliminar por su número de carné.
                    var filtro = Builders<Libro>.Filter.Eq(libro => libro.Name, objLibro.Name);

                    var result = librosCollection.DeleteOne(filtro);

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
    public class Libro
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
}
