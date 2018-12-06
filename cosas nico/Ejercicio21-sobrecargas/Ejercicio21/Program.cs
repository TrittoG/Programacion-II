using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f = new Fahrenheit(100);
            Celsius c = (Celsius)f;
            Kelvin k = (Kelvin)f;

            Console.WriteLine(((Fahrenheit)k).GetTemp());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
