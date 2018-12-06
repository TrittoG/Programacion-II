using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 18";
            Punto _1 = new Punto(1,4);
            Punto _2 = new Punto(3, 8);
            Rectangulo rec = new Rectangulo(_1, _2);
            Console.WriteLine("El area del rectangulos es: " + rec.Area());
            Console.WriteLine("El perimetro del rectangulo es: " + rec.Perimetro());
            Console.WriteLine(Rectangulo.Mostrar(rec));
            Console.ReadKey();
        }
    }
}
