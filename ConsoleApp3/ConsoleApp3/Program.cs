using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 11";

            int i,valor, maximo, minimo, chico= -101, grande= 101, sumador = 0, contador = 0;
            float promedio;
            string ahre;
            maximo = 100;
            minimo = -100;

            for(i=0;i<10;i++)
            {
                Console.WriteLine("ingrese un valor");
                ahre = Console.ReadLine();

                if (int.TryParse(ahre, out valor))
                {
                    if(Validacion.Validar(valor, minimo, maximo) == true)
                    {
                        Console.WriteLine("validado {0}", valor);

                        if(valor < chico)
                        {
                            chico = valor;
                        }
                        if(valor > grande)
                        {
                            grande = valor;
                        }

                        sumador = sumador + valor;
                        contador++;


                    }
                    else
                    {
                        Console.WriteLine("numero incorrecto");
                    }
                }

            }
            promedio = (float)sumador / contador;
            Console.WriteLine("el promedio es {0}", promedio);
            Console.ReadKey();
            

        }
    }
}
