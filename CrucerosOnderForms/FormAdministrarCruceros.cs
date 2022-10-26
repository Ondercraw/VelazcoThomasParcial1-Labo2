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
    public partial class FormAdministrarCruceros : Form
    {

        private Cruceros nuevoCrucero = new Cruceros();
        private BaseDeDatos listaCruceros;

        private static string[] lugarRegional = {"Montevideo (Uruguay)", "Ushuaia (Argentina)", "Recife (Brasil)", "Santiago (Chile)", "Lima(Perú)", "Isla de Pascua(Chile)",
                                                    "Isla Galápagos(Ecuador)", "Puerto Madryn(Argentina)" ,"Río de Janeiro(Brasil)","Cartagena(Colombia)"};

        private static string[] lugarExtraregional = {"La Habana (Cuba)", "Venecia (Italia)", "Acapulco (México)", "Miami (EE.UU.)", "Nueva York (EE.UU.)",
                                                        "Bangkok (Tailandia)", "Taipei (Taiwán)", "Atenas (Grecia)"};

        public FormAdministrarCruceros()
        {
            InitializeComponent();
            this.listaCruceros = new BaseDeDatos();
        }


        private void rb_Regional_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            for(int i = 0; i < lugarRegional.Length; i++)
            {
                comboBox1.Items.Add(lugarRegional[i]);
            }
        }

        private void rb_ExtraRegional1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            for (int i = 0; i < lugarExtraregional.Length; i++)
            {
                comboBox1.Items.Add(lugarExtraregional[i]);
            }
        }

        private void rb_Regional2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            for (int i = 0; i < lugarRegional.Length; i++)
            {
                comboBox2.Items.Add(lugarRegional[i]);
            }
        }

        private void rb_ExtraRegional2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            for (int i = 0; i < lugarExtraregional.Length; i++)
            {
                comboBox2.Items.Add(lugarExtraregional[i]);
            }
        }

        private void btn_AgregarCruceros_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null || comboBox2.SelectedItem != null)
            {

                this.nuevoCrucero = new Cruceros(int.Parse(tb_CantidadCamarotesCrucero.Text), tb_MatriculaCrucero.Text, tb_NombreCrucero.Text, int.Parse(tb_CantidadSalonesCrucero.Text), int.Parse(tb_CantidadCasinosCrucero.Text));

                if (BaseDeDatos.AñadirCruceros(this.nuevoCrucero))
                {
                    MessageBox.Show("Se añadio el Crucero");
                }
                else
                {
                    MessageBox.Show("Hubo un error al añadir un Crucero");
                }
            }
        }

        private void btn_VolverAdmC_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra en la creacion de cruceros\n\nRellene los campos con los datos de los cruceros\nLuego seleccione el Punto de partida y Destino del viaje\nPor ultimo presione el boton Añadir para crear un crucero");
        }
    }
}
