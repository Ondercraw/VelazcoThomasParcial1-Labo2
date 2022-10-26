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
    public partial class FormAdministrarViajes : Form
    {

        private int n = 0;
        public int bandera = 0;
        public string matriculaCrucero = "";
        public FormAdministrarViajes()
        {
            InitializeComponent();
        }

        private void FormAdministrarViajes_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BaseDeDatos.listaCruceros;
            if (bandera != 0)
            {

                this.dataGridView2.Hide();
                this.btn_AñadirPasajeroAdmV.Show();
            }
            else
            {
                this.btn_AñadirPasajeroAdmV.Hide();
            }
        }

        private void btn_VolverAdmV_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
            this.Hide();
            frmMenu.Show();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            this.dataGridView2.Rows.Clear();

            if (bandera != 0)
            {

                this.dataGridView2.Hide();
            }
            else
            {

                foreach (var item in BaseDeDatos.listaPasajeroACrucero)
                {

                    if ((string)dataGridView1.Rows[n].Cells[1].Value == item.Matricula)
                    {


                        for (int i = 0; i < BaseDeDatos.listaPasajero.Count; i++)
                        {
                            if (item.Nombre == BaseDeDatos.listaPasajero[i].Nombre && item.Dni == BaseDeDatos.listaPasajero[i].Dni)
                            {
                                this.dataGridView2.Rows.Add(BaseDeDatos.listaPasajero[i].Nombre, BaseDeDatos.listaPasajero[i].Apellido,
                                    BaseDeDatos.listaPasajero[i].Edad, BaseDeDatos.listaPasajero[i].Dni, BaseDeDatos.listaPasajero[i].Pasaporte
                                    , BaseDeDatos.listaPasajero[i].Clase);


                            }

                        }

                    }

                }
            }
           
        }

        private void btn_AñadirPasajeroAdmV_Click(object sender, EventArgs e)
        {
            this.matriculaCrucero = (string)dataGridView1.Rows[n].Cells[1].Value;
            this.DialogResult = DialogResult.OK;
           
        }

    }
}
