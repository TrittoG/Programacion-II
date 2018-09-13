using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 2";
            int numero;
            double cubo;
            string numeroString;

            Console.WriteLine("ingrese un numero");
            numeroString = Console.ReadLine();
            numero = int.Parse(numeroString);

            if(numero < 0)
            {
                Console.WriteLine("error numero menos que 0");
            }

            Console.WriteLine("numero elevado a la 2: " +Math.Pow(numero, 2));
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("el numero elevado a la 3: " + cubo);

            Console.ReadKey();

        }
    }
}
