using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Moto :VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short clinidrada, short ruedas, short puertas, Colores color) :base(ruedas, puertas, color)
        {
            this.cilindrada = clinidrada;
        }

        public static string Mostrar(Moto m)
        {
            return VehiculoTerrestre.Mostrar(m) + "\nCilindrada " + m.cilindrada;
        }
    }
}
