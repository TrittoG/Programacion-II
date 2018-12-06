using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double? Calcular(double primerNum, double segundNum, char signo)
        {
            switch(signo)
            {
                case '-':
                    return (primerNum - segundNum);
                case '*':
                    return (primerNum * segundNum);
                case '/':
                    if (Validar(segundNum))
                        return (primerNum / segundNum);
                    break;
                case '+':
                    return (primerNum + segundNum);
            }
            return null;
        }
        private static Boolean Validar(double segundNum)
        {
            if(segundNum != 0)
                return true;
            return false;
        }
        public static void Mostrar(double? resultado)
        {
            Console.WriteLine("El resultado de la operacion es: " + resultado);
        }
    }
}
