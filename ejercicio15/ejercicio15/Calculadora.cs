using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Calculadora
    {
        public static double? Calcular(double numeroUno, double numeroDos, char operador)
        {
            double? retorno = null;

            switch(operador)
            {
                case '+':
                    retorno = numeroUno + numeroDos;
                    break;

                case '-':
                    retorno = numeroUno - numeroDos;
                    break;

                case '*':
                    retorno = numeroUno * numeroDos;
                    break;

                case '/':
                    if(Calculadora.Validar(numeroDos))
                    retorno = numeroUno / numeroDos;             
                    break;
            }

            return retorno;
        }


        private static Boolean Validar(double numeroDos)
        {
            if(numeroDos != 0)
            {
                return true;
            }
            return false;
        }

        public static void Mostrar(double? respuesta)
        {
            Console.WriteLine("el resultado es: {0}", respuesta);
        }
    }
}
