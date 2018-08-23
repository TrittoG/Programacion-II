using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejerccio 3";
            //Console.BackgroundColor = (ConsoleColor)(12);

            int numero,i,j,contador;
            string numeroString;

            Console.WriteLine("ingrese un numero");
            numeroString = Console.ReadLine();

            numero = int.Parse(numeroString);
            
            for(i=0;i<=numero;i++)
            {
                contador = 0;
                for (j=1;j<=i;j++)
                {
                    if(i%j == 0)
                    {
                        contador++;                  
                    }

                }
                if(contador == 2)
                {
                    Console.WriteLine("{0, 10}",i);
                }
            }
            

            Console.ReadKey();
            Console.Clear();
            Console.ReadKey();
        }
    }
}
