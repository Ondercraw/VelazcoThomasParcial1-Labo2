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
    public partial class FormMenu : Form
    {


        private BaseDeDatos listaCruceros;
        public Usuarios usuarioLogeado = new Usuarios();
        public FormMenu()
        {
            InitializeComponent();
            this.listaCruceros = new BaseDeDatos();
            
            lb_fecha.Text = DateTime.Today.ToString();
        }

        public FormMenu(Usuarios usuario) : this()
        {
            this.usuarioLogeado = usuario;
            this.lb_usuario.Text = usuarioLogeado.getNombre;

        }

        private void btn_VentaViajes_Click(object sender, EventArgs e)
        {
            FormVentas frmVentas = new FormVentas();
            this.Hide();
            frmVentas.Show();

        }

        private void btn_AdministrarCruceros_Click(object sender, EventArgs e)
        {
            FormAdministrarCruceros frmCruceros = new FormAdministrarCruceros();
            this.Hide();
            frmCruceros.Show();
        }

        private void btn_AdministrarViajes_Click(object sender, EventArgs e)
        {
            FormAdministrarViajes frmViajes = new FormAdministrarViajes();
            this.Hide();
            frmViajes.Show();
        }

        private void btn_MostrarPasajeros_Click(object sender, EventArgs e)
        {
            FormMostrarPasajeros frmPasajeros = new FormMostrarPasajeros();
            this.Hide();
            frmPasajeros.Show();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticasHistoricas frmEstadisticas = new FormEstadisticasHistoricas();
            this.Hide();
            frmEstadisticas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra en el menu de la aplicacion \n\nPara vender un viaje presione el boton Vender Viaje\nPara consultar las estadisticas historicas presione el boton Estadisticas\nPara ver los viajes presione el boton Mostrar Viajes\nPara ver los pasajeros presione el boton Mostrar Pasajeros\nPara crear un crucero para luego vender el viaje presione el boton Crear Viaje");
        }
    }
}
