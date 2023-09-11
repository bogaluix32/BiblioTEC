using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BibliotecaTEC
{
    public partial class Menu : Form
    {
        private static IconMenuItem activeMenu = null;
        private static Form activeForm = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm estudiantesForm = new ClientForm();
            estudiantesForm.Show();
        }

        private void btnAbrirLibrosForm_Click(object sender, EventArgs e)
        {
            LibrosForm librosForm = new LibrosForm();
            librosForm.Show();
        }

        private void btnAbrirAlquileresForm_Click(object sender, EventArgs e)
        {
            AlquileresForm alquileresForm = new AlquileresForm();
            alquileresForm.Show();
        }

        private void btnAbrirFormSistemaCostos_Click(object sender, EventArgs e)
        {
            SistemaCostosForm sistemaCostosForm = new SistemaCostosForm();
            sistemaCostosForm.Show();
        }
    }
}
