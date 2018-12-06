using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lsNum = new List<int>();
            Random nmRnd = new Random();
            Console.WriteLine("LISTA");
            Console.WriteLine("Generando numero random");
            for (int i = 0; i < 20; i++)
            {
                lsNum.Add(nmRnd.Next(-1000, 1000));
                Console.WriteLine(lsNum[i]);
            }
            Console.ReadKey();
            Console.WriteLine("Numeros positivos ordenados de forma decreciente");

            lsNum.Sort(OrdenarAB);
            for (int i = 19; i > 0; i--)
            {
                if (lsNum[i] > 0)
                    Console.WriteLine(lsNum[i]);
            }
            Console.ReadKey();
            Console.WriteLine("Numeros negativos ordenados de forma creciente");

            lsNum.Sort(OrdenarBA);
            for (int i = 19; i > 0; i--)
            {
                if (lsNum[i] < 0)
                    Console.WriteLine(lsNum[i]);
            }

            Console.ReadKey();

            Console.WriteLine("PILAS");
            Console.WriteLine("Generando numeros random");
            Stack<int> skNm = new Stack<int>();
            for (int i = 0; i < 20; i++)
            {
                skNm.Push(nmRnd.Next(-1000,1000));
                Console.WriteLine(skNm.ElementAt<int>(0));
            }
            Console.ReadKey();

            Console.WriteLine("Numeros positivos ordenados de forma decreciente");

            lsNum = skNm.ToList<int>();
            lsNum.Sort(OrdenarBA);
            skNm.Clear();
            foreach(int s in lsNum)
            {
                skNm.Push(s);
                if(s > 0)
                    Console.WriteLine(skNm.ElementAt<int>(0));
            }

            Console.ReadKey();
            Console.WriteLine("Numeros negativos ordenados de forma creciente");

            lsNum = skNm.ToList<int>();
            lsNum.Sort(OrdenarAB);
            skNm.Clear();
            foreach (int s in lsNum)
            {
                skNm.Push(s);
                if (s < 0)
                    Console.WriteLine(skNm.ElementAt<int>(0));
            }
            Console.ReadKey();

            Console.WriteLine("COLAS");
            Console.WriteLine("Generando numeros random");
            Queue<int> queNm = new Queue<int>();

            for(int i = 0; i < 20; i++)
            {
                queNm.Enqueue(nmRnd.Next(-1000, 1000));
                Console.WriteLine(queNm.ElementAt(i));
            }

            Console.ReadKey();

            Console.WriteLine("Numeros positivos ordenados de forma decreciente");

            lsNum = queNm.ToList<int>();
            lsNum.Sort(OrdenarBA);
            queNm.Clear();

            foreach(int s in lsNum)
            {
                queNm.Enqueue(s);
                if (s > 0)
                    Console.WriteLine(s);
            }

            Console.ReadKey();

            Console.WriteLine("Numeros negativos ordenados de forma creciente");

            lsNum = queNm.ToList<int>();
            lsNum.Sort(OrdenarAB);
            queNm.Clear();

            foreach (int s in lsNum)
            {
                queNm.Enqueue(s);
                if (s < 0)
                    Console.WriteLine(s);
            }

            Console.ReadKey();
        }

        private static int OrdenarAB(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }

        private static int OrdenarBA(int a, int b)
        {
            return -OrdenarAB(a, b);
        }
    }
}
