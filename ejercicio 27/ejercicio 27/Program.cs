using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            List<int> arrayInt = new List<int>(20);


            Console.WriteLine("---------------LISTAS-------------------");
            Console.WriteLine("Numeros generados: ");
            int i;

            for (i = 0; i < arrayInt.Capacity; i++)
            {
                arrayInt.Add(aleatorio.Next(-100, 100));
                Console.WriteLine("{0}", arrayInt[i]);
            }



            arrayInt.Sort(Ordenar);

            Console.WriteLine("POSITIVOS ORDENADOS: ");
            for (i = 0; i < arrayInt.Capacity; i++)
            {
                if (arrayInt[i]> 0)
                    Console.WriteLine("{0}", arrayInt[i]);
            }


            arrayInt.Sort(OtroOrdenar);

            Console.WriteLine("negativos ORDENADOS: ");
            for (i = 0; i < arrayInt.Capacity; i++)
            {
                if (arrayInt[i] < 0)
                    Console.WriteLine("{0}", arrayInt[i]);
            }


            Console.ReadKey();

            Console.WriteLine("-------------PILAS----------------");

            Stack<int> stackLista = new Stack<int>();

            for (i = 0; i < 20; i++)
            {
                stackLista.Push(aleatorio.Next(-100, 100));
                Console.WriteLine("{0}", stackLista.ElementAt<int>(i));
            }


            Console.ReadKey();













        }

        public static int Ordenar(int a, int b)
        {
            if (a == b)
                return 0;
            else if (a > b)
                return 1;
            else 
                return -1;
        }

        public static int OtroOrdenar(int a, int b)
        {
            return -Ordenar(a, b);    
        }

    }
}
