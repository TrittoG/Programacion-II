using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short ruedas, short puertas, Colores color)
        {
            this.cantidadPuertas = puertas;
            this.cantidadRuedas = ruedas;
            this.color = color;
        }

        public static string Mostrar(VehiculoTerrestre v)
        {
            return "Ruedas " + v.cantidadRuedas + "\nPuertas " + v.cantidadPuertas + "\nColor " + v.color;
        }
    }
}
