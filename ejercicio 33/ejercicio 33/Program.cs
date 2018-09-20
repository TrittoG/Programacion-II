using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro lib = new Libro();

            lib[0] = "Hola";
            lib[34] = "piripitiflautico";
            Console.WriteLine("{0} {1}", lib[0], lib[34]);

            Console.ReadKey();


        }
    }
}
