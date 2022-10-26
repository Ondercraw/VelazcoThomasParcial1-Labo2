using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrucerosOnder
{
    public class Cruceros
    {

        private int cantidadCamarotes;
        private string matricula;
        private string nombre;
        private int cantidadSalones;
        private int cantidadCasinos;


        public int CantidadCamarotes { get => cantidadCamarotes; set => cantidadCamarotes = value; }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CantidadSalones { get => cantidadSalones; set => cantidadSalones = value; }
        public int CantidadCasinos { get => cantidadCasinos; set => cantidadCasinos = value; }

        
        public Cruceros() { }
       
        public Cruceros(int cantidadCamarotes, string matricula, string nombre, int cantidadSalones, int cantidadCasinos)
        {
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadCasinos = cantidadCasinos;
            this.cantidadSalones = cantidadSalones;
            this.matricula = matricula;
            this.nombre = nombre;       
        }
    }
}
