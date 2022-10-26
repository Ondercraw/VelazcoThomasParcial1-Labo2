using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrucerosOnder
{
    public class Usuarios
    {
        private string usuario;
        private string password;


        public Usuarios() { }
        public Usuarios(string nombre, string contraseña)
        {
            this.usuario = nombre;
            this.password = contraseña;
        }

        #region Operadores
        public static bool operator ==(Usuarios aComprobar, Usuarios registrado)
        {
            bool retorno = false;

            if (aComprobar is not null)
            {
                retorno = aComprobar.usuario == registrado.usuario && aComprobar.password == registrado.password;
            }

            return retorno;

        }
        public static bool operator !=(Usuarios aComprobar, Usuarios registrado)
        {
            return !(aComprobar == registrado);
        }

        public string getNombre
        {
            get { return this.usuario; }
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Usuarios)
                {
                    retorno = this == obj as Usuarios;
                }
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
