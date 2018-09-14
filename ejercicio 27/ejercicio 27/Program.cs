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






            Console.Clear();





            Console.WriteLine("-------------PILAS----------------");

            Stack<int> stackPila = new Stack<int>();

            for (i = 0; i < 20; i++)
            {
                stackPila.Push(aleatorio.Next(-100, 100));
            }

            foreach (int s in stackPila)
            {
                Console.WriteLine(s);
            }


            arrayInt = stackPila.ToList<int>();

            arrayInt.Sort(Ordenar);

            stackPila.Clear();

            Console.WriteLine("POSITIVOS ORDENADOS");

            foreach(int s in arrayInt)
            {
                
                stackPila.Push(s);
                if(s > 0)
                    Console.WriteLine(stackPila.ElementAt<int>(0));
            }

            Console.WriteLine("NEGATIVOS ORDENADOS");

            arrayInt = stackPila.ToList<int>();

            arrayInt.Sort(OtroOrdenar);

            stackPila.Clear();

            foreach (int s in arrayInt)
            {
                stackPila.Push(s);
                if (s < 0)
                    Console.WriteLine(stackPila.ElementAt<int>(0));
            }

            Console.WriteLine("COLAS-----------");

            Queue<int> cola = new Queue<int>();

            for(i= 0; i < 20; i++ )
            {
                cola.Enqueue(aleatorio.Next(-100, 100));
                Console.WriteLine(cola.ElementAt<int>(i));
            }

            arrayInt = cola.ToList<int>();

            arrayInt.Sort(Ordenar);

            cola.Clear();

            Console.WriteLine("-ordenados positivos");
            int j = 0;
            foreach (int s in arrayInt)
            {
                
                cola.Enqueue(s);
                if(s>0)
                    Console.WriteLine(cola.ElementAt<int>(j));
                j++;
            }


            arrayInt = cola.ToList<int>();

            arrayInt.Sort(OtroOrdenar);

            cola.Clear();

            Console.WriteLine("-ordenados NEGATIVOS");
            j = 0;
            foreach (int s in arrayInt)
            {

                cola.Enqueue(s);
                if (s < 0)
                    Console.WriteLine(cola.ElementAt<int>(j));
                j++;
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
