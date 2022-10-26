using CrucerosOnder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrucerosOnderForms
{
    public partial class FormMostrarPasajeros : Form
    {
        public FormMostrarPasajeros()
        {
            InitializeComponent();
        }

        private void FormMostrarPasajeros_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BaseDeDatos.listaPasajero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
