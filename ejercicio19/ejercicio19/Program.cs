using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hola ";
            string b = " mundo";

            Sumador asd = new Sumador();
            Sumador qwe = new Sumador(2);

            Console.WriteLine(asd.Sumar(a, b));
            Console.WriteLine(asd.Sumar(1, 2));
            

            Console.WriteLine("sumas: {0}",(int)asd);
            Console.WriteLine("sumas: {0}", (int)qwe);

            if((asd|qwe) == true)
            {
                Console.WriteLine("tienen las mismas sumas");
            }
            else
            {
                Console.WriteLine("no tienen las mismas sumas");
            }

            Console.WriteLine("las sumas totales son: {0}", asd + qwe);
            Console.ReadKey();
        }
    }
}
