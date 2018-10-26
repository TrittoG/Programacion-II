using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio44
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("pedro");
            Local l = new Local("pehuajo", 12, "bsas", 13);
            Provincial p = new Provincial("pehua", Franja.Franja_1, 12, "bsas");
            c += l;
            c += p;
            Console.WriteLine("DATOS DE LLAMADAS: " + c.Leer());
            Console.ReadKey();
        }
    }
}
