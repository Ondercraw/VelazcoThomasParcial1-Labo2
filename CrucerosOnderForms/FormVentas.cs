using CrucerosOnder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrucerosOnderForms
{
    public partial class FormVentas : Form
    {
        private Pasajero newPasajero = new Pasajero();
        private BaseDeDatos listaPasajeros;
        private bool EstadoBtn = false;
        private bool EstadoBtn2 = false;
        
        private PasajeroACrucero cargaCrucero = new PasajeroACrucero();

        public FormVentas()
        {
            InitializeComponent();
            this.listaPasajeros = new BaseDeDatos();

            groupBox1.Hide();
            groupBox2.Hide();
        }



        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            if(EstadoBtn == true) 
            {

                if (cb_ClaseIndv.SelectedItem != null)
                {

                    this.newPasajero = new Pasajero(tb_NombreIndv.Text, tb_ApellidoIndv.Text, int.Parse(tb_EdadIndv.Text), tb_DniIndv.Text, tb_PasaporteIndv.Text, cb_ClaseIndv.SelectedItem.ToString());

                    if (BaseDeDatos.AñadirPasajero(this.newPasajero))
                    {
                        MessageBox.Show("Se añadio el pasajero, ahora añadelo a un crucero");
                        
                        FormAdministrarViajes frmViajes = new FormAdministrarViajes();
                        
                        
                        frmViajes.bandera = 1;
                        
                        frmViajes.ShowDialog();

                        if (frmViajes.DialogResult == DialogResult.OK)
                        { 

                            this.cargaCrucero = new PasajeroACrucero(tb_NombreIndv.Text, tb_DniIndv.Text, frmViajes.matriculaCrucero.ToString());
                           
                            BaseDeDatos.AñadirPasajeroACrucero(this.cargaCrucero);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al añadir un pasajero");
                    }
                }
            }
            else
            {
                if(EstadoBtn2 == true)
                {
                    this.newPasajero = new Pasajero("Grupo Familiar",tb_ApellidoFam.Text, int.Parse(tb_EdadFam.Text), tb_DniFam.Text, tb_PasaporteFam.Text, cb_ClaseFam.SelectedItem.ToString());
                    if (BaseDeDatos.AñadirPasajero(this.newPasajero))
                    {
                        MessageBox.Show("Se añadio el grupo familiar");
                        FormAdministrarViajes frmViajes = new FormAdministrarViajes();
                        
                        frmViajes.bandera = 1;
                        frmViajes.ShowDialog();

                        if (frmViajes.DialogResult == DialogResult.OK)
                        {
                            this.cargaCrucero = new PasajeroACrucero("Grupo Familiar", tb_DniFam.Text, frmViajes.matriculaCrucero.ToString());
                            BaseDeDatos.AñadirPasajeroACrucero(this.cargaCrucero);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al añadir un grupo familiar");
                    }
                }
            }
        }

        private void btn_IndividualFrmV_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            btn_GrupoFamiliarFrmV.Hide();
            EstadoBtn = true;
        }

        private void btn_GrupoFamiliarFrmV_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            btn_IndividualFrmV.Hide();
            EstadoBtn2 = true;
        }

        private void btn_VolverVentas_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra en la venta de viajes\n\nPara poder vender un viaje primero elija el tipo de pasaje\nLuego rellene los campos con los datos pedidos en las cajas de texto\n\nPor ultimo presione el boton Añadir para completar la venta del pasaje y luego\n presione el boton Añadir Pasajero en la pestaña abierta");
        }
    }
}
