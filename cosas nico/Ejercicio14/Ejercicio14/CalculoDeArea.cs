using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)//lado*lado
        {
            if(lado > 0)
            {
                return (lado * lado);
            }
            return -1;
        }
        public static double CalcularTriangulo(double altura, double bas)//base x altura
        {
            if(altura > 0 && bas > 0)
            {
                return (bas * altura / 2);
            }
            return -1;
        }
        public static double CalcularCirculo(double radio)//pi x radioal cuadrado
        {
            if(radio > 0)
            {
                return (radio * radio * Math.PI);
            }
            return -1;
        }
    }
}
