using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio52;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera1 car1 = new Cartuchera1();
            Cartuchera2 car2 = new Cartuchera2();

            Lapiz uno = new Lapiz(10);
            Lapiz dos = new Lapiz(5);
            Lapiz tres = new Lapiz(5);

            Boligrafo bUno = new Boligrafo(10, ConsoleColor.Blue);
            Boligrafo bDos = new Boligrafo(5, ConsoleColor.Red);
            Boligrafo bTres = new Boligrafo(5, ConsoleColor.Green);

            car1.utiles.Add(uno);
            car1.utiles.Add(dos);
            car1.utiles.Add(tres);
            car1.utiles.Add(bUno);
            car1.utiles.Add(bDos);
            car1.utiles.Add(bTres);

            car2.lapices.Add(uno);
            car2.lapices.Add(dos);
            car2.lapices.Add(tres);
            car2.lapiceras.Add(bUno);
            car2.lapiceras.Add(bDos);
            car2.lapiceras.Add(bTres);

            Console.WriteLine(car2.ProbarElemento().ToString());
            Console.WriteLine(car1.ProbarElementos().ToString());
            Console.ReadKey();

        }
    }
}
