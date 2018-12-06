using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Camion :VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short marchas, int peso, short ruedas, short puertas, Colores color) : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = peso;
        }

        public static string Mostrar(Camion c)
        {
            return VehiculoTerrestre.Mostrar(c) + "\nMarchas " + c.cantidadMarchas + "\nCarga " + c.pesoCarga;
        }
    }
}
