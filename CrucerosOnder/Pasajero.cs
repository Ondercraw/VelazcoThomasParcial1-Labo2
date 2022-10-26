using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrucerosOnder
{
    public class Pasajero
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string dni;
        private string pasaporte;
        private string clase;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Pasaporte { get => pasaporte; set => pasaporte = value; }
        public string Clase { get => clase; set => clase = value; }

        public Pasajero() { }
        public Pasajero(string nombre, string apellido, int edad, string dni, string pasaporte, string clase)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            this.pasaporte = pasaporte;
            this.clase = clase;

        }
    }

    
}
