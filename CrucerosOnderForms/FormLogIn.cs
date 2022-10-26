using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrucerosOnder;

namespace CrucerosOnderForms
{
    public partial class FormLogIn : Form
    {
        public Registro listado;

        public FormLogIn()
        {
            InitializeComponent();
            listado = new Registro();
            this.listado.registroDeUsuarios.Add(new Usuarios("Thomas", "12345"));
            this.listado.registroDeUsuarios.Add(new Usuarios("Abril", "milo00"));
            this.listado.registroDeUsuarios.Add(new Usuarios("Luis", "RGT"));
            this.listado.registroDeUsuarios.Add(new Usuarios("Patricio", "roju10"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarioIngresado = new Usuarios(ingresoNombre.Text, ingresoPassword.Text);
            int validacion = this.listado.registrado(usuarioIngresado);
            if (validacion != -1)
            {
                FormMenu menu = new FormMenu(this.listado.registroDeUsuarios[validacion]);
                this.Hide();
                menu.Show();
            }
            else
            {
                this.ingresoPassword.Clear();
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
