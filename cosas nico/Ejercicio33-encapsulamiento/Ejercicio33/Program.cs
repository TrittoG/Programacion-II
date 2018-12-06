using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 33";
            Libro book = new Libro();
            for(int i = 0; i < 20; i++)
            {
                book[i] = "Capitulo " + i;
            }
            Console.WriteLine(book[18]);
            book[18] = "Capitulo modificado";
            Console.WriteLine(book[18]);
            book[50] = "Capitulo 20";
            Console.WriteLine(book[20]);
            Console.ReadKey();
        }
    }
}
