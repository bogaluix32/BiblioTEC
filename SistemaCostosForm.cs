using iTextSharp.text.pdf;
using iTextSharp.text;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.tool.xml;
using System.Text;
using MongoDB.Bson;

namespace BibliotecaTEC
{
    public partial class SistemaCostosForm : Form
    {
        private readonly Conexion _mongoDBConnection;
        public SistemaCostosForm()
        {
            InitializeComponent();
            _mongoDBConnection = new Conexion();
        }

        private void btnReporteMorisidades_Click(object sender, EventArgs e)
        {
            string htmlText = Properties.Resources.PlantillaReporteMorosidad.ToString();

            htmlText = htmlText.Replace("@nombrenegocio", "BiblioTEC");

            htmlText = htmlText.Replace("@nombreReporte", "Reporte de Morosidades");
            htmlText = htmlText.Replace("@fechaReporte", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            IMongoCollection<Morosidades> morosidadesEstudiantilesCollection = _mongoDBConnection.MorosidadesCollection;

            // Define la proyección para incluir solo los campos 'carne' y 'fullname'.
            var projection = Builders<Morosidades>.Projection
                .Include(moro => moro.CarneEstudiante)
                .Include(moro => moro.Morosidad)
                .Include(moro => moro.CampusEstudiante)
                .Include(moro => moro.FechaVecimiento);

            // Realiza la consulta con la proyección y obtén los resultados en una lista.
            List<Morosidades> listaMorosidades = morosidadesEstudiantilesCollection.Find(_ => true)
                .Project<Morosidades>(projection)
                .ToList();
            StringBuilder filasBuilder = new StringBuilder(); 

            foreach (Morosidades morosidad in listaMorosidades)
            {
                filasBuilder.Append("<tr>");
                filasBuilder.Append("<td>").Append(morosidad.CarneEstudiante.ToString()).Append("</td>");
                filasBuilder.Append("<td>").Append(morosidad.Morosidad.ToString()).Append("</td>");
                filasBuilder.Append("<td>").Append(morosidad.CampusEstudiante.ToString()).Append("</td>");
                filasBuilder.Append("<td>").Append(morosidad.FechaVecimiento.ToString()).Append("</td>");
                filasBuilder.Append("</tr>");
            }

            filas = filasBuilder.ToString();

            htmlText = htmlText.Replace("@filas", filas);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("ReporteMorosidades_{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy"));
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(htmlText))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Reporte Generado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAbrirFormEstudiantes_Click(object sender, EventArgs e)
        {
            string htmlText = Properties.Resources.PlantillaReporteExtraviados.ToString();

            htmlText = htmlText.Replace("@nombrenegocio", "BiblioTEC");

            htmlText = htmlText.Replace("@nombreReporte", "Reporte de Extravios");
            htmlText = htmlText.Replace("@fechaReporte", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            IMongoCollection<Extravios> extraviosCollection = _mongoDBConnection.ExtraviosCollection;

            // Define la proyección para incluir solo los campos 'carne' y 'fullname'.
            var projection = Builders<Extravios>.Projection
                .Include(extravio => extravio.NombreLibro)
                .Include(extravio => extravio.CantidadExtraviada)
                .Include(extravio => extravio.Campus);

            // Realiza la consulta con la proyección y obtén los resultados en una lista.
            List<Extravios> listaExtravios = extraviosCollection.Find(_ => true)
                .Project<Extravios>(projection)
                .ToList();
            StringBuilder filasBuilder = new StringBuilder();

            foreach (Extravios extravio in listaExtravios)
            {
                filasBuilder.Append("<tr>");
                filasBuilder.Append("<td>").Append(extravio.NombreLibro.ToString()).Append("</td>");
                filasBuilder.Append("<td>").Append(extravio.CantidadExtraviada.ToString()).Append("</td>");
                filasBuilder.Append("<td>").Append(extravio.Campus.ToString()).Append("</td>");
                filasBuilder.Append("</tr>");
            }

            filas = filasBuilder.ToString();

            htmlText = htmlText.Replace("@filas", filas);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("ReporteExtravios_{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy"));
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(htmlText))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Reporte Generado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }

    public class Extravios
    {
        public ObjectId _id { get; set; }
        public string NombreLibro { get; set; }
        public int CantidadExtraviada { get; set; }
        public string Campus { get; set; }
    }
}
