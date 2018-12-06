using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 14";
            string respuesta = "s";
            string eleccionn;
            int eleccion;
            double altura, bas, lado, radio, retorno;
            string alt, ba, lad, rad;

            while(respuesta == "s")
            {
                Console.WriteLine("1)Area de un cuadrado");
                Console.WriteLine("2)Area de un triangulo");
                Console.WriteLine("3)Area de un circulo");
                Console.WriteLine("4)Salir");
                eleccionn = Console.ReadLine();
                if(int.TryParse(eleccionn, out eleccion))
                {
                    switch (eleccion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el valor del lado");
                            lad = Console.ReadLine();
                            if(double.TryParse(lad, out lado))
                            {
                                retorno = CalculoDeArea.CalcularCuadrado(lado);
                                if (retorno > 0)
                                {
                                    Console.WriteLine("El area del cuadrado es: " + retorno);
                                }
                                else
                                {
                                    Console.WriteLine("Valor ingresado debe ser mayor a 0");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor ingresado invalido");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el valor de la base");
                            ba = Console.ReadLine();
                            Console.WriteLine("Ingrese el valor de la altura");
                            alt = Console.ReadLine();
                            if(double.TryParse(ba, out bas))
                            {
                                if(double.TryParse(alt, out altura))
                                {
                                    retorno = CalculoDeArea.CalcularTriangulo(altura, bas);
                                    if(retorno > 0)
                                    {
                                        Console.WriteLine("El area del triangulo es: " + retorno);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Los valores deben ser mayor de 0");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valor de la altura invalida");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor de la base invalida");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Ingrese el valor del radio");
                            rad = Console.ReadLine();
                            if(double.TryParse(rad, out radio))
                            {
                                retorno = CalculoDeArea.CalcularCirculo(radio);
                                if(retorno > 0)
                                {
                                    Console.WriteLine("El area del circulo es: " + retorno);
                                }
                                else
                                {
                                    Console.WriteLine("El radio debe ser mayor a 0");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor invalido");
                            }
                            break;
                        case 4:
                            respuesta = "n";
                            break;
                        default:
                            Console.WriteLine("Valor no valido");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Valor no valido");
                }

            }
            
        }
    }
}
