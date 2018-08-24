using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 12";

            int numero, suma = 0;
            string ahre;
            char respuesta = 's';

            do
            {
                Console.WriteLine("valor: ");
                ahre = Console.ReadLine();

                if(int.TryParse(ahre, out numero))
                {
                    suma = numero + suma;
                }
                else
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine("sumando {0}", suma);
                Console.WriteLine("quiere ingresar otro valor? s/n ");
                ahre = Console.ReadLine();
                respuesta = char.Parse(ahre);

            } while (ValidarRespuesta.ValidaS_N(respuesta));
        }
    }
}
