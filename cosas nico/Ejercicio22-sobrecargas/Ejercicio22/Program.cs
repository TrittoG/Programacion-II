using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 22";
            NumeroBinario nb = "111";
            NumeroDecimal nd = 10;
            Console.WriteLine("Suma bd: " + (nb + nd));
            Console.WriteLine("Suma db: " + (nd + nb));
            if (nb == nd)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("Son difernetes bd");

            if (nd == nb)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("Son diferentes db");
            Console.ReadKey();
        }
    }
}
