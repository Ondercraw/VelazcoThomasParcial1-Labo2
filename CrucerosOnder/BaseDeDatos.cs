using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrucerosOnder
{
    public class BaseDeDatos
    {

        public static List<Pasajero> listaPasajero;
        public static List<Cruceros> listaCruceros;
        public static List<PasajeroACrucero> listaPasajeroACrucero;

        static BaseDeDatos()
        {
            BaseDeDatos.listaPasajero = new List<Pasajero>();
            BaseDeDatos.listaCruceros = new List<Cruceros>();
            BaseDeDatos.listaPasajeroACrucero = new List<PasajeroACrucero>();
            listaCruceros.Add(new Cruceros(25, "ASD12", "Onder", 8, 2));
            listaCruceros.Add(new Cruceros(30, "NVE54", "Gemma", 7, 3));
            listaCruceros.Add(new Cruceros(50, "EMD1", "Abril", 9, 1));
            listaPasajero.Add(new Pasajero("Thomas","Velazco", 19, "4532672", "2VA34D", "Premium" ));
            listaPasajero.Add(new Pasajero("Ignacio", "Ramirez", 19, "4465891", "5ER84M", "Premium"));
            listaPasajero.Add(new Pasajero("Patricio", "Perez", 18, "4587254", "3JH22G", "Clase media"));
            listaPasajeroACrucero.Add(new PasajeroACrucero("Thomas", "4532672", "ASD12"));
        }

        public static bool AñadirPasajero(Pasajero nuevoPasajero)
        {
            bool r = true;

            listaPasajero.Add(nuevoPasajero);

            return r;
        }

        public static bool AñadirCruceros(Cruceros nuevoCrucero)
        {
            bool r = true;

            listaCruceros.Add(nuevoCrucero);

            return r;
        }

        public static bool AñadirPasajeroACrucero(PasajeroACrucero nuevoCrucero)
        {
            bool r = true;

            listaPasajeroACrucero.Add(nuevoCrucero);

            return r;
        }


    }
}
