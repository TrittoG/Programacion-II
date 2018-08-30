using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 14";
            double valor;
            double valorDos;
            string respuesta;
            string termina = "n";
            string valorString;
            double area;

            do
            {
                Console.WriteLine("ingrese que area desea calcular: cuadrado/circulo/triangulo");
                respuesta = Console.ReadLine();

                switch(respuesta)
                {
                    case "cuadrado" :
                        {
                            Console.WriteLine("ingrese el lado del cuadrado");
                            valorString = Console.ReadLine();

                            if (double.TryParse(valorString, out valor))
                            {
                                area = CalculoDeArea.CalcularCuadrado(valor);
                                Console.WriteLine("el area del cuadrado es: {0}", area);                                  
                            }
                        }
                        break;

                    case "triangulo":
                        {
                            Console.WriteLine("ingrese altura");
                            valorString = Console.ReadLine();

                            if (double.TryParse(valorString, out valor))
                            {
                                Console.WriteLine("ingrese base");
                                valorString = Console.ReadLine();

                                if (double.TryParse(valorString, out valorDos))
                                {
                                    area = CalculoDeArea.CalcularTriangulo(valor, valorDos);
                                    Console.WriteLine("el area del triangulo es: {0}", area);
                                }
                            }
                        }
                        break;
                    case "circulo":
                        
                            Console.WriteLine("ingrese el radio del circulo");
                            valorString = Console.ReadLine();

                            if (double.TryParse(valorString, out valor))
                            {
                            area = CalculoDeArea.CalcularCirculo(valor);s
                                Console.WriteLine("el area del circulo es: {0}", area);
                            }

                        
                        break;
                }
                Console.WriteLine("desea volver a ingresar valor? s/n");
                termina = Console.ReadLine();

            } while (termina != "n");
            

        }
    }
}
