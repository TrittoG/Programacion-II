using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double ingreso) //base por altura
        {
            double retorno = -1;

            if(ingreso > 0)
            {
                retorno = ingreso * ingreso;
            }
            return retorno;
        }

        public static double CalcularTriangulo(double ingreso, double ingresoDos) //base por altura sobre dos
        {
            double retorno = -1;

            if(ingreso > 0 && ingresoDos > 0)
            {
                retorno = (ingreso * ingresoDos) / 2;
            }

            return retorno;
        }

        public static double CalcularCirculo(double ingreso) //pi por radio al cuadrado
        {
            double retorno = -1;

            if(ingreso > 0)
            {
                retorno = Math.PI * (Math.Pow(ingreso, 2));
            }

            return retorno;
        }
    }
}
