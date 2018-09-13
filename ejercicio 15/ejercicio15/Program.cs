using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 15";

            double numeroUno;
            double numeroDos;
            double? respuesta;
            char operador;

            string valor;

            Console.WriteLine("ingrese el primer valor: ");
            valor = Console.ReadLine();

            if(double.TryParse(valor, out numeroUno))
            {
                Console.WriteLine("ingrese el segundio valor: ");
                valor = Console.ReadLine();

                if(double.TryParse(valor, out numeroDos))
                {
                    Console.WriteLine("ingrese el operador '+ '-' '*' '/' ");
                    valor = Console.ReadLine();
                    operador = char.Parse(valor);

                    respuesta = Calculadora.Calcular(numeroUno, numeroDos, operador);
                    if(respuesta == null)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    Calculadora.Mostrar(respuesta);

                    Console.ReadKey();

                }
            }

        }
    }
}
