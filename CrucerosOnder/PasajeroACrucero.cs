using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrucerosOnder
{
    public class PasajeroACrucero
    {
        private string nombre;
        private string dni;
        private string matricula;

        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        public PasajeroACrucero() { }
        public PasajeroACrucero(string nombre, string dni, string matricula)
        {

            this.nombre = nombre;
            this.dni = dni;
            this.matricula = matricula;
        }
    }
}
