using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTEC
{
    public partial class ClientForm : Form
    {
        private readonly Conexion _mongoDBConnection;
        public ClientForm()
        {
            InitializeComponent();
            _mongoDBConnection = new Conexion(); 
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ListarEstudiantes();
        }

        private void ListarEstudiantes()
        {
            IMongoCollection<Estudiante> estudiantesCollection = _mongoDBConnection.EstudiantesCollection;

            // Define la proyección para incluir solo los campos 'carne' y 'fullname'.
            var projection = Builders<Estudiante>.Projection
                .Include(estudiante => estudiante.carne)
                .Include(estudiante => estudiante.fullname)
                .Include(estudiante => estudiante.campus)
                .Include(estudiante => estudiante.anio);

            // Realiza la consulta con la proyección y obtén los resultados en una lista.
            List<Estudiante> estudiantes = estudiantesCollection.Find(_ => true)
                .Project<Estudiante>(projection)
                .ToList();

            // Limpia el DataGridView antes de agregar nuevos datos.
            dgvData.Rows.Clear();

            // Agrega los estudiantes al DataGridView.
            foreach (var estudiante in estudiantes)
            {
                dgvData.Rows.Add("",
                    estudiante.carne,
                    estudiante.fullname,
                    estudiante.campus,
                    estudiante.anio
                );
            }
        }

        private void ClearForm()
        {
            txtIndex.Text = "-1";
            txtID.Text = "0";
            txtFullName.Text = "";
            txtFullName.Text = "";
            txtCampus.Text = "";
            txtAnio.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;

            Estudiante objEstudiante = new Estudiante()
            {
                carne = txtCarne.Text,
                fullname = txtFullName.Text,
                campus = txtCampus.Text,
                anio = Convert.ToInt32(txtAnio.Text)
            };
            if (Convert.ToInt32(txtID.Text) == 0)
            {
                IMongoCollection<Estudiante> estudiantesCollection = _mongoDBConnection.EstudiantesCollection;

                // Inserta el estudiante en la colección.
                estudiantesCollection.InsertOne(objEstudiante);

                dgvData.Rows.Add(new object[] {"",
                        txtCarne.Text,
                        txtFullName.Text,
                        txtCampus.Text,
                        Convert.ToInt32(txtAnio.Text),
                    });

                ClearForm();
            }
            else
            {
                IMongoCollection<Estudiante> estudiantesCollection = _mongoDBConnection.EstudiantesCollection;

                // Define el filtro para identificar al estudiante que deseas actualizar.
                var filtro = Builders<Estudiante>.Filter.Eq(estudiante => estudiante.carne, objEstudiante.carne);

                // Define la actualización con los nuevos valores.
                var actualizacion = Builders<Estudiante>.Update
                    .Set(estudiante => estudiante.fullname, objEstudiante.fullname)
                    .Set(estudiante => estudiante.campus, objEstudiante.campus)
                    .Set(estudiante => estudiante.anio, objEstudiante.anio);

                // Realiza la actualización en la colección.
                estudiantesCollection.UpdateOne(filtro, actualizacion);

                ClearForm();
                ListarEstudiantes();
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                int i = e.RowIndex;

                if (i >= 0)
                {
                    txtIndex.Text = i.ToString();
                    txtID.Text = dgvData.Rows[i].Cells["carne"].Value.ToString();
                    txtCarne.Text = dgvData.Rows[i].Cells["carne"].Value.ToString();
                    txtFullName.Text = dgvData.Rows[i].Cells["fullName"].Value.ToString();
                    txtCampus.Text = dgvData.Rows[i].Cells["campus"].Value.ToString();
                    txtAnio.Text = dgvData.Rows[i].Cells["anio"].Value.ToString();
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el estudiante?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string message = string.Empty;

                    Estudiante objEstudiante = new Estudiante()
                    {
                        carne = txtCarne.Text,
                    };

                    IMongoCollection<Estudiante> estudiantesCollection = _mongoDBConnection.EstudiantesCollection;

                    // Define el filtro para identificar al estudiante que deseas eliminar por su número de carné.
                    var filtro = Builders<Estudiante>.Filter.Eq(estudiante => estudiante.carne, objEstudiante.carne);

                    var result = estudiantesCollection.DeleteOne(filtro);

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


    public class Estudiante
    {
        public ObjectId _id { get; set; }
        public string carne { get; set; }
        public string fullname { get; set; }
        public string campus { get; set; }
        public int anio { get; set; }
    }
}
