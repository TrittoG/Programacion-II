using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Automovil :VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short marchas, int pasajeros, short ruedas, short puertas, Colores color) : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }

        public static string Mostrar(Automovil a)
        {
            return VehiculoTerrestre.Mostrar(a) + "\nMarchas " + a.cantidadMarchas + "\nPasajeros " + a.cantidadPasajeros;
        }
    }
}
