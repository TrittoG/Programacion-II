using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euros e = new Euros(10);
            Pesos p = new Pesos(10);
            Dolares d = new Dolares(10);
            e = e + p;
            Console.WriteLine(e.GetCantidad());
            Console.ReadKey();
        }
    }
}
