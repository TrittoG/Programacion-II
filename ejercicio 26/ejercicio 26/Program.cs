using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            int[] arrayInt = new int[20];

            Console.WriteLine("Numeros generados: ");
            int i;

            for (i= 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = aleatorio.Next(-100, 100);
                Console.WriteLine("{0}", arrayInt[i]);
            }

            Console.WriteLine("POSITIVOS ORDENADOS: ");

            int bandera;
            int a;

            do
            {
                bandera = 1;
                for (i = 0; i < (arrayInt.Length - 1); i++)
                {                
                    if (arrayInt[i] < arrayInt[i + 1])
                    {
                           
                        a = arrayInt[i];
                        arrayInt[i] = arrayInt[i + 1];
                        arrayInt[i + 1] = a;
                        bandera = 0;
                    }
                  
                }
            } while (bandera == 0);

            for(i=0;i<arrayInt.Length;i++)
                if(arrayInt[i]>0)
                Console.WriteLine("{0}", arrayInt[i]);

            Console.WriteLine("Negativos ORDENADOS: ");
           
            for (i = (arrayInt.Length-1); i > 0; i--)
                if (arrayInt[i] < 0)
                    Console.WriteLine("{0}", arrayInt[i]);

            Console.ReadKey();

        }
    }
}
