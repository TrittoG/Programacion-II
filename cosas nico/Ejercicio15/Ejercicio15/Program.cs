using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 15";
            double num1, num2;
            double? resultado;
            string nu1, nu2, sig;
            char signo;
            Console.WriteLine("Ingrese la operacion a calcular(+,-,/,*)");
            sig = Console.ReadLine();
            if (char.TryParse(sig, out signo))
            {
                if (signo == '+' || signo == '-' || signo == '/' || signo == '*')
                {
                    Console.WriteLine("Ingrese el primer numero a caluclar");
                    nu1 = Console.ReadLine();
                    if (double.TryParse(nu1, out num1))
                    {
                        Console.WriteLine("Ingrese el segundo numero a calcular");
                        nu2 = Console.ReadLine();
                        if (double.TryParse(nu2, out num2))
                        {
                            resultado = Calculadora.Calcular(num1, num2, signo);
                            if(resultado != null)
                            {
                                Calculadora.Mostrar(resultado);
                            }else
                            {
                                Console.WriteLine("No se puede dividir por 0");
                            }
                        }
                        else
                            Console.WriteLine("Segundo numero invalido");
                    }
                    else
                        Console.WriteLine("Numero invalido");
                }
                else
                    Console.WriteLine("Signo invalido");
            }
            else
                Console.WriteLine("Signo invalido");
            Console.ReadKey();
        }
    }
}
