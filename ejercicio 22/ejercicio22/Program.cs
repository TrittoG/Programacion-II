using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 22";

            NumeroBinario objBinario = "100";
            NumeroDecimal objDecimal = 5;

            if(objDecimal == objBinario)
            {
                Console.WriteLine("iguales");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.WriteLine("-----------");

            Console.WriteLine("suma binaria{0}", objBinario + objDecimal);
            Console.WriteLine("Suma decimal {0}", objDecimal + objBinario);
            Console.ReadKey();

        }
    }
}
