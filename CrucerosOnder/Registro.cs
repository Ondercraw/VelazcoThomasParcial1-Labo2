using System;
using System.Collections.Generic;

namespace CrucerosOnder
{
    public class Registro
    {
        public List<Usuarios> registroDeUsuarios;

        public Registro()
        {
            this.registroDeUsuarios = new List<Usuarios>();
        }

        public int registrado(Usuarios intento)
        {
            int login = -1;
            Usuarios comprobar;
            for (int i = 0; i < this.registroDeUsuarios.Count; i++)
            {
                comprobar = this.registroDeUsuarios[i];
                if (intento == comprobar)
                {
                    login = i;
                    break;
                }
            }
            return login;
        }

        public override string ToString()
        {
            string mensaje = "";

            foreach (Usuarios usuario in registroDeUsuarios)
            {
                mensaje = mensaje + usuario.ToString() + "\n";
            }

            return mensaje;
        }

    }
}
