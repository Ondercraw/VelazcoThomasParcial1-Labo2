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
    public partial class FormEstadisticasHistoricas : Form
    {
        public FormEstadisticasHistoricas()
        {
            InitializeComponent();
        }

        private void btn_VolverEst_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
            this.Hide();
            frmMenu.Show();
        }
    }
}
