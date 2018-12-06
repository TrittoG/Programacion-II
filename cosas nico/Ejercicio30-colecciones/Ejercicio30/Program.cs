using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio NRO 30";
            Competencia com = new Competencia(5, 10);
            AutoF1 a = new AutoF1(0, "lala");
            AutoF1 b = new AutoF1(1, "lala");
            AutoF1 c = new AutoF1(2, "lala");
            AutoF1 d = new AutoF1(4, "lala");
            AutoF1 e = new AutoF1(4, "lala");
            AutoF1 f = new AutoF1(5, "lala");
            AutoF1 g = new AutoF1(6, "lala");

            if (com + a)
            {
                Console.WriteLine("Se agrego el auto a");
            }
            else
                Console.WriteLine("No se pudo agregar el auto a");
            System.Threading.Thread.Sleep(500);
            if (com + b)
            {
                Console.WriteLine("Se agrego el auto b");
            }
            else
                Console.WriteLine("No se pudo agregar el auto b");
            System.Threading.Thread.Sleep(500);
            if (com + c)
            {
                Console.WriteLine("Se agrego el auto c");
            }
            else
                Console.WriteLine("No se pudo agregar el auto c");
            System.Threading.Thread.Sleep(500);
            if (com + d)
            {
                Console.WriteLine("Se agrego el auto d");
            }
            else
                Console.WriteLine("No se pudo agregar el auto d");
            System.Threading.Thread.Sleep(500);
            if (com + e)
            {
                Console.WriteLine("Se agrego el auto e");
            }
            else
                Console.WriteLine("No se pudo agregar el auto e");
            System.Threading.Thread.Sleep(500);
            if (com + f)
            {
                Console.WriteLine("Se agrego el auto f");
            }
            else
                Console.WriteLine("No se pudo agregar el auto f");
            System.Threading.Thread.Sleep(500);
            if (com + g)
            {
                Console.WriteLine("Se agrego el auto g");
            }
            else
                Console.WriteLine("No se pudo agregar el auto g");

            Console.WriteLine(com.MostrarDatos());
            Console.ReadKey();
        }
    }
}
