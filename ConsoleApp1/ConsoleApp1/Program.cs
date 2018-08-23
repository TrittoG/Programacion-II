using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 1";
            int numero, minimo,maximo, i, suma, promedio;
            string numeroString;

            Console.WriteLine("ingrese un numero: ");
            numeroString = Console.ReadLine();

            numero = int.Parse(numeroString);
            suma = numero;
            maximo = numero;
            minimo = numero;
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                numeroString = Console.ReadLine();
                numero = int.Parse(numeroString);
                suma = suma + numero;
                if (numero < minimo)
                {
                    minimo = numero;
                }
                if(numero > maximo)
                {
                    maximo = numero;
                }
            }

            promedio = suma / 5;

            Console.WriteLine("el minimo es : "+ minimo);
            Console.WriteLine("el maximo es : "+ maximo);
            Console.WriteLine("el promedio es : " + promedio);
            Console.ReadKey();
        }
    }
}
