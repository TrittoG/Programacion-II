using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GENERANDO NUMERO RANDOM");
            Console.ForegroundColor = ConsoleColor.White;
            int[] numeroEnteros = new int[20];
            for(int i = 0; i < 20; i++)
            {
                Random rm = new Random(DateTime.Now.Millisecond);
                Console.ReadKey();
                numeroEnteros[i] = rm.Next(-32768, 32767);
                Console.WriteLine(numeroEnteros[i]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NUMEROS POSITIVOS DE MAYOR A MENOR");
            Console.ForegroundColor = ConsoleColor.White;
            int flagSwap, aux;
            do
            {
                flagSwap = 0;
                for (int i = 0; i < 20 - 1; i++)
                {
                    if (numeroEnteros[i] < numeroEnteros[i + 1])
                    {
                        aux = numeroEnteros[i];
                        numeroEnteros[i] = numeroEnteros[i + 1];
                        numeroEnteros[i + 1] = aux;
                        flagSwap = 1;
                    }
                }
            }while(flagSwap == 1);

            for(int i = 0; i < 20; i++)
            {
                if (numeroEnteros[i] > 0)
                    Console.WriteLine(numeroEnteros[i]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NUMERO NEGATIVOS DE MENOR A MAYOR");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 19; i > 0; i--)
            {
                if (numeroEnteros[i] < 0)
                    Console.WriteLine(numeroEnteros[i]);
            }
            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(2); 
            Console.ReadKey();
        }
    }
}
